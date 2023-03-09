using System.ComponentModel.DataAnnotations;

namespace _2011063274_NguyenQuangTam.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
    }
}