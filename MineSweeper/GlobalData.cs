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
        public static string PlayerTimeEasy = "Пусто";
        public static string PlayerTimeMedium = "Пусто";
        public static string PlayerTimeHard = "Пусто";
        public static string PlayerName = "Аноним";
        public static string path = Directory.GetCurrentDirectory();
        public static string EasyLdrFileName = string.Format(@"{0}\EasyLeader.txt", path);
        public static string MediumLdrFileName = string.Format(@"{0}\MediumLeader.txt", path);
        public static string HardLdrFileName = string.Format(@"{0}\HardLeader.txt", path);
        public static string ColorForm = string.Format(@"{0}\colorform.txt", path);
        public static string DifficultSetting = string.Format(@"{0}\difficultSetting.txt", path);

    }
}
