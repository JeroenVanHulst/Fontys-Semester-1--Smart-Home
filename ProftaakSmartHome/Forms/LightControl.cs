﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProftaakSmartHome.Classes;

namespace ProftaakSmartHome.Forms
{
    public partial class LightControl : UserControl
    {
        private Device _device;
        public LightControl(Device device)
        {
            InitializeComponent();
            _device = device;
            valueSlider.Value = device.Value;
            setButtonOnOf();
            labelName.Text = device.Name;

            if (device.Type != DeviceType.DimmableLight) valueSlider.Hide();
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            _device.OnOff = !_device.OnOff;

            _device.Update();

            setButtonOnOf();
        }

        private void setButtonOnOf()
        {
            valueSlider.Enabled = _device.OnOff;

            if (_device.OnOff)
            {
                buttonOnOff.Text = "On";
                buttonOnOff.BackColor = Color.Green;
            }
            else
            {
                buttonOnOff.Text = "Off";
                buttonOnOff.BackColor = Color.Red;
            }
        }

        private void valueSlider_ValueChanged(object sender, EventArgs e)
        {
            _device.Value = valueSlider.Value;
            _device.Update();
        }
    }
}
