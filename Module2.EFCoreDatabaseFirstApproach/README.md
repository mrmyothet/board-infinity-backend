```sql
CREATE DATABASE DatabaseFirstDB;

USE DatabaseFirstDB;

CREATE TABLE Customer
(CustomerId INT PRIMARY KEY IDENTITY(1,1), 
CustomerName VARCHAR NOT NULL,
CustomerAmount FLOAT);

```

```cmd
Scaffold-DbContext "Server=MYOTHETPC\MSSQLEXPRESS2016;Database=DatabaseFirstDB;Integrated Security=true;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

```sql
ALTER TABLE Customer
Add City VARCHAR(50);

ALTER TABLE Customer
ALTER COLUMN CustomerName VARCHAR(50);
```

```cmd

Scaffold-DbContext "Server=MYOTHETPC\MSSQLEXPRESS2016;Database=DatabaseFirstDB;Integrated Security=true;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

```