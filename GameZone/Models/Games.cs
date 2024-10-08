﻿using System.ComponentModel.DataAnnotations;

namespace GameZone.Models
{
    public class Games : BaseEntity
    {
        
        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Cover { get; set; } = string.Empty;
        public int CategoryId { get; set; } //FK
        public Category Category { get; set; } = default!;

        public ICollection<GameDevice> Device { get; set; } = new List<GameDevice>();
    }
}
