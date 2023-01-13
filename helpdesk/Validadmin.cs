using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Validadmin
    {
        public string us = "Ephy";
        public string ps = "Ephy123";
        public Boolean check(string a, string b) {
            if (us == a && ps == b)
            {
                return true;
            }
            else {
                return false;
            }
        
        }
    }
}
