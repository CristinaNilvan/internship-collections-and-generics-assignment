using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Ingredient
    {
        public Ingredient(int id, string? name, int calories)
        {
            Id = id;
            Name = name;
            Calories = calories;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Calories { get; set; }

        public virtual string GenerateIngredientCode()
        {
            return $"{Id}{Name[..2]}";
        }
    }
}
