﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_GreenFluffyBites.Models
{
    public class Article
    {

        [Key]
        public int Id { get; set; }

        [Required]        
        [StringLength(55)]
        public string Title { get; set; }
        
        [Required]
        [StringLength(300)]
        public string Content { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public bool IsAuthor(string name)
        {
            return this.Author.UserName.Equals(name);
        }
    }
}