﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ThzTodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsComplete { get; set; }

        public DateTime DateDue { get; set; }
    }
}