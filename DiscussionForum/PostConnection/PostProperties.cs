using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.PostConnection
{
    public class PostProperties
    {
       public int Post_Id { set; get; }
        public string Post_Title { set; get; }
        public string Post_Subtitle { set; get; }
        public string Post_Content { set; get; }
        public string Post_status { get; set; }
    }

}