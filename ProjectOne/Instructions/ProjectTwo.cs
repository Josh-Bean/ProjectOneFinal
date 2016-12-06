/*Joshua Bean, Section 2, Group 14, Last Modified: December 8th, 2016, Project 2, 
 
 * Using Project 1, you will need to enhance it by creating a Degree database.  Your site will display the information in the database, 
 * rather than hard coded information.  You will also learn about and begin using user authentication.

 * In this project you will:

 * Create a database that has the following tables:

 * Degrees - stores information about each degree (BSIS, MISM). The degree table includes the following attributes:
 * degree id
 * degree name
 * degree coordinator (BSIS – Dr. Albrecht, MISM – Dr. Bonnie Anderson)
 * coordinator title
 * coordinator office address
 * PhD Education
 * Masters Education
 * Bachelors Education
 * coordinator picture

 * Users - Table includes:
 * userID
 * userEmail
 * password
 * first name
 * last name

 * DegreeQuestions - Table includes:
 * degreequestionID
 * degreeID
 * userID
 * question
 * answer

2. Create a login page which allows a user to login with an email address and password. This view will also have a link that will allow them
 * to create a new account/user. Once that account is created they are automatically logged in. You will not have to worry about maintaining
 * the account once it is created. You will use a lookup(find) to the User table to authenticate the user.

3. Add authentication rules to implement the following logic: 

The user must be logged in to view the FAQ page.  If an authorized user tries to access the FAQ page redirect them to the Login page. 
 * Users that are not authenticated can still see the degrees view, they just can't get to the FAQ view to review questions and add questions

4. Once in the FAQ page, add functionality so the user can post a question or reply to a question.  These should be saved to the DegreeQuestions
 * table. Once the question is posted, the question cannot be deleted or edited. However, the answer can be changed over and over again (similar 
 * to a wiki) by any authorized user. You will store the latest answer inputted (there is only 1 answer per question). 
 */