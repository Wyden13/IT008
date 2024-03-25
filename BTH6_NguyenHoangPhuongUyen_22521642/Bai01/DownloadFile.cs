using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class DownloadFile
    {
        public string Filepath { get; set; }
        public string Filename { get; set; }
        public double Filesize { get; set; }
        public string Status { get; set; }
        public long Percentage { get; set; }
        public DownloadFile(string filename, string filepath,double filesize)
        {
            Filename = filename;
            Filepath = filepath;
            Filesize = filesize;
            Status = "Downloading";
            Percentage = 0;
        }
    }
}
