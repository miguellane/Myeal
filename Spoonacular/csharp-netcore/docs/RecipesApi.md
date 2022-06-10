# Spoonacular.Api.RecipesApi

All URIs are relative to *https://api.spoonacular.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAnalyzedRecipeInstructions**](RecipesApi.md#getanalyzedrecipeinstructions) | **GET** /recipes/{id}/analyzedInstructions | Get Analyzed Recipe Instructions
[**GetRecipeInformation**](RecipesApi.md#getrecipeinformation) | **GET** /recipes/{id}/information | Get Recipe Information
[**RecipeNutritionLabelImage**](RecipesApi.md#recipenutritionlabelimage) | **GET** /recipes/{id}/nutritionLabel.png | Recipe Nutrition Label Image
[**RecipeNutritionLabelWidget**](RecipesApi.md#recipenutritionlabelwidget) | **GET** /recipes/{id}/nutritionLabel | Recipe Nutrition Label Widget
[**SearchRecipes**](RecipesApi.md#searchrecipes) | **GET** /recipes/complexSearch | Search Recipes
[**SearchRecipesByIngredients**](RecipesApi.md#searchrecipesbyingredients) | **GET** /recipes/findByIngredients | Search Recipes by Ingredients
[**SearchRecipesByNutrients**](RecipesApi.md#searchrecipesbynutrients) | **GET** /recipes/findByNutrients | Search Recipes by Nutrients
[**SummarizeRecipe**](RecipesApi.md#summarizerecipe) | **GET** /recipes/{id}/summary | Summarize Recipe


<a name="getanalyzedrecipeinstructions"></a>
# **GetAnalyzedRecipeInstructions**
> InlineResponse2004 GetAnalyzedRecipeInstructions (int id, bool? stepBreakdown = null)

Get Analyzed Recipe Instructions

Get an analyzed breakdown of a recipe's instructions. Each step is enriched with the ingredients and equipment required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class GetAnalyzedRecipeInstructionsExample
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
            var id = 1;  // int | The item's id.
            var stepBreakdown = true;  // bool? | Whether to break down the recipe steps even more. (optional) 

            try
            {
                // Get Analyzed Recipe Instructions
                InlineResponse2004 result = apiInstance.GetAnalyzedRecipeInstructions(id, stepBreakdown);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.GetAnalyzedRecipeInstructions: " + e.Message );
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
 **id** | **int**| The item&#39;s id. | 
 **stepBreakdown** | **bool?**| Whether to break down the recipe steps even more. | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

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

<a name="getrecipeinformation"></a>
# **GetRecipeInformation**
> InlineResponse2003 GetRecipeInformation (int id, bool? includeNutrition = null)

Get Recipe Information

Use a recipe id to get full information about a recipe, such as ingredients, nutrition, diet and allergen information, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class GetRecipeInformationExample
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
            var id = 1;  // int | The item's id.
            var includeNutrition = false;  // bool? | Include nutrition data in the recipe information. Nutrition data is per serving. If you want the nutrition data for the entire recipe, just multiply by the number of servings. (optional)  (default to false)

            try
            {
                // Get Recipe Information
                InlineResponse2003 result = apiInstance.GetRecipeInformation(id, includeNutrition);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.GetRecipeInformation: " + e.Message );
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
 **id** | **int**| The item&#39;s id. | 
 **includeNutrition** | **bool?**| Include nutrition data in the recipe information. Nutrition data is per serving. If you want the nutrition data for the entire recipe, just multiply by the number of servings. | [optional] [default to false]

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

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

<a name="recipenutritionlabelimage"></a>
# **RecipeNutritionLabelImage**
> Object RecipeNutritionLabelImage (decimal id, bool? showOptionalNutrients = null, bool? showZeroValues = null, bool? showIngredients = null)

Recipe Nutrition Label Image

Get a recipe's nutrition label as an image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class RecipeNutritionLabelImageExample
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
            var id = 641166;  // decimal | The recipe id.
            var showOptionalNutrients = false;  // bool? | Whether to show optional nutrients. (optional) 
            var showZeroValues = false;  // bool? | Whether to show zero values. (optional) 
            var showIngredients = false;  // bool? | Whether to show a list of ingredients. (optional) 

            try
            {
                // Recipe Nutrition Label Image
                Object result = apiInstance.RecipeNutritionLabelImage(id, showOptionalNutrients, showZeroValues, showIngredients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.RecipeNutritionLabelImage: " + e.Message );
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
 **id** | **decimal**| The recipe id. | 
 **showOptionalNutrients** | **bool?**| Whether to show optional nutrients. | [optional] 
 **showZeroValues** | **bool?**| Whether to show zero values. | [optional] 
 **showIngredients** | **bool?**| Whether to show a list of ingredients. | [optional] 

### Return type

**Object**

### Authorization

[apiKeyScheme](../README.md#apiKeyScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipenutritionlabelwidget"></a>
# **RecipeNutritionLabelWidget**
> string RecipeNutritionLabelWidget (decimal id, bool? defaultCss = null, bool? showOptionalNutrients = null, bool? showZeroValues = null, bool? showIngredients = null)

Recipe Nutrition Label Widget

Get a recipe's nutrition label as an HTML widget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class RecipeNutritionLabelWidgetExample
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
            var id = 641166;  // decimal | The recipe id.
            var defaultCss = false;  // bool? | Whether the default CSS should be added to the response. (optional)  (default to true)
            var showOptionalNutrients = false;  // bool? | Whether to show optional nutrients. (optional) 
            var showZeroValues = false;  // bool? | Whether to show zero values. (optional) 
            var showIngredients = false;  // bool? | Whether to show a list of ingredients. (optional) 

            try
            {
                // Recipe Nutrition Label Widget
                string result = apiInstance.RecipeNutritionLabelWidget(id, defaultCss, showOptionalNutrients, showZeroValues, showIngredients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.RecipeNutritionLabelWidget: " + e.Message );
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
 **id** | **decimal**| The recipe id. | 
 **defaultCss** | **bool?**| Whether the default CSS should be added to the response. | [optional] [default to true]
 **showOptionalNutrients** | **bool?**| Whether to show optional nutrients. | [optional] 
 **showZeroValues** | **bool?**| Whether to show zero values. | [optional] 
 **showIngredients** | **bool?**| Whether to show a list of ingredients. | [optional] 

### Return type

**string**

### Authorization

[apiKeyScheme](../README.md#apiKeyScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="searchrecipesbyingredients"></a>
# **SearchRecipesByIngredients**
> List&lt;InlineResponse2001&gt; SearchRecipesByIngredients (string? ingredients = null, int? number = null, bool? limitLicense = null, decimal? ranking = null, bool? ignorePantry = null)

Search Recipes by Ingredients

 Ever wondered what recipes you can cook with the ingredients you have in your fridge or pantry? This endpoint lets you find recipes that either maximize the usage of ingredients you have at hand (pre shopping) or minimize the ingredients that you don't currently have (post shopping).         

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class SearchRecipesByIngredientsExample
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
            var ingredients = carrots,tomatoes;  // string? | A comma-separated list of ingredients that the recipes should contain. (optional) 
            var number = 10;  // int? | The maximum number of items to return (between 1 and 100). Defaults to 10. (optional)  (default to 10)
            var limitLicense = true;  // bool? | Whether the recipes should have an open license that allows display with proper attribution. (optional)  (default to true)
            var ranking = 1;  // decimal? | Whether to maximize used ingredients (1) or minimize missing ingredients (2) first. (optional) 
            var ignorePantry = false;  // bool? | Whether to ignore typical pantry items, such as water, salt, flour, etc. (optional)  (default to false)

            try
            {
                // Search Recipes by Ingredients
                List<InlineResponse2001> result = apiInstance.SearchRecipesByIngredients(ingredients, number, limitLicense, ranking, ignorePantry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.SearchRecipesByIngredients: " + e.Message );
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
 **ingredients** | **string?**| A comma-separated list of ingredients that the recipes should contain. | [optional] 
 **number** | **int?**| The maximum number of items to return (between 1 and 100). Defaults to 10. | [optional] [default to 10]
 **limitLicense** | **bool?**| Whether the recipes should have an open license that allows display with proper attribution. | [optional] [default to true]
 **ranking** | **decimal?**| Whether to maximize used ingredients (1) or minimize missing ingredients (2) first. | [optional] 
 **ignorePantry** | **bool?**| Whether to ignore typical pantry items, such as water, salt, flour, etc. | [optional] [default to false]

### Return type

[**List&lt;InlineResponse2001&gt;**](InlineResponse2001.md)

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

<a name="searchrecipesbynutrients"></a>
# **SearchRecipesByNutrients**
> List&lt;InlineResponse2002&gt; SearchRecipesByNutrients (decimal? minCarbs = null, decimal? maxCarbs = null, decimal? minProtein = null, decimal? maxProtein = null, decimal? minCalories = null, decimal? maxCalories = null, decimal? minFat = null, decimal? maxFat = null, decimal? minAlcohol = null, decimal? maxAlcohol = null, decimal? minCaffeine = null, decimal? maxCaffeine = null, decimal? minCopper = null, decimal? maxCopper = null, decimal? minCalcium = null, decimal? maxCalcium = null, decimal? minCholine = null, decimal? maxCholine = null, decimal? minCholesterol = null, decimal? maxCholesterol = null, decimal? minFluoride = null, decimal? maxFluoride = null, decimal? minSaturatedFat = null, decimal? maxSaturatedFat = null, decimal? minVitaminA = null, decimal? maxVitaminA = null, decimal? minVitaminC = null, decimal? maxVitaminC = null, decimal? minVitaminD = null, decimal? maxVitaminD = null, decimal? minVitaminE = null, decimal? maxVitaminE = null, decimal? minVitaminK = null, decimal? maxVitaminK = null, decimal? minVitaminB1 = null, decimal? maxVitaminB1 = null, decimal? minVitaminB2 = null, decimal? maxVitaminB2 = null, decimal? minVitaminB5 = null, decimal? maxVitaminB5 = null, decimal? minVitaminB3 = null, decimal? maxVitaminB3 = null, decimal? minVitaminB6 = null, decimal? maxVitaminB6 = null, decimal? minVitaminB12 = null, decimal? maxVitaminB12 = null, decimal? minFiber = null, decimal? maxFiber = null, decimal? minFolate = null, decimal? maxFolate = null, decimal? minFolicAcid = null, decimal? maxFolicAcid = null, decimal? minIodine = null, decimal? maxIodine = null, decimal? minIron = null, decimal? maxIron = null, decimal? minMagnesium = null, decimal? maxMagnesium = null, decimal? minManganese = null, decimal? maxManganese = null, decimal? minPhosphorus = null, decimal? maxPhosphorus = null, decimal? minPotassium = null, decimal? maxPotassium = null, decimal? minSelenium = null, decimal? maxSelenium = null, decimal? minSodium = null, decimal? maxSodium = null, decimal? minSugar = null, decimal? maxSugar = null, decimal? minZinc = null, decimal? maxZinc = null, int? offset = null, int? number = null, bool? random = null, bool? limitLicense = null)

Search Recipes by Nutrients

Find a set of recipes that adhere to the given nutritional limits. You may set limits for macronutrients (calories, protein, fat, and carbohydrate) and/or many micronutrients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class SearchRecipesByNutrientsExample
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
            var minVitaminC = 0;  // decimal? | The minimum amount of Vitamin C in milligrams the recipe must have. (optional) 
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
            var random = false;  // bool? | If true, every request will give you a random set of recipes within the requested limits. (optional) 
            var limitLicense = true;  // bool? | Whether the recipes should have an open license that allows display with proper attribution. (optional)  (default to true)

            try
            {
                // Search Recipes by Nutrients
                List<InlineResponse2002> result = apiInstance.SearchRecipesByNutrients(minCarbs, maxCarbs, minProtein, maxProtein, minCalories, maxCalories, minFat, maxFat, minAlcohol, maxAlcohol, minCaffeine, maxCaffeine, minCopper, maxCopper, minCalcium, maxCalcium, minCholine, maxCholine, minCholesterol, maxCholesterol, minFluoride, maxFluoride, minSaturatedFat, maxSaturatedFat, minVitaminA, maxVitaminA, minVitaminC, maxVitaminC, minVitaminD, maxVitaminD, minVitaminE, maxVitaminE, minVitaminK, maxVitaminK, minVitaminB1, maxVitaminB1, minVitaminB2, maxVitaminB2, minVitaminB5, maxVitaminB5, minVitaminB3, maxVitaminB3, minVitaminB6, maxVitaminB6, minVitaminB12, maxVitaminB12, minFiber, maxFiber, minFolate, maxFolate, minFolicAcid, maxFolicAcid, minIodine, maxIodine, minIron, maxIron, minMagnesium, maxMagnesium, minManganese, maxManganese, minPhosphorus, maxPhosphorus, minPotassium, maxPotassium, minSelenium, maxSelenium, minSodium, maxSodium, minSugar, maxSugar, minZinc, maxZinc, offset, number, random, limitLicense);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.SearchRecipesByNutrients: " + e.Message );
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
 **minVitaminC** | **decimal?**| The minimum amount of Vitamin C in milligrams the recipe must have. | [optional] 
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
 **random** | **bool?**| If true, every request will give you a random set of recipes within the requested limits. | [optional] 
 **limitLicense** | **bool?**| Whether the recipes should have an open license that allows display with proper attribution. | [optional] [default to true]

### Return type

[**List&lt;InlineResponse2002&gt;**](InlineResponse2002.md)

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

<a name="summarizerecipe"></a>
# **SummarizeRecipe**
> InlineResponse2005 SummarizeRecipe (int id)

Summarize Recipe

Automatically generate a short description that summarizes key information about the recipe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class SummarizeRecipeExample
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
            var id = 1;  // int | The item's id.

            try
            {
                // Summarize Recipe
                InlineResponse2005 result = apiInstance.SummarizeRecipe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipesApi.SummarizeRecipe: " + e.Message );
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
 **id** | **int**| The item&#39;s id. | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

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

