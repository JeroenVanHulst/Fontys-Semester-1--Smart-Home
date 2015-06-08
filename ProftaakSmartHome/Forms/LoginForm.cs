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
using ProftaakSmartHome.Services;

namespace ProftaakSmartHome.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btInloggen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                labelError.Text = @"Één of meerdere velden zijn niet ingevuld!";
                labelError.Visible = true;
                return;
            }

            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            var user = User.GetUserByName(username);
            if (user == null)
            {
                labelError.Text = @"Username of wachtwoord zijn niet correct ingevuld.";
                labelError.Visible = true;
                return;
            }

            var passwordConverted = UserService.ConvertStringToMd5(password);

            if (user.Password != passwordConverted)
            {
                labelError.Text = @"Username of wachtwoord zijn niet correct ingevuld.";
                labelError.Visible = true;
                return;
            }

            var controlForm = new ControlForm(user);
        }
    }
}
