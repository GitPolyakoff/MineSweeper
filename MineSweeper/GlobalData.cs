using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    
    public class GlobalData
    {
        public static string PlayerTime = "Пусто";
        public static string PlayerName = "Аноним";
        public static string path = Directory.GetCurrentDirectory();
        public static string DifficultSetting = string.Format(@"{0}\difficultSetting.txt", path);
    }
}
