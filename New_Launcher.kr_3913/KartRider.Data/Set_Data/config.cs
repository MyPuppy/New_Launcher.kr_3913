using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KartRider;

namespace Set_Data
{
    public static class config
    {
        public static byte PreventItem_Use = 0;

        public static void Load_PreventItem()
        {
            string Load_PreventItem = FileName.config_LoadFile + FileName.config_PreventItem + FileName.Extension;
            if (File.Exists(Load_PreventItem))
            {
                string textValue = System.IO.File.ReadAllText(Load_PreventItem);
                config.PreventItem_Use = byte.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_PreventItem, false))
                {
                    streamWriter.Write(config.PreventItem_Use);
                }
            }
            config.Check_PreventItem();
        }

        public static void Check_PreventItem()
        {
            if (config.PreventItem_Use == 0)
            {
                Program.PreventItem = false;
            }
            else
            {
                Program.PreventItem = true;
            }
        }

        public static void Load_ALL()
        {
            config.Load_PreventItem();
        }
    }
}