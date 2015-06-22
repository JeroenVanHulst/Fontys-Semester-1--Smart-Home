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

        public MainForm(User user)
        {
            InitializeComponent();
            
            advTreeUsers.SelectionChanged += advTreeUsers_SelectionChanged;
            advTreeDevices.SelectionChanged += advTreeDevices_SelectionChanged;
            advTreeGroups.SelectionChanged += advTreeGroups_SelectionChanged;
            advPropertyGridUsers.PropertyValueChanged += advPropertyGridUsers_PropertyChanged;
            advPropertyGridDevices.PropertyValueChanged += advPropertyGridDevices_PropertyChanged;
            advPropertyGridGroup.PropertyValueChanged += advPropertyGridGroup_PropertyChanged;

            _user = user;
            setControls();
            setGroups();

            if (_user.IsAdmin)
            {
                setUsers();
                setDevices();
            }

            setDevicesControl();

            /*_watcher = new FileSystemWatcher
            {
                NotifyFilter =
                    NotifyFilters.LastAccess | NotifyFilters.LastWrite // These are the flags of change types to watch for
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Filter = Database.Filename
            };
            _watcher.Changed += DatabaseOnChanged;
            _watcher.Deleted += DatabaseOnDeleted;
            _watcher.Error += DatabaseOnError;
            _watcher.EnableRaisingEvents = true; // Begin watching*/
        }

        void advTreeGroups_SelectionChanged(object sender, EventArgs e)
        {
            advPropertyGridGroup.SelectedObject = advTreeGroups.SelectedNode.Tag as Group;
        }

        private void advTreeUsers_SelectionChanged(object sender, EventArgs e)
        {
            advPropertyGridUsers.SelectedObject = advTreeUsers.SelectedNode.Tag as User;
        }

        void advTreeDevices_SelectionChanged(object sender, EventArgs e)
        {
            advPropertyGridDevices.SelectedObject = advTreeDevices.SelectedNode.Tag as Device;
        }

        /// <summary>
        /// Adds LightControl for every device the user has permission for
        /// </summary>
        private void setDevicesControl()
        {
            if (_user.Privileges == null) return;

            foreach (var group in _user.Privileges)
            {
                group.Devices.ForEach(x => flowLayoutPanel.Controls.Add(new LightControl(x)));
            }
        }

        private void setControls()
        {
            if (_user.IsAdmin) return;

            tabDevices.Dispose();
            tabGroups.Dispose();
            tabUsers.Dispose();
        }

        #region users
        private void setUsers()
        {
            var users = User.GetAllUsers();
            advTreeUsers.ClearAndDisposeAllNodes();

            foreach (var user in users)
            {
                var node = new Node { Tag = user };
                node.Cells.Add(new Cell(user.Name));
                node.Cells.Add(new Cell(user.Privileges.Count.ToString()));
                advTreeUsers.Nodes.Add(node);
            }
        }

        private void buttonAddUser_Click(object sender, System.EventArgs e)
        {
            var user = new User("new user") {Password = "DefaultPassword"};
            var node = new Node {Tag = user};
            node.Cells.Add(new Cell(user.Name));
            node.Cells.Add(new Cell(user.Privileges.Count.ToString()));

            advTreeUsers.Nodes.Add(node);
            advTreeUsers.SelectedNode = node;
            advPropertyGridUsers.SelectedObject = advTreeUsers.SelectedNode.Tag;

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
            userGroupForm.ShowDialog();
            advTreeUsers.SelectedNode.Cells[2].Text = ((User) advTreeUsers.SelectedNode.Tag).Privileges.Count.ToString();
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
                node.Cells.Add(new Cell(device.Name));
                node.Cells.Add(new Cell(device.Type.ToString()));
                node.Cells.Add(new Cell(device.Value.ToString()));
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
                node.Cells.Add(new Cell(group.Name));
                node.Cells.Add(new Cell(group.Devices.Count.ToString()));
                advTreeGroups.Nodes.Add(node);
            }
        }

        private void buttonAddGroup_Click(object sender, System.EventArgs e)
        {
            var group = new Group("New group");
            var node = new Node { Tag = group };
            node.Cells.Add(new Cell(group.Name));
            node.Cells.Add(new Cell(group.Devices.Count.ToString()));

            advTreeGroups.Nodes.Add(node);
            advTreeGroups.SelectedNode = node;
            advPropertyGridGroup.SelectedObject = advTreeGroups.SelectedNode.Tag;

            group.Insert();
        }
        private void buttonEditGroupDevices_Click(object sender, System.EventArgs e)
        {
            if (advTreeGroups.SelectedNode == null) return;

            var devices = (from Node node in advTreeDevices.Nodes select node.Tag as Device).ToList();
            var groupDeviceForm = new GroupDevices(advTreeGroups.SelectedNode.Tag as Group, devices);
            groupDeviceForm.ShowDialog();
            advTreeGroups.SelectedNode.Cells[2].Text = ((Group) advTreeGroups.SelectedNode.Tag).Devices.Count.ToString();
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
        #endregion

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var group = comboBoxGroups.SelectedItem as Group;

            flowLayoutPanel.Controls.Clear();

            group.Devices.ForEach(x => flowLayoutPanel.Controls.Add(new LightControl(x)));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
