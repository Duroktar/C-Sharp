﻿using System;

namespace LHue
{
    /// <summary>
    /// Used when project is set as WindowsApplication.
    /// If we change the project type to a library this class will not be initialized.
    /// Note: WindowsApplication will react same as dll when it's called from LINKS using Functions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            // Loads the window just as if it was called from LINKS.
            // Running in WindowsApplication mode will not allow usage of UI templates.
            LHue.MyCustomClass.Test_InitWPFWindow();
            
        }

        private static async void Test()
        {
            LREST lRest = new LREST();
            //await lRest.Get("http://73.251.151.39/api/lz3nFIcGOelQlsxsDJYqrXGuxivjFmWswZ9fIGcw/lights");
            //await lRest.Delete("http://73.251.151.39/api/lz3nFIcGOelQlsxsDJYqrXGuxivjFmWswZ9fIGcw/lights");
            Console.WriteLine("Get Request Completed.");
            
        }
    }
}