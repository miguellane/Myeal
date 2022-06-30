# Spoonacular.Api.RecipesApi

All URIs are relative to *https://api.spoonacular.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchRecipes**](RecipesApi.md#searchrecipes) | **GET** /recipes/complexSearch | Search Recipes


<a name="searchrecipes"></a>
# **SearchRecipes**
> InlineResponse200 SearchRecipes (string? query = null, string? cuisine = null, string? excludeCuisine = null, string? diet = null, string? intolerances = null, string? equipment = null, string? includeIngredients = null, string? excludeIngredients = null, string? type = null, bool? instructionsRequired = null, bool? fillIngredients = null, bool? addRecipeInformation = null, bool? addRecipeNutrition = null, string? author = null, string? tags = null, decimal? recipeBoxId = null, string? titleMatch = null, decimal? maxReadyTime = null, bool? ignorePantry = null, string? sort = null, string? sortDirection = null, decimal? minCarbs = null, decimal? maxCarbs = null, decimal? minProtein = null, decimal? maxProtein = null, decimal? minCalories = null, decimal? maxCalories = null, decimal? minFat = null, decimal? maxFat = null, decimal? minAlcohol = null, decimal? maxAlcohol = null, decimal? minCaffeine = null, decimal? maxCaffeine = null, decimal? minCopper = null, decimal? maxCopper = null, decimal? minCalcium = null, decimal? maxCalcium = null, decimal? minCholine = null, decimal? maxCholine = null, decimal? minCholesterol = null, decimal? maxCholesterol = null, decimal? minFluoride = null, decimal? maxFluoride = null, decimal? minSaturatedFat = null, decimal? maxSaturatedFat = null, decimal? minVitaminA = null, decimal? maxVitaminA = null, decimal? minVitaminC = null, decimal? maxVitaminC = null, decimal? minVitaminD = null, decimal? maxVitaminD = null, decimal? minVitaminE = null, decimal? maxVitaminE = null, decimal? minVitaminK = null, decimal? maxVitaminK = null, decimal? minVitaminB1 = null, decimal? maxVitaminB1 = null, decimal? minVitaminB2 = null, decimal? maxVitaminB2 = null, decimal? minVitaminB5 = null, decimal? maxVitaminB5 = null, decimal? minVitaminB3 = null, decimal? maxVitaminB3 = null, decimal? minVitaminB6 = null, decimal? maxVitaminB6 = null, decimal? minVitaminB12 = null, decimal? maxVitaminB12 = null, decimal? minFiber = null, decimal? maxFiber = null, decimal? minFolate = null, decimal? maxFolate = null, decimal? minFolicAcid = null, decimal? maxFolicAcid = null, decimal? minIodine = null, decimal? maxIodine = null, decimal? minIron = null, decimal? maxIron = null, decimal? minMagnesium = null, decimal? maxMagnesium = null, decimal? minManganese = null, decimal? maxManganese = null, decimal? minPhosphorus = null, decimal? maxPhosphorus = null, decimal? minPotassium = null, decimal? maxPotassium = null, decimal? minSelenium = null, decimal? maxSelenium = null, decimal? minSodium = null, decimal? maxSodium = null, decimal? minSugar = null, decimal? maxSugar = null, decimal? minZinc = null, decimal? maxZinc = null, int? offset = null, int? number = null, bool? limitLicense = null)

Search Recipes

Search through hundreds of thousands of recipes using advanced filtering and ranking. NOTE: This method combines searching by query, by ingredients, and by nutrients into one endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class SearchRecipesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spoonacular.com";
            // Configure API key authorization: apiKeyScheme
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new RecipesApi(config);
            var query = burger;  // string? | The (natural language) search query. (optional) 
            var cuisine = italian;  // string? | The cuisine(s) of the recipes. One or more, comma separated (will be interpreted as 'OR'). See a full list of supported cuisines. (optional) 
            var excludeCuisine = greek;  // string? | The cuisine(s) the recipes must not match. One or more, comma separated (will be interpreted as 'AND'). See a full list of supported cuisines. (optional) 
            var diet = vegetarian;  // string? | The diet for which the recipes must be suitable. See a full list of supported diets. (optional) 
            var intolerances = gluten;  // string? | A comma-separated list of intolerances. All recipes returned must not contain ingredients that are not suitable for people with the intolerances entered. See a full list of supported intolerances. (optional) 
            var equipment = pan;  // string? | The equipment required. Multiple values will be interpreted as 'or'. For example, value could be \"blender, frying pan, bowl\". (optional) 
            var includeIngredients = tomato,cheese;  // string? | A comma-separated list of ingredients that should/must be used in the recipes. (optional) 
            var excludeIngredients = eggs;  // string? | A comma-separated list of ingredients or ingredient types that the recipes must not contain. (optional) 
            var type = main course;  // string? | The type of recipe. See a full list of supported meal types. (optional) 
            var instructionsRequired = true;  // bool? | Whether the recipes must have instructions. (optional) 
            var fillIngredients = false;  // bool? | Add information about the ingredients and whether they are used or missing in relation to the query. (optional) 
            var addRecipeInformation = false;  // bool? | If set to true, you get more information about the recipes returned. (optional) 
            var addRecipeNutrition = false;  // bool? | If set to true, you get nutritional information about each recipes returned. (optional) 
            var author = coffeebean;  // string? | The username of the recipe author. (optional) 
            var tags = "tags_example";  // string? | The tags (can be diets, meal types, cuisines, or intolerances) that the recipe must have. (optional) 
            var recipeBoxId = 2468;  // decimal? | The id of the recipe box to which the search should be limited to. (optional) 
            var titleMatch = Crock Pot;  // string? | Enter text that must be found in the title of the recipes. (optional) 
            var maxReadyTime = 20;  // decimal? | The maximum time in minutes it should take to prepare and cook the recipe. (optional) 
            var ignorePantry = false;  // bool? | Whether to ignore typical pantry items, such as water, salt, flour, etc. (optional)  (default to false)
            var sort = calories;  // string? | The strategy to sort recipes by. See a full list of supported sorting options. (optional) 
            var sortDirection = asc;  // string? | The direction in which to sort. Must be either 'asc' (ascending) or 'desc' (descending). (optional) 
            var minCarbs = 10;  // decimal? | The minimum amount of carbohydrates in grams the recipe must have. (optional) 
            var maxCarbs = 100;  // decimal? | The maximum amount of carbohydrates in grams the recipe can have. (optional) 
            var minProtein = 10;  // decimal? | The minimum amount of protein in grams the recipe must have. (optional) 
            var maxProtein = 100;  // decimal? | The maximum amount of protein in grams the recipe can have. (optional) 
            var minCalories = 50;  // decimal? | The minimum amount of calories the recipe must have. (optional) 
            var maxCalories = 800;  // decimal? | The maximum amount of calories the recipe can have. (optional) 
            var minFat = 1;  // decimal? | The minimum amount of fat in grams the recipe must have. (optional) 
            var maxFat = 100;  // decimal? | The maximum amount of fat in grams the recipe can have. (optional) 
            var minAlcohol = 0;  // decimal? | The minimum amount of alcohol in grams the recipe must have. (optional) 
            var maxAlcohol = 100;  // decimal? | The maximum amount of alcohol in grams the recipe can have. (optional) 
            var minCaffeine = 0;  // decimal? | The minimum amount of caffeine in milligrams the recipe must have. (optional) 
            var maxCaffeine = 100;  // decimal? | The maximum amount of caffeine in milligrams the recipe can have. (optional) 
            var minCopper = 0;  // decimal? | The minimum amount of copper in milligrams the recipe must have. (optional) 
            var maxCopper = 100;  // decimal? | The maximum amount of copper in milligrams the recipe can have. (optional) 
            var minCalcium = 0;  // decimal? | The minimum amount of calcium in milligrams the recipe must have. (optional) 
            var maxCalcium = 100;  // decimal? | The maximum amount of calcium in milligrams the recipe can have. (optional) 
            var minCholine = 0;  // decimal? | The minimum amount of choline in milligrams the recipe must have. (optional) 
            var maxCholine = 100;  // decimal? | The maximum amount of choline in milligrams the recipe can have. (optional) 
            var minCholesterol = 0;  // decimal? | The minimum amount of cholesterol in milligrams the recipe must have. (optional) 
            var maxCholesterol = 100;  // decimal? | The maximum amount of cholesterol in milligrams the recipe can have. (optional) 
            var minFluoride = 0;  // decimal? | The minimum amount of fluoride in milligrams the recipe must have. (optional) 
            var maxFluoride = 100;  // decimal? | The maximum amount of fluoride in milligrams the recipe can have. (optional) 
            var minSaturatedFat = 0;  // decimal? | The minimum amount of saturated fat in grams the recipe must have. (optional) 
            var maxSaturatedFat = 100;  // decimal? | The maximum amount of saturated fat in grams the recipe can have. (optional) 
            var minVitaminA = 0;  // decimal? | The minimum amount of Vitamin A in IU the recipe must have. (optional) 
            var maxVitaminA = 100;  // decimal? | The maximum amount of Vitamin A in IU the recipe can have. (optional) 
            var minVitaminC = 0;  // decimal? | The minimum amount of Vitamin C milligrams the recipe must have. (optional) 
            var maxVitaminC = 100;  // decimal? | The maximum amount of Vitamin C in milligrams the recipe can have. (optional) 
            var minVitaminD = 0;  // decimal? | The minimum amount of Vitamin D in micrograms the recipe must have. (optional) 
            var maxVitaminD = 100;  // decimal? | The maximum amount of Vitamin D in micrograms the recipe can have. (optional) 
            var minVitaminE = 0;  // decimal? | The minimum amount of Vitamin E in milligrams the recipe must have. (optional) 
            var maxVitaminE = 100;  // decimal? | The maximum amount of Vitamin E in milligrams the recipe can have. (optional) 
            var minVitaminK = 0;  // decimal? | The minimum amount of Vitamin K in micrograms the recipe must have. (optional) 
            var maxVitaminK = 100;  // decimal? | The maximum amount of Vitamin K in micrograms the recipe can have. (optional) 
            var minVitaminB1 = 0;  // decimal? | The minimum amount of Vitamin B1 in milligrams the recipe must have. (optional) 
            var maxVitaminB1 = 100;  // decimal? | The maximum amount of Vitamin B1 in milligrams the recipe can have. (optional) 
            var minVitaminB2 = 0;  // decimal? | The minimum amount of Vitamin B2 in milligrams the recipe must have. (optional) 
            var maxVitaminB2 = 100;  // decimal? | The maximum amount of Vitamin B2 in milligrams the recipe can have. (optional) 
            var minVitaminB5 = 0;  // decimal? | The minimum amount of Vitamin B5 in milligrams the recipe must have. (optional) 
            var maxVitaminB5 = 100;  // decimal? | The maximum amount of Vitamin B5 in milligrams the recipe can have. (optional) 
            var minVitaminB3 = 0;  // decimal? | The minimum amount of Vitamin B3 in milligrams the recipe must have. (optional) 
            var maxVitaminB3 = 100;  // decimal? | The maximum amount of Vitamin B3 in milligrams the recipe can have. (optional) 
            var minVitaminB6 = 0;  // decimal? | The minimum amount of Vitamin B6 in milligrams the recipe must have. (optional) 
            var maxVitaminB6 = 100;  // decimal? | The maximum amount of Vitamin B6 in milligrams the recipe can have. (optional) 
            var minVitaminB12 = 0;  // decimal? | The minimum amount of Vitamin B12 in micrograms the recipe must have. (optional) 
            var maxVitaminB12 = 100;  // decimal? | The maximum amount of Vitamin B12 in micrograms the recipe can have. (optional) 
            var minFiber = 0;  // decimal? | The minimum amount of fiber in grams the recipe must have. (optional) 
            var maxFiber = 100;  // decimal? | The maximum amount of fiber in grams the recipe can have. (optional) 
            var minFolate = 0;  // decimal? | The minimum amount of folate in micrograms the recipe must have. (optional) 
            var maxFolate = 100;  // decimal? | The maximum amount of folate in micrograms the recipe can have. (optional) 
            var minFolicAcid = 0;  // decimal? | The minimum amount of folic acid in micrograms the recipe must have. (optional) 
            var maxFolicAcid = 100;  // decimal? | The maximum amount of folic acid in micrograms the recipe can have. (optional) 
            var minIodine = 0;  // decimal? | The minimum amount of iodine in micrograms the recipe must have. (optional) 
            var maxIodine = 100;  // decimal? | The maximum amount of iodine in micrograms the recipe can have. (optional) 
            var minIron = 0;  // decimal? | The minimum amount of iron in milligrams the recipe must have. (optional) 
            var maxIron = 100;  // decimal? | The maximum amount of iron in milligrams the recipe can have. (optional) 
            var minMagnesium = 0;  // decimal? | The minimum amount of magnesium in milligrams the recipe must have. (optional) 
            var maxMagnesium = 100;  // decimal? | The maximum amount of magnesium in milligrams the recipe can have. (optional) 
            var minManganese = 0;  // decimal? | The minimum amount of manganese in milligrams the recipe must have. (optional) 
            var maxManganese = 100;  // decimal? | The maximum amount of manganese in milligrams the recipe can have. (optional) 
            var minPhosphorus = 0;  // decimal? | The minimum amount of phosphorus in milligrams the recipe must have. (optional) 
            var maxPhosphorus = 100;  // decimal? | The maximum amount of phosphorus in milligrams the recipe can have. (optional) 
            var minPotassium = 0;  // decimal? | The minimum amount of potassium in milligrams the recipe must have. (optional) 
            var maxPotassium = 100;  // decimal? | The maximum amount of potassium in milligrams the recipe can have. (optional) 
            var minSelenium = 0;  // decimal? | The minimum amount of selenium in micrograms the recipe must have. (optional) 
            var maxSelenium = 100;  // decimal? | The maximum amount of selenium in micrograms the recipe can have. (optional) 
            var minSodium = 0;  // decimal? | The minimum amount of sodium in milligrams the recipe must have. (optional) 
            var maxSodium = 100;  // decimal? | The maximum amount of sodium in milligrams the recipe can have. (optional) 
            var minSugar = 0;  // decimal? | The minimum amount of sugar in grams the recipe must have. (optional) 
            var maxSugar = 100;  // decimal? | The maximum amount of sugar in grams the recipe can have. (optional) 
            var minZinc = 0;  // decimal? | The minimum amount of zinc in milligrams the recipe must have. (optional) 
            var maxZinc = 100;  // decimal? | The maximum amount of zinc in milligrams the recipe can have. (optional) 
            var offset = 56;  // int? | The number of results to skip (between 0 and 900). (optional) 
            var number = 10;  // int? | The maximum number of items to return (between 1 and 100). Defaults to 10. (optional)  (default to 10)
            var limitLicense = true;  // bool? | Whether the recipes should have an open license that allows display with proper attribution. (optional)  (default to true)

            try
            {
                // Search Recipes
                InlineResponse200 result = apiInstance.SearchRecipes(query, cuisine, excludeCuisine, diet, intolerances, equipment, includeIngredients, excludeIngredients, type, instructionsRequired, fillIngredients, addRecipeInformation, addRecipeNutrition, author, tags, recipeBoxId, titleMatch, maxReadyTime, ignorePantry, sort, sortDirection, minCarbs, maxCarbs, minProtein, maxProtein, minCalories, maxCalories, minFat, maxFat, minAlcohol, maxAlcohol, minCaffeine, maxCaffeine, minCopper, maxCopper, minCalcium, maxCalcium, minCholine, maxCholine, minCholesterol, maxCholesterol, minFluoride, maxFluoride, minSaturatedFat, maxSaturatedFat, minVitaminA, maxVitaminA, minVitaminC, maxVitaminC, minVitaminD, maxVitaminD, minVitaminE, maxVitaminE, minVitaminK, maxVitaminK, minVitaminB1, maxVitaminB1, minVitaminB2, maxVitaminB2, minVitaminB5, maxVitaminB5, minVitaminB3, maxVitaminB3, minVitaminB6, maxVitaminB6, minVitaminB12, maxVitaminB12, minFiber, maxFiber, minFolate, maxFolate, minFolicAcid, maxFolicAcid, minIodine, maxIodine, minIron, maxIron, minMagnesium, maxMagnesium, minManganese, maxManganese, minPhosphorus, maxPhosphorus, minPotassium, maxPotassium, minSelenium, maxSelenium, minSodium, maxSodium, minSugar, maxSugar, minZinc, maxZinc, offset, number, limitLicense);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.SearchRecipes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string?**| The (natural language) search query. | [optional] 
 **cuisine** | **string?**| The cuisine(s) of the recipes. One or more, comma separated (will be interpreted as &#39;OR&#39;). See a full list of supported cuisines. | [optional] 
 **excludeCuisine** | **string?**| The cuisine(s) the recipes must not match. One or more, comma separated (will be interpreted as &#39;AND&#39;). See a full list of supported cuisines. | [optional] 
 **diet** | **string?**| The diet for which the recipes must be suitable. See a full list of supported diets. | [optional] 
 **intolerances** | **string?**| A comma-separated list of intolerances. All recipes returned must not contain ingredients that are not suitable for people with the intolerances entered. See a full list of supported intolerances. | [optional] 
 **equipment** | **string?**| The equipment required. Multiple values will be interpreted as &#39;or&#39;. For example, value could be \&quot;blender, frying pan, bowl\&quot;. | [optional] 
 **includeIngredients** | **string?**| A comma-separated list of ingredients that should/must be used in the recipes. | [optional] 
 **excludeIngredients** | **string?**| A comma-separated list of ingredients or ingredient types that the recipes must not contain. | [optional] 
 **type** | **string?**| The type of recipe. See a full list of supported meal types. | [optional] 
 **instructionsRequired** | **bool?**| Whether the recipes must have instructions. | [optional] 
 **fillIngredients** | **bool?**| Add information about the ingredients and whether they are used or missing in relation to the query. | [optional] 
 **addRecipeInformation** | **bool?**| If set to true, you get more information about the recipes returned. | [optional] 
 **addRecipeNutrition** | **bool?**| If set to true, you get nutritional information about each recipes returned. | [optional] 
 **author** | **string?**| The username of the recipe author. | [optional] 
 **tags** | **string?**| The tags (can be diets, meal types, cuisines, or intolerances) that the recipe must have. | [optional] 
 **recipeBoxId** | **decimal?**| The id of the recipe box to which the search should be limited to. | [optional] 
 **titleMatch** | **string?**| Enter text that must be found in the title of the recipes. | [optional] 
 **maxReadyTime** | **decimal?**| The maximum time in minutes it should take to prepare and cook the recipe. | [optional] 
 **ignorePantry** | **bool?**| Whether to ignore typical pantry items, such as water, salt, flour, etc. | [optional] [default to false]
 **sort** | **string?**| The strategy to sort recipes by. See a full list of supported sorting options. | [optional] 
 **sortDirection** | **string?**| The direction in which to sort. Must be either &#39;asc&#39; (ascending) or &#39;desc&#39; (descending). | [optional] 
 **minCarbs** | **decimal?**| The minimum amount of carbohydrates in grams the recipe must have. | [optional] 
 **maxCarbs** | **decimal?**| The maximum amount of carbohydrates in grams the recipe can have. | [optional] 
 **minProtein** | **decimal?**| The minimum amount of protein in grams the recipe must have. | [optional] 
 **maxProtein** | **decimal?**| The maximum amount of protein in grams the recipe can have. | [optional] 
 **minCalories** | **decimal?**| The minimum amount of calories the recipe must have. | [optional] 
 **maxCalories** | **decimal?**| The maximum amount of calories the recipe can have. | [optional] 
 **minFat** | **decimal?**| The minimum amount of fat in grams the recipe must have. | [optional] 
 **maxFat** | **decimal?**| The maximum amount of fat in grams the recipe can have. | [optional] 
 **minAlcohol** | **decimal?**| The minimum amount of alcohol in grams the recipe must have. | [optional] 
 **maxAlcohol** | **decimal?**| The maximum amount of alcohol in grams the recipe can have. | [optional] 
 **minCaffeine** | **decimal?**| The minimum amount of caffeine in milligrams the recipe must have. | [optional] 
 **maxCaffeine** | **decimal?**| The maximum amount of caffeine in milligrams the recipe can have. | [optional] 
 **minCopper** | **decimal?**| The minimum amount of copper in milligrams the recipe must have. | [optional] 
 **maxCopper** | **decimal?**| The maximum amount of copper in milligrams the recipe can have. | [optional] 
 **minCalcium** | **decimal?**| The minimum amount of calcium in milligrams the recipe must have. | [optional] 
 **maxCalcium** | **decimal?**| The maximum amount of calcium in milligrams the recipe can have. | [optional] 
 **minCholine** | **decimal?**| The minimum amount of choline in milligrams the recipe must have. | [optional] 
 **maxCholine** | **decimal?**| The maximum amount of choline in milligrams the recipe can have. | [optional] 
 **minCholesterol** | **decimal?**| The minimum amount of cholesterol in milligrams the recipe must have. | [optional] 
 **maxCholesterol** | **decimal?**| The maximum amount of cholesterol in milligrams the recipe can have. | [optional] 
 **minFluoride** | **decimal?**| The minimum amount of fluoride in milligrams the recipe must have. | [optional] 
 **maxFluoride** | **decimal?**| The maximum amount of fluoride in milligrams the recipe can have. | [optional] 
 **minSaturatedFat** | **decimal?**| The minimum amount of saturated fat in grams the recipe must have. | [optional] 
 **maxSaturatedFat** | **decimal?**| The maximum amount of saturated fat in grams the recipe can have. | [optional] 
 **minVitaminA** | **decimal?**| The minimum amount of Vitamin A in IU the recipe must have. | [optional] 
 **maxVitaminA** | **decimal?**| The maximum amount of Vitamin A in IU the recipe can have. | [optional] 
 **minVitaminC** | **decimal?**| The minimum amount of Vitamin C milligrams the recipe must have. | [optional] 
 **maxVitaminC** | **decimal?**| The maximum amount of Vitamin C in milligrams the recipe can have. | [optional] 
 **minVitaminD** | **decimal?**| The minimum amount of Vitamin D in micrograms the recipe must have. | [optional] 
 **maxVitaminD** | **decimal?**| The maximum amount of Vitamin D in micrograms the recipe can have. | [optional] 
 **minVitaminE** | **decimal?**| The minimum amount of Vitamin E in milligrams the recipe must have. | [optional] 
 **maxVitaminE** | **decimal?**| The maximum amount of Vitamin E in milligrams the recipe can have. | [optional] 
 **minVitaminK** | **decimal?**| The minimum amount of Vitamin K in micrograms the recipe must have. | [optional] 
 **maxVitaminK** | **decimal?**| The maximum amount of Vitamin K in micrograms the recipe can have. | [optional] 
 **minVitaminB1** | **decimal?**| The minimum amount of Vitamin B1 in milligrams the recipe must have. | [optional] 
 **maxVitaminB1** | **decimal?**| The maximum amount of Vitamin B1 in milligrams the recipe can have. | [optional] 
 **minVitaminB2** | **decimal?**| The minimum amount of Vitamin B2 in milligrams the recipe must have. | [optional] 
 **maxVitaminB2** | **decimal?**| The maximum amount of Vitamin B2 in milligrams the recipe can have. | [optional] 
 **minVitaminB5** | **decimal?**| The minimum amount of Vitamin B5 in milligrams the recipe must have. | [optional] 
 **maxVitaminB5** | **decimal?**| The maximum amount of Vitamin B5 in milligrams the recipe can have. | [optional] 
 **minVitaminB3** | **decimal?**| The minimum amount of Vitamin B3 in milligrams the recipe must have. | [optional] 
 **maxVitaminB3** | **decimal?**| The maximum amount of Vitamin B3 in milligrams the recipe can have. | [optional] 
 **minVitaminB6** | **decimal?**| The minimum amount of Vitamin B6 in milligrams the recipe must have. | [optional] 
 **maxVitaminB6** | **decimal?**| The maximum amount of Vitamin B6 in milligrams the recipe can have. | [optional] 
 **minVitaminB12** | **decimal?**| The minimum amount of Vitamin B12 in micrograms the recipe must have. | [optional] 
 **maxVitaminB12** | **decimal?**| The maximum amount of Vitamin B12 in micrograms the recipe can have. | [optional] 
 **minFiber** | **decimal?**| The minimum amount of fiber in grams the recipe must have. | [optional] 
 **maxFiber** | **decimal?**| The maximum amount of fiber in grams the recipe can have. | [optional] 
 **minFolate** | **decimal?**| The minimum amount of folate in micrograms the recipe must have. | [optional] 
 **maxFolate** | **decimal?**| The maximum amount of folate in micrograms the recipe can have. | [optional] 
 **minFolicAcid** | **decimal?**| The minimum amount of folic acid in micrograms the recipe must have. | [optional] 
 **maxFolicAcid** | **decimal?**| The maximum amount of folic acid in micrograms the recipe can have. | [optional] 
 **minIodine** | **decimal?**| The minimum amount of iodine in micrograms the recipe must have. | [optional] 
 **maxIodine** | **decimal?**| The maximum amount of iodine in micrograms the recipe can have. | [optional] 
 **minIron** | **decimal?**| The minimum amount of iron in milligrams the recipe must have. | [optional] 
 **maxIron** | **decimal?**| The maximum amount of iron in milligrams the recipe can have. | [optional] 
 **minMagnesium** | **decimal?**| The minimum amount of magnesium in milligrams the recipe must have. | [optional] 
 **maxMagnesium** | **decimal?**| The maximum amount of magnesium in milligrams the recipe can have. | [optional] 
 **minManganese** | **decimal?**| The minimum amount of manganese in milligrams the recipe must have. | [optional] 
 **maxManganese** | **decimal?**| The maximum amount of manganese in milligrams the recipe can have. | [optional] 
 **minPhosphorus** | **decimal?**| The minimum amount of phosphorus in milligrams the recipe must have. | [optional] 
 **maxPhosphorus** | **decimal?**| The maximum amount of phosphorus in milligrams the recipe can have. | [optional] 
 **minPotassium** | **decimal?**| The minimum amount of potassium in milligrams the recipe must have. | [optional] 
 **maxPotassium** | **decimal?**| The maximum amount of potassium in milligrams the recipe can have. | [optional] 
 **minSelenium** | **decimal?**| The minimum amount of selenium in micrograms the recipe must have. | [optional] 
 **maxSelenium** | **decimal?**| The maximum amount of selenium in micrograms the recipe can have. | [optional] 
 **minSodium** | **decimal?**| The minimum amount of sodium in milligrams the recipe must have. | [optional] 
 **maxSodium** | **decimal?**| The maximum amount of sodium in milligrams the recipe can have. | [optional] 
 **minSugar** | **decimal?**| The minimum amount of sugar in grams the recipe must have. | [optional] 
 **maxSugar** | **decimal?**| The maximum amount of sugar in grams the recipe can have. | [optional] 
 **minZinc** | **decimal?**| The minimum amount of zinc in milligrams the recipe must have. | [optional] 
 **maxZinc** | **decimal?**| The maximum amount of zinc in milligrams the recipe can have. | [optional] 
 **offset** | **int?**| The number of results to skip (between 0 and 900). | [optional] 
 **number** | **int?**| The maximum number of items to return (between 1 and 100). Defaults to 10. | [optional] [default to 10]
 **limitLicense** | **bool?**| Whether the recipes should have an open license that allows display with proper attribution. | [optional] [default to true]

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[apiKeyScheme](../README.md#apiKeyScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

