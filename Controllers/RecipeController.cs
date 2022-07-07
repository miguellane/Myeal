using Microsoft.AspNetCore.Mvc;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;
using System.Diagnostics;
using System.Net;
using Myeal.Models;

namespace Myeal.Controllers
{
    public class RecipeController : Controller
    {        

        //GET: Recipe
        public IActionResult RecipeSearchResult(RecipeSearchFormModel search)
        {
            Configuration config = new Configuration();
            config.ApiKey.Add("apiKey", "4aece01f23bf462e83f2a9401bd8c19d");
            RecipesApi apiInstance = new RecipesApi(config);

            try
            {
                /*var response = apiInstance.SearchRecipesAsync
                    (
                        search.query, 
                        search.cuisine, search.excludeCuisine, search.diet, search.intolerances, search.equipment, search.includeIngredients, search.excludeIngredients, search.type, search.instructionsRequired, search.fillIngredients, search.addRecipeInformation, search.addRecipeNutrition, search.author, search.tags, search.recipeBoxId, search.titleMatch, search.maxReadyTime, search.ignorePantry, search.sort, search.sortDirection,
                        search.minCarbs, search.maxCarbs, search.minProtein, search.maxProtein, search.minCalories, search.maxCalories, search.minFat, search.maxFat, search.minAlcohol, search.maxAlcohol, search.minCaffeine, search.maxCaffeine, search.minCopper, search.maxCopper, search.minCalcium, search.maxCalcium, search.minCholine, search.maxCholine, search.minCholesterol, search.maxCholesterol, search.minFluoride, search.maxFluoride, search.minSaturatedFat, search.maxSaturatedFat, search.minA, search.maxVitaminA, search.minC, search.maxVitaminC, search.minD, search.maxVitaminD, search.minE, search.maxVitaminE, search.minK, search.maxVitaminK, search.minB1, search.maxVitaminB1, search.minB2, search.maxVitaminB2, search.minB5, search.maxVitaminB5, search.minB3, search.maxVitaminB3, search.minB6, search.maxVitaminB6, search.minB12, search.maxVitaminB12, search.minFiber, search.maxFiber, search.minFolate, search.maxFolate, search.minFolicAcid, search.maxFolicAcid, search.minIodine, search.maxIodine, search.minIron, search.maxIron, search.minMagnesium, search.maxMagnesium, search.minManganese, search.maxManganese, search.minPhosphorus, search.maxPhosphorus, search.minPotassium, search.maxPotassium, search.minSelenium, search.maxSelenium, search.minSodium, search.maxSodium, search.minSugar, search.maxSugar, search.minZinc, search.maxZinc,
                        search.offset, search.number, search.limitLicense
                    );*/
                var response = apiInstance.SearchRecipesAsync
                    (
                        search.query,
                        null, null, null, null, search.equipment, search.includeIngredients, search.excludeIngredients, null, search.instructionsRequired, search.fillIngredients, search.addRecipeInformation, search.addRecipeNutrition, search.author, search.tags, search.recipeBoxId, search.titleMatch, search.maxReadyTime, search.ignorePantry, null, search.sortDirection,
                        search.minCarbs, search.maxCarbs, search.minProtein, search.maxProtein, search.minCalories, search.maxCalories, search.minFat, search.maxFat, search.minAlcohol, search.maxAlcohol, search.minCaffeine, search.maxCaffeine, search.minCopper, search.maxCopper, search.minCalcium, search.maxCalcium, search.minCholine, search.maxCholine, search.minCholesterol, search.maxCholesterol, search.minFluoride, search.maxFluoride, search.minSaturatedFat, search.maxSaturatedFat, search.minA, search.maxVitaminA, search.minC, search.maxVitaminC, search.minD, search.maxVitaminD, search.minE, search.maxVitaminE, search.minK, search.maxVitaminK, search.minB1, search.maxVitaminB1, search.minB2, search.maxVitaminB2, search.minB5, search.maxVitaminB5, search.minB3, search.maxVitaminB3, search.minB6, search.maxVitaminB6, search.minB12, search.maxVitaminB12, search.minFiber, search.maxFiber, search.minFolate, search.maxFolate, search.minFolicAcid, search.maxFolicAcid, search.minIodine, search.maxIodine, search.minIron, search.maxIron, search.minMagnesium, search.maxMagnesium, search.minManganese, search.maxManganese, search.minPhosphorus, search.maxPhosphorus, search.minPotassium, search.maxPotassium, search.minSelenium, search.maxSelenium, search.minSodium, search.maxSodium, search.minSugar, search.maxSugar, search.minZinc, search.maxZinc,
                        search.offset, search.number, search.limitLicense
                    );
                response.Wait();

                List<SpoonacularSearchViewModel> results = response.Result.Results;
                return View(results);
            }
            catch (ApiException ex)
            {
                Debug.Print("Exception when calling RecipesApi.SearchRecipesAsync: " + ex.Message);
                return View(null);
            }
        }

        public IActionResult RecipeSearchForm()
        {
            return View(new RecipeSearchFormModel());

        }
        // GET: HomeController1/Details/5
        public ActionResult RecipeDetails(int id)
        {
            return View();
        }
    }
}
