using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExercises.Builder
{
    public class Car
    {
        public int Id { get; set; }

        public Model Model { get; set; }       
        public Engine Engine { get; set; }
        public DateTime ProductionDate { get; set; }
        public override string ToString()
        {

            return $"Wyprodukowano :  {Model} / {Engine} / {ProductionDate}";
        }
    }

    public enum Model
    {
        Auris,
        Yaris,
        Hilux,
        Rav
    }
    public enum Engine
    {
        Disel,
        Hybrid,
        Electric,        
    }
}

