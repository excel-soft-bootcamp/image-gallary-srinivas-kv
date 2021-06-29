using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSharingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Gmail gmail = new Gmail();
            ImageGallary gmailgallary = new ImageGallary(gmail);
            gmailgallary.FileShare();
            WhatsApp whatsApp = new WhatsApp();
            ImageGallary whatsAppgallary = new ImageGallary(whatsApp);
            whatsAppgallary.FileShare();*/
            Bluetooth bluetooth = new Bluetooth();
            ImageGallary bluetoothgallary = new ImageGallary(bluetooth);
            bluetoothgallary.FileShare();
            Console.ReadLine();
        }
    }
}
