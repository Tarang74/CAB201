@ECHO OFF

setlocal ENABLEDELAYEDEXPANSION

@REM Display help text
IF "%~1"=="-h" GOTO :help
IF "%~1"=="-help" GOTO :help

@REM Set global variables
@REM Script name
SET scriptname=%~nx0

@REM Script mode
SET /A file=0
SET /A recursive=0

@REM Options
SET /A verbose=0
SET /A open=0

SET /A tex="a"

@REM Set mode
IF "%1"=="" GOTO :noMode

IF "%1"=="recursive" (
    SET recursive=1
) ELSE (
    IF "%1"=="file" (
        SET file=1
    ) ELSE (
        GOTO :invalidMode
    )
)

SHIFT
SET directory=%~1
SHIFT

IF %file%==1 (
    SET tex=%~1
    SHIFT
)

@REM If no parameters, build without opening
IF "%1"=="" GOTO :default

@REM Loop through all parameters
SET /A numP=0

:loop
    @REM Use numP to test each parameter for validity
    SET numP=0

    @REM Check options
    IF "%1"=="-v" (
        SET numP=1
        SET verbose=1
    ) ELSE (
        IF "%1"=="-verbose" (
            SET numP=1
            SET verbose=1
        )
    )
    IF "%1"=="-o" (
        SET numP=1
        SET open=1
    ) ELSE (
        IF "%1"=="-open" (
            SET numP=1
            SET open=1
        )
    )

    @REM If current option is not valid
    IF !numP!==0 GOTO :invalidOption
    
    @REM Shift variables and loop if another option exists
    SHIFT
    IF NOT "%1"=="" GOTO :loop

:: Default
:default
    IF NOT EXIST "%directory%" GOTO :invalidDirectory

    IF %recursive%==1 (
        FOR /R "%directory%" %%i IN (*.TIKZ) DO (
            SET tex=%%~ni
            CALL :main
        )
    ) ELSE (
        CALL :main
    )

    @REM Finally:
    GOTO :EOF

:: Main function
:main
    @REM Verbose options
    IF %verbose%==0 (
        CALL :buildPDF
    ) ELSE (
        CALL :buildPDFv
    )
    
    @REM Open options
    IF %open%==1 (
        CALL :openPDF
    )

    EXIT /B

:: Build PDF
:buildPDF
    ECHO -- Building PDF --
    latexmk -aux-directory=Debug -shell-escape -file-line-error -interaction=nonstopmode -halt-on-error -output-directory=figures -silent -xelatex %directory%/%tex%.tikz
    EXIT /B

:: Build PDF verbose
:buildPDFv
    ECHO -- Building PDF -- (v)
    latexmk -aux-directory=Debug -shell-escape -file-line-error -interaction=nonstopmode -halt-on-error -output-directory=figures -verbose -xelatex %directory%/%tex%.tikz
    EXIT /B

:: Open PDF
:openPDF
    ECHO -- Opening PDF --
    figures\%tex%.pdf
    EXIT /B

:: Help
:help
    ECHO %scriptname% compile tikz diagrams using XeLaTeX.
    ECHO.
    ECHO     Usage: %scriptname% file [directory] [filename] [option] ...
    ECHO            %scriptname% recursive [directory] [option] ...
    ECHO.
    ECHO Available options:
    ECHO     %scriptname% [-h ^| -help]                  Provides help information.
    ECHO     %scriptname% [filename] [-v ^| -verbose]    Show compiler output.
    ECHO     %scriptname% [filename] [-o ^| -open]       Open the PDF after compilation.
    GOTO :EOF

:: No Mode
:noMode
    ECHO No mode provided. [file ^| recursive] expected.
    ECHO Try "%scriptname% -h" for more information.
    GOTO :EOF

:: Invalid Option
:invalidOption
    ECHO Unknown option: %1
    ECHO Try "%scriptname% -h" for more information.
    GOTO :EOF

:: Invalid Mode
:invalidMode
    ECHO Invalid mode provided. [file ^| recursive] expected.
    ECHO Try "%scriptname% -h" for more information.
    GOTO :EOF

:: No Directory
:noDirectory
    ECHO No directory was supplied.
    ECHO Try "%scriptname% -h" for more information.
    GOTO :EOF

:: Invalid Directory
:invalidDirectory
    ECHO Directory "%directory%" is invalid.
    ECHO Try "%scriptname% -h" for more information.
    GOTO :EOF