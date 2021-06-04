
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
            this.comboBox_ComPorts = new System.Windows.Forms.ComboBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.comboBox_AudioApps = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_ComPorts
            // 
            this.comboBox_ComPorts.AllowDrop = true;
            this.comboBox_ComPorts.FormattingEnabled = true;
            this.comboBox_ComPorts.Location = new System.Drawing.Point(144, 111);
            this.comboBox_ComPorts.Name = "comboBox_ComPorts";
            this.comboBox_ComPorts.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ComPorts.TabIndex = 1;
            this.comboBox_ComPorts.Text = "comboBox1";
            this.comboBox_ComPorts.SelectedIndexChanged += new System.EventHandler(this.comPortBox_SelectedIndexChanged);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(144, 243);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(121, 97);
            this.outputBox.TabIndex = 2;
            // 
            // comboBox_AudioApps
            // 
            this.comboBox_AudioApps.AllowDrop = true;
            this.comboBox_AudioApps.FormattingEnabled = true;
            this.comboBox_AudioApps.Location = new System.Drawing.Point(345, 111);
            this.comboBox_AudioApps.Name = "comboBox_AudioApps";
            this.comboBox_AudioApps.Size = new System.Drawing.Size(121, 23);
            this.comboBox_AudioApps.TabIndex = 3;
            this.comboBox_AudioApps.Text = "comboBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_AudioApps);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.comboBox_ComPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_ComPorts;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.ComboBox comboBox_AudioApps;
    }
}

