using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAnki.Models
{
    public class Entry
    {
        public int id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public Entry()
        {

        }

    }
}
