namespace TEC_Companion
{
    partial class Form1
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
            this.ComboBox_COMPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Data = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_AmbientTemp = new System.Windows.Forms.Label();
            this.Label_Humidity = new System.Windows.Forms.Label();
            this.Label_DewPoint = new System.Windows.Forms.Label();
            this.Button_ReadCOM = new System.Windows.Forms.Button();
            this.Panel_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox_COMPorts
            // 
            this.ComboBox_COMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COMPorts.FormattingEnabled = true;
            this.ComboBox_COMPorts.Location = new System.Drawing.Point(159, 12);
            this.ComboBox_COMPorts.Name = "ComboBox_COMPorts";
            this.ComboBox_COMPorts.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_COMPorts.TabIndex = 0;
            this.ComboBox_COMPorts.SelectedIndexChanged += new System.EventHandler(this.ComboBox_COMPorts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Arduino COM Port:";
            // 
            // Panel_Data
            // 
            this.Panel_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Data.Controls.Add(this.Label_DewPoint);
            this.Panel_Data.Controls.Add(this.Label_Humidity);
            this.Panel_Data.Controls.Add(this.Label_AmbientTemp);
            this.Panel_Data.Controls.Add(this.label4);
            this.Panel_Data.Controls.Add(this.label3);
            this.Panel_Data.Controls.Add(this.label2);
            this.Panel_Data.Location = new System.Drawing.Point(12, 76);
            this.Panel_Data.Name = "Panel_Data";
            this.Panel_Data.Size = new System.Drawing.Size(268, 179);
            this.Panel_Data.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Humidity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dew Point:";
            // 
            // Label_AmbientTemp
            // 
            this.Label_AmbientTemp.AutoSize = true;
            this.Label_AmbientTemp.Location = new System.Drawing.Point(191, 20);
            this.Label_AmbientTemp.Name = "Label_AmbientTemp";
            this.Label_AmbientTemp.Size = new System.Drawing.Size(52, 13);
            this.Label_AmbientTemp.TabIndex = 7;
            this.Label_AmbientTemp.Text = "##.## *C";
            // 
            // Label_Humidity
            // 
            this.Label_Humidity.AutoSize = true;
            this.Label_Humidity.Location = new System.Drawing.Point(191, 46);
            this.Label_Humidity.Name = "Label_Humidity";
            this.Label_Humidity.Size = new System.Drawing.Size(39, 13);
            this.Label_Humidity.TabIndex = 8;
            this.Label_Humidity.Text = "### %";
            // 
            // Label_DewPoint
            // 
            this.Label_DewPoint.AutoSize = true;
            this.Label_DewPoint.Location = new System.Drawing.Point(191, 72);
            this.Label_DewPoint.Name = "Label_DewPoint";
            this.Label_DewPoint.Size = new System.Drawing.Size(52, 13);
            this.Label_DewPoint.TabIndex = 9;
            this.Label_DewPoint.Text = "##.## *C";
            // 
            // Button_ReadCOM
            // 
            this.Button_ReadCOM.Location = new System.Drawing.Point(159, 39);
            this.Button_ReadCOM.Name = "Button_ReadCOM";
            this.Button_ReadCOM.Size = new System.Drawing.Size(121, 23);
            this.Button_ReadCOM.TabIndex = 10;
            this.Button_ReadCOM.Text = "Read COM Ports";
            this.Button_ReadCOM.UseVisualStyleBackColor = true;
            this.Button_ReadCOM.Click += new System.EventHandler(this.Button_ReadCOM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Button_ReadCOM);
            this.Controls.Add(this.Panel_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_COMPorts);
            this.Name = "Form1";
            this.Text = "TEC Companion";
            this.Panel_Data.ResumeLayout(false);
            this.Panel_Data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_COMPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_DewPoint;
        private System.Windows.Forms.Label Label_Humidity;
        private System.Windows.Forms.Label Label_AmbientTemp;
        private System.Windows.Forms.Button Button_ReadCOM;
    }
}

