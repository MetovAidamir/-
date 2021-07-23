using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVP_FruitStorage.Models
{
    class Сhamber
    {
        [Key]
        public int Kod_chamber { get; set; }
        public int Nomer { get; set; }
        public int Size {get; set;}
        public ICollection<FruitStorage> Fruit_Storages { get; set; }
    }
}
