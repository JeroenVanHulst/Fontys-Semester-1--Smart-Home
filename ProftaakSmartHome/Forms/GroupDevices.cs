using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProftaakSmartHome.Classes;

namespace ProftaakSmartHome.Forms
{
    public partial class GroupDevices : Form
    {
        private Group _group;

        private List<Device> _devices;
        public GroupDevices(Group group, List<Device> devices)
        {
            InitializeComponent();
            _group = group;
            _devices = devices;

            SetGroupAndDevices();
        }

        private void SetGroupAndDevices()
        {
            _group.Devices.ForEach(x => listBoxGroup.Items.Add(x));

            _devices.Where(x => _group.Devices.Count(y => y.Id == x.Id) == 0).ToList().ForEach(x => listBoxDevices.Items.Add(x));
        }

        private void buttonDeleteFromGroup_Click(object sender, EventArgs e)
        {
            if (listBoxGroup.SelectedItem == null) return;

            var device = listBoxGroup.SelectedItem as Device;

            _group.Devices.Remove(device);
            listBoxGroup.Items.Remove(device);
            listBoxDevices.Items.Add(device);
        }

        private void buttonMoveToGroup_Click(object sender, EventArgs e)
        {
            if (listBoxDevices.SelectedItem == null) return;

            var device = listBoxDevices.SelectedItem as Device;

            _group.Devices.Add(device);
            listBoxGroup.Items.Add(device);
            listBoxDevices.Items.Remove(device);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _group.UpdateDevices();
            Close();
        }
    }
}
