using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewsLetter6.Models
{
    public class NewsletterArticle
    {
        [Key]
        public int ArticleId { get; set; }
        public int ArticleIdInTheTitle { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }            

        [ForeignKey("TitleId")]
        public NewsLetterTitle? NewsletterTitle { get; set; }
        public int TitleId { get; set; }
    }
}