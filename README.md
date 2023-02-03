# CalorieCountingApp
Solution Structure:
  *CalorieCountingApp project is a windows form application
  
  *CalorieCalculator.cs is the class to trigger the calculation, it has dependency on IElvesRepository which is being injected through constructer
  
  *ElvesRepository.cs is the class where input parsing and the calculation happens
  
  *FoodFactory.cs is a singleton class to store and generate unique Food name based on calorie value. (Two different foods may have same calorie though! I didn't thought    about this situation while writing the factory.)
  
  *Model classes are located inside CalorieCountingLibrary project
  
  *There is opportunity to write Unit Tests around CalorieCalculator class to test some edge case scenarios defiened in ElvesRepository.cs
  
To run the application please select "CalorieCountingApp" as start-up project

Please add your input to the Input textbox and hit Find "Find Elf With Max Calories" button to see the output
