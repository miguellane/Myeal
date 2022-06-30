using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Myeal.Models
{
    public class RecipeSearchFormModel
    {
		[Key]
		public int Id { get; set; }
        [Required]
		public string query { get; set; }
		//public string? cuisine { get; set; } = null;
		public Cuisines cuisines { get; set; } = Cuisines.None;
		//public string? excludeCuisine { get; set; } = null;
		public Cuisines excludeCuisines { get; set; } = Cuisines.None;
		//public string? diet { get; set; } = null;
		public Diets diets { get; set; } = Diets.None;
		//public string? intolerances { get; set; } = null;
		public Intolerances intolerances { get; set; } = Intolerances.None;
		public string? equipment { get; set; } = null;
		public string? includeIngredients { get; set; } = null;
		public string? excludeIngredients { get; set; } = null;
		//public string? type { get; set; } = null;
		public Types types { get; set; } = Types.None;
		public bool instructionsRequired { get; set; } = true;
		public bool fillIngredients { get; set; } = false;
		public bool addRecipeInformation { get; set; } = true;
		public bool addRecipeNutrition { get; set; } = true;
		public string? author { get; set; } = null;
		public string? tags { get; set; } = null;
		public decimal? recipeBoxId { get; set; } = null;
		public string? titleMatch { get; set; } = null;
		public decimal? maxReadyTime { get; set; } = null;
		public bool? ignorePantry { get; set; } = true;
		//public string sort { get; set; } = "calories";
		public Sorts sorts { get; set; }
		public string sortDirection { get; set; } = "desc";
		public decimal? minCarbs { get; set; } = null; public decimal? maxCarbs { get; set; } = null;
		public decimal? minProtein { get; set; } = null; public decimal? maxProtein { get; set; } = null; 
		public decimal? minCalories { get; set; } = null; public decimal? maxCalories { get; set; } = null; 
		public decimal? minFat { get; set; } = null; public decimal? maxFat { get; set; } = null; 
		public decimal? minAlcohol { get; set; } = null; public decimal? maxAlcohol { get; set; } = null; 
		public decimal? minCaffeine { get; set; } = null; public decimal? maxCaffeine { get; set; } = null; 
		public decimal? minCopper { get; set; } = null; public decimal? maxCopper { get; set; } = null; 
		public decimal? minCalcium { get; set; } = null; public decimal? maxCalcium { get; set; } = null; 
		public decimal? minCholine { get; set; } = null; public decimal? maxCholine { get; set; } = null; 
		public decimal? minCholesterol { get; set; } = null; public decimal? maxCholesterol { get; set; } = null; 
		public decimal? minFluoride { get; set; } = null; public decimal? maxFluoride { get; set; } = null; 
		public decimal? minSaturatedFat { get; set; } = null; public decimal? maxSaturatedFat { get; set; } = null; 
		public decimal? minA { get; set; } = null; public decimal? maxVitaminA { get; set; } = null; 
		public decimal? minC { get; set; } = null; public decimal? maxVitaminC { get; set; } = null; 
		public decimal? minD { get; set; } = null; public decimal? maxVitaminD { get; set; } = null; 
		public decimal? minE { get; set; } = null; public decimal? maxVitaminE { get; set; } = null; 
		public decimal? minK { get; set; } = null; public decimal? maxVitaminK { get; set; } = null; 
		public decimal? minB1 { get; set; } = null; public decimal? maxVitaminB1 { get; set; } = null; 
		public decimal? minB2 { get; set; } = null; public decimal? maxVitaminB2 { get; set; } = null; 
		public decimal? minB5 { get; set; } = null; public decimal? maxVitaminB5 { get; set; } = null; 
		public decimal? minB3 { get; set; } = null; public decimal? maxVitaminB3 { get; set; } = null; 
		public decimal? minB6 { get; set; } = null; public decimal? maxVitaminB6 { get; set; } = null; 
		public decimal? minB12 { get; set; } = null; public decimal? maxVitaminB12 { get; set; } = null; 
		public decimal? minFiber { get; set; } = null; public decimal? maxFiber { get; set; } = null; 
		public decimal? minFolate { get; set; } = null; public decimal? maxFolate { get; set; } = null; 
		public decimal? minFolicAcid { get; set; } = null; public decimal? maxFolicAcid { get; set; } = null; 
		public decimal? minIodine { get; set; } = null; public decimal? maxIodine { get; set; } = null; 
		public decimal? minIron { get; set; } = null; public decimal? maxIron { get; set; } = null; 
		public decimal? minMagnesium { get; set; } = null; public decimal? maxMagnesium { get; set; } = null; 
		public decimal? minManganese { get; set; } = null; public decimal? maxManganese { get; set; } = null; 
		public decimal? minPhosphorus { get; set; } = null; public decimal? maxPhosphorus { get; set; } = null; 
		public decimal? minPotassium { get; set; } = null; public decimal? maxPotassium { get; set; } = null; 
		public decimal? minSelenium { get; set; } = null; public decimal? maxSelenium { get; set; } = null; 
		public decimal? minSodium { get; set; } = null; public decimal? maxSodium { get; set; } = null; 
		public decimal? minSugar { get; set; } = null; public decimal? maxSugar { get; set; } = null; 
		public decimal? minZinc{ get; set; } = null; public decimal? maxZinc { get; set; } = null;
		public int offset { get; set; } = 0;
		public int number { get; set; } = 10;
		public bool? limitLicense { get; set; } = true;

	}

	//[Flags]
	public enum Cuisines
	{
		None = 0,
		[Description("African")]
		African = 1,
		[Description("American")]
		American = 2,
		[Description("British")]
		British = 4,
		[Description("Cajun")]
		Cajun = 8,
		[Description("Caribbean")]
		Caribbean = 16,
		[Description("Chinese")]
		Chinese = 32,
		[Description("Eastern European")]
		Eastern_European = 64,
		[Description("European")]
		European = 128,
		[Description("French")]
		French = 256,
		[Description("German")]
		German = 512,
		[Description("Greek")]
		Greek = 1024,
		[Description("Indian")]
		Indian = 2048,
		[Description("Irish")]
		Irish = 4096,
		[Description("Italian")]
		Italian = 8192,
		[Description("Japanese")]
		Japanese = 16384,
		[Description("Jewish")]
		Jewish = 32768,
		[Description("Korean")]
		Korean = 65536,
		[Description("Latin American")]
		Latin_American = 131072,
		[Description("Mediterranean")]
		Mediterranean = 262144,
		[Description("Mexican")]
		Mexican = 524288,
		[Description("Middle Eastern")]
		Middle_Eastern = 1048576,
		[Description("Nordic")]
		Nordic = 2097152,
		[Description("Southern")]
		Southern = 4194304,
		[Description("Spanish")]
		Spanish = 8388608,
		[Description("Thai")]
		Thai = 16777216,
		[Description("Vietnamese")]
		Vietnamese = 33554432
	}
	public enum Diets
	{
		None = 0,
		[Description("Gluten Free")]
		Gluten_Free = 1,
		[Description("Ketogenic")]
		Ketogenic = 2,
		[Description("Vegatarian")]
		Vegatarian = 4,
		[Description("Lacto Vegatarian")]
		Lacto_Vegatarian = 8,
		[Description("Ovo Vegatarian")]
		Ovo_Vegatarian = 16,
		[Description("Vegan")]
		Vegan = 32,
		[Description("Pescatarian")]
		Pescatarian = 64,
		[Description("Paleo")]
		Paleo = 128,
		[Description("Primal")]
		Primal = 256,
		[Description("Low FODMAP")]
		Low_FODMAP = 512,
		[Description("Whole30")]
		Whole30 = 1024
	}
	//[Flags]
	public enum Intolerances
	{
		None = 0,
		[Description("Dairy")]
		Dairy = 1,
		[Description("Egg")]
		Egg = 2,
		[Description("Gluten")]
		Gluten = 4,
		[Description("Grain")]
		Grain = 8,
		[Description("Peanut")]
		Peanut = 16,
		[Description("Seafood")]
		Seafood = 32,
		[Description("Sesame")]
		Sesame = 64,
		[Description("Shellfish")]
		Shellfish = 128,
		[Description("Soy")]
		Soy = 256,
		[Description("Sulfite")]
		Sulfite = 512,
		[Description("Tree Nut")]
		Tree_Nut = 1024,
		[Description("Wheat")]
		Wheat = 2048
	}
	public enum Types
	{
		None = 0,
		[Description("main course")]
		main_course = 1,
		[Description("side dish")]
		side_dish = 2,
		[Description("dessert")]
		dessert = 4,
		[Description("appetizer")]
		appetizer = 8,
		[Description("salad")]
		salad = 16,
		[Description("bread")]
		bread = 32,
		[Description("breakfast")]
		breakfast = 64,
		[Description("soup")]
		soup = 128,
		[Description("beverage")]
		beverage = 256,
		[Description("sauce")]
		sauce = 512,
		[Description("marinade")]
		marinade = 1024,
		[Description("fingerfood")]
		fingerfood = 2048,
		[Description("snack")]
		snack = 4096,
		[Description("drink")]
		drink = 8192
	}
	public enum Sorts
	{

		[Description("meta-score")]
		meta_score,
		[Description("popularity")]
		popularity,
		[Description("healthiness")]
		healthiness,
		[Description("price")]
		price,
		[Description("time")]
		time,
		[Description("random")]
		random,
		[Description("max-used-ingredients")]
		max_used_ingredients,
		[Description("min-missing-ingredients")]
		min_missing_ingredients,
		[Description("alcohol")]
		alcohol,
		[Description("caffeine")]
		caffeine,
		[Description("copper")]
		copper,
		[Description("energy")]
		energy,
		[Description("calories")]
		calories,
		[Description("calcium")]
		calcium,
		[Description("carbohydrates")]
		carbohydrates,
		[Description("carbs")]
		carbs,
		[Description("choline")]
		choline,
		[Description("cholesterol")]
		cholesterol,
		[Description("total-fat")]
		total_fat,
		[Description("fluoride")]
		fluoride,
		[Description("trans-fat")]
		trans_fat,
		[Description("saturated-fat")]
		saturated_fat,
		[Description("mono-unsaturated-fat")]
		mono_unsaturated_fat,
		[Description("poly-unsaturated-fat")]
		poly_unsaturated_fat,
		[Description("fiber")]
		fiber,
		[Description("folate")]
		folate,
		[Description("folic-acid")]
		folic_acid,
		[Description("iodine")]
		iodine,
		[Description("iron")]
		iron,
		[Description("magnesium")]
		magnesium,
		[Description("manganese")]
		manganese,
		[Description("vitamin-b3")]
		vitamin_b3,
		[Description("niacin")]
		niacin,
		[Description("vitamin-b5")]
		vitamin_b5,
		[Description("pantothenic-acid")]
		pantothenic_acid,
		[Description("phosphorus")]
		phosphorus,
		[Description("potassium")]
		potassium,
		[Description("protein")]
		protein,
		[Description("vitamin-b2")]
		vitamin_b2,
		[Description("riboflavin")]
		riboflavin,
		[Description("selenium")]
		selenium,
		[Description("sodium")]
		sodium,
		[Description("vitamin-b1")]
		vitamin_b1,
		[Description("thiamin")]
		thiamin,
		[Description("vitamin-a")]
		vitamin_a,
		[Description("vitamin-b6")]
		vitamin_b6,
		[Description("vitamin-b12")]
		vitamin_b12,
		[Description("vitamin-c")]
		vitamin_c,
		[Description("vitamin-d")]
		vitamin_d,
		[Description("vitamin-e")]
		vitamin_e,
		[Description("vitamin-k")]
		vitamin_k,
		[Description("sugar")]
		sugar,
		[Description("zinc")]
		zinc
	}

}
