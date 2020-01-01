using System;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace Domain.Interfaces
{
    public interface IActor
    {
        Guid Id { get; set; }
        DateTime CreatedAt { get; }
        DateTime UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }

    public class AActor : IActor
    {
        public AActor(string name, string description)
        {
            this.Name = name;
            this.Description = description;

        }
        public AActor() { }
        public Guid Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Required]
        [GraphQLIgnore]
        public bool IsDeleted { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        //TODO: Add positional properties/fields e.g. location saved
    }





}