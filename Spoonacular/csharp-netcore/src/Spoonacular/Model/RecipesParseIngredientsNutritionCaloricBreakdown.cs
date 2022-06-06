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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Spoonacular.Client.OpenAPIDateConverter;

namespace Spoonacular.Model
{
    /// <summary>
    /// RecipesParseIngredientsNutritionCaloricBreakdown
    /// </summary>
    [DataContract(Name = "_recipes_parseIngredients_nutrition_caloricBreakdown")]
    public partial class RecipesParseIngredientsNutritionCaloricBreakdown : IEquatable<RecipesParseIngredientsNutritionCaloricBreakdown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipesParseIngredientsNutritionCaloricBreakdown" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecipesParseIngredientsNutritionCaloricBreakdown() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipesParseIngredientsNutritionCaloricBreakdown" /> class.
        /// </summary>
        /// <param name="percentProtein">percentProtein (required).</param>
        /// <param name="percentFat">percentFat (required).</param>
        /// <param name="percentCarbs">percentCarbs (required).</param>
        public RecipesParseIngredientsNutritionCaloricBreakdown(decimal percentProtein = default(decimal), decimal percentFat = default(decimal), decimal percentCarbs = default(decimal))
        {
            this.PercentProtein = percentProtein;
            this.PercentFat = percentFat;
            this.PercentCarbs = percentCarbs;
        }

        /// <summary>
        /// Gets or Sets PercentProtein
        /// </summary>
        [DataMember(Name = "percentProtein", IsRequired = true, EmitDefaultValue = false)]
        public decimal PercentProtein { get; set; }

        /// <summary>
        /// Gets or Sets PercentFat
        /// </summary>
        [DataMember(Name = "percentFat", IsRequired = true, EmitDefaultValue = false)]
        public decimal PercentFat { get; set; }

        /// <summary>
        /// Gets or Sets PercentCarbs
        /// </summary>
        [DataMember(Name = "percentCarbs", IsRequired = true, EmitDefaultValue = false)]
        public decimal PercentCarbs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecipesParseIngredientsNutritionCaloricBreakdown {\n");
            sb.Append("  PercentProtein: ").Append(PercentProtein).Append("\n");
            sb.Append("  PercentFat: ").Append(PercentFat).Append("\n");
            sb.Append("  PercentCarbs: ").Append(PercentCarbs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecipesParseIngredientsNutritionCaloricBreakdown);
        }

        /// <summary>
        /// Returns true if RecipesParseIngredientsNutritionCaloricBreakdown instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipesParseIngredientsNutritionCaloricBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipesParseIngredientsNutritionCaloricBreakdown input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PercentProtein == input.PercentProtein ||
                    this.PercentProtein.Equals(input.PercentProtein)
                ) && 
                (
                    this.PercentFat == input.PercentFat ||
                    this.PercentFat.Equals(input.PercentFat)
                ) && 
                (
                    this.PercentCarbs == input.PercentCarbs ||
                    this.PercentCarbs.Equals(input.PercentCarbs)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.PercentProtein.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentFat.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentCarbs.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}