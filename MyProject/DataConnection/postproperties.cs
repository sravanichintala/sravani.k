﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.DataConnection
{
    public class postproperties
    {
        int PostId{ get; set; }
        public   string Title { get; set; }
        public  string Subtitle { get; set; }
        public string Content { get; set; }
        public string PostStatus{ get; set; }
    }
}