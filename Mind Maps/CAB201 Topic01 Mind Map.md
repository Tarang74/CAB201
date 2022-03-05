# CAB201

## Programming in a statically typed, object oriented language

### Weeks 1-5: Programming in a statically typed language

- Programming

	- From Wikipedia: Computer programming is the process of designing and building an executable computer program to accomplish a specific computing result or to perform a specific task.
	- Programming involves:

		- Analysis

			- What is the problem?
			- What data is involved - input, output?
			- What is the relationship between input and output?
			- What other constraints?

		- Design

			- Specify modules that need to be created to implement the solution.
			- Module -- group of closely related fuctions and data they need to do their job
			- Which parts of the problem are closely related? They probably belong together in a module.
			- How do modules fit together and communicate?
			- How can I test each of these modules to be sure they behave as desired?
			- How can I test the complete system to be sure it behaves as desired?

		- Implementation

			- Create working software to "do" each part of the design
			- Select suitable algorithms and data structures to do each required item of functionality
			- Write code to implement the algorithms and data structures

		- Testing

			- Before we write any code we should have a very clear idea how the program can be validated; usually that is done by testing

	- Programming tends to be incremental

		- Large problems are split into small tasks and tackled one task at a time, or shared across a team

	- Programming tends to be iterative

		- Each task tends to involve some amount of analysis, design, implementation, and testing.
		- As we implement each part, we test it
		- If tests reveal no defects: move on to the next task
		- If tests reveal defects: debug and re-test

- Statically typed language

	- Type of an expression is "what kind of data" the expression carries
	- Variables are a kind of expression which has an identity and a value
	- The value of a variable may change as program runs
	- In a statically typed language, the type of each variable is specified before it can be used, and never changes.
	- In a dynamically typed language (e.g. Python, Matlab) the type of a variable can change as the program runs.

- C# is a statically typed, object oriented language

	- C# is a means to an end, not the end 
	- We will not exhaustively explore all of C#
	- Focus will be on illustration of key concepts rather than minutiae
	- Exploring C#

		- C# Interactive: use C# like a calculator

			- Expressions and types (int, double)
			- Variables
			- Strings
			- Converting between strings and numeric types, and one numeric type to another

				- 1. Numeric conversion

					- Conversion is required whenever an expression of some type is used in an operation that works on some other type
					- Two kinds of numeric conversion
					- (1) Implicit conversion "just works" -- no special action needed on our part

						- Implicit conversion happens without any special action on our part, but only in certain situations
						- Any integral type implicitly converts to any floating point type
						- Integral types implicitly convert to other integral types which can store the value without loss
						- Float implicitly converts to double
						- Double does not implicitly convert to anything
						- Decimal does not implicitly convert to anything
						- An int literal that is small enough to fit into the destination type implicitly converts to the destination type

					- (2) Explicit conversion requires a cast operator

						- Typical use case 1: convert any floating point expression to any integral type
						- Typical use case 2: convert integral expression to a narrower integral type
						- Syntax of cast expression:
( TYPE ) EXPRESSION
						- e.g. int i = (int) 1.414M;

					- Rules for numeric conversion on-line at: docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
					- Values can be converted from one type to another, but information may be lost in translation

				- 2. Conversion from numeric to string

					- Produce a string that contains a representation of a numeric value
					- As with explicit numeric conversions the value may be distorted in translation.
					- In order of increasing power, we have

						- String concatenation

							- The string concatenation operator can be used to construct a string in stages
							- If expr_1 and expr_2 are expressions, and either of them yields a string,
expr_1 + expr_2
is a string containing string representations of both, concatenated
							- If either expression is not a string, then it is silently converted to a string by calling its ToString() method
							- Advantage: concatenation is similar in C# to many other languages, so it may be familiar
							- Disadvantage: concatenation is verbose and clumsy if custom formatting is required

						- ToString()

							- Every C# object has a method with signature
string ToString()which returns a string representing the contents of the object
							- The numeric types also have a method with signature
string ToString(string format)
which can be used to produce a string with a desired format
							- Examples: pad with leading zeros, or limit number of decimal places
							- The other conversion methods in this part all use ToString to do the real work
							- Advantage: every object has ToString(), and all numeric types have the overloaded form to enable custom formatting
							- Disadvantage: verbose, but we rarely call it explicitly anyway

						- String interpolation

							- Insert expressions of any type directly into a string literal
							- Use special string literal
							- $"This is a string interpolation expression."
							- Insert expressions by enclosing them in braces
							- string s = $"The square root of 5 is {Math.Sqrt(5)}."
							- Alignment and formatting can be carried out to produce justified output with custom formatting.
							- e.g string s = $"The square root of 5 is {Math.Sqrt(5),12:F4}."
							- Advantage: probably the most readable of the options
							- Disadvantage: hard-coded string literal potentially makes programs harder to maintain or translate to another language

						- Composite formatting

							- Insert expressions of any type into a format string using numbered place-holders
							- Any string expression can be used as format string, including literals, variables, or dynamically constructed strings
							- Doesn't stand alone, but a range of C# standard library functions use it:- Console.WriteLine,  String.Format
							- Insert expressions by enclosing a numeric placeholder in braces, and following up with the expressions to be inserted, in order required by the placeholders
							- Alignment and formatting can be carried out to produced justified output with custom formatting- string.Format("The square root of {0} is {1,12:F4}.", 5, Math.Sqrt(5))
							- Advantages: very flexible; programs are easier to maintain; text can be constructed dynamically or loaded from configuration files
							- Disadvantages: more verbose and less readable than interpolation

						- The more of these techniques you master the more efficient you will be -- "work smarter not harder"
						- Which of these do we use and how much detail do we need to know?

							- Ideally, you will learn how to use all of these; use whichever seems best that the time.
							- Focus your learning on the general concept and usage of each technique.
							- Don't try to memorise every last detail of format strings, but make sure you know where to find them in a hurry if you need to use them.

				- 3. Conversion from string to numeric

					- int.Parse, double.Parse, ...

						- Each numeric type has a method called Parse which tries to convert a string to that type
						- The int class has a method int.Parse, with signature
int Parse(string s)
						- The double class has a method double.Parse, with signature
double Parse(string s)

					- Convert.ToInt32, Convert.ToDouble, ...

						- Convert class has methods for each of the numeric types which try to convert a string to the corresponding type
						- int Convert.ToInt32(string s)
						- double Convert.ToDouble(string s)

					- Which of these we actually use in day-to-day work is a matter of choice, but we need to understand and be able to use any of these methods

		- C# Projects: build stand-alone executable programs involving Standard input, standard output, and sequences of instructions

			- Interactive scripting environments are great for exploring language features and writing throw-away code, but they are not suitable for developing complex software systems
			- To develop complex programs we need the robustness of a compiled language and project management infrastructure to help us manage complexity
			- Visual Studio uses a project metaphor to help us organise our work
			- Most of the programs we develop will be C# projects, and we'll compile them to produce stand-alone executable programs
			- We'll start by creating some simple stand-alone executable programs

				- Hello World

					- The traditional "first program"
					- Create a new C# Console Application Project
					- Review code skeleton in C# editor
					- Note: a detailed dissection of the boilerplate code may be found on Blackboard -- for now just concentrate on the contents of the Main method
					- Compile the program
					- Run the program

				- Echo String

					- Create a new C# Console Application Project
					- Modify the code skeleton

						- Display a prompt
						- Read a line of text from the standard input stream and store it in a string
						- Write the content of the string to the standard output stream

					- Compile the program
					- Run the program

				- Currency Conversion

					- Display prompt to enter currency amount
					- Read a line of text from the standard input stream and store it in a numeric variable of suitable type
					- Display prompt to enter conversion factor
					- Read a line of text from the standard input stream and store it in a numeric variable of suitable type
					- Compute the equivalent value
					- Display the converted currency amount

				- Temperature Conversion

					- Display prompt to enter temperature
					- Read a line of text from the standard input stream and store it in a numeric variable of suitable type
					- Compute the equivalent value
					- Display the converted temperature

				- Retail price Calculator

					- Display prompt to enter wholesale price
					- Read a line of text from the standard input stream and store it in a numeric variable of suitable type
					- Compute GST amount and store it
					- Display prompt to enter markup percentage
					- Read a line of text from the standard input stream and store it in a numeric variable of suitable type
					- Compute the markup amount and store it
					- Add wholesale, GST and markup to get final price
					- Display the final price and GST

			- That's all for Topic 1 ^_^

		- AMS: submit programs for testing on a QUT server

			- https://sefams01quteduau/CAB201

### Weeks 6-12: Object oriented programming

*XMind - Trial Version*