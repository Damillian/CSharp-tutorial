using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PingPong
{
    class Player
    {
        public PictureBox bat;

        private Key upKey;
        private Key downKey;

        public Player(PictureBox bat, Key upKey, Key downKey)
        {
            this.bat = bat;
            this.upKey = upKey;
            this.downKey = downKey;
        }

        public void MoveBat()
        {
            if (Keyboard.IsKeyDown(downKey) && bat.Top < 210)
                bat.Top += 4;
            else if (Keyboard.IsKeyDown(upKey) && bat.Top > 20)
                bat.Top -= 4;
        }
    }
}
