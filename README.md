# Project Name - Blazor User Management
[Click here to visit the project repository](https://github.com/VladMak11/TestTaskDevBlazorMaksymenko)

### Formulation of the Test Task
[Link to the statement of the test task](https://github.com/VladMak11/TestTaskDevBlazorMaksymenko/tree/main/TechnicalTaskDescription)

### Contact Information
- Name : Maksymenko Vladyslav
- CV : [link to CV](https://drive.google.com/file/d/1MSJBEHmWgQlJQ49KGeu0O-dzIlnv6jdL/view?usp=share_link)
- Telegram : [send me a message ](https://t.me/victory1105)

## Description
> This project is a small web application built using Blazor Server, .NET 7 , and Bootstrap 5. It utilizes a server-side MS SQL database for data storage. The main purpose of the application is to manage users and their properties.
**The following pages are included in the application:**
> * _User List_
(Displays a table with all users. Where access to all CRUD operations is provided.)
> * _User Upsert Form_
(Provides a form for creating and editing user details. The form includes fields to fill in all user entity properties. There is a save button to store the user data in the database. When editing a user, the form automatically populates with the selected user's data.)
> * _Property List_
(Displays a table with all users. Where access to all CRUD operations is provided.)
> * _Property Upsert Form_
(Offers a form for creating and editing property details. The form follows a similar structure to the user form, allowing users to fill in all property entity properties. The save button saves the property data to the database. When editing a property, the form automatically populates with the selected property's data.)

### Technologies Used
- Blazor Server
- .NET 7
- Bootstrap 5
- MS SQL Server
- Docker
 
### How to Run?
1. Create Doker Container.

```
docker run -e "ACCEPT_EULA=Y" -e 'MMSQL_PID=Express' -e "MSSQL_SA_PASSWORD=VladM20472019" -p 1433:1433 -v sqlvolume:/var/opt/mssql -d --name sql-db mcr.microsoft.com/mssql/server:2019-latest 
```
2.  Copy DB backup to container (start copy-backup.bat).
3.  Load DB backup.
4.  Start run-application.bat.
5.  App url - http://localhost:5279/.