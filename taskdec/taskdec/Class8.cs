using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace taskdec
{
    class Getfilesfrom
    {
        public void GetFiles()
        {
            string[] filePaths = Directory.GetFiles(@"c:\MyDir\");
        }
    }
}
