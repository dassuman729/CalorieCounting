using CalorieCountingApp.Repository;
using CalorieCountingLibrary;

namespace CalorieCountingApp
{
    public class CalorieCalculator
    {
        private IElvesRepository _elvesRepository;
        public CalorieCalculator(IElvesRepository elvesRepository)
        {
            _elvesRepository = elvesRepository;
        }

        public Elf Calculate(string input)
        {
            var elves = _elvesRepository.BuildElves(input);
            return _elvesRepository.FindElfCarringMaximumCalories(elves);
        }
    }
}
