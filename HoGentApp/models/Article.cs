﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoGentApp.models
{
    class Article
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ArticleTarget> Targets { get; set; }
    }
}
