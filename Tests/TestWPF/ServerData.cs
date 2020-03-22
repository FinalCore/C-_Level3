using System;
using System.Collections.Generic;
using System.Text;

namespace TestWPF
{
    static class ServerData
    {
        // c сервера mail почта почему-то не отправляется
        //internal static string serverAddress = "smtp.mail.ru";
        //internal static int serverPort = 465;

        // С яндекса отправляется, но только на яндекс
        internal static string serverAddress = "smtp.yandex.ru";
        internal static int serverPort = 25;
    }
}
