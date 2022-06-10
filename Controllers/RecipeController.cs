using Microsoft.AspNetCore.Mvc;
using Spoonacular.Client;
using Spoonacular.Model;
using System.Diagnostics;
using System.Net;

namespace Myeal.Controllers
{
    public class RecipeController : Controller
    {
        //GET: Recipe
        public IActionResult RecipeSearchResult(string SearchString)
        {
            ApiClient client = new ApiClient();
            string path = $"/recipes/complexSearch?query={SearchString}&instructionsRequired=true&addRecipeInformation=true&addRecipeNutrition=true&ignorePantry=false&sort=calories&sortDirection=asc&offset=0&number=10&limitLicense=true&apiKey=4aece01f23bf462e83f2a9401bd8c19d";
            RequestOptions options = new RequestOptions();
            Configuration config = new Configuration();
            //options.PathParameters = ;
            //options.QueryParameters = ;

            var response = client.GetAsync<InlineResponse200>(path, options, config);
            Debug.WriteLine("Task sent");
            response.Wait();

            Debug.WriteLine($"Response received: {response.Result.ErrorText} {response.Result.ResponseType} {response.Result.Data}");
            Debug.WriteLine("Recipes found");


            return View(response.Result.Data.Results);
        }

        public IActionResult RecipeSearchForm()
        {
            return View();
        }
    }
}
