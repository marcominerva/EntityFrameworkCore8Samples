/*
Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MinimalDB' Microsoft.EntityFrameworkCore.SqlServer -ContextDir DataAccessLayer -OutputDir 'DataAccessLayer/Entities'
optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });
add-migration Initial -Context EntityFrameworkCore8Samples.Collections.SampleDbContext
update-database -Context EntityFrameworkCore8Samples.Collections.SampleDbContext
*/

using EntityFrameworkCore8Samples.Collections;
using Microsoft.EntityFrameworkCore;

//using var db = new MinimalDbContext();

//var ids = new List<Guid>
//{
//    Guid.Parse("85c3d025-70f0-4e34-b7f5-24ea5dde79ec"),
//    Guid.Parse("fc2546de-a286-429c-a483-298d8e14a666")
//};

//var invoices = await db.Invoices.Where(i => ids.Contains(i.Id)).ToListAsync();

//var city = "Taggia";
//var people = await db.Database.SqlQuery<Person>($"""
//    SELECT c.Id, FirstName + ' ' + LastName AS Name, c.Name AS CityName
//    FROM People p
//    INNER JOIN Cities c
//    ON p.CityId = c.Id
//    WHERE c.Name = {city}
//    """)
//    .OrderBy(p => p.Name).ToListAsync();

using var db = new SampleDbContext();

//db.Products.Add(new Product
//{
//    Id = Guid.NewGuid(),
//    Name = "Logitech K120",
//    Tags = new List<string> { "hardware", "keyboard", "wired" }
//});

//await db.SaveChangesAsync();

//var products = await db.Products.Where(p => p.Tags.Contains("hardware")).ToListAsync();

//db.Landmarks.Add(new Landmark
//{
//    Id = Guid.NewGuid(),
//    Name = "Bastione grosso",
//    Position = new Position { Latitude = 43.85888, Longitude = 7.85194 }
//});

//await db.SaveChangesAsync();

var landmarks = await db.Landmarks.Where(l => l.Position.Latitude > 42).ToListAsync();

Console.ReadLine();

public class Person
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string CityName { get; set; }
}