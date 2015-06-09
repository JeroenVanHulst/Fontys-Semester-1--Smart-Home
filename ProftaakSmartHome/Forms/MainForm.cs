using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.AdvTree;
using ProftaakSmartHome.Classes;

namespace ProftaakSmartHome.Forms
{
    public partial class MainForm : Form
    {
        private User _user;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            setControls();
            setGroups();

            if (_user.IsAdmin)
            {
                setUsers();
                setDevices();
            }
        }

        private void setControls()
        {
            if (_user.IsAdmin) return;

            tabDevices.Visible = false;
            tabGroups.Visible = false;
            tabUsers.Visible = false;
            buttonSave.Enabled = false;
        }

        private void setGroups()
        {
            var groups = _user.IsAdmin ? Group.GetAllGroups() : new List<Group>(_user.Privileges);

            foreach (var group in groups)
            {
                comboBoxGroups.Items.Add(group);
                if (!_user.IsAdmin) continue;

                var node = new Node {Tag = group};
                node.Cells[1].Text = group.Name;
                node.Cells[2].Text = group.Devices.Count.ToString();
                advTreeGroups.Nodes.Add(node);
            }
        }

        private void setUsers()
        {
            var users = User.GetAllUsers();

            foreach (var user in users)
            {
                var node = new Node {Tag = user};
                node.Cells[1].Text = user.Name;
                node.Cells[2].Text = user.Privileges.ToString();
                advTreeUsers.Nodes.Add(node);
            }
        }

        private void setDevices()
        {
            var devices = Device.GetAllDevices();

            foreach (var device in devices)
            {
                var node = new Node { Tag = device };
                node.Cells[1].Text = device.Name;
                node.Cells[2].Text = device.Type.ToString();
                node.Cells[3].Text = device.Value.ToString();
                advTreeDevices.Nodes.Add(node);
            }
        }

        private void buttonAddUser_Click(object sender, System.EventArgs e)
        {
            var user = new User("new user");
            advPropertyGridUsers.SelectedObject = user;
        }

        private void advPropertyGridUsers_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private void advPropertyGridGroup_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private void advPropertyGridDevices_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}
