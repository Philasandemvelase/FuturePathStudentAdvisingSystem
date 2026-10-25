/* =====================================================================
   Future Path Student Advising System
   01_CreateDatabase.sql  -  run ONCE per machine (safe to re-run)

   Creates the FuturePathDB database on SQL Server LocalDB.
   Run against: (localdb)\MSSQLLocalDB   (Visual Studio > SQL Server
   Object Explorer > (localdb)\MSSQLLocalDB > right-click > New Query)
   ===================================================================== */
USE master;
GO

IF DB_ID(N'FuturePathDB') IS NULL
BEGIN
    CREATE DATABASE FuturePathDB;
    PRINT 'FuturePathDB created.';
END
ELSE
    PRINT 'FuturePathDB already exists - nothing to do.';
GO
