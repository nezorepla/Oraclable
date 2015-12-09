﻿ 
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
namespace Oraclable
{
   

// Change this to match your program's normal namespace
namespace MyProg
{
    class IniFile   // revision 10
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath )
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section )
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }
        public void Write(string Key, string Value)
        {
            WritePrivateProfileString(null ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section )
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section )
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section )
        {
            return Read(Key, Section).Length > 0;
        }

        //internal void Write(string p, string p_2)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
}
