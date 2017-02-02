using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace showerthoughts.Models
{
    public class thought
    {
        public int id { get; set; }
        public string title { get; set; }   
 
        [AllowHtml]
        public string bdText { get; set; }

        public DateTime date { get; set; }
        public int rate { get; set; }
        
        //autor

        public string authorId { get; set; } 

        //subthought
    }
}