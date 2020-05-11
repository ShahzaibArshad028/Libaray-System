﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__PHASE_1
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        public welcome(Color BackGround, Color ForeGround, Color PanelBack, Color PanelFore)
        {
            InitializeComponent();
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
          
            if (PanelBack == Color.FromArgb(220, 220, 220))
            {
                Color LIGHT = PanelBack;
                imgPanel.BackColor = LIGHT;
                AddBtn.BackColor = LIGHT;
                RemoveBtn.BackColor = LIGHT;
                RetBtn.BackColor = LIGHT;
                CngPsdBtn.BackColor = LIGHT;
                addNewUserBtn.BackColor = LIGHT;
                LogoutBtn.BackColor = LIGHT;
                ExitBtn.BackColor = LIGHT;
                SearchBtn.BackColor = LIGHT;
                leftPanel.BackColor = Color.FromArgb(190, 190, 190);

            }
            else
            {
                Color DARK = PanelBack;
                AddBtn.BackColor = DARK;
                RemoveBtn.BackColor = DARK;
                RetBtn.BackColor = DARK;
                CngPsdBtn.BackColor = DARK;
                addNewUserBtn.BackColor = DARK;
                LogoutBtn.BackColor = DARK;
                ExitBtn.BackColor = DARK;
                imgPanel.BackColor = DARK;
                SearchBtn.BackColor = DARK;
                leftPanel.BackColor = Color.FromArgb(70,70,105);
            }
        }
        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            login lgnForm = new login(this.BackColor,
                this.ForeColor, leftPanel.BackColor, leftPanel.ForeColor);
            this.Hide();
            lgnForm.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RetBtn_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return();
            returnForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void imgPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add addForm = new Add();
            addForm.Show();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Remove removeForm = new Remove();
            removeForm.Show();  
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.Show();
        }

        private void CngPsdBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.Show();
        }

        private void addNewUserBtn_Click(object sender, EventArgs e)
        {
            NewUser addNewUser = new NewUser();
            addNewUser.Show();
        }
    }
}
