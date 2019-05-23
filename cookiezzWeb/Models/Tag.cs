namespace cookiezz.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string TagName { get; set; }
    }
}