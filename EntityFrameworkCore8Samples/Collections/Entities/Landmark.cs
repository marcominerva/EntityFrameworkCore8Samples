namespace EntityFrameworkCore8Samples.Collections.Entities;

public class Landmark
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Position Position { get; set; }
}

public class Position
{
    public double Latitude { get; set; }

    public double Longitude { get; set; }
}