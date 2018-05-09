namespace TEC_Companion
{
	partial class Form_Options
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
			this.Button_Accept = new System.Windows.Forms.Button();
			this.ComboBox_COMPorts = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Button_COMRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button_Accept
			// 
			this.Button_Accept.Location = new System.Drawing.Point(174, 318);
			this.Button_Accept.Name = "Button_Accept";
			this.Button_Accept.Size = new System.Drawing.Size(103, 23);
			this.Button_Accept.TabIndex = 0;
			this.Button_Accept.Text = "Accept";
			this.Button_Accept.UseVisualStyleBackColor = true;
			this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
			// 
			// ComboBox_COMPorts
			// 
			this.ComboBox_COMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_COMPorts.FormattingEnabled = true;
			this.ComboBox_COMPorts.Location = new System.Drawing.Point(174, 12);
			this.ComboBox_COMPorts.Name = "ComboBox_COMPorts";
			this.ComboBox_COMPorts.Size = new System.Drawing.Size(103, 21);
			this.ComboBox_COMPorts.TabIndex = 1;
			this.ComboBox_COMPorts.SelectedIndexChanged += new System.EventHandler(this.ComboBox_COMPorts_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Choose COM Port:";
			// 
			// Button_COMRefresh
			// 
			this.Button_COMRefresh.Location = new System.Drawing.Point(174, 39);
			this.Button_COMRefresh.Name = "Button_COMRefresh";
			this.Button_COMRefresh.Size = new System.Drawing.Size(103, 23);
			this.Button_COMRefresh.TabIndex = 3;
			this.Button_COMRefresh.Text = "Refresh";
			this.Button_COMRefresh.UseVisualStyleBackColor = true;
			this.Button_COMRefresh.Click += new System.EventHandler(this.Button_COMRefresh_Click);
			// 
			// Form_Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 353);
			this.Controls.Add(this.Button_COMRefresh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ComboBox_COMPorts);
			this.Controls.Add(this.Button_Accept);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form_Options";
			this.Text = "Options";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Button_Accept;
		private System.Windows.Forms.ComboBox ComboBox_COMPorts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Button_COMRefresh;
	}
}