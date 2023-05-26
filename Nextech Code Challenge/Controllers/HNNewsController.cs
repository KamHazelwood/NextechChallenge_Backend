using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Nextech_Code_Challenge.Models;
using Nextech_Code_Challenge.Utils;


namespace Nextech_Code_Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HackersNewsController : ControllerBase
    {
        /// Get newest 20 news
        // GET: api/news - return newest news stories
        [HttpGet, EnableCors, ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client)]
        public IActionResult Get()
        {
            List<NewsHN> newestStories = new List<NewsHN>();
            // create try catch if request was bad.
            try
            {
                newestStories = HNHelper.GetNews(20);
            }
            catch (Exception e)
            {
                return BadRequest("Unable to process request.");
            }
       
            return Ok(newestStories);
        }

       
        // Search news based on 'title' of news.
        // return news article based on name inputted by user
        [HttpGet("[action]"), EnableCors]
        public IActionResult SearchNews(string searchTerm)
        {
            List<NewsHN> newestStories = new List<NewsHN>();
      
            try
            {
                // If no search term was provided, return default amount of news
                if (String.IsNullOrWhiteSpace(searchTerm)) 
                {
                    newestStories = HNHelper.GetNews(20);
                    return Ok(newestStories);
                }

                // top 40 news 
                newestStories = HNHelper.GetNews(40);

                return Ok(newestStories.Where(x => x.title.Contains(searchTerm, StringComparison.CurrentCultureIgnoreCase)));
            }
            // create catch block if request was bad
            catch (Exception e)
            {
                return BadRequest("Unable to process request.");
            }
        }
    }
}
