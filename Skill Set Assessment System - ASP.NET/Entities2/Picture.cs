using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Picture
    {
        private string Picture_ID;
        private byte[] Image;

        public string picture_ID
        {
            get
            {
                return Picture_ID;
            }
            set
            {
                Picture_ID = value;
            }
        }

        public byte [] image
        {
            get
            {
                return Image;
            }
            set
            {
                Image = value;
            }
        }
    }
}
