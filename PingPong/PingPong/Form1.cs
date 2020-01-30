using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PingPong
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;
        Ball ball;
        public Form1()
        {
            InitializeComponent();

            player1 = new Player(pbPlayer1, Key.W, Key.S);
            player2 = new Player(pbPlayer2, Key.Up, Key.Down);
            ball = new Ball(pbBall);
            timer1.Tick += new EventHandler(MoveObjects);
            timer1.Interval = 10;
            timer1.Start();
        }

        private void MoveObjects(object sender, EventArgs e)
        {
            player1.MoveBat();
            player2.MoveBat();
            ball.MoveBall();
            ball.CheckForCollision(player1, player2);

            string winner = ball.CheckForWinner();
            if (winner != null)
            {
                Console.WriteLine("the winner is " + winner);

                ball = new Ball(pbBall);

                if (winner == "p1")
                {
                    lblP1Score.Text = (Int32.Parse(lblP1Score.Text) + 1).ToString();
                } else
                {
                    lblP2Score.Text = (Int32.Parse(lblP2Score.Text) + 1).ToString();
                }
                
            }
                
        }
    }
}
