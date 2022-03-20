using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    public class Slova
    {
        public string Text { get; set; }
        public string Jmenovka { get; set; }
        public Slova(
            string text)
        {
            this.Text = text;
            this.Jmenovka = text;
        }
    }
}