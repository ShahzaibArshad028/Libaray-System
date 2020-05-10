namespace Project__PHASE_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.themeLight = new System.Windows.Forms.RadioButton();
            this.ThemeDark = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // themeLight
            // 
            this.themeLight.AutoSize = true;
            this.themeLight.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLight.Location = new System.Drawing.Point(54, 0);
            this.themeLight.Name = "themeLight";
            this.themeLight.Size = new System.Drawing.Size(153, 110);
            this.themeLight.TabIndex = 1;
            this.themeLight.TabStop = true;
            this.themeLight.Text = "Light Mode";
            this.themeLight.UseVisualStyleBackColor = true;
            this.themeLight.CheckedChanged += new System.EventHandler(this.themeLight_CheckedChanged);
            // 
            // ThemeDark
            // 
            this.ThemeDark.AutoSize = true;
            this.ThemeDark.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeDark.Location = new System.Drawing.Point(54, 85);
            this.ThemeDark.Name = "ThemeDark";
            this.ThemeDark.Size = new System.Drawing.Size(153, 110);
            this.ThemeDark.TabIndex = 2;
            this.ThemeDark.TabStop = true;
            this.ThemeDark.Text = "Dark Mode";
            this.ThemeDark.UseVisualStyleBackColor = true;
            this.ThemeDark.CheckedChanged += new System.EventHandler(this.ThemeDark_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThemeDark);
            this.panel1.Controls.Add(this.themeLight);
            this.panel1.Location = new System.Drawing.Point(539, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 198);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1364, 736);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Windows Library System ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton themeLight;
        private System.Windows.Forms.RadioButton ThemeDark;
        private System.Windows.Forms.Panel panel1;
    }
}

