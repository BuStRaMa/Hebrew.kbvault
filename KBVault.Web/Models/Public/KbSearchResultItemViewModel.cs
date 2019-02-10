using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KBVault.Dal;

namespace KBVault.Web.Models.Public
{
    public class KbSearchResultItemViewModel
    {
        public bool IsArticle { get; set; }
        public bool IsAttachment { get; set; }
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
    }
}