using CalorieCountingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalorieCountingApp.Repository
{
    public class ElvesRepository : IElvesRepository
    {
        public List<Elf> BuildElves(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Input");
            }
            var elves = new List<Elf>();
            var calorieGroups = input.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)?.ToList();
            if (calorieGroups?.Count > 0)
            {
                var elfNameCounter = 0;
                foreach (var group in calorieGroups)
                {
                    var calories = group.Split($"{Environment.NewLine}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)?.ToList();
                    var elf = new Elf() { Name = $"Elf_{++elfNameCounter}", Foods = new List<Food>() };
                    if (calories?.Count > 0)
                    {
                        foreach (var calorie in calories)
                        {
                            if (int.TryParse(calorie, out int calorieValue))
                            {
                                elf.Foods.Add(new Food() { Name = FoodFactory.Instance.RegisterFood(calorieValue), Calorie = calorieValue });
                            }
                            else
                            {
                                throw new Exception($"Unable to parse calorie value: {calorie}");
                            }
                        }
                        elves.Add(elf);
                    }
                    else
                    {
                        // No item in group // Just Skip?
                    }
                }
            }
            else
            {
                throw new Exception("Wrong Input!");
            }
            return elves;
        }

        public Elf FindElfCarringMaximumCalories(List<Elf> elves)
        {
            var maxCalories = elves.Max(elf => elf.TotalCalories);
            return elves.FirstOrDefault(e => e.TotalCalories == maxCalories);
        }
    }
}
