namespace MVCAjax.Data
{
  public class Product
  {
    public string Id { get; init; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public short Stock { get; set; } // int den küçük +-32.000 değer alır.
    public bool Liked { get; set; }
    public string? PhotoUrl { get; set; }


    public Product()
    {
      Id = Guid.NewGuid().ToString(); 
    }

  }
}
