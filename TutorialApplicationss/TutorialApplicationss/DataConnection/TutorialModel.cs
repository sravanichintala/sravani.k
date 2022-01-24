using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialApplicationss.DataConnection
{
    public class TutorialModel
    {
        public int TutorialId { get; set; }
        public string TutorialName { get; set; }
        public string TutorialDesc { get; set; }
        public int Published { get; set; }
    }
}