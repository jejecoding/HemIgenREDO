namespace HemIgenREDO
{
    partial class MenuForm
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.btnHardcore = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlMainMenu.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackgroundImage = global::HemIgenREDO.Properties.Resources.lild_strand_1;
            this.pnlMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainMenu.Controls.Add(this.pnlDifficulty);
            this.pnlMainMenu.Controls.Add(this.btnExit);
            this.pnlMainMenu.Controls.Add(this.btnStart);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(384, 361);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.BackgroundImage = global::HemIgenREDO.Properties.Resources.mt_des_voeux_300_600x450;
            this.pnlDifficulty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDifficulty.Controls.Add(this.btnBack);
            this.pnlDifficulty.Controls.Add(this.btnHardcore);
            this.pnlDifficulty.Controls.Add(this.btnHard);
            this.pnlDifficulty.Controls.Add(this.btnNormal);
            this.pnlDifficulty.Controls.Add(this.btnEasy);
            this.pnlDifficulty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDifficulty.Location = new System.Drawing.Point(0, 0);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(384, 361);
            this.pnlDifficulty.TabIndex = 2;
            // 
            // btnHardcore
            // 
            this.btnHardcore.BackgroundImage = global::HemIgenREDO.Properties.Resources.New_Piskel__5_;
            this.btnHardcore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHardcore.Location = new System.Drawing.Point(150, 243);
            this.btnHardcore.Name = "btnHardcore";
            this.btnHardcore.Size = new System.Drawing.Size(100, 50);
            this.btnHardcore.TabIndex = 3;
            this.btnHardcore.UseVisualStyleBackColor = true;
            this.btnHardcore.Click += new System.EventHandler(this.btnHardcore_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackgroundImage = global::HemIgenREDO.Properties.Resources.New_Piskel__4_;
            this.btnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHard.Location = new System.Drawing.Point(150, 188);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(100, 50);
            this.btnHard.TabIndex = 2;
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackgroundImage = global::HemIgenREDO.Properties.Resources.New_Piskel__3_;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Location = new System.Drawing.Point(150, 133);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(100, 50);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackgroundImage = global::HemIgenREDO.Properties.Resources.New_Piskel__2_;
            this.btnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEasy.Location = new System.Drawing.Point(150, 78);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(100, 50);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::HemIgenREDO.Properties.Resources.exitbre;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(150, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::HemIgenREDO.Properties.Resources.start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(150, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(272, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "MenuForm";
            this.Text = "Hem Igen Huvudmeny";
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlDifficulty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.Button btnHardcore;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnBack;
    }
}

