using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningApp
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeFrorm;

        public Form1()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();                  
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 150, 136);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        } 

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeFrorm != null)
            {
                activeFrorm.Close();
            }
            ActivateButton(btnSender);
            activeFrorm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInfo(), sender);
        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuiz(), sender);
        }

        private void btn_www_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLinks(), sender);
        }      
    }
}
