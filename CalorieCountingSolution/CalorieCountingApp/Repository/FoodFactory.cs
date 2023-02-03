using System.Collections.Generic;

namespace CalorieCountingApp.Repository
{
    public class FoodFactory
    {
        private static FoodFactory _foodFactory;
        private static object _lock = new object();
        private Dictionary<int, string> _foodDictionary = new Dictionary<int, string>();
        private int _foodNameCounter = 0;
        private FoodFactory() { }

        public static FoodFactory Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_foodFactory == null)
                    {
                        _foodFactory = new FoodFactory();
                    }
                    return _foodFactory;
                }
            }
        }

        public string RegisterFood(int calorie)
        {
            if (!_foodDictionary.TryGetValue(calorie, out string foodName))
            {
                foodName = $"Food_{++_foodNameCounter}";
                _foodDictionary.Add(calorie, foodName);
            }
            return foodName;
        }
    }
}
