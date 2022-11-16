using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MineSweeper
{
    public class Player
    {
        string time;
        string nickname;    
        public Player()
        {
            Time = "00:00";
            nickname = "";
        }
        public Player(string nickname,string time)
        {
            this.Time = time;
            this.NickName = nickname;
        }
        public string NickName
        {
            set { nickname = value; }
            get { return nickname; }
        }
        public string Time
        {
            set { time = value; }
            get { return time; }
        }       
    }
}
