using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NCMRViewer
{
   public static class Comm
    {
        public static string ConnString = new StreamReader(@"paths\connectionString.txt").ReadLine();
        public static string ImgPath = @"Images\";


        public static string CurrentImage = "";
    }
}
