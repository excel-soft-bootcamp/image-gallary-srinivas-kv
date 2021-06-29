using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSharingApp 
{
    public class Bluetooth : IShare
    {
        public void Send()
        {
            Console.WriteLine("Bluetooth is sharing image");
        }
    }
}
