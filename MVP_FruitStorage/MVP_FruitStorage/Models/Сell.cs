using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVP_FruitStorage.Models
{
    class Сell
    {
        [Key]
        public int Kod_cell { get; set; }
        public int Kod_apple { get; set; }
        public int Kod_sotr { get; set; }
        public int Size { get; set; }
        public virtual Apple Apple { get; set; }
        public virtual Sotr Sotr { get; set; }
    }
}
