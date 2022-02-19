Instructions
Description
For this phase of the course project, you will be adding functionality to your web browser in addition to modifying some of the existing GUI elements.

In your custom browser tab control:
Add a StatusStrip control, and dock it to the bottom of your custom control. Your StatusStrip will contain the following:
Add a ProgressBar control that will display the loading progress each time you navigate to a page. (Hint: look into the WebBrowser control’s events and find what you can utilize from there)
A StatusLabel that will display the word “loading” while the page is loading, and the word “done” when the page has finished loading.
BONUS: add another StatusLabel control that will display the URL of any link you hover over in the WebBrowser control.
 

In your “History Manager Form” form:
Implement search functionality:
Add a “search term” TextBox control and a “Search” Button
When the user enters a phrase in the TextBox and clicks the Search Button, filter the list to show only the history items that contain the keyword(s) the user is searching for.
Implement delete functionality:
Add a “Delete” Button to your form.
When a user selects an item in the list, and clicks on the Delete Button, the item will be deleted from the database and the list will be refreshed.
Implement clear history functionality:
Add a “Clear History” Button to your form
When the user clicks on this button, the system will delete all history items from the database table and will refresh the list.
 

In your “Bookmark Manager Form” form:
Implement search functionality:
Add a “search term” TextBox control and a “Search” Button
When the user enters a phrase in the TextBox and clicks the Search Button, filter the list to show only the bookmark items that contain the keyword(s) the user is searching for.
Implement delete functionality:
Add a “Delete” Button to your form.
When a user selects an item in the list, and clicks on the Delete Button, the item will be deleted from the database and the list will be refreshed.
 

In your main form:
In your MenuStrip control, implement the following functionality for the following menu items:
Tools -> Clear History
When selected, the system will delete all history items from the database table.
BONUS: Implement “Add Tab” and “Close Tab” buttons. This feature exists in most modern web browsers, and allows a user to add a new tab by clicking on a [+] button at the end of the tab list, and to close the current tab by clicking on the [x] button on that tab.
 

Publish your application:
Publish your application using ClickOnce technology. Follow the steps demonstrated in the packaging and deployment video, and make sure that you include a link to your database in the project you publish.
After installing the published version of your application, it should be a working copy of your application, and support any database related operations.
Make sure all work is regularly committed in Git, preferably after each point of the assignment.

 

Requirements:
Submit a single zip file containing your solution folder using the following format: username_module6project.zip
Make sure your zip file contains the contents of the publish folder after publishing the final version of your application.
Make sure your zip file contains the entire Git repository.
Upload your zip file to Canvas and submit.
Print Ready PDF Version: cpsc2713-m6-project.pdf 
