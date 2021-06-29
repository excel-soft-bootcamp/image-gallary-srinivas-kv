using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSharingApp 
{
    public class WhatsApp : IShare
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp is sharing image");
        }
    }
}
