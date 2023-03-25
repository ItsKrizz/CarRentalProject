How to run the application on your PC:

1. Make sure you have .Net Core 3.1 Installed.
2. Download the zip file or pull the repository with a version control.
3. Connect the AppDbContext to your server name.
4. Open the package manager console and run the following commands (Make sure you have chosen CarRental.Data):

      Install-Package Microsoft.EntityFrameworkCore -Version 3.1.32 
      Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.32 
      Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.1.32 
      Install-Package Microsoft.EntityFrameworkCore.Design -Version 3.1.32 
      Install-Package Microsoft.EntityFrameworkCore.Proxies -Version 3.1.32

5. In the package mannager console type "Update-Database" (Make sure you have chosen CarRental.Data).
6. Run the seeder in "CarRental.Seeder" if you want to fill the database with example data.
7. Use the app!
