using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prasitestavimui.Generators
{
    internal class StringGenerator
    {
        public static string getEmail() {
            DateTime tim = DateTime.Now;
            string email_Password = "test_" + tim.ToString("yyyy_MM_dd_HH_mm_ss") + "@gmail.com";
            return email_Password;
        }


    }
}
