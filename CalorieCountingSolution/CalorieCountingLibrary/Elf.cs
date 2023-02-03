using System.Collections.Generic;
using System.Linq;

namespace CalorieCountingLibrary
{
    public class Elf
    {
        public string Name { get; set; }
        public List<Food> Foods { get; set; }
        public int TotalCalories { get { return Foods != null ? Foods.Sum(f => f.Calorie) : 0; } }
    }
}