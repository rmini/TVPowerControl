namespace TVPowerControl {
    partial class TVPowerControlForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TVPowerControlForm));
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.labelComPort = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.checkBoxEnablePowerOn = new System.Windows.Forms.CheckBox();
            this.buttonPowerOn = new System.Windows.Forms.Button();
            this.buttonPowerOff = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxEnablePowerOff = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(13, 13);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.ScrollAlwaysVisible = true;
            this.listBoxMessages.Size = new System.Drawing.Size(386, 160);
            this.listBoxMessages.TabIndex = 0;
            // 
            // labelComPort
            // 
            this.labelComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(10, 189);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(56, 13);
            this.labelComPort.TabIndex = 1;
            this.labelComPort.Text = "COM Port:";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(71, 186);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(81, 21);
            this.comboBoxComPort.TabIndex = 2;
            this.comboBoxComPort.DropDown += new System.EventHandler(this.comboBoxComPort_DropDown);
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPort_SelectedIndexChanged);
            // 
            // checkBoxEnablePowerOn
            // 
            this.checkBoxEnablePowerOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxEnablePowerOn.AutoSize = true;
            this.checkBoxEnablePowerOn.Location = new System.Drawing.Point(13, 213);
            this.checkBoxEnablePowerOn.Name = "checkBoxEnablePowerOn";
            this.checkBoxEnablePowerOn.Size = new System.Drawing.Size(203, 17);
            this.checkBoxEnablePowerOn.TabIndex = 3;
            this.checkBoxEnablePowerOn.Text = "Power on TV when PC display wakes";
            this.checkBoxEnablePowerOn.UseVisualStyleBackColor = true;
            this.checkBoxEnablePowerOn.CheckedChanged += new System.EventHandler(this.checkBoxEnablePowerOn_CheckedChanged);
            // 
            // buttonPowerOn
            // 
            this.buttonPowerOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPowerOn.Location = new System.Drawing.Point(13, 254);
            this.buttonPowerOn.Name = "buttonPowerOn";
            this.buttonPowerOn.Size = new System.Drawing.Size(75, 23);
            this.buttonPowerOn.TabIndex = 4;
            this.buttonPowerOn.Text = "Power On";
            this.buttonPowerOn.UseVisualStyleBackColor = true;
            this.buttonPowerOn.Click += new System.EventHandler(this.buttonPowerOn_Click);
            // 
            // buttonPowerOff
            // 
            this.buttonPowerOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPowerOff.Location = new System.Drawing.Point(94, 254);
            this.buttonPowerOff.Name = "buttonPowerOff";
            this.buttonPowerOff.Size = new System.Drawing.Size(75, 23);
            this.buttonPowerOff.TabIndex = 5;
            this.buttonPowerOff.Text = "Power Off";
            this.buttonPowerOff.UseVisualStyleBackColor = true;
            this.buttonPowerOff.Click += new System.EventHandler(this.buttonPowerOff_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TV Power Control";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(94, 26);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItemExit.Text = "E&xit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // checkBoxEnablePowerOff
            // 
            this.checkBoxEnablePowerOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxEnablePowerOff.AutoSize = true;
            this.checkBoxEnablePowerOff.Location = new System.Drawing.Point(13, 231);
            this.checkBoxEnablePowerOff.Name = "checkBoxEnablePowerOff";
            this.checkBoxEnablePowerOff.Size = new System.Drawing.Size(202, 17);
            this.checkBoxEnablePowerOff.TabIndex = 6;
            this.checkBoxEnablePowerOff.Text = "Power off TV when PC display sleeps";
            this.checkBoxEnablePowerOff.UseVisualStyleBackColor = true;
            this.checkBoxEnablePowerOff.CheckedChanged += new System.EventHandler(this.checkBoxEnablePowerOff_CheckedChanged);
            // 
            // TVPowerControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 291);
            this.Controls.Add(this.checkBoxEnablePowerOff);
            this.Controls.Add(this.buttonPowerOff);
            this.Controls.Add(this.buttonPowerOn);
            this.Controls.Add(this.checkBoxEnablePowerOn);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.labelComPort);
            this.Controls.Add(this.listBoxMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TVPowerControlForm";
            this.Text = "TV Power Control";
            this.Load += new System.EventHandler(this.TVPowerControlForm_Load);
            this.Resize += new System.EventHandler(this.TVPowerControlForm_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.CheckBox checkBoxEnablePowerOn;
        private System.Windows.Forms.Button buttonPowerOn;
        private System.Windows.Forms.Button buttonPowerOff;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.CheckBox checkBoxEnablePowerOff;
    }
}

