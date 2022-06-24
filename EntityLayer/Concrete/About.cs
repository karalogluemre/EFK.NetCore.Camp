﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string AboutDetail1 { get; set; }
        public string AboutDetail2 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
