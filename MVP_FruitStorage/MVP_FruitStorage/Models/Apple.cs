using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MVP_FruitStorage.Models
{
    class Apple
    {
        [Key]
        public int Kod_apple { get; set; }
        public string Name_apple { get; set; }
        public int Price { get; set; }
        public int Size { get; set; }
        public ICollection<Сell> Сells { get; set; }
    }
}
