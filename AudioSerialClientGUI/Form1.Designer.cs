
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
            this.textbox_Val1 = new System.Windows.Forms.TextBox();
            this.comboBox_App1 = new System.Windows.Forms.ComboBox();
            this.textbox_App1 = new System.Windows.Forms.TextBox();
            this.comboBox_App2 = new System.Windows.Forms.ComboBox();
            this.textbox_App2 = new System.Windows.Forms.TextBox();
            this.textbox_Val2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_ComPorts
            // 
            this.comboBox_ComPorts.AllowDrop = true;
            this.comboBox_ComPorts.FormattingEnabled = true;
            this.comboBox_ComPorts.Location = new System.Drawing.Point(206, 185);
            this.comboBox_ComPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_ComPorts.Name = "comboBox_ComPorts";
            this.comboBox_ComPorts.Size = new System.Drawing.Size(171, 33);
            this.comboBox_ComPorts.TabIndex = 1;
            this.comboBox_ComPorts.Text = "comboBox1";
            this.comboBox_ComPorts.SelectedIndexChanged += new System.EventHandler(this.comPortBox_SelectedIndexChanged);
            // 
            // textbox_Val1
            // 
            this.textbox_Val1.Location = new System.Drawing.Point(206, 256);
            this.textbox_Val1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_Val1.Name = "textbox_Val1";
            this.textbox_Val1.ReadOnly = true;
            this.textbox_Val1.Size = new System.Drawing.Size(171, 31);
            this.textbox_Val1.TabIndex = 2;
            // 
            // comboBox_App1
            // 
            this.comboBox_App1.AllowDrop = true;
            this.comboBox_App1.FormattingEnabled = true;
            this.comboBox_App1.Location = new System.Drawing.Point(493, 185);
            this.comboBox_App1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_App1.Name = "comboBox_App1";
            this.comboBox_App1.Size = new System.Drawing.Size(171, 33);
            this.comboBox_App1.TabIndex = 3;
            this.comboBox_App1.Text = "comboBox_SelectedApp1";
            this.comboBox_App1.SelectedIndexChanged += new System.EventHandler(this.comboBox_AudioApps_SelectedIndexChanged);
            // 
            // textbox_App1
            // 
            this.textbox_App1.Location = new System.Drawing.Point(718, 185);
            this.textbox_App1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_App1.Name = "textbox_App1";
            this.textbox_App1.ReadOnly = true;
            this.textbox_App1.Size = new System.Drawing.Size(171, 31);
            this.textbox_App1.TabIndex = 4;
            // 
            // comboBox_App2
            // 
            this.comboBox_App2.AllowDrop = true;
            this.comboBox_App2.FormattingEnabled = true;
            this.comboBox_App2.Location = new System.Drawing.Point(493, 256);
            this.comboBox_App2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_App2.Name = "comboBox_App2";
            this.comboBox_App2.Size = new System.Drawing.Size(171, 33);
            this.comboBox_App2.TabIndex = 5;
            this.comboBox_App2.Text = "comboBox_SelectedApp2";
            this.comboBox_App2.SelectedIndexChanged += new System.EventHandler(this.comboBox_App2_SelectedIndexChanged);
            // 
            // textbox_App2
            // 
            this.textbox_App2.Location = new System.Drawing.Point(718, 256);
            this.textbox_App2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_App2.Name = "textbox_App2";
            this.textbox_App2.ReadOnly = true;
            this.textbox_App2.Size = new System.Drawing.Size(171, 31);
            this.textbox_App2.TabIndex = 6;
            // 
            // textbox_Val2
            // 
            this.textbox_Val2.Location = new System.Drawing.Point(206, 297);
            this.textbox_Val2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_Val2.Name = "textbox_Val2";
            this.textbox_Val2.ReadOnly = true;
            this.textbox_Val2.Size = new System.Drawing.Size(171, 31);
            this.textbox_Val2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.textbox_Val2);
            this.Controls.Add(this.textbox_App2);
            this.Controls.Add(this.comboBox_App2);
            this.Controls.Add(this.textbox_App1);
            this.Controls.Add(this.comboBox_App1);
            this.Controls.Add(this.textbox_Val1);
            this.Controls.Add(this.comboBox_ComPorts);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

