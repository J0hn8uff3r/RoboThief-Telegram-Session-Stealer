using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboThiefClient
{
    public static class TelegramBot
    {
        public static String BotToken;
        public static String id;

        public static void SetValues()
        {
	    // Put your Bot token received from BotFather...
            BotToken = "";
	    
	    // Put your Userid here
            id = "";
        }
    }
}
