﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeReview.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public virtual Coffee Coffee { get; set; }

        public Review()
        {
        }

        public Review(int id, string content)
        {
            Id = id;
            Content = content;
        }


    }
}
