using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesTurtle.Models
{
    public class Turtle
    {
        public int ID { get; set; }
        public string TurtleName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}