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
        public static Player FromString(string text)
        {
            char[] del = { ';' };
            string[] sub = text.Split(del);
            Player pl = new Player(sub[0], sub[1]);
            return pl;
        }
        public static bool ReadFile(string LdrFileName, List<Player> players)
        {
            bool success = false;
            if (string.IsNullOrEmpty(LdrFileName) ||
                string.IsNullOrWhiteSpace(LdrFileName) ||
                players == null)
                return success;

            // очистить список
            players.Clear();

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(LdrFileName,
                    Encoding.Default);
                string str;
                Player pl = null;
                while (!reader.EndOfStream)
                {
                    str = reader.ReadLine();
                    //Проверка на пустую строку
                    if (string.IsNullOrEmpty(str))
                        continue;
                    //Проверка на строку состоящую только из пробелов
                    if (string.IsNullOrWhiteSpace(str))
                        continue;
                    //Проверка на комментарий
                    if (str[0] == '#')
                        continue;
                    pl = FromString(str);
                    if (pl != null)
                        players.Add(pl);

                }

                reader.Close();

                success = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "Ошибка при чтении файла");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }

            return success;
        }
        public static bool SaveFile(string LdrFileName,
            List<Player> players)
        {
            bool success = false;
            if (string.IsNullOrEmpty(LdrFileName) ||
                string.IsNullOrWhiteSpace(LdrFileName) ||
                players == null || players.Count == 0)
                return success;

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(LdrFileName, false,
                    Encoding.Default);

                foreach (Player pl in players)
                    writer.WriteLine(pl.GetDataString());// сохранить в файле

                writer.Close();
                success = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "Ошибка при сохранении файла");
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }


            return success;
        }
        public string GetDataString()
        {
            string format = "{0};{1}";
            return string.Format(format, nickname, time);
        }
    }
}
