﻿namespace HackerNewsClient.Models
{
    public class NewsModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string TimeAgo { get; set; }
        public string Url { get; set; }
        public int Page { get; set; }

        public NewsModel(int page, string title, string author, string timeAgo, string url)
        {
            Title = title;
            Author = author;
            TimeAgo = timeAgo;
            Url = url;
            Page = page;

        }
    }
}
