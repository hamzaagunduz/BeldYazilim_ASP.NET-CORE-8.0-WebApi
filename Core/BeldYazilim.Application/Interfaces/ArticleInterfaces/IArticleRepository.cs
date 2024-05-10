﻿using BeldYazilim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Interfaces.ArticleInterfaces
{
    public interface IArticleRepository
    {
        public List<Article> GetAllArticlesWithAuthors();
        public List<Article> GetAllArticlesWithAuthorsAndCategory();
        public Article GetArticleWithAuthorsById(int articleId);
        public List<Article> GetTopRatedArticles(int count);
        public List<Article> GetLatestArticles(int count);
        public List<Article> GetLastFiveArticlesByCategory(int categoryId);
        public List<Article> GetRandomArticles(int count);
        public List<Article> GetArticlesByCategoryPaged(int categoryId, int pageNumber, int pageSize);


	}
}
