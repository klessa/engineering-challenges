# Challenge for Software Engineer 
To better assess a candidate's development skills, we would like to provide the following challenge.  You have as much time as you'd like (though we ask that you not spend more than a few hours).    

1. Senior Software Engineer or Software Engineer: If you are applying to this position, the email address you should use for submission is [dev.challenges@onetechnologies.net](dev.challenges@onetechnologies.net).
1. Data Developer: If you are applying to this position, the email address you should use for submission is [datadev.challenges@onetechnologies.net](datadev.challenges@onetechnologies.net).

Feel free to email the appropriate address above if you have any questions.

## Submission Instructions
1. First, fork this project on github.  You will need to create an account if you don't already have one.
1. Next, complete the project as described below within your fork.
1. Finally, push all of your changes to your fork on github and submit a pull request.  You should also email the appropriate address listed in the first section and your recruiter to let them know you have submitted a solution.  Make sure to include your github username in your email (so we can match people with pull requests).

## Alternate Submission Instructions (if you don't want to publicize completing the challenge)
1. Clone the repository
1. Next, complete your project as described below within your local repository
1. Email a patch file to the appropriate address listed above ([dev.challenges@onetechnologies.net](dev.challenges@onetechnologies.net) if you are applying for the general Senior Software Engineer or Software Engineer position).

## Project Description
Imagine that One Technologies has just acquired a new company and their website.  We would like to continue using the existing website with the exception of replacing all customer service phone numbers of the old company with our own.  Your task is to write a console application that takes a file directory as a single parameter and outputs a file with a list of all files in that directory that contain phone number with the format of either ###-###-#### or (###)###-####.  

Here's what your console application must do:

1. Your app must accept a single parameter indicating which directory to begin searching.  Bonus points if it handles local and UNC paths. 
1. Your app must search the given directory and any children for files that contain phone numbers.  
1. Your app must produce a .txt file with matching files including paths written on individual lines.
1. Your app must write to the console the total number of matching files and the total number of files searched.
1. Your app must be written in a .Net language (c#, VB.Net, f#) 

Your application does not need to:

1. Worry about authentication.  
1. Have unit tests (but bonus points if it does).

Your application should be easy to set up and should run on modern versions of Windows.  It should not require any for-pay software.  Nuget packages are perfectly acceptable.

## Evaluation
Evaluation of your submission will be based on the following criteria:

1. Did your application fulfill the basic requirements?
1. Did you document the method for setting up and running your application?
1. Did you follow the instructions for submission?

## My Submission
I executed the program test by pulling down the contents of onetechnologies.net for identifying files with phone numbers in them, which resulted in the following matches for phone numbers:

\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\hts-log.txt
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\hts-cache\new.lst
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\2008\03\03\test-post\index.html
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\2008\03\03\test-post\index62e6.html
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\category\company-retreats\feed\index.html
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\category\featured\feed\index.html
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\contact-us\index.html
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\feed\index.html
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\press-room\scoresense-one-technologies-ftc-settlement\index.html
\\localhost\C$\Documents\TestDir\OneTechnologies\OneTechnologies\onetechnologies.net\tag\post\feed\index.html

In order to execute the console application:

1. Build the solution
1. Run unit tests if desired
1. Execute the program as $TARGETDIR/ParsePhoneNumbers $TESTDIR where $TARGETDIR is the destination output for the solution and $TESTDIR is the local or UNC path to the directory to be parsed
1. Review console output for matching file counts
1. Review $TARGETDIR/ParsePhoneNumbers.txt for listing of matching files



