### Formulation of the Test Task
[Посилання на завдання]()





http://localhost:5279/

Create Doker Container
1. docker run -e "ACCEPT_EULA=Y" -e 'MMSQL_PID=Express' -e "MSSQL_SA_PASSWORD=VladM20472019" -p 1434:1433 -v sqlvolume:/var/opt/mssql -d --name sql-db2 mcr.microsoft.com/mssql/server:2019-latest 
2 