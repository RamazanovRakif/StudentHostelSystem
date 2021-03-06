﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class News
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Context { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }
    }
}
