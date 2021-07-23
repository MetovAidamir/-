using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_FruitStorage.Models
{
    class context:DbContext
    {
        public context() : base("Connection") { }
        public DbSet<FruitStorage> FuitStorages { get; set; }
        public DbSet<Sotr> Sotrs { get; set; }
        public DbSet<Apple> Apples { get; set; }
        public DbSet<Сell> Сells { get; set; }
        public DbSet<Сhamber> Сhambers { get; set; }  
    }
}
