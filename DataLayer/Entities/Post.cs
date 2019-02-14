using DataLayer.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Post : IEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Text is required")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "DateTime is required")]
        public DateTime DateTime { get; set; }
        [JsonIgnore]
        public IList<Comment> Comments { get; set; }
    }
}
