using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVP_FruitStorage.Models
{
   class FruitStorage
    {
        [Key]
       public int FruitStorageKod { get; set; }
       public int Weightfruit { get; set; }
       public int Kod_sotr {get;set;}
       public int Kod_cell { get; set; }
       public int Kod_chamber { get; set; }
       public  DateTime Date_fill { get; set; }
       public virtual Sotr Sotr { get; set; }    
       public virtual Сhamber Chamber { get; set; }
    }
}
