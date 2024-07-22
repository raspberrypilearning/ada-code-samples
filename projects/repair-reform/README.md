
Repair & Reform is one of the database scenarios used on the [Ada Computer Science](https://adacomputerscience.org/) platform.

The [scenario page](https://adacomputerscience.org/concepts/projdb_repair_and_reform_scenario) contains information about the design of the database, sample data, and links to the related questions that use this scenario. There is also an instance of the database in the final "Try it now" section that uses the [Ada SQL Editor](https://adacomputerscience.org/support/student/code#sql-editor), allowing you to write and run SQL statements within the browser without any extensions or downloads. 

Repair & Reform is also used within a larger [database project](https://adacomputerscience.org/topics/projdb_repair_and_reform) with sections on analysis, design, implementation, testing and evaluation.

### Database structure

The database has four tables:

- `customer`
- `staff`
- `treatment`
- `appointment`

The test data contains 240 appointments scheduled throughout January 2024.

### Files

`repair_reform.sqlite` contains a copy of the SQLite database with the tables and test data included.

The `.txt` files contain the SQL statements for creating the tables and inserting the test data yourself:

- `repair_reform_create_tables.txt` is for creating the four tables
- `repair_reform_insert_all.txt` has the test data for all four tables
- the remaining `.txt` files have the test data for each individual table separately

### Usage

The SQL statements are designed to be used with DB Browser (SQLite):
https://sqlitebrowser.org/dl/


All of the resources in this topic have been developed to be used alongside the learning materials in Ada Computer Science by the Raspberry Pi Foundation. Usage licensed under CC BY-NC-SA 4.0 - https://creativecommons.org/licenses/by-nc-sa/4.0/
