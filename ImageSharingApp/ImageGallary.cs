using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSharingApp
{
    class ImageGallary
    {
        IShare _share;
        public ImageGallary(IShare file)
        {
            this._share = file;
        }
        public void FileShare()
        {
            _share.Send();
        }

    }
}
