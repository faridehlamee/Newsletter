using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLetter6.Models;

namespace NewsLetter6.ViewModels
{
    public class TitleArticleVM
    {
        public int TitleId { get; set; }
        public DateTime TitleDate { get; set; } 
        public bool IsActive { get; set; } 
        public ICollection<NewsletterArticle>? Articles { get; set; }

        public string FormattedTitleDate
        {
            get
            {
                return TitleDate.ToString("MMMM dd, yyyy");
            }
        }
    }
}