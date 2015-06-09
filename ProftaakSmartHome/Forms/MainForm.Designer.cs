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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.advPropertyGridDevices = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.advTreeDevices = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader4 = new DevComponents.AdvTree.ColumnHeader();
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.advPropertyGridGroup = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.buttonEditGroupDevices = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.advTreeGroups = new DevComponents.AdvTree.AdvTree();
            this.columnHeader5 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader6 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader7 = new DevComponents.AdvTree.ColumnHeader();
            this.node2 = new DevComponents.AdvTree.Node();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.advPropertyGridUsers = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUserPrivileges = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGridDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeDevices)).BeginInit();
            this.tabGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGridGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeGroups)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGridUsers)).BeginInit();
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
            this.tabControl.Controls.Add(this.flowLayoutPanel);
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
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(934, 494);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // tabDevices
            // 
            this.tabDevices.Controls.Add(this.advPropertyGridDevices);
            this.tabDevices.Controls.Add(this.advTreeDevices);
            this.tabDevices.Location = new System.Drawing.Point(4, 22);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevices.Size = new System.Drawing.Size(940, 536);
            this.tabDevices.TabIndex = 1;
            this.tabDevices.Text = "Devices";
            this.tabDevices.UseVisualStyleBackColor = true;
            // 
            // advPropertyGridDevices
            // 
            this.advPropertyGridDevices.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGridDevices.Location = new System.Drawing.Point(779, 165);
            this.advPropertyGridDevices.Name = "advPropertyGridDevices";
            this.advPropertyGridDevices.Size = new System.Drawing.Size(155, 365);
            this.advPropertyGridDevices.TabIndex = 7;
            this.advPropertyGridDevices.Text = "advPropertyGrid3";
            this.advPropertyGridDevices.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.advPropertyGridDevices_PropertyChanged);
            // 
            // advTreeDevices
            // 
            this.advTreeDevices.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTreeDevices.AllowDrop = true;
            this.advTreeDevices.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTreeDevices.BackgroundStyle.Class = "TreeBorderKey";
            this.advTreeDevices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTreeDevices.Columns.Add(this.columnHeader1);
            this.advTreeDevices.Columns.Add(this.columnHeader2);
            this.advTreeDevices.Columns.Add(this.columnHeader3);
            this.advTreeDevices.Columns.Add(this.columnHeader4);
            this.advTreeDevices.Location = new System.Drawing.Point(6, 6);
            this.advTreeDevices.Name = "advTreeDevices";
            this.advTreeDevices.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.advTreeDevices.NodesConnector = this.nodeConnector1;
            this.advTreeDevices.NodeStyle = this.elementStyle1;
            this.advTreeDevices.PathSeparator = ";";
            this.advTreeDevices.Size = new System.Drawing.Size(767, 524);
            this.advTreeDevices.Styles.Add(this.elementStyle1);
            this.advTreeDevices.TabIndex = 0;
            this.advTreeDevices.Text = "advTree1";
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
            this.tabGroups.Controls.Add(this.advPropertyGridGroup);
            this.tabGroups.Controls.Add(this.buttonEditGroupDevices);
            this.tabGroups.Controls.Add(this.buttonDeleteGroup);
            this.tabGroups.Controls.Add(this.buttonAddGroup);
            this.tabGroups.Controls.Add(this.advTreeGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 22);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroups.Size = new System.Drawing.Size(940, 536);
            this.tabGroups.TabIndex = 2;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // advPropertyGridGroup
            // 
            this.advPropertyGridGroup.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGridGroup.Location = new System.Drawing.Point(779, 165);
            this.advPropertyGridGroup.Name = "advPropertyGridGroup";
            this.advPropertyGridGroup.Size = new System.Drawing.Size(155, 365);
            this.advPropertyGridGroup.TabIndex = 7;
            this.advPropertyGridGroup.Text = "advPropertyGrid2";
            this.advPropertyGridGroup.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.advPropertyGridGroup_PropertyChanged);
            // 
            // buttonEditGroupDevices
            // 
            this.buttonEditGroupDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonEditGroupDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditGroupDevices.ForeColor = System.Drawing.Color.White;
            this.buttonEditGroupDevices.Location = new System.Drawing.Point(779, 59);
            this.buttonEditGroupDevices.Name = "buttonEditGroupDevices";
            this.buttonEditGroupDevices.Size = new System.Drawing.Size(155, 47);
            this.buttonEditGroupDevices.TabIndex = 6;
            this.buttonEditGroupDevices.Text = "Edit devices";
            this.buttonEditGroupDevices.UseVisualStyleBackColor = false;
            this.buttonEditGroupDevices.Click += new System.EventHandler(this.buttonEditGroupDevices_Click);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonDeleteGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteGroup.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteGroup.Location = new System.Drawing.Point(779, 112);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(155, 47);
            this.buttonDeleteGroup.TabIndex = 5;
            this.buttonDeleteGroup.Text = "Delete";
            this.buttonDeleteGroup.UseVisualStyleBackColor = false;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGroup.ForeColor = System.Drawing.Color.White;
            this.buttonAddGroup.Location = new System.Drawing.Point(779, 6);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(155, 47);
            this.buttonAddGroup.TabIndex = 4;
            this.buttonAddGroup.Text = "Add";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
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
            this.tabUsers.Controls.Add(this.advPropertyGridUsers);
            this.tabUsers.Controls.Add(this.buttonDeleteUser);
            this.tabUsers.Controls.Add(this.buttonEditUserPrivileges);
            this.tabUsers.Controls.Add(this.buttonAddUser);
            this.tabUsers.Controls.Add(this.advTreeUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(940, 536);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // advPropertyGridUsers
            // 
            this.advPropertyGridUsers.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGridUsers.Location = new System.Drawing.Point(779, 165);
            this.advPropertyGridUsers.Name = "advPropertyGridUsers";
            this.advPropertyGridUsers.Size = new System.Drawing.Size(155, 365);
            this.advPropertyGridUsers.TabIndex = 6;
            this.advPropertyGridUsers.Text = "advPropertyGrid1";
            this.advPropertyGridUsers.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.advPropertyGridUsers_PropertyChanged);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(779, 112);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(155, 47);
            this.buttonDeleteUser.TabIndex = 5;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonEditUserPrivileges
            // 
            this.buttonEditUserPrivileges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonEditUserPrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditUserPrivileges.ForeColor = System.Drawing.Color.White;
            this.buttonEditUserPrivileges.Location = new System.Drawing.Point(779, 59);
            this.buttonEditUserPrivileges.Name = "buttonEditUserPrivileges";
            this.buttonEditUserPrivileges.Size = new System.Drawing.Size(155, 47);
            this.buttonEditUserPrivileges.TabIndex = 4;
            this.buttonEditUserPrivileges.Text = "Edit privileges";
            this.buttonEditUserPrivileges.UseVisualStyleBackColor = false;
            this.buttonEditUserPrivileges.Click += new System.EventHandler(this.buttonEditUserPrivileges_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(145)))));
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(779, 6);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(155, 47);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGridDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeDevices)).EndInit();
            this.tabGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGridGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeGroups)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.TabPage tabDevices;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private DevComponents.AdvTree.AdvTree advTreeDevices;
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
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditUserPrivileges;
        private System.Windows.Forms.Button buttonAddUser;
        private DevComponents.AdvTree.AdvTree advTreeUsers;
        private DevComponents.AdvTree.ColumnHeader columnHeader9;
        private DevComponents.AdvTree.ColumnHeader columnHeader10;
        private DevComponents.AdvTree.ColumnHeader columnHeader11;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.NodeConnector nodeConnector3;
        private DevComponents.DotNetBar.ElementStyle elementStyle3;
        private System.Windows.Forms.Button buttonEditGroupDevices;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonSave;
        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGridDevices;
        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGridGroup;
        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGridUsers;

    }
}