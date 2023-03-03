using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2_3.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}