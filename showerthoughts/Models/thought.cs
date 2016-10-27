using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace showerthoughts.Models
{
    public class thought
    {
        public int id { get; set; }
        public string title { get; set; }      
        public string bdText { get; set; }
        public DateTime date { get; set; }
        public int rate { get; set; }
        
        //autor
        //subthought
    }
}