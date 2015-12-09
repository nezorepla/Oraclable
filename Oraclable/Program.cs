using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;
using Oraclable.MyProg;

namespace Oraclable
{
       class Program
    {
        static void Main(string[] args)
        {

            // Creates or loads an INI file in the same directory as your executable
            // named EXE.ini (where EXE is the name of your executable)
           // var MyIni = new IniFile();

            // Or specify a specific name in the current dir
            //var MyIni = new IniFile("Settings.ini");

            // Or specify a specific name in a specific dir
            var MyIni = new IniFile(@"C:\Users\Alper\Documents\GitHub\Oraclable\Settings.ini");

            MyIni.Write("DefaultVolume", "100");
            MyIni.Write("HomePage", "http://www.google.com");
        }
    
    

    }
}
