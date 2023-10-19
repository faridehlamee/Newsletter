using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsLetter6.Models
{
    public class NewsLetterTitle
        {
            [Key]
            public int TitleId { get; set; }
            public DateTime TitleDate { get; set; } 
            public bool IsActive { get; set; } 
            public ICollection<NewsletterArticle>? Articles { get; set; }

        }
}