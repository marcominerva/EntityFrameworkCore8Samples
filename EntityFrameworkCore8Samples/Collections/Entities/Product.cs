namespace EntityFrameworkCore8Samples.Collections.Entities;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public IList<string> Tags { get; set; }

    //public List<double> LastPrices { get; set; }
}