# NextechCodeChallenge backend

This project uses ASP.NET Core 2.1.

Tests are located in the UnitTest HackerNews folder. 
 - Creating the unit test in C# had some challenging moments. This was my first time creating unit tests in C#. They do appear to be working properly and meeting the requirements. If there are issues I would like to schedule a coding review to discuss them. 

## API Endpoints backend

Creating and understanding the HackerNewsServices.cs page was easier than I had originally planned. I did look through documentation on various C# pages do understand the syntax that was needed as well as any dependencies that I should import as well. 
  - I created numerous comments to understand my logic pattern for the http endpoints for understanding. If this isn't how this should have been setup I would like to talk about this during a coding review. 

Setup GET api to retrieve top 20 stories during start up
Setup GET api to search for stories whose title matches the search term. 
  - I kept trying to set this part up in the front end but realized that I need to setup the API using GET to retrieve the search term. I definitely spent more time than I had thought before realizing where this part needed to be setup. 

  ## NextechCodeChallenge frontend 

  The front end is a simple design. It allows an end user to see the top 20 stories on one page. 

  The front end also has the search box that allows the user to search for any article name and will display that name. 
  Within the app.component.html file has the materal design files through angular. This type of angular design allows an end user to see a grid of all the stories and looks simple. 

  The front end also has unit tests that can be ran. 
  All instructions are on the front end ReadME doc
