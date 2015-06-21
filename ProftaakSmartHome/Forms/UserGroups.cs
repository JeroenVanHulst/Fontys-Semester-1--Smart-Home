using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProftaakSmartHome.Classes;

namespace ProftaakSmartHome.Forms
{
    public partial class UserGroups : Form
    {
        private User _user;

        private List<Group> _groups;
        public UserGroups(User user, List<Group> groups)
        {
            InitializeComponent();
            _user = user;
            _groups = groups;

            SetGroupAndDevices();
        }

        private void SetGroupAndDevices()
        {
            _user.Privileges.ForEach(x => listBoxUser.Items.Add(x));

            _groups.Where(x => _user.Privileges.Count(y => y.Id == x.Id) == 0).ToList().ForEach(x => listBoxGroups.Items.Add(x));
        }

        private void buttonDeleteFromUser_Click(object sender, EventArgs e)
        {
            if (listBoxUser.SelectedItem == null) return;

            var group = listBoxUser.SelectedItem as Group;

            _user.Privileges.Remove(group);
            listBoxUser.Items.Remove(group);
            listBoxGroups.Items.Add(group);
        }

        private void buttonMoveToUser_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem == null) return;

            var group = listBoxGroups.SelectedItem as Group;

            _user.Privileges.Add(group);
            listBoxUser.Items.Add(group);
            listBoxGroups.Items.Remove(group);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _user.UpdatePrivilages();
            Close();
        }
    }
}
