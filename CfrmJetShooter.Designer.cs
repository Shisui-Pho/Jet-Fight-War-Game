
namespace Jet_Shooter_Game_by_Phiwo
{
    partial class CfrmJetShooter
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
            this.picJet = new System.Windows.Forms.PictureBox();
            this.picEnemy1 = new System.Windows.Forms.PictureBox();
            this.picEnemy2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.picBullet = new System.Windows.Forms.PictureBox();
            this.tmrStarGame = new System.Windows.Forms.Timer(this.components);
            this.picEnemy3 = new System.Windows.Forms.PictureBox();
            this.lblCoordinates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picJet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // picJet
            // 
            this.picJet.BackgroundImage = global::Jet_Shooter_Game_by_Phiwo.Properties.Resources.player;
            this.picJet.Location = new System.Drawing.Point(267, 484);
            this.picJet.Name = "picJet";
            this.picJet.Size = new System.Drawing.Size(110, 101);
            this.picJet.TabIndex = 0;
            this.picJet.TabStop = false;
            // 
            // picEnemy1
            // 
            this.picEnemy1.Image = global::Jet_Shooter_Game_by_Phiwo.Properties.Resources.enemy;
            this.picEnemy1.Location = new System.Drawing.Point(52, -3);
            this.picEnemy1.Name = "picEnemy1";
            this.picEnemy1.Size = new System.Drawing.Size(100, 85);
            this.picEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnemy1.TabIndex = 1;
            this.picEnemy1.TabStop = false;
            // 
            // picEnemy2
            // 
            this.picEnemy2.Image = global::Jet_Shooter_Game_by_Phiwo.Properties.Resources.enemy;
            this.picEnemy2.Location = new System.Drawing.Point(512, -3);
            this.picEnemy2.Name = "picEnemy2";
            this.picEnemy2.Size = new System.Drawing.Size(100, 85);
            this.picEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnemy2.TabIndex = 2;
            this.picEnemy2.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(302, 230);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 25);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // picBullet
            // 
            this.picBullet.Image = global::Jet_Shooter_Game_by_Phiwo.Properties.Resources.bullet;
            this.picBullet.Location = new System.Drawing.Point(320, 484);
            this.picBullet.Name = "picBullet";
            this.picBullet.Size = new System.Drawing.Size(7, 27);
            this.picBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBullet.TabIndex = 4;
            this.picBullet.TabStop = false;
            // 
            // tmrStarGame
            // 
            this.tmrStarGame.Interval = 40;
            this.tmrStarGame.Tick += new System.EventHandler(this.tmrStarGame_Tick);
            // 
            // picEnemy3
            // 
            this.picEnemy3.Image = global::Jet_Shooter_Game_by_Phiwo.Properties.Resources.enemy;
            this.picEnemy3.Location = new System.Drawing.Point(277, -3);
            this.picEnemy3.Name = "picEnemy3";
            this.picEnemy3.Size = new System.Drawing.Size(100, 85);
            this.picEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnemy3.TabIndex = 5;
            this.picEnemy3.TabStop = false;
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(615, 561);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(66, 13);
            this.lblCoordinates.TabIndex = 6;
            this.lblCoordinates.Text = "Co-ordinates";
            // 
            // CfrmJetShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(684, 573);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCoordinates);
            this.Controls.Add(this.picJet);
            this.Controls.Add(this.picBullet);
            this.Controls.Add(this.picEnemy2);
            this.Controls.Add(this.picEnemy3);
            this.Controls.Add(this.picEnemy1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CfrmJetShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jet Shooter";
            this.Load += new System.EventHandler(this.CfrmJetShooter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.MouseCaptureChanged += new System.EventHandler(this.CoordinatesForCode);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetCoordinates);
            ((System.ComponentModel.ISupportInitialize)(this.picJet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJet;
        private System.Windows.Forms.PictureBox picEnemy1;
        private System.Windows.Forms.PictureBox picEnemy2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picBullet;
        private System.Windows.Forms.Timer tmrStarGame;
        private System.Windows.Forms.PictureBox picEnemy3;
        private System.Windows.Forms.Label lblCoordinates;
    }
}

