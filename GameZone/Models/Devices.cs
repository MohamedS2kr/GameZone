using System.ComponentModel.DataAnnotations;

namespace GameZone.Models
{
    public class Devices : BaseEntity
    {
        [MaxLength(55)]
        public string Icon { get; set; } = string.Empty;
    }
}
