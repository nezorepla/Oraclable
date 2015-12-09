using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;
 
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
 
            if (!MyIni.KeyExists("PASSWORD"))
            {
                MyIni.Write("PASSWORD", "******");
            }

            var PASS = MyIni.Read("PASSWORD");

            Console.WriteLine(PASS);

            Console.ReadKey();
//To read the values out of the INI file:

//var DefaultVolume = IniFile.Read("DefaultVolume");
//var HomePage = IniFile.Read("HomePage");
//Optionally, you can set [Section]'s:

//MyIni.Write("DefaultVolume", "100", "Audio");
//MyIni.Write("HomePage", "http://www.google.com", "Web");
//To create a file like this:

//[Audio]
//DefaultVolume=100

//[Web]
//HomePage=http://www.google.com
//You can also check for the existence of a key like so:

//if(!MyIni.KeyExists("DefaultVolume", "Audio"))
//{
//    MyIni.Write("DefaultVolume", "100", "Audio");
//}
//You can delete a key like so:

//MyIni.DeleteKey("DefaultVolume", "Audio");
//You can also delete a whole section (including all keys) like so:

//MyIni.DeleteSection("Web");
//Please feel free to comment with any improvements!
        }
    
    

    }
}
