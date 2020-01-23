using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    class Ball
    {
        private PictureBox ball;
        
        //angle 0 = horizontal, 1 is up, -1 is down
        private double angle;
        private double speed;
        private string direction;
        private string winner;

        public Ball(PictureBox ball)
        {
            this.ball = ball;
            this.direction = "right";
            this.angle = 0;
            this.speed = 4;
            ball.Top = 130;
            ball.Left = 250;
        }

        public void MoveBall()
        {
            if (this.direction == "right")
                ball.Left += (int)speed;
            if (this.direction == "left")
                ball.Left -= (int)speed;

            ball.Top -= (int)(4* angle);
        }

        public void CheckForCollision (Player p1, Player p2)
        {
            if (ball.Left < p1.bat.Left + 20 + speed  && ball.Left > p1.bat.Left && ball.Top > p1.bat.Top - 20 && ball.Top < p1.bat.Top + 80)
            {
                this.direction = "right";
                changeAngle(p1.bat.Top);
            }
            if (ball.Left + 25 > p2.bat.Left - speed && ball.Left < p2.bat.Left + 20 && ball.Top > p2.bat.Top - 20 && ball.Top < p2.bat.Top + 80)
            {
                this.direction = "left";
                changeAngle(p2.bat.Top);
            }
                
            if (ball.Top <5 || ball.Top > 275)
            {
                angle = -angle;
            }

            if (ball.Left < -10)
                winner = "p2";
            else if (ball.Left > 650)
                winner = "p1";
            else
                winner = null;
            
        }

        public string CheckForWinner()
        {
            return winner;
        }

        private void changeAngle(int topOfBat)
        {
            this.angle = (topOfBat - ball.Top + 30) * 0.04;
            this.speed += .3;
        }
    }
}
