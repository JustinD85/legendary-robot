using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class GameObject : DomainBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
    }
}