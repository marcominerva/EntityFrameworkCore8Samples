/*
Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MinimalDB' Microsoft.EntityFrameworkCore.SqlServer -ContextDir DataAccessLayer -OutputDir 'DataAccessLayer/Entities'
optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });
add-migration Initial -Context EntityFrameworkCore8Samples.Collections.SampleDbContext
update-database -Context EntityFrameworkCore8Samples.Collections.SampleDbContext
*/

Console.ReadLine();