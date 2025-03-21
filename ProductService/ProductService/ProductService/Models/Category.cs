﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? CatName { get; set; }

        public string? Description { get; set; }

        //public int? ParentId { get; set; }

        //public int? Levels { get; set; }

        //public int? Ordering { get; set; }

        //public bool Published { get; set; }

        //public string? Thumb { get; set; }

        //public string? Title { get; set; }

        //public string? Alias { get; set; }

        //public string? MetaDesc { get; set; }

        //public string? MetaKey { get; set; }

        //public string? Cover { get; set; }

        //public string? SchemaMarkup { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
