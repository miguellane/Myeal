/*
 * spoonacular API
 *
 * The spoonacular Nutrition, Recipe, and Food API allows you to access over 380,000 recipes, thousands of ingredients, 800,000 food products, and 100,000 menu items. Our food ontology and semantic recipe search engine makes it possible to search for recipes using natural language queries, such as \"gluten free brownies without sugar\" or \"low fat vegan cupcakes.\" You can automatically calculate the nutritional information for any recipe, analyze recipe costs, visualize ingredient lists, find recipes for what's in your fridge, find recipes based on special diets, nutritional requirements, or favorite ingredients, classify recipes into types and cuisines, convert ingredient amounts, or even compute an entire meal plan. With our powerful API, you can create many kinds of food and especially nutrition apps.  Special diets/dietary requirements currently available include: vegan, vegetarian, pescetarian, gluten free, grain free, dairy free, high protein, whole 30, low sodium, low carb, Paleo, ketogenic, FODMAP, and Primal.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: mail@spoonacular.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Spoonacular.Client;
using Spoonacular.Api;
// uncomment below to import models
//using Spoonacular.Model;

namespace Spoonacular.Test.Api
{
    /// <summary>
    ///  Class for testing RecipesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RecipesApiTests : IDisposable
    {
        private RecipesApi instance;

        public RecipesApiTests()
        {
            instance = new RecipesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecipesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RecipesApi
            //Assert.IsType<RecipesApi>(instance);
        }

        /// <summary>
        /// Test SearchRecipes
        /// </summary>
        [Fact]
        public void SearchRecipesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? query = null;
            //string? cuisine = null;
            //string? excludeCuisine = null;
            //string? diet = null;
            //string? intolerances = null;
            //string? equipment = null;
            //string? includeIngredients = null;
            //string? excludeIngredients = null;
            //string? type = null;
            //bool? instructionsRequired = null;
            //bool? fillIngredients = null;
            //bool? addRecipeInformation = null;
            //bool? addRecipeNutrition = null;
            //string? author = null;
            //string? tags = null;
            //decimal? recipeBoxId = null;
            //string? titleMatch = null;
            //decimal? maxReadyTime = null;
            //bool? ignorePantry = null;
            //string? sort = null;
            //string? sortDirection = null;
            //decimal? minCarbs = null;
            //decimal? maxCarbs = null;
            //decimal? minProtein = null;
            //decimal? maxProtein = null;
            //decimal? minCalories = null;
            //decimal? maxCalories = null;
            //decimal? minFat = null;
            //decimal? maxFat = null;
            //decimal? minAlcohol = null;
            //decimal? maxAlcohol = null;
            //decimal? minCaffeine = null;
            //decimal? maxCaffeine = null;
            //decimal? minCopper = null;
            //decimal? maxCopper = null;
            //decimal? minCalcium = null;
            //decimal? maxCalcium = null;
            //decimal? minCholine = null;
            //decimal? maxCholine = null;
            //decimal? minCholesterol = null;
            //decimal? maxCholesterol = null;
            //decimal? minFluoride = null;
            //decimal? maxFluoride = null;
            //decimal? minSaturatedFat = null;
            //decimal? maxSaturatedFat = null;
            //decimal? minVitaminA = null;
            //decimal? maxVitaminA = null;
            //decimal? minVitaminC = null;
            //decimal? maxVitaminC = null;
            //decimal? minVitaminD = null;
            //decimal? maxVitaminD = null;
            //decimal? minVitaminE = null;
            //decimal? maxVitaminE = null;
            //decimal? minVitaminK = null;
            //decimal? maxVitaminK = null;
            //decimal? minVitaminB1 = null;
            //decimal? maxVitaminB1 = null;
            //decimal? minVitaminB2 = null;
            //decimal? maxVitaminB2 = null;
            //decimal? minVitaminB5 = null;
            //decimal? maxVitaminB5 = null;
            //decimal? minVitaminB3 = null;
            //decimal? maxVitaminB3 = null;
            //decimal? minVitaminB6 = null;
            //decimal? maxVitaminB6 = null;
            //decimal? minVitaminB12 = null;
            //decimal? maxVitaminB12 = null;
            //decimal? minFiber = null;
            //decimal? maxFiber = null;
            //decimal? minFolate = null;
            //decimal? maxFolate = null;
            //decimal? minFolicAcid = null;
            //decimal? maxFolicAcid = null;
            //decimal? minIodine = null;
            //decimal? maxIodine = null;
            //decimal? minIron = null;
            //decimal? maxIron = null;
            //decimal? minMagnesium = null;
            //decimal? maxMagnesium = null;
            //decimal? minManganese = null;
            //decimal? maxManganese = null;
            //decimal? minPhosphorus = null;
            //decimal? maxPhosphorus = null;
            //decimal? minPotassium = null;
            //decimal? maxPotassium = null;
            //decimal? minSelenium = null;
            //decimal? maxSelenium = null;
            //decimal? minSodium = null;
            //decimal? maxSodium = null;
            //decimal? minSugar = null;
            //decimal? maxSugar = null;
            //decimal? minZinc = null;
            //decimal? maxZinc = null;
            //int? offset = null;
            //int? number = null;
            //bool? limitLicense = null;
            //var response = instance.SearchRecipes(query, cuisine, excludeCuisine, diet, intolerances, equipment, includeIngredients, excludeIngredients, type, instructionsRequired, fillIngredients, addRecipeInformation, addRecipeNutrition, author, tags, recipeBoxId, titleMatch, maxReadyTime, ignorePantry, sort, sortDirection, minCarbs, maxCarbs, minProtein, maxProtein, minCalories, maxCalories, minFat, maxFat, minAlcohol, maxAlcohol, minCaffeine, maxCaffeine, minCopper, maxCopper, minCalcium, maxCalcium, minCholine, maxCholine, minCholesterol, maxCholesterol, minFluoride, maxFluoride, minSaturatedFat, maxSaturatedFat, minVitaminA, maxVitaminA, minVitaminC, maxVitaminC, minVitaminD, maxVitaminD, minVitaminE, maxVitaminE, minVitaminK, maxVitaminK, minVitaminB1, maxVitaminB1, minVitaminB2, maxVitaminB2, minVitaminB5, maxVitaminB5, minVitaminB3, maxVitaminB3, minVitaminB6, maxVitaminB6, minVitaminB12, maxVitaminB12, minFiber, maxFiber, minFolate, maxFolate, minFolicAcid, maxFolicAcid, minIodine, maxIodine, minIron, maxIron, minMagnesium, maxMagnesium, minManganese, maxManganese, minPhosphorus, maxPhosphorus, minPotassium, maxPotassium, minSelenium, maxSelenium, minSodium, maxSodium, minSugar, maxSugar, minZinc, maxZinc, offset, number, limitLicense);
            //Assert.IsType<InlineResponse200>(response);
        }
    }
}