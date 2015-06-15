using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevComponents.AdvTree;
using ProftaakSmartHome.Classes;
using ProftaakSmartHome.Services;

namespace ProftaakSmartHome.Forms
{
    public partial class MainForm : Form
    {
        private User _user;
        private FileSystemWatcher _watcher;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            setControls();

            if (_user.IsAdmin)
            {
                setGroups();
                setUsers();
                setDevices();
            }

            setDevicesControl();

            _watcher = new FileSystemWatcher
            {
                NotifyFilter =
                    NotifyFilters.LastAccess | NotifyFilters.LastWrite // These are the flags of change types to watch for
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Filter = Database.Filename
            };
            _watcher.Changed += DatabaseOnChanged;
            _watcher.Deleted += DatabaseOnDeleted;
            _watcher.Error += DatabaseOnError;
            _watcher.EnableRaisingEvents = true; // Begin watching
        }

        /// <summary>
        /// Adds LightControl for every device the user has permission for
        /// </summary>
        private void setDevicesControl()
        {
            foreach (var group in _user.Privileges)
            {
                group.Devices.ForEach(x => flowLayoutPanel.Controls.Add(new LightControl(x)));
            }
        }

        private void setControls()
        {
            if (_user.IsAdmin) return;

            tabDevices.Visible = false;
            tabGroups.Visible = false;
            tabUsers.Visible = false;
        }

        #region users
        private void setUsers()
        {
            var users = User.GetAllUsers();
            advTreeUsers.ClearAndDisposeAllNodes();

            foreach (var user in users)
            {
                var node = new Node { Tag = user };
                node.Cells[1].Text = user.Name;
                node.Cells[2].Text = user.Privileges.Count.ToString();
                advTreeUsers.Nodes.Add(node);
            }
        }

        private void buttonAddUser_Click(object sender, System.EventArgs e)
        {
            var user = new User("new user") {Password = "DefaultPassword"};
            var node = new Node {Tag = user};
            node.Cells[1].Text = user.Name;
            node.Cells[2].Text = user.Privileges.Count.ToString();

            advTreeUsers.Nodes.Add(node);
            advTreeUsers.SelectedNode = node;
            advPropertyGridUsers.SelectedObject = advTreeUsers.SelectedNode;

            user.Insert();
        }

        private void buttonDeleteUser_Click(object sender, System.EventArgs e)
        {
            if (advTreeUsers.SelectedNode == null) return;

            var node = advTreeUsers.SelectedNode;
            var user = node.Tag as User;

            if (MessageBox.Show(@"Are you sure you want to delete " + user.Name + "?", "Warning",MessageBoxButtons.YesNo) == DialogResult.No) return;

            if (user.Remove()) advTreeUsers.SelectedNode.Remove();
        }

        private void buttonEditUserPrivileges_Click(object sender, System.EventArgs e)
        {
            if (advTreeUsers.SelectedNode == null) return;

            var groups = (from Node node in advTreeGroups.Nodes select node.Tag as Group).ToList();
            var userGroupForm = new UserGroups(advTreeUsers.SelectedNode.Tag as User, groups);
            userGroupForm.Show();
        }
        #endregion

        #region device
        private void setDevices()
        {
            var devices = Device.GetAllDevices();
            advTreeDevices.ClearAndDisposeAllNodes();

            foreach (var device in devices)
            {
                var node = new Node { Tag = device };
                node.Cells[1].Text = device.Name;
                node.Cells[2].Text = device.Type.ToString();
                node.Cells[3].Text = device.Value.ToString();
                advTreeDevices.Nodes.Add(node);
            }
        }
        #endregion

        #region groups
        private void setGroups()
        {
            var groups = _user.IsAdmin ? Group.GetAllGroups() : new List<Group>(_user.Privileges);
            advTreeGroups.ClearAndDisposeAllNodes();

            foreach (var group in groups)
            {
                comboBoxGroups.Items.Add(group);
                if (!_user.IsAdmin) continue;

                var node = new Node { Tag = group };
                node.Cells[1].Text = group.Name;
                node.Cells[2].Text = group.Devices.Count.ToString();
                advTreeGroups.Nodes.Add(node);
            }
        }

        private void buttonAddGroup_Click(object sender, System.EventArgs e)
        {
            var group = new Group("New group");
            var node = new Node { Tag = group };
            node.Cells[1].Text = group.Name;
            node.Cells[2].Text = group.Devices.Count.ToString();

            advTreeGroups.Nodes.Add(node);
            advTreeGroups.SelectedNode = node;
            advPropertyGridGroup.SelectedObject = advTreeGroups.SelectedNode;

            group.Insert();
        }
        private void buttonEditGroupDevices_Click(object sender, System.EventArgs e)
        {
            if (advTreeGroups.SelectedNode == null) return;

            var devices = (from Node node in advTreeDevices.Nodes select node.Tag as Device).ToList();
            var groupDeviceForm = new GroupDevices(advTreeGroups.SelectedNode.Tag as Group, devices);
            groupDeviceForm.Show();
        }

        private void buttonDeleteGroup_Click(object sender, System.EventArgs e)
        {
            if (advTreeGroups.SelectedNode == null) return;

            var node = advTreeGroups.SelectedNode;
            var group = node.Tag as Group;

            if (MessageBox.Show(@"Are you sure you want to delete " + group.Name + "?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No) return;

            if (group.Remove()) advTreeUsers.SelectedNode.Remove();
        }
        #endregion

        #region events
        private void advPropertyGridUsers_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ((User)advTreeUsers.SelectedNode.Tag).Update();
        }

        private void advPropertyGridGroup_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ((Group)advTreeGroups.SelectedNode.Tag).Update();
        }

        private void advPropertyGridDevices_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ((Device)advTreeDevices.SelectedNode.Tag).Update();
        }

        private void DatabaseOnError(object sender, ErrorEventArgs e)
        {
            // Actions for when the database can't be monitored for changes for some reason
            //MessageBox.Show(e.GetException().Message);
        }

        private void DatabaseOnDeleted(object sender, FileSystemEventArgs e)
        {
            // Actions for when the database is deleted
            //MessageBox.Show("{0} was deleted", e.Name);
        }

        private void DatabaseOnChanged(object sender, FileSystemEventArgs e)
        {
            // Actions for when the database is changed
            Database.PreviousHash = DatabaseService.GetMd5HashFromFile(Database.Filename);

            // TODO: Determine what exactly needs to be executed when this happens
            setDevices();
        }
        #endregion
    }
}
