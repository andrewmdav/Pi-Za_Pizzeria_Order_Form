# Pi-Za_Pizzeria_Order_Form

General Description:<br>
Windows form example that retrieves/records customer order and contact information from a database, calculates pricing, 
and verifies credit card information.

File Arrangement:<br>
All project files were included in the latest commit to assist with downloading and running a copy of the project.  Note 
that the database, multimedia, and read in/write out text files are located in ~\Pi-Za Pizzeria Order Form\bin\Debug.  
Listed below are the primary files to focus on for running the project and code review:
	
	-Solution File: 		Phase 4 Pizza Project.sln
	-Order Form Code:		OrderForm.cs
	-Credit Card Form Code:		CreditCardForm.cs
	-Customer Class Code:		CustomerClass.cs

Detailed Description:<br>
Form intakes a customer's contact and order information.  It utilizes the Customer class for contact data organization
and calls the frmCreditCard form to collect payment information.  A returning customer's contact information is proactively   
retrieved from a database after successfull phone number input validation.  The form writes customer/order information to 
a database after completion of contact and credit card information.  FileStreams are used to read in the state
abbreviations (StateAbbrev.txt) for the combo box and write out certain order information to a text file (Customer Data File.txt).  
Other features include background music, with the option to mute, order number and date displays, and a reset option.
