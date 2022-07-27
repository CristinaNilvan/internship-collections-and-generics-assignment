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

        public override bool Equals(object? obj)
        {
            return obj is Ingredient ingredient &&
                   Id == ingredient.Id &&
                   Name == ingredient.Name &&
                   Calories == ingredient.Calories;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Calories);
        }

        public override string? ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
