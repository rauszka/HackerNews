# HackerNews

## Description
It is a web application, that uses ASP.NET Core MVC framework with controllers and views. 
The site is fetching data asynchronously from backend which is using HackerNews API.[Geometry].

## Tasks

## Main page

- Create a web application which renders news from the Hacker news site.
- The opening page of the website (/) can be accessed.
- There is a menu at the top of the page with the following elements.
- Hackson news: **Top news**, **Newest**, **Jobs**
- Clicking Hackson news redirects to the start page.
- Clicking top news refreshes the inner content of the page with the top news without reloading the page. See details below.
- Clicking jobs, refreshes the inner content of the page with the jobs without reloading the page. See details below.
- There is a footer with the name and email address of the developer.



## Top news

- Show top news from Hacker News site as cards next to each other.
- Data from the '/https://api.hnpwa.com/v0/news/1.json' external endpoint is displayed properly on your web page, including respective title, timeAgo, author, and url data fields. - If the page parameter is not set, the first thirty elements are received and returned (that is, the first page). - If the parameter is set, the respective page is received ('GET /api/top?page=5' returns news from the fifth page).
- This endpoint uses the data from Hacker News API (api.hnpwa.com), which is retrieved on the backend side. (See General requirements.)
- The opening page of the website (/) loads the first thirty top news articles from hacker news.
- The page has an HTML div element that contains the data in cards.
- Every card shows the following information on a news article.
- Title, which is also a link to the original article.
- Author, the uploader, if available.
- TimeAgo, which is the publication date.
- The webpage follows a generic MVC design.



## Newest news

- When I select Newest from the menu, the page content changes to newest news.
- Data from the '/api/newest' external endpoint is displayed properly on the webpage, including the respective "title", "timeAgo", "author" and "url" data fields. - If the page parameter is not defined, the first thirty elements are received and returned (that is, the first page). - If the parameter is set, the respective page is received ('GET /api/newest?page=5' returns news from fifth page).
- When clicking the Newest button in the menu, the page refreshes the content of the cards with the first thirty latest news articles.
- The page has an HTML div element that contains the data in cards.
- Every card shows the following information on a news article.
- Title, which is also a link to the original article.
- Author, the uploader, if available.
- TimeAgo, which is the publication date.



## Job news

- When I select Jobs from the menu the page content changes to job-related news.
- Data from the '/api/jobs' external endpoint is displayed properly on the webpage, including the respective "title", "timeAgo", and "url" data fields. - If the page parameter is not defined, the first thirty elements are received and returned (that is, the first page). - If the page parameter is set, the page is received ('GET /api/jobs?page=5' returns news from the fifth page).
- The page has an HTML div element that contains the data in cards.
- Every card shows the following information on a job news article.
- Title, which is also a link to the original article.
- TimeAgo, which is the publication date.
- There is a next button above the cards. Clicking this button displays the next thirty job news, if available.
- There is a previous button above the table. Clicking this button displays the previous thirty job news, if available.


## Requirements

- create a new **feature branch** and commit every change to your Github repo
- It’s even better if you make [atomic commits](https://en.wikipedia.org/wiki/Atomic_commit)


### Features
- Refresh your knowledge of asynchronously fetching data from backend.
- Serialize data to JSON.
- Call an API from the backend.
- Multi-server systems.


# Links
##### [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio)
##### [Retreive API data from Controller](https://stackoverflow.com/questions/29699884/calling-web-api-from-mvc-controller)
##### [Serializing and Deserializing JSON](https://www.newtonsoft.com/json/help/html/SerializingJSON.htm)
##### [Razor syntax](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1)
