/* Joshua Bean, Section 2, Group 14, October 31, 2016, Project One
 * IDEA 2 – Student FAQ for BYUIS Site

Create an MVC website that will allow perspective Students to ask questions of current/past students of Brigham Young University Information
 * Systems programs.
 * On the landing page I want you to implement a bootstrap jumbotron class to create a “call to action” (If you don’t know what a call to action is,
 * google it!). The landing page (home page), should also display any content that is conducive to providing information about BYU, Information 
 * Systems, different knowledge areas (software development, project management, data analysis, security, database, etc.). The content can
 * include text, links quotes, videos, etc. – be creative.

 * Your website should be harmonious with the environment at BYU so you can be creative (look at other BYU sites to get a feel for the themes)
 * On the landing page there will be three main links:
 * Degrees – should take you to the degrees view
 * The degrees view will have a dropdown that will consist of (for now) two degrees (you will choose any 2 degrees BSIS or MISM which have been 
 * hardcoded into the dropdown).
 * As the user clicks on an entry in the degree list, take them to another view (_____ degree FAQ’s) which is dynamically loaded using source
 * code. For now, the questions and answers on the view for each degree will all be the same (HARD CODED - You will create the question and
 * answer), regardless of which degree is chosen. You must however pass the following unique information for each degree in the viewbag:
 

* degree name
* degree coordinator (BSIS – Dr. Albrecht, MISM – Dr. Bonnie Anderson)
* Title
* their office address
* PhD Education
* Masters Education
* Bachelors Education
* Their picture
 

*You will need to display all of this information in a section above the FAQ’s on the dynamically loaded view. Please make it look professional.
*Talk with classmates and talk about the most effective ways to display this information.
*At the top of the each dynamically created view, you will display a bootstrap breadcrumb (Google it!) that will help the user better 
*navigate your site. Using this breadcrumb menu, the user should be able to go back to the degrees page to select a different degree.
*At the very bottom of each degree’s FAQ’s will be a question form. The user will be able to fill out this form to post a new question, 
*just like you would post a comment on Facebook. ** For project 1 we will not be posting the questions or saving them in the database,
*we just want the form to be there and available.
*Under each FAQ question, there will also need to be a way for a current/past student to answer that specific question, so you will need 
*to add a reply button in order to have a response form dynamically created when a student wants to answer another student’s question. 
*You do not need to save the replies for this project.
 

*About us- should take you to the about view
*The About view should display “made up” information about the department that wants to help future students get questions about their degrees
 * answered by those that have received that degree. Think about what you could say that might truly describe why a student would want to do this
 

*Contact – should take you to the contact view
*The contact view will have basic department information, such as phone number and email. The view will also have a contact form that will
 *have fields for the user’s name, email, subject (choose from a list), and message body.
*There will need to be a submit button at the bottom of the contact form. This button however, won’t do anything with the data yet. 
 *For now it will just clear the text in the form.
 * 
 */