﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Domain.Entities
{
    public class User 
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } =  string.Empty;

        public string Password { get; set; } =  string.Empty;

        public ICollection<Movie> Movies { get; set; }
    }
}
