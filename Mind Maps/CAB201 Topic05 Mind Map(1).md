- Topic05 -- File I/O; Method consolidation

	- Reference

		- Farrell, Chapter 14
		- Microsoft C# documentation: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/
		- Microsoft API documentation: https://docs.microsoft.com/en-us/dotnet/api/system.io?view=net-5.0

	- General problem: how to get data into and out of our programs
	- Command line arguments

		- Problem addressed; transmit data into program from command line
		- Language and type support

			- Main(string []args)
			- The args array contains the text entered on the command line when program is run
			- Arguments are usually split into fields, separated by spaces
			- Surround an argument with double quotes to include space

		- Example

			- EchoArgs

				- Uses a for loop to iterate over the args array, displaying each value
				- Implement...

		- Setting command line args

			- In Visual Studio, use the Project Properties -> Debug form
			- Like this...
			- In command prompt, just type them on the command line
			- Like this...

	- Working with the file system

		- Directory I/O

			- Problem addressed: manage a collection of documents in the file system
			- Language and type system support

				- Directory type

					- Collection of static methods which can be used to interact with the file system, creating and reading directory information

				- DirectoryInfo type

					- Used to convey information about a single directory

				- FileInfo type

					- Gets information about a single file, including size, full name, and attributes

				- Environment.CurrentDirectory

					- Gets the name of present working directory

			- Examples

				- ListFiles

					- Lists file information about all files and directories in the current working directory
					- First, displays the name of the working directory
					- Gets a DirectoryInfo object with information about the current directory
					- Using that, we get a list of FileInfo objects (about the files), and DirectoryInfo objects (about the directories)
					- For-each loops are used to display both these lists separately
					- Implement...

		- File I/O

			- Problem addressed: making data persistent between runs of a program
			- Language and type support

				- File type

					- Static methods for interacting with files
					- File.Exists -- ask if a file exists
					- File.ReadAllText -- reads all text from a file, returning a string
					- File.WriteAllText -- writes a string to a file, replacing any existing content
					- File.Copy, File.Create, File.Delete, File.Move, and plenty more...

				- StreamReader type

					- Methods to read text from a file, similar to using Console.Read and ReadLine

				- StreamWriter type

					- Methods to write text to a file, similar to using Console.Write and Console.WriteLine

				- using keyword

					- Guarantees that files will be closed properly when accessed via StreamReader or StreamWriter.

			- Examples

				- EchoLines

					- Get name of text document from user
					- Check to see if file exists
					- If it exists:

						- Use a StreamReader in a loop to read and display contents of file, line by line

					- Otherwise:

						- Display a message to the effect that the file does not exist

					- Implement...

				- SortLines

					- Get the name of text document from user
					- Check to see if file exists
					- If it exists:

						- Use a StreamReader in a loop to read the contents of the file line by line; store the contents in a list of string
						- Sort the list
						- Write the contents of the sorted list to another file

					- Otherwise

						- Display a message to the effect that the file does not exist

					- Implement...

	- LemonadeStand Case Study

		- LemonadeStand V2

			- Still processes new sales for a single date
			- User specifies the date
			- Sales records are stored in a CSV formatted text document
			- Extend the report generator to allow user to query all sales, sales for a single day, or sales within a range of dates

		- Proceed in an incremental manner, as far as possible testing each new item of functionality as it is implemented
		- Before embarking on other changes, add new constant values in Main to represent the extended menu choices

			- Implement...

		- User will supply sales date and name of CSV document as command line arguments

			- ProcessArgs Method

				- Parameters

					- args -- array of string containing command line arguments
					- date -- out parameter which refers to a DateTime value where we store the date

						- DateTime is a useful data type in the C# standard library

					- fileName -- out parameter which refers to a string where we store the file name

				- Returns

					- Boolean indicating success (true), or failure (false)

				- Algorithm

					- Initialise date and fileName with default values
					- If number of arguments is less than 2, display an error message and return false
					- Try to convert args[0] to a DateTime value
					- If date is not valid, display error message and return false
					- Test for existence of file with name given by args[1]
					- If not found, display an error message and return false
					- Copy args[1] to fileName and returns true

				- Test plan

					- Insufficient arguments -- expect error message, return false
					- Invalid date -- expect error message, return false
					- Valid date
					- Non-existent file -- expect error message, return false
					- Valid file -- expect return true

				- Implement...

		- Program will parse existing data into parallel lists from CSV formatted text document

			- ReadSales Method

				- Parameters

					- fileName -- name of data file
					- salesDates -- A list containing the date of each sales record
					- salesRec -- the sales records corresponding to the dates (a parallel list); each element of this list is an int array

				- Returns

					- No explicit return value, but the salesDates and salesRec lists are populated as side effects

				- Algorithm

					- Records are parsed one line at a time from file
					- Each record is separated into fields using comma delimiter
					- First field is converted to a date and added to salesDates
					- Remaining fields are converted to int and stored in an int array, and this array is added to the salesRec list
					- NB: No attempt is made to detect and recover from data conversion errors in this method

						- In real life, we would definitely do so
						- You will learn techniques for that in later topics
						- For the moment, we are better off letting the program crash early rather than risk corrupting the input file later when the program exits.

				- Test plan

					- Empty input file -- expect empty lists returned
					- Valid date
					- Valid product counts -- expect record to be added

				- Implement...

		- After sales data is loaded, we get a reference to the sales counters for the specified date

			- GetSalesRecord Method

				- Parameters

					- date -- the date to be processed
					- salesDates -- A list containing the date of each sales record
					- salesRec -- the sales records corresponding to the dates (a parallel list); each element of this list is an int array

				- Returns

					- An int array which contains the sales record for the stipulated date
					- As a side effect, if the date was not found in salesDates, both salesDates and salesRec will be modified to include sales for the new date

				- Algorithm

					- If date is found in salesDate:

						- The corresponding element of salesRec is returned so new sales data can be added to the record

					- Otherwise

						- A new sales record is created
						- The sales date is inserted into the salesDates list so that the list is always kept in ascending order
						- The newly created sales record is inserted into the salesRec list at the corresponding location so that the two lists are always correctly aligned

				- Test plan

					- Empty list -- expect date and new sales record to be inserted at start
					- Date less than all items in list -- expect date and new sales record to be inserted at start
					- Date greater than all items in list -- expect date and new sales record to be inserted at end
					- Date between existing dates -- expect date and new sales record to be inserted before all items with greater date
					- Date exists -- test start middle and end, expect list sizes to remain unchanged, and existing sales record to be returned

				- Implement...

		- Before the program finishes, we must save the file

			- SaveSales method

				- Parameters

					- fileName -- a string containing the name of a file that will be overwritten with sales data
					- salesDates -- a list of sales dates
					- salesRec -- a list containing sales records corresponding to each date

				- Algorithm

					- A StreamWriter is used to emit sales data to the file
					- Nested loops are used to traverse the list of sales dates, and the respective sales counters for each date
					- For each i:

						- salesDate[i] is written to the file (without moving to a new line)
						- Each value in salesRec[i] is written, with commas inserted to separate values
						- After all sales figures are written, WriteLine is used to terminate the line in a portable manner

				- Implement...

		- Run method is modified to accommodate salesDates and salesRec

			- Parameters added

				- salesDates -- the list of sales dates (required for report generation)
				- salesRec -- the list of sales records corresponding to the sales dates

			- Algorithm

				- Algorithm is essentially unchanged, but the new parameters must be passed to Process

			- Implement...

		- Menu functionality is unchanged, as it is data driven
		- We introduce two helper methods to help take care of new reporting requirements: GetDate, and GetSalesBetween
		- GetDate

			- Prompts user for a date
			- Parameters

				- label -- a descriptive string which is included as part of the prompt

			- Returns

				- A DateTime entered by the user

			- Algorithm

				- Use a suitable loop to perform the following until a valid date is obtained

					- Prompt the user to enter a date
					- Read a line of text from standard input
					- Attempt to convert the text to a DateTime value

				- Return the resulting value

			- Implement, and use the Immediate Window to test interactively...

		- GetSalesBetween

			- Searches the salesDates and salesRec lists to get all sales between a designated start and end date
			- Parameters

				- startDate -- the beginning of the interval
				- endDate -- the end of the interval
				- salesDates -- a list of dates for which sales records are available
				- salesRec -- a list of sales records corresponding to the sales dates
				- datesBetween -- a list which will be populated with the dates that fall between the start and end dates
				- salesBetween -- a list which will be populated with the sales records corresponding to the entries in datesBetween

			- Algorithm

				- A counter-controlled loop is used to iterate over salesDates
				- If salesDates[i] falls between start and end dates:

					- salesDates[i] is added to datesBetween
					- salesRec[i] is added to salesBetween

			- Test plan

				- Sales lists empty -- expect empty lists
				- Date range which is not present in salesDates -- expect empty lists
				- Date range which includes all dates -- expect lists to contain all dates and sales records
				- Date range with multiple records in salesDates -- expect to see dates and sales records for those dates date

			- Implement, using the Immediate Window to test interactively...

		- Report

			- Parameters removed

				- sales

					- Daily sales figures no longer relevant

			- Parameters added

				- title -- custom report title to suit new reporting requirements
				- salesDates -- list of dates for which sales data is available (required for reporting)
				- salesRec -- list of int arrays containing daily sales data (required for reporting)
				- startDate -- beginning of requested range
				- endDate -- end of requested range

			- Algorithm changes

				- Where previously data for a single date was tabulated, we now loop over a range of days
				- To simplify process, a helper method (GetSalesBetween) is created
				- If no sales are found in specified interval, a suitable message is displayed
				- Otherwise, for each date, the date and all sales are tabulated.

			- Test plan

				- Sales lists empty -- expect "not found" message
				- List all dates -- expect to see report for all dates in list
				- Specific date not in list -- expect "not found" message
				- Specific date in list -- expect to see records for that date
				- Date range with no records in list -- expect "not found" message
				- Date range with multiple records in list -- expect to see records for that range

			- Implement, and either test in Immediate Window, or go on to Process...

		- Process method extended

			- Parameters added

				- salesDates -- list of dates for which sales data is available (required for reporting)
				- salesRec -- list of int arrays containing daily sales data (required for reporting)

			- Algorithm changes

				- Modified reporting requirements incorporated into switch statement
				- If "all sales" report requested:

					- Calls Report with DateTime.MinValue as start date, and DateTime.MaxValue as end date

				- If "single day" report requested:

					- Calls (a new helper method called) GetDate to get the date of interest
					- Calls Report with that date as both start and end date

				- If "date range" is requested:

					- Calls GetDate to get the start date
					- Calls GetDate again to get the end date
					- Calls Report, with the respective start and end dates

			- Implement...

	- Summary

		- This case study illustrates aspects of the software development process...
		- Top-down design, where we think as much as possible in the language of the problem we're solving
		- Incremental implementation, tackling a succession of small tasks
		- Testing as we go, with a well-defined test plan formulated ahead of time

	- End

*XMind - Trial Version*