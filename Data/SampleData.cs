using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLetter6.Models;

namespace NewsLetter6.Data
{
    public class SampleData
    {
        public static List<NewsLetterTitle> GetArticles()
        {
            List<NewsLetterTitle> articles = new List<NewsLetterTitle>() {
                new NewsLetterTitle() {
                    TitleId = 1,
                    TitleDate=DateTime.Now.AddDays(1),
                    IsActive=true
                },
                new NewsLetterTitle() {
                    TitleId = 2,
                    TitleDate=DateTime.Now.AddDays(2),
                    IsActive=true
                },
                new NewsLetterTitle() {
                    TitleId = 3,
                    TitleDate=DateTime.Now.AddDays(3),
                    IsActive=true
                },
            };

            return articles;
        }

        public static List<NewsletterArticle> GetArticleDetails()
        {
            List<NewsletterArticle> articleDetails = new List<NewsletterArticle>() {
                new NewsletterArticle() {
                    ArticleId = 1,
                    ArticleIdInTheTitle = 1,
                    Name="Foldable solar panel",
                    Description = "Although compact solar panels have been around for a while, the new foldable variety offers more convenience and flexibility. You can market foldable solar panels to various audiences, from the digital nomad hoping to get some work done on the beach to the backpacker heading into the wilderness. And consider selling them as part of a kit that includes cables, batteries, and converters—users will need these to store electricity for later use.",
                    Picture = "/img/image1.jpg",
                    TitleId = 1
                },
                new NewsletterArticle() {
                    ArticleId = 2,
                    ArticleIdInTheTitle = 2,
                    Name="Reusable straws",
                    Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                    Picture = "/img/image2.jpg",
                    TitleId = 1
                },
                new NewsletterArticle() {
                    ArticleId = 3,
                    ArticleIdInTheTitle = 1,
                    Name="Reusable straws",
                    Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                    Picture = "/img/image2.jpg",
                    TitleId = 2
                },
                new NewsletterArticle() {
                    ArticleId = 4,
                    ArticleIdInTheTitle = 2,
                    Name="Reusable straws",
                    Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                    Picture = "/img/image2.jpg",
                    TitleId = 2
                },
                new NewsletterArticle() {
                    ArticleId = 5,
                    ArticleIdInTheTitle = 3,
                    Name="Reusable straws",
                    Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                    Picture = "/img/image2.jpg",
                    TitleId = 2
                },
                new NewsletterArticle() {
                    ArticleId = 6,
                    ArticleIdInTheTitle = 1,
                    Name="Reusable straws",
                    Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                    Picture = "/img/image2.jpg",
                    TitleId = 3
                },
                new NewsletterArticle() {
                    ArticleId = 7,
                    ArticleIdInTheTitle = 2,
                    Name="Reusable straws",
                    Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                    Picture = "/img/image2.jpg",
                    TitleId = 3
                },
                new NewsletterArticle() {
                    ArticleId = 8,
                    ArticleIdInTheTitle = 3,
                    Name="Reusable straws",
                    Description = "Reusable straws are the sustainable choice for eco-conscious consumers. These durable alternatives to single-use plastic straws help reduce plastic pollution, protect marine life, and minimize our carbon footprint. With options like stainless steel, glass, bamboo, and silicone, reusable straws offer a stylish and eco-friendly way to sip your favorite beverages while making a positive impact on our planet. Embrace the trend, ditch disposables, and sip sustainably with reusable straws today!",
                    Picture = "/img/image1.jpg",
                    TitleId = 3
                },
            };

            return articleDetails;
        }        

    }
}