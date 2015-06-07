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
    public partial class ControlForm : Form
    {
        private User _user;
        private List<Group> _groups;

        public ControlForm(User user)
        {
            InitializeComponent();
            _user = user;
            _groups = Group.GetAllGroups();
        }
    }
}
