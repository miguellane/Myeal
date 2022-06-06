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
    /// InlineResponse20013Steps
    /// </summary>
    [DataContract(Name = "inline_response_200_13_steps")]
    public partial class InlineResponse20013Steps : IEquatable<InlineResponse20013Steps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20013Steps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20013Steps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20013Steps" /> class.
        /// </summary>
        /// <param name="number">number (required).</param>
        /// <param name="step">step (required).</param>
        /// <param name="ingredients">ingredients.</param>
        /// <param name="equipment">equipment.</param>
        public InlineResponse20013Steps(decimal number = default(decimal), string step = default(string), List<InlineResponse20013Ingredients> ingredients = default(List<InlineResponse20013Ingredients>), List<InlineResponse20013Ingredients> equipment = default(List<InlineResponse20013Ingredients>))
        {
            this.Number = number;
            // to ensure "step" is required (not null)
            if (step == null)
            {
                throw new ArgumentNullException("step is a required property for InlineResponse20013Steps and cannot be null");
            }
            this.Step = step;
            this.Ingredients = ingredients;
            this.Equipment = equipment;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = false)]
        public decimal Number { get; set; }

        /// <summary>
        /// Gets or Sets Step
        /// </summary>
        [DataMember(Name = "step", IsRequired = true, EmitDefaultValue = false)]
        public string Step { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>
        [DataMember(Name = "ingredients", EmitDefaultValue = false)]
        public List<InlineResponse20013Ingredients> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets Equipment
        /// </summary>
        [DataMember(Name = "equipment", EmitDefaultValue = false)]
        public List<InlineResponse20013Ingredients> Equipment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse20013Steps {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  Equipment: ").Append(Equipment).Append("\n");
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
            return this.Equals(input as InlineResponse20013Steps);
        }

        /// <summary>
        /// Returns true if InlineResponse20013Steps instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20013Steps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20013Steps input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Step == input.Step ||
                    (this.Step != null &&
                    this.Step.Equals(input.Step))
                ) && 
                (
                    this.Ingredients == input.Ingredients ||
                    this.Ingredients != null &&
                    input.Ingredients != null &&
                    this.Ingredients.SequenceEqual(input.Ingredients)
                ) && 
                (
                    this.Equipment == input.Equipment ||
                    this.Equipment != null &&
                    input.Equipment != null &&
                    this.Equipment.SequenceEqual(input.Equipment)
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
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.Step != null)
                {
                    hashCode = (hashCode * 59) + this.Step.GetHashCode();
                }
                if (this.Ingredients != null)
                {
                    hashCode = (hashCode * 59) + this.Ingredients.GetHashCode();
                }
                if (this.Equipment != null)
                {
                    hashCode = (hashCode * 59) + this.Equipment.GetHashCode();
                }
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
            // Step (string) minLength
            if (this.Step != null && this.Step.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Step, length must be greater than 1.", new [] { "Step" });
            }

            yield break;
        }
    }

}
