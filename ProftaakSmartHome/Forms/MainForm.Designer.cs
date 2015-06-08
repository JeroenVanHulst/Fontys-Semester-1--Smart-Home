namespace ProftaakSmartHome.Forms
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader4 = new DevComponents.AdvTree.ColumnHeader();
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.advTreeGroups = new DevComponents.AdvTree.AdvTree();
            this.columnHeader5 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader6 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader7 = new DevComponents.AdvTree.ColumnHeader();
            this.node2 = new DevComponents.AdvTree.Node();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.advTreeUsers = new DevComponents.AdvTree.AdvTree();
            this.columnHeader9 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader10 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader11 = new DevComponents.AdvTree.ColumnHeader();
            this.node3 = new DevComponents.AdvTree.Node();
            this.nodeConnector3 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle3 = new DevComponents.DotNetBar.ElementStyle();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.tabGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeGroups)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabControl);
            this.tabControl1.Controls.Add(this.tabDevices);
            this.tabControl1.Controls.Add(this.tabGroups);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.White;
            this.tabControl.Controls.Add(this.comboBoxGroups);
            this.tabControl.Controls.Add(this.label1);
            this.tabControl.Controls.Add(this.flowLayoutPanel1);
            this.tabControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabControl.Location = new System.Drawing.Point(4, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl.Size = new System.Drawing.Size(940, 536);
            this.tabControl.TabIndex = 0;
            this.tabControl.Text = "Control";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(51, 9);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(289, 21);
            this.comboBoxGroups.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(934, 494);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabDevices
            // 
            this.tabDevices.Controls.Add(this.advTree1);
            this.tabDevices.Location = new System.Drawing.Point(4, 22);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevices.Size = new System.Drawing.Size(940, 536);
            this.tabDevices.TabIndex = 1;
            this.tabDevices.Text = "Devices";
            this.tabDevices.UseVisualStyleBackColor = true;
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.AllowDrop = true;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Columns.Add(this.columnHeader1);
            this.advTree1.Columns.Add(this.columnHeader2);
            this.advTree1.Columns.Add(this.columnHeader3);
            this.advTree1.Columns.Add(this.columnHeader4);
            this.advTree1.Location = new System.Drawing.Point(6, 6);
            this.advTree1.Name = "advTree1";
            this.advTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(767, 524);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Width.Absolute = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Name:";
            this.columnHeader2.Width.Absolute = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width.Absolute = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.StretchToFill = true;
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width.Absolute = 150;
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Text = "node1";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.button6);
            this.tabGroups.Controls.Add(this.button5);
            this.tabGroups.Controls.Add(this.button4);
            this.tabGroups.Controls.Add(this.advTreeGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 22);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroups.Size = new System.Drawing.Size(940, 536);
            this.tabGroups.TabIndex = 2;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(779, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = "Edit devices";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(779, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(779, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // advTreeGroups
            // 
            this.advTreeGroups.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTreeGroups.AllowDrop = true;
            this.advTreeGroups.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTreeGroups.BackgroundStyle.Class = "TreeBorderKey";
            this.advTreeGroups.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTreeGroups.Columns.Add(this.columnHeader5);
            this.advTreeGroups.Columns.Add(this.columnHeader6);
            this.advTreeGroups.Columns.Add(this.columnHeader7);
            this.advTreeGroups.Location = new System.Drawing.Point(6, 6);
            this.advTreeGroups.Name = "advTreeGroups";
            this.advTreeGroups.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2});
            this.advTreeGroups.NodesConnector = this.nodeConnector2;
            this.advTreeGroups.NodeStyle = this.elementStyle2;
            this.advTreeGroups.PathSeparator = ";";
            this.advTreeGroups.Size = new System.Drawing.Size(767, 524);
            this.advTreeGroups.Styles.Add(this.elementStyle2);
            this.advTreeGroups.TabIndex = 1;
            this.advTreeGroups.Text = "advTreeGroups";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Width.Absolute = 25;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "Name:";
            this.columnHeader6.Width.Absolute = 250;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            this.columnHeader7.StretchToFill = true;
            this.columnHeader7.Text = "Devices";
            this.columnHeader7.Width.Absolute = 250;
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Text = "node1";
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.button3);
            this.tabUsers.Controls.Add(this.button2);
            this.tabUsers.Controls.Add(this.button1);
            this.tabUsers.Controls.Add(this.advTreeUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(940, 536);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(779, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(779, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit privileges";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(779, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // advTreeUsers
            // 
            this.advTreeUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTreeUsers.AllowDrop = true;
            this.advTreeUsers.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTreeUsers.BackgroundStyle.Class = "TreeBorderKey";
            this.advTreeUsers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTreeUsers.Columns.Add(this.columnHeader9);
            this.advTreeUsers.Columns.Add(this.columnHeader10);
            this.advTreeUsers.Columns.Add(this.columnHeader11);
            this.advTreeUsers.Location = new System.Drawing.Point(6, 6);
            this.advTreeUsers.Name = "advTreeUsers";
            this.advTreeUsers.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node3});
            this.advTreeUsers.NodesConnector = this.nodeConnector3;
            this.advTreeUsers.NodeStyle = this.elementStyle3;
            this.advTreeUsers.PathSeparator = ";";
            this.advTreeUsers.Size = new System.Drawing.Size(767, 524);
            this.advTreeUsers.Styles.Add(this.elementStyle3);
            this.advTreeUsers.TabIndex = 1;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Name = "columnHeader9";
            this.columnHeader9.Width.Absolute = 25;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Name = "columnHeader10";
            this.columnHeader10.Text = "Name:";
            this.columnHeader10.Width.Absolute = 250;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Name = "columnHeader11";
            this.columnHeader11.Text = "Priviliges";
            this.columnHeader11.Width.Absolute = 250;
            // 
            // node3
            // 
            this.node3.Expanded = true;
            this.node3.Name = "node3";
            this.node3.Text = "node1";
            // 
            // nodeConnector3
            // 
            this.nodeConnector3.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle3
            // 
            this.elementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle3.Name = "elementStyle3";
            this.elementStyle3.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(801, 578);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 47);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(972, 628);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gebruikers";
            this.tabControl1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
            this.tabDevices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.tabGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTreeGroups)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTreeUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.TabPage tabDevices;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.TabPage tabUsers;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.AdvTree.ColumnHeader columnHeader3;
        private DevComponents.AdvTree.ColumnHeader columnHeader4;
        private DevComponents.AdvTree.AdvTree advTreeGroups;
        private DevComponents.AdvTree.ColumnHeader columnHeader5;
        private DevComponents.AdvTree.ColumnHeader columnHeader6;
        private DevComponents.AdvTree.ColumnHeader columnHeader7;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevComponents.AdvTree.AdvTree advTreeUsers;
        private DevComponents.AdvTree.ColumnHeader columnHeader9;
        private DevComponents.AdvTree.ColumnHeader columnHeader10;
        private DevComponents.AdvTree.ColumnHeader columnHeader11;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.NodeConnector nodeConnector3;
        private DevComponents.DotNetBar.ElementStyle elementStyle3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSave;

    }
}