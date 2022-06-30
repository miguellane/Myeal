using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myeal.Models
{
    public class SpoonacularSearchViewModel
    {
        public bool vegetarian { get; set; }
        public bool vegan { get; set; }
        public bool glutenFree { get; set; }
        public bool dairyFree { get; set; }
        public bool veryHealthy { get; set; }
        public bool cheap { get; set; }
        public bool veryPopular { get; set; }
        public bool sustainable { get; set; }
        public bool lowFodmap { get; set; }
        public int weightWatcherSmartPoints { get; set; }
        public string gaps { get; set; }
        public int preparationMinutes { get; set; }
        public int cookingMinutes { get; set; }
        public int aggregateLikes { get; set; }
        public int healthScore { get; set; }
        public string creditsText { get; set; }
        public string license { get; set; }
        public string sourceName { get; set; }
        public double pricePerServing { get; set; }
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public int readyInMinutes { get; set; }
        public int servings { get; set; }
        public string sourceUrl { get; set; }
        public int openLicense { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public Nutrition nutrition { get; set; }
        public string summary { get; set; }
        [NotMapped]
        public List<string> cuisines { get; set; }
        [NotMapped]
        public List<string> dishTypes { get; set; }
        [NotMapped]
        public List<string> diets { get; set; }
        [NotMapped]
        public List<string> occasions { get; set; }
        public List<AnalyzedInstruction> analyzedInstructions { get; set; }
        public string spoonacularSourceUrl { get; set; }
    }
    public class Nutrition
    {
        public int NutritionID  { get; set; }
        public List<Nutrient> nutrients { get; set; }
        public List<Property> properties { get; set; }
        public List<Flavonoid> flavonoids { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public CaloricBreakdown caloricBreakdown { get; set; }
        public WeightPerServing weightPerServing { get; set; }

        public int SpoonacularSearchViewModelID { get; set; }
        public SpoonacularSearchViewModel SpoonacularSearchViewModel { get; set; }
    }
    public class Nutrient
    {
        public int NutrientID { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string unit { get; set; }
        public double percentOfDailyNeeds { get; set; }

        public int NutritionID { get; set;}
        public Nutrition Nutrition { get; set; }
        //public int IngredientID { get; set; }
        //public Ingredient Ingredient { get; set; }
    }
    public class Property
    {
        public int PropertyID { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string unit { get; set; }

        public int NutritionID { get; set; }
        public Nutrition Nutrition { get; set; }
    }
    public class Flavonoid
    {
        public int FlavonoidID { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string unit { get; set; }

        public int NutrutionID { get; set; }
        public Nutrition Nutrition { get; set; }
    }
    public class Ingredient
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string unit { get; set; }
        public List<Nutrient> nutrients { get; set; }
        public string localizedName { get; set; }
        public string image { get; set; }

        public int NutritionID { get; set;}
        public Nutrition Nutrition{ get; set; }
        //public int StepID { get;set; }
        //public Step Step { get; set; }
      
    }
    public class CaloricBreakdown
    {
        public int CaloricBreakdownID { get; set; }
        public double percentProtein { get; set; }
        public double percentFat { get; set; }
        public double percentCarbs { get; set; }

        public int NutritionID  { get; set; }
        public Nutrition Nutrition { get; set; }
    }
    public class WeightPerServing
    {
        public int WeightPerServingID { get; set; }
        public int amount { get; set; }
        public string unit { get; set; }

        public int NutritionID  { get; set; }
        public Nutrition Nutrition { get; set; }
    }
    public class AnalyzedInstruction
    {
        public int AnalyzedInstructionID { get; set; }
        public string name { get; set; }
        public List<Step> steps { get; set; }

        public int SpoonacularSearchViewModelID { get; set; }
        public SpoonacularSearchViewModel SpoonacularSearchViewModel { get; set; }
    }
    public class Step
    {
        public int StepID { get; set; }
        public int number { get; set; }
        public string step { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<Equipment> equipment { get; set; }
        public Length length { get; set; }

        public int AnalyzedInstructionID { get; set; }
        public AnalyzedInstruction AnalyzedInstruction { get; set; }
    }
    public class Equipment
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string localizedName { get; set; }
        public string image { get; set; }
        public Temperature temperature { get; set; }

        public int StepID { set; get; }
        public Step Step { get; set; }
    }
    public class Temperature
    {
        public int TemperatureID { get; set; }
        public double number { get; set; }
        public string unit { get; set; }

        public int EquipmentID { get; set; }
        public Equipment equipment { get; set; }
    }
    public class Length
    {
        public int LengthId { get; set; }
        public int number { get; set; }
        public string unit { get; set; }

        public int StepId { get; set; }
        public Step Step { get; set; }

        
    }
}
