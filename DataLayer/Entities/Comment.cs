using System;
using System.ComponentModel.DataAnnotations;
using DataLayer.Interfaces;

namespace DataLayer.Entities
{
    public class Comment: IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
