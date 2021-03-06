using Todo.Service.Mongo.Entity;
using Todo.Service.Mongo.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Todo.Service.Mongo.Models
{
    public class TodoTask
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<string> Tags { get; set; }
        public TaskPriority Status { get; set; } = TaskPriority.Created;
        public TaskColor Color { get; set; } = TaskColor.Blue;
    }
}
