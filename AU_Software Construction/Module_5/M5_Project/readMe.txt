Instructions
Description
For this phase of the course project, you will be adding functionality to your web browser in addition to modifying some of the existing GUI elements.

 

Inside your WebBrowser.Data project:
Add a new database and add the following tables:
History (columns: Id, URL, Title, Date)
Bookmarks (columns: Id, URL, Title)
Use what you learned in this module to add a new dataset and table adapter for each table

Inside your WebBrowser.Logic project: 
Add a HistoryItem class with the following properties:
URL (string) 
Title (string) 
Date (DateTime) 
Add a BookmarkItem class with the following properties: 
URL (string) 
Title (string) 
Add a History Manager class, with static methods that can add a history item to the database and get all history items from the database
Add a Bookmark Manager class, with static methods that can add a bookmark item to the database and get all bookmark items from the database


Inside your WebBrowser.UI Project:
Add a new ‘History Manager Form’ form
Add a ListBox control in the designer for this form
Implement the on load event handler for this form and use the History Manager class to get all history items and display them in the ListBox using the following format: [date] Title (URL)
Add a new ‘Bookmark Manager Form’ form
Add a ListBox control in the designer for this form
Implement the on load event handler for this form and use the Bookmark Manager class to get all bookmark items and display them in the ListBox using the following format: Title (URL)
 

In the code for your main form:
Implement functionality for: 
A Bookmark button: when clicked, the URL and Title of the current page will be added to the Bookmark table in the database if it does not already exist (use the Bookmark Manager to add the new bookmark to the database)
When you navigate to any URL from any tab, after it finishes loading, add the URL, Title, and date and time of navigation to the History table in the database (use the History Manager to add the new history item to the database)
In your MenuStrip control, implement the following functionality for the following menu items:
Tools -> Manage History
When clicked create a new instance of the “History Manager Form” form and call ShowDialog()
Tools -> Manage Bookmarks
When clicked create a new instance of the “Bookmark Manager Form” form and call ShowDialog()
 

Make sure all work is regularly committed in Git, preferably after each point of the assignment.

 

Requirements:
Submit a single zip file containing your solution folder using the following format: username_module5project.zip
Make sure your zip file contains the entire Git repository.
Upload your zip file to Canvas and submit.
Print Ready PDF Version: cpsc2713-m5-project.pdf 
