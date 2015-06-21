namespace ProftaakSmartHome.Forms
{
    partial class LightControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.valueSlider = new System.Windows.Forms.HScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.BackColor = System.Drawing.Color.Red;
            this.buttonOnOff.Location = new System.Drawing.Point(224, 23);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(75, 23);
            this.buttonOnOff.TabIndex = 2;
            this.buttonOnOff.Text = "Off";
            this.buttonOnOff.UseVisualStyleBackColor = false;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // valueSlider
            // 
            this.valueSlider.Location = new System.Drawing.Point(181, 53);
            this.valueSlider.Maximum = 255;
            this.valueSlider.Name = "valueSlider";
            this.valueSlider.Size = new System.Drawing.Size(523, 22);
            this.valueSlider.TabIndex = 3;
            this.valueSlider.ValueChanged += new System.EventHandler(this.valueSlider_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProftaakSmartHome.Properties.Resources._078574_blue_jelly_icon_business_light_off2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(222, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 5;
            // 
            // LightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueSlider);
            this.Controls.Add(this.buttonOnOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LightControl";
            this.Size = new System.Drawing.Size(930, 81);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOnOff;
        private System.Windows.Forms.HScrollBar valueSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
    }
}
