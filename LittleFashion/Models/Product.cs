using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace LittleFashion.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubDescription { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }

    }
}
