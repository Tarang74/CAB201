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

- Topic01 -- Exploring C#

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

- Topic02 -- Structured Programming in C#

	- The problem: how to manage the order in which executable instructions are carried out
- also called "flow of control"
	- References

		- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/statements
		- Farrell Chapters 4 and 5

	- Introduction

		- In Topic 1 we looked at two kinds of C# statements

			- Declaration statements

				- Used to define variables and possibly assign an initial value.
				- Syntax

					- TYPE_SPECIFIER IDENTIFIER;
TYPE_SPECIFIER IDENTIFIER = EXPRESSION;
					- TYPE_SPECIFIER -- the type of the variable

						- Determines what kind of data the variable can hold, and what operations it can participate in

					- IDENTIFIER -- the name of the variable
					- EXPRESSION -- an initial value that will be assigned to the variable

			- Expression statements

				- Evaluate expressions which involve previously declared variables and global objects
				- Method call
e.g. Console.Write("hello");
				- Assignment
e.g. f = c*9/5+32;

		- There are limits to what we can do with those simple statements

			- Suppose we've been asked to write a program to calculate the sum of the counting numbers in the sub-range 1..5

				- Implementation is Demo 2.01

			- Customer likes that, and they get enthusiastic. They ask for a new program just like it, but going up to 10 instead.

				- We change our program to do the extra calculations
				- Implementation is Demo 2.02

			- Now the customer gets really excited. Their business is booming because of that program.
They tell us they'll need lots more programs, and some of their clients may need it to count as high as a million.

				- Now we've got a problem!
				- Its simply not feasible to hard-code a million lines today, and 500,000 tomorrow, and 850,000 the day after.

			- We solve this problem by structured programming, using sequence, selection, and iteration.

	- Sequence - Statements execute one after the  other

		- The only way to group multiple statements is to use braces.

			- Python uses indentation to do something similar to statement block.
			- Matlab uses keywords such as if, else, and end, to delineate blocks
			- Neither of these mechanisms work in C#

		- Statement block: a list of statements glued together with braces

			- Syntax

				- {
STATEMENT_1
STATEMENT_2
...
STATEMENT_N
}

			- Semantics

				- A block acts as if it were a single instruction.
				- The statements inside the block are executed in sequence, in the order they appear

			- Test

				- To test the block, we must create suitable conditions to allow us to test each statement 1 .. N

		- Any kind of statement can appear inside a block

			- Declaration statements, expression statements, selection statements, iteration statements, and nested blocks
			- Nested blocks

				- Usually nested blocks appear as part of other statements such as the selection and iteration statements
				- Code inside a nested block has access to the variables declared in the outer block...
				- ... but only variables declared already above the nested block.
				- Any changes made to a variable from an enclosing block are visible in the enclosing block
				- Demo 2.03 - C# interactive. Nested blocks, accessing variable declared before and after block

			- Variables declared in a block are local to that block

				- Variables can be declared in any block, including nested blocks.
				- Variables are _local_ to the block in which they are declared.
				- That means they are not visible outside the block in which they are declared.
				- Variables declared within a block may not have the same name as a variable already visible from an enclosing block.
				- Demo 2.04 - C# Interactive, local variables in nested blocks

	- Selection - statements that let us choose from a range of options

		- If statement

			- Syntax

				- if ( GUARD ) STATEMENT
				- GUARD is any expression that yields a Boolean value (true or false) when evaluated
				- STATEMENT may be any statement

			- Semantics

				- GUARD is evaluated once, with possible side-effects, depending on the expression
				- If the resulting Boolean value is true, then STATEMENT is executed once.
				- Otherwise, control passes immediately to the next statement after the if statement.

			- Test

				- Include cases that ...
				- ... cause STATEMENT to be executed
				- ... cause STATEMENT to be skipped
				- ... cover the boundaries where GUARD flips from True to False

					- Just inside the boundary
					- On the boundary
					- Just outside the boundary
					- "typical case" -- well within the boundary
					- "typical case" -- well outside the boundary

				- !!! PLUS !!! All necessary tests for the STATEMENT

					- All necessary tests for STATEMENT
					- If we write complex code, this leads to an exponential explosion of test cases
					- As we progress, we learn strategies for keeping a lid on complexity, and for testing complex programs

			- Demo 2.05 - Hot

		- If-else statement

			- Syntax

				- if ( GUARD ) STATEMENT_1 else STATEMENT_2
				- GUARD is any expression which yields a Boolean value (true or false) when evaluated
				- STATEMENT_1, STATEMENT_2 may be any statements

			- Semantics

				- GUARD_EXPRESSION is evaluated once
				- If the resulting value is true, then STATEMENT_1 is executed (once)
				- Otherwise, STATEMENT_2 is executed once

			- Test

				- Include cases that...
				- ... cause STATEMENT_1 to be executed
				- ... cause STATEMENT_2 to be executed
				- ... cover everything required to test STATEMENT_1
				- ... cover everything required to test STATEMENT_2
				- For further notes on coverage, refer to the if statement

			- Demo 2.06 - Hot Or Not

		- Nested if statements

			- This is not really a separate kind of statement, just a common pattern
			- An if-else statement, in which one (or both) of the branches is another if-else statement
			- Syntax

				- if ( G1 ) if ( G2 ) S1 else S2 else S3
				- G1, G2 -- Boolean-valued expressions
				- S1, S2, S3 -- arbitrary statements

			- Semantics

				- G1 is evaluated once.

					- If the result is true, G2 is evaluated

						- If the result is true, S1 is executed
						- Otherwise S2 is executed

					- Otherwise S3 is executed

			- Practical considerations

				- When writing real code, we use indentation to assist with readability, but C# generally ignores spaces, tabs, and new-lines
				- I personally prefer to use braces in every branch, even when they're not strictly required.
				- I would write this so it looks like
if ( G1 ) {
    if ( G2 ) {
        S1
    }
    else {
        S2
    }
}
else {
    S3
}
				- Some consider the extra braces to be superfluous. I find that programs written in this manner are easier to debug and maintain.

			- Demo 2.07 - Goldilocks

		- Cascading if statements

			- Also, not really a separate kind of statement, just a common pattern
			- An if-else in which the second branch is also an if-else ...
			- Syntax

				- if ( G1 ) S1 else if ( G2 ) S2  else if ( G3 ) S3 ... else SN

			- Semantics

				- G1 is evaluated

					- If result is true, S1 is executed
					- Otherwise, G2 is evaluated

						- If result is true, S2 is executed
						- Otherwise, G3 is evaluated

							- If result is true, S3 is executed
							- Otherwise ...

								- ...
								- If all else fails, SN is executed

			- Demo 2.08 - Income Tax

		- Switch statement

			- C#6 form of switch statement (the C#7 form is requires advanced programming knowledge for effective use)
			- Switch is another kind of multi-way branch, which can sometimes but not always be used instead of a cascading if statement
			- Syntax (typical usage) *

				- switch ( EXPRESSION ) {
case C1:
    STATEMENT
    ...
    STATEMENT
    break;
case C2:
    STATEMENT
    ...
    STATEMENT
    break;
...
case CN:
    STATEMENT
    ...
    STATEMENT
    break;
default:
    STATEMENT
    ...
    STATEMENT
    break;
}
				- EXPRESSION -- an integral or string expression
				- CX -- a constant value (usually a literal) of matching type
				- STATEMENT

					- Any statement

			- Semantics

				- Expression is evaluated, getting result value
				- If value == C1, do statements following case C1, and stop at break, and jump to the next statement after the switch
				- Otherwise, if value == C2, do statements following case C2, and stop at break
				- ...
				- Otherwise, do statements following default

			- Constraints

				- Control is not allowed to fall through from one branch to the next
				- Must end each branch with one of the following keywords: break, return, goto, or throw
				- In a loop you may also end branches with continue

			- Demo 2.09 - State of Origin
			- Demo 2.10 - Day of week

	- Iteration - Some instructions let us do a statement zero, one, or many times, without making multiple copies of the statement

		- while: if a condition is true, do something, and keep doing it until the condition is not true

			- Syntax

				- while ( GUARD ) LOOP_BODY
				- GUARD -- a Boolean expression
				- LOOP_BODY -- any statement; often a block containing multiple statements

			- Semantics

				- Step 1: Evaluate GUARD

					- If result is true:

						- Step 2: Execute LOOP_BODY

							- Go to Step 1

					- Otherwise, proceed to next statement in the program

			- Observations

				- If GUARD evaluates to false when control reaches while statement then the loop body will not be executed at all.
				- Pattern of execution:
guard, body, guard, body, ..., guard

			- Test

				- Include cases that ...
				- ... cause LOOP_BODY to be skipped
				- ... cause LOOP_BODY to be executed once
i.e. the value of GUARD becomes false after a single iteration
				- ... cause LOOP_BODY to be executed multiple times
				- ... cover all requirements for statements in LOOP_BODY

			- Demo 2.11 - Get user to enter an integer within bounds
			- Demo 2.12 - Extend Demo 2.11 to get a valid numeric integer within bounds (introduces TryParse)

		- do/while: do something, then check a condition and keep doing it until the condition is not true.

			- Syntax

				- do LOOP_BODY while ( GUARD );
				- LOOP_BODY -- any statement; often a block containing multiple statements
				- GUARD -- a Boolean expression

			- Semantics

				- Step 1: Execute LOOP_BODY

					- Step 2: Evaluate GUARD

						- If result is true

							- Go to step 1

						- Otherwise, proceed to next statement in program

			- Observations

				- Pattern of execution:
body, guard, body, guard, ... , body, guard
				- Very much like while loop; the body always executes at least once before the guard is evaluated

			- Test

				- Essentially the same as testing a while loop

		- for: a compact form of the while statement which is convenient for counting

			- Syntax

				- for ( INIT ; GUARD ; UPDATE ) LOOP_BODY
				- INIT -- a declaration statement, list of expression statements separated by commas, or an empty statement
				- GUARD -- a Boolean expression or an empty expression
				- UPDATE -- a list of expression statements separated by commas, or an empty statement
				- LOOP_BODY -- a statement, often a block containing multiple statements

			- Semantics

				- Step 1: execute INIT

					- Step 2: evaluate GUARD

						- If result is true

							- Step 3: execute LOOP_BODY

								- Step 4: execute UPDATE

									- Go to Step 2

						- If result is false, proceed to next statement in program

			- Observations

				- Convenient for counter-controlled loops
				- Execution pattern:
init,guard,body,update,guard,body,update,...,guard
				- As with while, body of loop may never execute

			- Test

				- Essentially the same as testing a while loop

			- Demo 2.13 - Sum of Integers

		- break and continue

			- Statements that may appear in the body of a loop
			- If break is executed, control jumps immediately to the next statement in the program after the loop

				- i.e. the loop terminates

			- If continue is executed, control jumps to the end of the loop body, then resumes from that point

				- In a while loop, we effectively skip ahead to the guard
				- In a for loop, control skips to the UPDATE statement, then moves on to the guard
				- Either way, we stop processing the current iteration, and move on to the next

	- Boolean expressions and variables

		- Boolean type

			- Two values: true and false
			- C# type name is bool
			- Not numeric, so there is no direct conversion between int and bool, either explicit or implicit

		- Boolean expression

			- Any expression which when evaluated, yields a Boolean value
			- Comparison operations are Boolean expressions

				- x == y
				- x < y
				- x <= y
				- x != y
				- x > y
				- x >= y

			- Logical operations are Boolean expressions

				- a && b

					- and

				- a || b

					- or

				- !a

					- not

			- Parentheses can be used to enforce ordering within Boolean expressions
			- Boolean variables are Boolean expressions

				- bool finished = false;
while ( ! finished ) {
    do_something();
    finished = everything_done();
}
				- bool less = x < y;

					- Equivalent to

						- bool less;
if ( x < y )
    less = true;
else
    less = false;

		- Boolean operator semantics

			- a && b

				- a is evaluated

					- If the result is true

						- b is evaluated

							- If the result is true, then (a && b) is true
							- Otherwise (a && b) is false

					- If the result is false, then (a && b) is false

						- At this point, the value of b is logically irrelevant at this point, so b is not evaluated.

			- a || b

				- a is evaluated

					- If result is true, then (a || b) is true

						- At this point, the value of b is logically irrelevant, so b is not evaluated

					- Otherwise, b is evaluated

						- If result is true, then (a || b) is true
						- Otherwise, (a || b) is false

			- Notice that b is not guaranteed to be evaluated. This called "short circuit evaluation".
			- !a

				- a is evaluated

					- If result is true, !a is false
					- Otherwise, !a is true

- Topic03 -- Arrays and Lists
- Topic04 -- Using Methods

	- References

		- Farrell, Chapters 7 and 8
		- https://docs.microsoft.com/en-us/dotnet/csharp/methods

	- The problem: manage complexity of programs which have complex (realistic) requirements
	- Methods help solve the problem

		- Dealing with complexity

			- Data is usually complex, and may be aggregated from multiple incompatible or unrelated sources
			- Logic is usually complex, because it involves modelling rules and constraints from the real world
			- While we deal with complexity, we need to guarantee:

				- Correctness

					- If a user is relying on a program to do their job, the software needs to be trustworthy
					- Must meet requirements
					- In our present context, given valid input, program should always produce the required outcomes
					- "Near Enough Is Good Enough" is not good enough

				- Robustness

					- If a user is relying on a program to do their job, it must not prevent them from doing their job by crashing or losing data
					- In our present context, invalid input should be detected and options for recovery should be available
					- "Garbage In, Garbage Out" is not good enough
					- Crashing is not good enough

				- Efficiency

					- If a user is relying on a program to do their job, the program needs to complete its work in a timely manner
					- So we need to learn and use efficient algorithms, and learn how to transform the task to allow efficient algorithms to be applied
					- In our context, avoid unnecessary loops and convoluted logic, and prefer to use existing standard library functions rather than writing our own code

		- Methods (functions or procedures in other languages) help us do these things

			- To address complexity we decompose large tasks into smaller tasks

				- Each sub-task handles part of the larger problem
				- We implement each sub-task separately, as a method
				- Tests can be written to target each method, keeping a lid on the complexity of the test plan

			- This same decomposition helps deliver the other requirements

				- As long as each sub-task is correct, robust, and efficient, the overall program will be also
				- Sub-tasks are simpler than the original problem, so these goals are easier to achieve

			- Methods have other benefits

				- Methods help us eliminate duplicate code, so our programs are more compact
				- Methods can be moved into libraries, then used later in other projects
				- Both of these help us be more productive

		- A method is essentially a list of instructions with a name, and usually a list of formal parameters
		- To do the instructions, we invoke the method by writing its name, followed by a parenthesised a list of arguments
		- Programs so far have invoked methods - now we will write some of our own

	- Examples -- create and invoke some simple methods

		- Sum -- map a pair of int to int
		- Add -- map pair of double arrays to double array
		- Dot -- map pair of double arrays to double
		- Print -- display elements of array (void method with side effect)

	- Syntax

		- Syntax (define a method)

			- [ACCESS_MODIFIERS] RETURN_TYPE IDENTIFIER (PARAMETER_LIST){ STATEMENTS }
			- ACCESS_MODIFIERS

				- Covered in Topics 6 and following
				- static or "nothing"

					- For present purposes, all our methods will be static

				- Future stuff

					- public, private, protected, internal
					- abstract, sealed, virtual...

			- RETURN_TYPE

				- void

					- The method does not yield a result; can be used as an EXPRESSION_STATEMENT
					- e.g. Console.Write

				- TYPE_SPECIFIER

					- Simple data types

						- int, double, string, ...

					- Structured data (arrays, lists)

						- int [], double [], List<string>, ...

			- IDENTIFIER

				- The name of the method
				- Any valid C# identifier
				- By convention, camel case using upper-case first letter

			- PARAMETER_LIST

				- Declare formal parameters of method

					- Determines what arguments may be passed to method
					- May include default values for parameters

				- Either an empty list, or a list of parameter declarations
				- PARAMETER_DEC [, ... , PARAMETER_DEC]

			- PARAMETER_DEC

				- [REF_OR_OUT_OR_PARAMS] TYPE_SPECIFIER IDENTIFIER [= INITIAL_VALUE]
				- REF_OR_OUT_OR_PARAMS

					- Come back to this later!

						- ref

							- A reference is sent instead of a value, can be used to send data to method, retrieve data, or both

						- out

							- A reference is sent to the method, and it can be used to send data back to the caller

						- params

			- STATEMENTS

				- Can be any sequence of statements, including declarations, expressions, and structured
				- As with nested blocks (see Topic 1) variables declared in a method body are local to the method body

		- Syntax (invoke a method)

			- IDENTIFIER ( ARGUMENT_LIST )
			- IDENTIFIER

				- The name of method to be invoked
				- If the method is defined in some other class, we qualify the name with the appropriate class name, e.g. Console.Write

			- ARGUMENT_LIST

				- Empty List, or
				- ARGUMENT [, ... , ARGUMENT]

			- ARGUMENT

				- EXPRESSION

					- Argument matches formal parameter list in order encountered

				- [REF_OR_OUT] EXPRESSION

					- ref required if formal parameter is ref
					- out required if formal parameter is out

				- IDENTIFIER : [REF_OR_OUT] EXPRESSION

					- Identifier is the name of a formal parameter in the method we're calling
					- Allows arguments to be supplied in any order
					- Especially useful with optional parameters

	- General semantics

		- We invoke a method by writing its name, followed by a list of arguments
		- When we do this:

			- The run-time system sets up storage locations for each formal parameter and local variable
			- Each expression in the argument list is evaluated, and the result is copied into the storage location set aside to hold the corresponding formal parameter
			- The instructions in the method body are executed
			- If the method returns a non-void type, then
return EXPRESSION;

				- Expression is evaluated and the result is placed in an intermediate storage location
				- Finally, that result is processed by the instructions surrounding the method invocation

		- Example -- z = sum(x,y)

			- Draw a picture of memory

	- Argument values are copied into formal parameters

		- Generally THERE IS NO CONNECTION between variables in the calling code, and parameters in the invoked method
		- Even if the variables have the same name!
		- The formal parameter has A COPY OF THE DATA. The original value is safe and sound where it was.
		- So changing the value of a parameter USUALLY does not change the value of the corresponding argument
		- But this plays out differently for value types and reference types

	- Working with value types

		- Value types: the data "lives in" the variable

			- Examples: int, double, decimal, instances of struct types (Future, possibly out of scope for this unit)
			- With value types, the value of a variable IS THE DATA
			- When we copy the value, we get a new, different, copy of the data
			- Modifying the copy leaves the original copy unchanged
			- Example -- Try_Change_Arg

				- Draw a picture of memory

	- Working with reference types

		- Reference types: The data "lives somewhere else"; a reference tells us where to find the data

			- Examples: any array, any List, string, instances of class types (Topic 6 and later)
			- With a reference type, the value of the variable is a REFERENCE TO THE DATA
			- So when we copy the value, we get THE SAME REFERENCE
			- The copied reference lets the underlying data be modified
			- Example -- Try_Change_Array_Contents

				- Draw a picture of memory

			- Changing the contents of an array does not change the reference -- if we did that, we'd be referring to a different array

		- Returning an array from a method

			- A method can create new arrays, and they can be sent back to the caller via return.
			- Example -- Vector_Add

				- Draw a picture of memory

	- Miscellaneous

		- References to value types -- ref and out keywords

			- Use references if we need to change the original copy of a value type passed as an argument.
			- A reference parameter can "reach out" to the calling scope and directly act on the original data.
			- If a parameter has the ref qualifier:

				- A reference to the original data will be sent to the method instead of a copy
				- The method can "reach back" and read or modify the original value

					- So the original value must be initialised beforehand

				- Calling code must use the ref keyword to invoke the method
				- The reference can be used for two-way communication from caller to method, and back
				- Example -- Low Pass Filter

					- Draw picture of memory

			- If a parameter has the out qualifier:

				- A reference to the original data is sent to the method, instead of a copy
				- The method can "reach back" and modify the original value

					- Cannot read the original value, so it does not need to be initialised

				- Calling code must use the out keyword to invoke the method
				- The reference is used for one-way communication, sending data back from the method to the caller
				- Especially useful if we want to "return" multiple values from a method.
				- Example -- CircleStats

	- Case Study -- Lemonade stand

		- A simple menu-driven program which records sales of lemonade, cookies, and possibly other items.
		- Program Structure

			- Globally visible constants are introduced to represent the menu options

				- LEMONADE, COOKIE, REPORT, QUIT

			- Main method:

				- Declares variables required to maintain the state of the program:

					- options: an array of strings which will be displayed as menu options
					- products: array of product names
					- sales: array of int, used to accumulate sales tallies for each product
					- -- products and sales are parallel arrays

				- Invokes Welcome, Farewell, and Run methods.

			- Welcome method: Displays a welcome message
			- Farewell method: displays a farewell message
			- Run method:

				- Parameters: options, products, sales (as in Main)
				- Implements an event loop to run the program
				- Invokes Menu method to get a user menu choice
				- Invokes Process method to process the user's chosen action
				- Finishes processing when user choice is QUIT

			- Menu method:

				- Parameters: options (as defined in Main)
				- Displays a menu, then gets the user's option (an integer value), returning only when a valid choice has been obtained
				- Invokes ShowMenu to display the options
				- Invokes GetOpt to (try to) get a valid option
				- Method returns when a valid option is received, otherwise the procedure is repeated

			- ShowMenu method:

				- Parameters: options (as above)
				- Prompts the user to enter an option, displaying the list of available options.

			- GetOpt method:

				- Parameters:

					- option -- reference to an integer in which the numeric result will be placed
					- low -- integer lower bound for valid option range
					- high -- integer upper bound for valid option range

				- Gets line of input text from standard input and tries to parse it into option
				- Returns boolean value, true if and only if a valid numeric value between low and high was obtained

			- Process method:

				- Parameters:

					- choice -- integer menu option
					- products -- list of product names (see Main)
					- sales -- list of product sales counters (see Main)

				- If choice is LEMONADE or COOKIE, increments the respective sales counter
				- If choice is REPORT, invokes Report to display sales report

			- Report method:

				- Parameters: products, sales -- as defined in Main
				- Displays a sales report by iterating over the parallel arrays and printing their contents.

### Weeks 6-12: Object oriented programming

*XMind - Trial Version*