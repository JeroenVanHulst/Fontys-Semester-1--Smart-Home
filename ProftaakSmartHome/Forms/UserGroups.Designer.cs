namespace ProftaakSmartHome.Forms
{
    partial class UserGroups
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
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonDeleteFromUser = new System.Windows.Forms.Button();
            this.buttonMoveToUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.Location = new System.Drawing.Point(12, 28);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(168, 329);
            this.listBoxUser.TabIndex = 0;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(227, 28);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(168, 329);
            this.listBoxGroups.TabIndex = 1;
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
            // buttonDeleteFromUser
            // 
            this.buttonDeleteFromUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonDeleteFromUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFromUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteFromUser.Location = new System.Drawing.Point(186, 133);
            this.buttonDeleteFromUser.Name = "buttonDeleteFromUser";
            this.buttonDeleteFromUser.Size = new System.Drawing.Size(35, 33);
            this.buttonDeleteFromUser.TabIndex = 6;
            this.buttonDeleteFromUser.Text = ">>";
            this.buttonDeleteFromUser.UseVisualStyleBackColor = false;
            this.buttonDeleteFromUser.Click += new System.EventHandler(this.buttonDeleteFromUser_Click);
            // 
            // buttonMoveToUser
            // 
            this.buttonMoveToUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonMoveToUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToUser.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToUser.Location = new System.Drawing.Point(186, 172);
            this.buttonMoveToUser.Name = "buttonMoveToUser";
            this.buttonMoveToUser.Size = new System.Drawing.Size(35, 33);
            this.buttonMoveToUser.TabIndex = 7;
            this.buttonMoveToUser.Text = "<<";
            this.buttonMoveToUser.UseVisualStyleBackColor = false;
            this.buttonMoveToUser.Click += new System.EventHandler(this.buttonMoveToUser_Click);
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
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "All available groups:";
            // 
            // UserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(407, 418);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMoveToUser);
            this.Controls.Add(this.buttonDeleteFromUser);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxUser);
            this.Name = "UserGroups";
            this.Text = "Groups in user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonDeleteFromUser;
        private System.Windows.Forms.Button buttonMoveToUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}