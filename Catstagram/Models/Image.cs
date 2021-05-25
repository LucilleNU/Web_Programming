﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagram.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string FileName { get; set; }
        public int Index { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
