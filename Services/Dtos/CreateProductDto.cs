namespace Services.Dtos
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int CategoryId { get; set; }
    }
}
