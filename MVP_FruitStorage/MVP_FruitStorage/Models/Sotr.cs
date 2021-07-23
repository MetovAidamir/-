using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_FruitStorage.Models
{
    class Sotr
    {
        [Key]
        public int Kod_sotr { get; set; }
        public string Fio { get; set; }
        public string Gender { get; set; }
        public string Experience { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string Phone { get; set; }
        public ICollection<FruitStorage> Fruit_Storages2 { get; set; }
        public ICollection<Сell> Сells { get; set; }
        public override string ToString()
        {
            return Fio;
        }
    }
}
