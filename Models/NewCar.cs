using System;
using Microsoft.AspNetCore.Http;

namespace shop.Models
{
    public class NewCar
    {
        public Guid id { get; set; }
        
        public string name { get; set; }
        
        public string shortDesc { get; set; }
        
        public string longDesc { get; set; }
        
        public ushort price { get; set; }
        
        public bool isFavourite { get; set; }
        
        public bool available { get; set; }
        
        public IFormFile File { get; set; }
        
        
    }
}