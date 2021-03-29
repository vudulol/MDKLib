using System;
using System.IO;
using Lab.core;

namespace Spesivcev
{
    class MyLog : LogAbstract, LogInterface
    {
        private static MyLog Instance;
        public MyLog() { }
        public static MyLog GetInstance()
        {
            if (Instance == null)
            {
                Instance = new MyLog();
            }
            return Instance;
        }
            public static void Log(string result) {
            GetInstance()._log(result);
            }
        public override void _log(string str)
        {
            GetInstance().log.Add(str);
        }
        public static void Write()
        {
                GetInstance()._write();
        }
        public override void _write()
        {
            foreach (string x in log)
            {
                Console.WriteLine(x);
            }
            DateTime date = DateTime.Now;
            string file = $"./Log/{date.ToString("dd.M.yyyy_hh.mm.ss.fff")}.log";
            DirectoryInfo dirInfo = new DirectoryInfo($"./Log/");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream fstream = new FileStream(file, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(String.Join("\n", log));
                fstream.Write(array, 0, array.Length);
            }
        }

    }
}
