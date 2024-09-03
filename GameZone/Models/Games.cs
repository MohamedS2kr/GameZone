namespace GameZone.Models
{
    public class Games : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public int CategoryId { get; set; } //FK
        public Category Category { get; set; }
    }
}
