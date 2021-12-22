using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace shop.Entities
{
    public class Car
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string ShortDesc { get; set; }
        [MaxLength(255)]
        public string LongDesc { get; set; }
        [MaxLength(10)]
        public byte[] Data { get; set; }
        [Required]
        public ushort Price { get; set; }

        public bool IsFavourite { get; set; }

        public bool Available { get; set; }

        [Obsolete("Used only for entity binding.", true)]
        public Car() { }

        public Car(string name, string shortDesc, string longDesc, byte[] data, ushort price, bool isFavourite, bool available, Guid categoryId)
        {
            Id = Guid.NewGuid();
            Name = name;
            ShortDesc = shortDesc;
            LongDesc = longDesc;
            Data = data;
            Price = price;
            IsFavourite = isFavourite;
            Available = available;
        }
    }
}