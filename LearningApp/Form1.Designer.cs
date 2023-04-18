namespace LearningApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btn_www = new System.Windows.Forms.Button();
            this.btn_quiz = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_www);
            this.panelMenu.Controls.Add(this.btn_quiz);
            this.panelMenu.Controls.Add(this.btn_Info);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(664, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(236, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LEARNING APP";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(106)))));
            this.panelDesktop.BackgroundImage = global::LearningApp.Properties.Resources.USUK;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesktop.Controls.Add(this.lblWelcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(664, 481);
            this.panelDesktop.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGray;
            this.lblWelcome.Location = new System.Drawing.Point(213, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(234, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            // 
            // btn_www
            // 
            this.btn_www.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_www.FlatAppearance.BorderSize = 0;
            this.btn_www.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_www.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_www.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_www.Image = global::LearningApp.Properties.Resources.www;
            this.btn_www.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_www.Location = new System.Drawing.Point(0, 220);
            this.btn_www.Name = "btn_www";
            this.btn_www.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_www.Size = new System.Drawing.Size(220, 70);
            this.btn_www.TabIndex = 3;
            this.btn_www.Text = "Links";
            this.btn_www.UseVisualStyleBackColor = true;
            this.btn_www.Click += new System.EventHandler(this.btn_www_Click);
            // 
            // btn_quiz
            // 
            this.btn_quiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quiz.FlatAppearance.BorderSize = 0;
            this.btn_quiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_quiz.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_quiz.Image = global::LearningApp.Properties.Resources.Q;
            this.btn_quiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quiz.Location = new System.Drawing.Point(0, 150);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_quiz.Size = new System.Drawing.Size(220, 70);
            this.btn_quiz.TabIndex = 2;
            this.btn_quiz.Text = "Quiz";
            this.btn_quiz.UseVisualStyleBackColor = true;
            this.btn_quiz.Click += new System.EventHandler(this.btn_quiz_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Info.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Info.Image = global::LearningApp.Properties.Resources.info;
            this.btn_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Info.Location = new System.Drawing.Point(0, 80);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Info.Size = new System.Drawing.Size(220, 70);
            this.btn_Info.TabIndex = 1;
            this.btn_Info.Text = "Info";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundImage = global::LearningApp.Properties.Resources.eng;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_www;
        private System.Windows.Forms.Button btn_quiz;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblWelcome;
    }
}

