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
        private PictureBox bat;

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
            if (Keyboard.IsKeyDown(downKey) && bat.Top < 250)
                bat.Top += 2;
            else if (Keyboard.IsKeyDown(upKey) && bat.Top > 50)
                bat.Top -= 2;
        }
    }
}
