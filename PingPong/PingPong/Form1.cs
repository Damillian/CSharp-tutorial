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
            timer1.Tick += new EventHandler(MoveObjects);
            timer1.Interval = 20;
            timer1.Start();
            


        }

        private void MoveObjects(object sender, EventArgs e)
        {
            player1.MoveBat();
            player2.MoveBat();
        }
    }
}
