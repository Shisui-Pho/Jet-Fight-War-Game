/*Developer name     : Phiwokwakhe Khathwane 
 * Available at      : phiwokwakhe299@gmail.com
 * Git-Hub Id        : @Shisui-Pho
 * Stack OverFlow Id : @Shisui-Pho
 * Zapsplat          : @The_Collector
 * Project Type      : Game 
 * Project name      : Fighter Jet (Mod Version )
*/

using System;
using System.Windows.Forms;
using System.Media;

namespace Jet_Shooter_Game_by_Phiwo
{
    
   
    public partial class CfrmJetShooter : Form
    {
        bool goLeft, goRight, isShouting, isGameOver;

        int iPlayerSpeed = 12, iBulletSpeed , iEnemySpeed, iScore;
        Random rndEnemyPosition = new Random();
        //int iNumber1 = 2;
	  int iNumber1 = 2;
	  int iCountScore = 0;

        private void CoordinatesForCode(object sender, EventArgs e)
        {

        }//CoordinatesForCode

        private void GetCoordinates(object sender, MouseEventArgs e)
        {
            string sCoordinates = "( " + e.X.ToString() + " ; " + e.Y.ToString() + " )";
            lblCoordinates.Text = sCoordinates;
        }//GetCoordinates

        public CfrmJetShooter()
        {
            InitializeComponent();
            gameOver(iNumber1);
            Playing();
           // resetGame();
        }//Initializing the components

        private void CfrmJetShooter_Load(object sender, EventArgs e)
        {

        }//CfrmaLoad

        private void tmrStarGame_Tick(object sender, EventArgs e)
        {
            /*SoundPlayer splyPlaySong = new SoundPlayer(Properties.Resources.Play2);
            splyPlaySong.Play();*/
            //PlaySound();
            
            picEnemy1.Visible = true;
            picEnemy2.Visible = true;
            picEnemy3.Visible = true;
            lblScore.Text = iScore.ToString();

            picEnemy1.Top += iEnemySpeed;
            picEnemy2.Top += iEnemySpeed;
            picEnemy3.Top += iEnemySpeed;

            if (picEnemy1.Top > 556 || picEnemy2.Top > 556 || picEnemy3.Top > 556)
            {
                gameOver();
            }//If the enemy jet hits the ground , then the game ends

            if (goLeft && picJet.Left > 0)
            {
                picJet.Left -= iPlayerSpeed;
            }//Check if the left key is pressed
            if(goRight && picJet.Left < 570)
            {
                picJet.Left += iPlayerSpeed;
            }//Check if the player pressed the right key
            if (isShouting)
            {
                iBulletSpeed = 20;
                picBullet.Top -= iBulletSpeed;
            }//
            else
            {
                picBullet.Left = -300;
                iBulletSpeed = 0;
               // picBullet.Top = picJet.Top;
            }//If the space key is not pressed remove the bullet from the game

            if(picBullet.Top < -30)
            {
                isShouting = false;
            }//

            if (picBullet.Bounds.IntersectsWith(picEnemy1.Bounds))
            {
                //Hit();
                iScore += 1;
                picEnemy1.Left = rndEnemyPosition.Next(0, 600);
                picEnemy1.Top = -470;
                isShouting = false;
		        iCountScore+= 1;

            }///If the bullet intersect with the enemy jets number 1 , then the score will be incremented and the enemy jet will dissapear and appear on a random place
            if (picBullet.Bounds.IntersectsWith(picEnemy2.Bounds))
            {
                //Hit();
                iScore += 1;
                picEnemy2.Left = rndEnemyPosition.Next(0, 600);
                picEnemy2.Top = -470;
                isShouting = false;
		        iCountScore+= 1;

            }///If the bullet intersect with the enemy jets number 1 , then the score will be incremented and the enemy jet will dissapear and appear on a random place
            if (picBullet.Bounds.IntersectsWith(picEnemy3.Bounds))
            {
                //Hit();
                iScore += 1;
                picEnemy3.Left = rndEnemyPosition.Next(0, 600);
                picEnemy3.Top = -470;
                isShouting = false;
		        iCountScore+= 1;

            }///If the bullet intersect with the enemy jets number 1 , then the score will be incremented and the enemy jet will dissapear and appear on a random place
            //Increase the score if the player hits a certain score

	     
	        if(iCountScore == 20)
	        {
                //Increase speed by 2
	 	        iEnemySpeed += 2 ;
                iPlayerSpeed += 2;
		
		        iCountScore = 0;
	        }//Loop to increase the speed every 20 points score	     

        }//tmrStarGame_Tick

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }//If the left key is pressed then assigne the bool variable of Left to true and the control can move to the left 
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }//If the left key is pressed then assigne the bool variable of Right to true and the control can move to the Right 

        }//Key is pressed

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }//If the player releases the button stop the execution of the button clicked
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }//If the player releases the button stop the execution of the button clicked

            if(e.KeyCode == Keys.Space)
            {
                isShouting = true;
                picBullet.Top = picJet.Top;
                picBullet.Left = picJet.Left + picJet.Width / 2;
            }//If the space key is pressed and released the start shooting 
            if(e.KeyCode == Keys.Enter)
            {
                resetGame();
            }//If the enter key is pressed and released then the game will restart
        }//KeyIsUp
        private void resetGame()
        {
            //Start the timer
            tmrStarGame.Start();

            //Initialize the positions of enemy jets based on the top position random 
            picEnemy1.Top = rndEnemyPosition.Next(-20, 80);
            picEnemy2.Top = rndEnemyPosition.Next(-20, 80);
            picEnemy3.Top = rndEnemyPosition.Next(-20, 80);

            //Initialize the position of enemy jets based on the horizontal position
            picEnemy1.Left = rndEnemyPosition.Next(0, 600);
            picEnemy2.Left = rndEnemyPosition.Next(0, 600);
            picEnemy3.Left = rndEnemyPosition.Next(0, 600);

            //Initialize the bullet to an initial position
            picBullet.Left = -300;

            //Inititialize all every variable
            iCountScore = 0;
            iScore = 0;
            lblScore.Text = iScore.ToString();
            iBulletSpeed = 0;
            iEnemySpeed = 6;
            isShouting = false;

        }//Reset the game
        private void gameOver(int _iNumber1 = 1)//int _iNumber1 = 1)
        {
            
            if(_iNumber1 == 1)
            {
                isGameOver = true;
                tmrStarGame.Stop();

                lblScore.Text =  Environment.NewLine + "Score : " + iScore + "\nGame Over !!!"  + Environment.NewLine + "Press enter to restart the game ";
            }
            else
            {
                //Start();
                picEnemy1.Visible = false;
                picEnemy2.Visible = false;
                picEnemy3.Visible = false;
                tmrStarGame.Stop();
                lblScore.Text = "Welcome to Phiwo's".PadLeft(100)+"Jet Shooter game" + Environment.NewLine + "\nPress enter to start the game ";
            }           
        }//GameOver
        private void Hit()
        {
            SoundPlayer splyPlaySong = new SoundPlayer(Properties.Resources.hit);//new SoundPlayer(Lococation : "@c:\Users\Phiwo\Desktop\hit.wav")//|| ("@c:\Users\Phiwo\Desktop\hit.wav");
            splyPlaySong.Play();
        }//Play hit sound
        private void Start()
        {
            SoundPlayer splyPlaySong = new SoundPlayer(Properties.Resources.play);
            splyPlaySong.Play();
        }//Play brgining sound
        private void Playing()
        {
            SoundPlayer splyPlaySong = new SoundPlayer(Properties.Resources.Japan_Life1);
            splyPlaySong.PlayLooping();
           //splyPlaySong.Loo
        }//Play playing sound
    }//End of Class
}//End of namespace
