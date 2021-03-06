﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSelenium
{
    /// <summary>
    /// This class is only used when it's called from command prompt or run directly.
    /// It will not be used when the exe is loaded as a plugin.
    /// </summary>
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            //[LSelenium.sChrome.SpeakTranslation("en","es","what time is it?")];
            //[LSelenium.sChrome.GetTranslation("en","es","what time is it?","Get")]
            Console.Title = "LINKS - Selenium";

            var parsedArgs = args
                .Select(s => s.Split(new[] { '=' }))
                .ToDictionary(s => s[0], s => s[1]);

            if (args.Length == 3)
            {
                sChrome.SpeakTranslation(parsedArgs["From"], parsedArgs["To"], parsedArgs["Phrase"]);
                sChrome.Close();
            }
            else if (args.Length == 4)
            {
                sChrome.GetTranslation(parsedArgs["From"], parsedArgs["To"], parsedArgs["Phrase"], parsedArgs["GetSet"]);
                sChrome.Close();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid syntax.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Usage: LSelenium \"{LanguageFrom}\" \"{LanguageTo}\" \"PhraseToTranslate\"");
                Console.WriteLine("Sample: LSelenium \"en\" \"es\" \"What time is it?\"");
                Console.WriteLine("Description: Translates specified phrase from {LanguageFrom} to {LanguageTo} and speaks.");
                Console.WriteLine();
                Console.WriteLine("Usage: LSelenium \"{LanguageFrom}\" \"{LanguageTo}\" \"PhraseToTranslate\" \"SetOrGet\"");
                Console.WriteLine("Sample: LSelenium \"en\" \"es\" \"What time is it?\" \"Set\"");
                Console.WriteLine("Description: Sets cliboard with translated text. \r\n  Using Get as last parameter returns the translation in console.");
            }
        }
    }    
}
