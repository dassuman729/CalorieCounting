using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCountingLibrary;

namespace CalorieCountingApp.Repository
{
    public interface IElvesRepository
    {
        List<Elf> BuildElves(string input);
        Elf FindElfCarringMaximumCalories(List<Elf> elves);
    }
}
