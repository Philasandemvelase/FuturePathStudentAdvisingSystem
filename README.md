Future Path Student Advising System
Future Path helps career advisors guide high-school learners towards the right university degree and funding. An advisor captures a learner's subjects, marks and interests, and the system checks them against each degree's requirements and gives a clear recommendation.

Built with C# (Windows Forms, .NET Framework 4.7.2) and SQL Server LocalDB.

What it does
Captures a learner's profile, school subjects and marks
Runs an interest questionnaire to see which fields suit the learner
Checks the learner against each degree programme's subject and mark requirements
Gives one of four outcomes: Strong Match, Possible Match, Not Currently Eligible, or More Information Needed
Suggests alternative programmes when the learner does not qualify for their first choice
Shows matching funding options: scholarships, bursaries, financial aid and external funding
Saves each advisory session and exports reports as PDF or TXT
Has separate logins for Administrators and Career Advisors
Lets administrators maintain faculties, programmes, requirements, funding and questionnaire questions
How it is built
The project uses a 3-tier design, so each part has one job:

Layer	Folder	Job
Presentation	Presentation/	Windows Forms screens for the public, advisors and administrators
Business	Business/	Controllers, entities and the rules that score and recommend
Data access	DAL/, Data/	Reads and writes the SQL Server database
The database has 18 tables. Passwords are stored as SHA-256 hashes, not plain text.

How to run it
You need Visual Studio with the .NET desktop development and Data storage and processing workloads (this installs SQL Server LocalDB).

Clone the repository and open FuturePathStudentAdvisingSystem.slnx in Visual Studio.
Open SQL Server Object Explorer and connect to (localdb)\MSSQLLocalDB.
Run the scripts in the Database/ folder in order:
01_CreateDatabase.sql
02_CreateTables.sql
03_SeedData.sql
04_VerifyData.sql (optional check)
Press F5 to build and run.
Demo staff logins are listed in Database/03_SeedData.sql.

Author
Philasande Mvelase, BSc Computer Science and Information Systems, University of Cape Town. Built for the INF2011S course project.
