using Nextech_Code_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nextech_Code_Challenge.Utils
{
    public class HNHelper
    {
        // Get the newest news.

        public static List<NewsHN> GetNews(int amount)
        {
            // Holds the news list
            List<NewsHN> newestStories = new List<NewsHN>();

            using (HttpClient client = new HttpClient())
            {
                // Get all newest news
                HttpResponseMessage response = client.GetAsync("https://hacker-news.firebaseio.com/v0/newstories.json").Result;
                response.EnsureSuccessStatusCode();

                int[] news = response.Content.ReadAsAsync<int[]>().Result;

                // Use amount given or less if the of amount news returned was a smaller number
                int newsAmmount = news.Length < amount ? news.Length : amount;
                for (int i = 0; i < newsAmmount; i++)
                {
                    // Get a news at a time
                    int newsId = news[i];
                    response = client.GetAsync($"https://hacker-news.firebaseio.com/v0/item/{newsId}.json").Result;

                    // If call was not a success, ignore it
                    if (!response.IsSuccessStatusCode)
                        continue;

                    NewsHN newsItem = response.Content.ReadAsAsync<NewsHN>().Result;

                    // Some news objects come as null
                    if (newsItem != null)
                        newestStories.Add(newsItem);
                }
            }

            return newestStories;
        }
    }
}