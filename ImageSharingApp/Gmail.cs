using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSharingApp
{
    public class Gmail : IShare
    {
        public void Send()
        {
            Console.WriteLine("Gmail is sharing image");
        }
    }
}
