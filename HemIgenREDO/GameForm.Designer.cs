namespace HemIgenREDO
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnMagnifier = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tlpMap = new System.Windows.Forms.TableLayoutPanel();
            this.btnStepTest = new System.Windows.Forms.Button();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tlpInventory = new System.Windows.Forms.TableLayoutPanel();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblStat5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrPlaytime = new System.Windows.Forms.Timer(this.components);
            this.tlpMap.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitGame
            // 
            this.btnExitGame.Location = new System.Drawing.Point(680, 387);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(92, 70);
            this.btnExitGame.TabIndex = 8;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(680, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 63);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Main Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnHand
            // 
            this.btnHand.Location = new System.Drawing.Point(368, 486);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(219, 63);
            this.btnHand.TabIndex = 10;
            this.btnHand.Text = "Hand";
            this.btnHand.UseVisualStyleBackColor = true;
            // 
            // btnMagnifier
            // 
            this.btnMagnifier.Location = new System.Drawing.Point(368, 387);
            this.btnMagnifier.Name = "btnMagnifier";
            this.btnMagnifier.Size = new System.Drawing.Size(219, 70);
            this.btnMagnifier.TabIndex = 11;
            this.btnMagnifier.Text = "Förstoringsglas";
            this.btnMagnifier.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesc.Location = new System.Drawing.Point(12, 387);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(328, 162);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "This text is a description for the biome you are in";
            // 
            // tlpMap
            // 
            this.tlpMap.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpMap.ColumnCount = 9;
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.Controls.Add(this.btnStepTest, 4, 4);
            this.tlpMap.Location = new System.Drawing.Point(0, 0);
            this.tlpMap.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMap.Name = "tlpMap";
            this.tlpMap.RowCount = 9;
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.Size = new System.Drawing.Size(326, 326);
            this.tlpMap.TabIndex = 13;
            // 
            // btnStepTest
            // 
            this.btnStepTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStepTest.Location = new System.Drawing.Point(149, 149);
            this.btnStepTest.Name = "btnStepTest";
            this.btnStepTest.Size = new System.Drawing.Size(28, 28);
            this.btnStepTest.TabIndex = 0;
            this.btnStepTest.Text = "X";
            this.btnStepTest.UseVisualStyleBackColor = true;
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.SystemColors.Window;
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMap.Controls.Add(this.tlpMap);
            this.panelMap.Location = new System.Drawing.Point(12, 30);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(330, 330);
            this.panelMap.TabIndex = 14;
            // 
            // tlpInventory
            // 
            this.tlpInventory.BackColor = System.Drawing.SystemColors.Window;
            this.tlpInventory.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpInventory.ColumnCount = 5;
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0032F));
            this.tlpInventory.Location = new System.Drawing.Point(368, 212);
            this.tlpInventory.Name = "tlpInventory";
            this.tlpInventory.RowCount = 3;
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInventory.Size = new System.Drawing.Size(404, 146);
            this.tlpInventory.TabIndex = 15;
            // 
            // tlpStats
            // 
            this.tlpStats.BackColor = System.Drawing.SystemColors.Window;
            this.tlpStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpStats.ColumnCount = 1;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.Controls.Add(this.lblStat5, 0, 4);
            this.tlpStats.Controls.Add(this.lblTime, 0, 3);
            this.tlpStats.Controls.Add(this.lblSteps, 0, 2);
            this.tlpStats.Controls.Add(this.lblWater, 0, 1);
            this.tlpStats.Controls.Add(this.lblHealth, 0, 0);
            this.tlpStats.Location = new System.Drawing.Point(368, 32);
            this.tlpStats.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 5;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.Size = new System.Drawing.Size(404, 149);
            this.tlpStats.TabIndex = 16;
            // 
            // lblStat5
            // 
            this.lblStat5.AutoSize = true;
            this.lblStat5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat5.Location = new System.Drawing.Point(5, 118);
            this.lblStat5.Name = "lblStat5";
            this.lblStat5.Size = new System.Drawing.Size(394, 29);
            this.lblStat5.TabIndex = 4;
            this.lblStat5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(5, 89);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(394, 27);
            this.lblTime.TabIndex = 3;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteps.Location = new System.Drawing.Point(5, 60);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(394, 27);
            this.lblSteps.TabIndex = 2;
            this.lblSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWater.Location = new System.Drawing.Point(5, 31);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(394, 27);
            this.lblWater.TabIndex = 1;
            this.lblWater.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHealth.Location = new System.Drawing.Point(5, 2);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(394, 27);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Map";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Description";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tlpStats);
            this.Controls.Add(this.tlpInventory);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnMagnifier);
            this.Controls.Add(this.btnHand);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExitGame);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hem Igen";
            this.tlpMap.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHand;
        private System.Windows.Forms.Button btnMagnifier;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TableLayoutPanel tlpMap;
        private System.Windows.Forms.Button btnStepTest;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Label lblStat5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrPlaytime;
    }
}