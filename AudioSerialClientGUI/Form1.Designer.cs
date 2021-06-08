
namespace AudioSerialClientGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_ComPorts = new System.Windows.Forms.ComboBox();
            this.textbox_Val1 = new System.Windows.Forms.TextBox();
            this.comboBox_App1 = new System.Windows.Forms.ComboBox();
            this.textbox_App1 = new System.Windows.Forms.TextBox();
            this.comboBox_App2 = new System.Windows.Forms.ComboBox();
            this.textbox_App2 = new System.Windows.Forms.TextBox();
            this.textbox_Val2 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // comboBox_ComPorts
            // 
            this.comboBox_ComPorts.AllowDrop = true;
            this.comboBox_ComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ComPorts.FormattingEnabled = true;
            this.comboBox_ComPorts.Location = new System.Drawing.Point(72, 83);
            this.comboBox_ComPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_ComPorts.Name = "comboBox_ComPorts";
            this.comboBox_ComPorts.Size = new System.Drawing.Size(171, 33);
            this.comboBox_ComPorts.TabIndex = 1;
            this.comboBox_ComPorts.SelectedIndexChanged += new System.EventHandler(this.comPortBox_SelectedIndexChanged);
            // 
            // textbox_Val1
            // 
            this.textbox_Val1.Location = new System.Drawing.Point(72, 154);
            this.textbox_Val1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_Val1.Name = "textbox_Val1";
            this.textbox_Val1.ReadOnly = true;
            this.textbox_Val1.Size = new System.Drawing.Size(171, 31);
            this.textbox_Val1.TabIndex = 2;
            // 
            // comboBox_App1
            // 
            this.comboBox_App1.AllowDrop = true;
            this.comboBox_App1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_App1.FormattingEnabled = true;
            this.comboBox_App1.Location = new System.Drawing.Point(359, 83);
            this.comboBox_App1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_App1.Name = "comboBox_App1";
            this.comboBox_App1.Size = new System.Drawing.Size(171, 33);
            this.comboBox_App1.TabIndex = 3;
            this.comboBox_App1.SelectedIndexChanged += new System.EventHandler(this.comboBox_AudioApps_SelectedIndexChanged);
            // 
            // textbox_App1
            // 
            this.textbox_App1.Location = new System.Drawing.Point(584, 83);
            this.textbox_App1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_App1.Name = "textbox_App1";
            this.textbox_App1.ReadOnly = true;
            this.textbox_App1.Size = new System.Drawing.Size(171, 31);
            this.textbox_App1.TabIndex = 4;
            // 
            // comboBox_App2
            // 
            this.comboBox_App2.AllowDrop = true;
            this.comboBox_App2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_App2.FormattingEnabled = true;
            this.comboBox_App2.Location = new System.Drawing.Point(359, 154);
            this.comboBox_App2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_App2.Name = "comboBox_App2";
            this.comboBox_App2.Size = new System.Drawing.Size(171, 33);
            this.comboBox_App2.TabIndex = 5;
            this.comboBox_App2.SelectedIndexChanged += new System.EventHandler(this.comboBox_App2_SelectedIndexChanged);
            // 
            // textbox_App2
            // 
            this.textbox_App2.Location = new System.Drawing.Point(584, 154);
            this.textbox_App2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_App2.Name = "textbox_App2";
            this.textbox_App2.ReadOnly = true;
            this.textbox_App2.Size = new System.Drawing.Size(171, 31);
            this.textbox_App2.TabIndex = 6;
            // 
            // textbox_Val2
            // 
            this.textbox_Val2.Location = new System.Drawing.Point(72, 195);
            this.textbox_Val2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_Val2.Name = "textbox_Val2";
            this.textbox_Val2.ReadOnly = true;
            this.textbox_Val2.Size = new System.Drawing.Size(171, 31);
            this.textbox_Val2.TabIndex = 7;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "PotPi running in background";
            this.notifyIcon1.BalloonTipTitle = "PotPi";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 299);
            this.Controls.Add(this.textbox_Val2);
            this.Controls.Add(this.textbox_App2);
            this.Controls.Add(this.comboBox_App2);
            this.Controls.Add(this.textbox_App1);
            this.Controls.Add(this.comboBox_App1);
            this.Controls.Add(this.textbox_Val1);
            this.Controls.Add(this.comboBox_ComPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(846, 355);
            this.MinimumSize = new System.Drawing.Size(846, 355);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "PotPi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_ComPorts;
        private System.Windows.Forms.TextBox textbox_Val1;
        private System.Windows.Forms.ComboBox comboBox_App1;
        private System.Windows.Forms.TextBox textbox_App1;
        private System.Windows.Forms.ComboBox comboBox_App2;
        private System.Windows.Forms.TextBox textbox_App2;
        private System.Windows.Forms.TextBox textbox_Val2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

