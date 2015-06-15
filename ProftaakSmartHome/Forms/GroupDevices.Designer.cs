namespace ProftaakSmartHome.Forms
{
    partial class GroupDevices
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonDeleteFromGroup = new System.Windows.Forms.Button();
            this.buttonMoveToGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.Location = new System.Drawing.Point(12, 28);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(168, 329);
            this.listBoxGroup.TabIndex = 0;
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.Location = new System.Drawing.Point(227, 28);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(168, 329);
            this.listBoxDevices.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.White;
            this.buttonOk.Location = new System.Drawing.Point(240, 363);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(155, 47);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonDeleteFromGroup
            // 
            this.buttonDeleteFromGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonDeleteFromGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFromGroup.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteFromGroup.Location = new System.Drawing.Point(186, 133);
            this.buttonDeleteFromGroup.Name = "buttonDeleteFromGroup";
            this.buttonDeleteFromGroup.Size = new System.Drawing.Size(35, 33);
            this.buttonDeleteFromGroup.TabIndex = 6;
            this.buttonDeleteFromGroup.Text = ">>";
            this.buttonDeleteFromGroup.UseVisualStyleBackColor = false;
            this.buttonDeleteFromGroup.Click += new System.EventHandler(this.buttonDeleteFromGroup_Click);
            // 
            // buttonMoveToGroup
            // 
            this.buttonMoveToGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonMoveToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToGroup.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToGroup.Location = new System.Drawing.Point(186, 172);
            this.buttonMoveToGroup.Name = "buttonMoveToGroup";
            this.buttonMoveToGroup.Size = new System.Drawing.Size(35, 33);
            this.buttonMoveToGroup.TabIndex = 7;
            this.buttonMoveToGroup.Text = "<<";
            this.buttonMoveToGroup.UseVisualStyleBackColor = false;
            this.buttonMoveToGroup.Click += new System.EventHandler(this.buttonMoveToGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Device in current group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "All available devices:";
            // 
            // GroupDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(407, 418);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMoveToGroup);
            this.Controls.Add(this.buttonDeleteFromGroup);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.listBoxGroup);
            this.Name = "GroupDevices";
            this.Text = "Devices in group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonDeleteFromGroup;
        private System.Windows.Forms.Button buttonMoveToGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}