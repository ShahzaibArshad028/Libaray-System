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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.themeLight = new System.Windows.Forms.RadioButton();
            this.ThemeDark = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartedButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // themeLight
            // 
            this.themeLight.AutoSize = true;
            this.themeLight.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLight.Location = new System.Drawing.Point(84, 88);
            this.themeLight.Name = "themeLight";
            this.themeLight.Size = new System.Drawing.Size(140, 29);
            this.themeLight.TabIndex = 1;
            this.themeLight.TabStop = true;
            this.themeLight.Text = "Light Mode";
            this.themeLight.UseVisualStyleBackColor = true;
            this.themeLight.CheckedChanged += new System.EventHandler(this.themeLight_CheckedChanged);
            // 
            // ThemeDark
            // 
            this.ThemeDark.AutoSize = true;
            this.ThemeDark.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeDark.Location = new System.Drawing.Point(84, 132);
            this.ThemeDark.Name = "ThemeDark";
            this.ThemeDark.Size = new System.Drawing.Size(135, 29);
            this.ThemeDark.TabIndex = 2;
            this.ThemeDark.TabStop = true;
            this.ThemeDark.Text = "Dark Mode";
            this.ThemeDark.UseVisualStyleBackColor = true;
            this.ThemeDark.CheckedChanged += new System.EventHandler(this.ThemeDark_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ThemeDark);
            this.panel1.Controls.Add(this.themeLight);
            this.panel1.Location = new System.Drawing.Point(160, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 198);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StartedButton);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(379, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 523);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(120, 101);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(376, 177);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Theme ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartedButton
            // 
            this.StartedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartedButton.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartedButton.Location = new System.Drawing.Point(244, 469);
            this.StartedButton.Name = "StartedButton";
            this.StartedButton.Size = new System.Drawing.Size(155, 40);
            this.StartedButton.TabIndex = 5;
            this.StartedButton.Text = "Let\'s Start";
            this.StartedButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2237, 1080);
            this.MinimumSize = new System.Drawing.Size(1278, 736);
            this.Name = "Form1";
            this.Text = "Windows Library System ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton themeLight;
        private System.Windows.Forms.RadioButton ThemeDark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartedButton;
    }
}

