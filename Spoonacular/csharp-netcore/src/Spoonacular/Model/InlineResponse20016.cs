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
    /// InlineResponse20016
    /// </summary>
    [DataContract(Name = "inline_response_200_16")]
    public partial class InlineResponse20016 : IEquatable<InlineResponse20016>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20016" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20016() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20016" /> class.
        /// </summary>
        /// <param name="parsedInstructions">parsedInstructions (required).</param>
        /// <param name="ingredients">ingredients (required).</param>
        /// <param name="equipment">equipment (required).</param>
        public InlineResponse20016(List<Object> parsedInstructions = default(List<Object>), List<Object> ingredients = default(List<Object>), List<Object> equipment = default(List<Object>))
        {
            // to ensure "parsedInstructions" is required (not null)
            if (parsedInstructions == null)
            {
                throw new ArgumentNullException("parsedInstructions is a required property for InlineResponse20016 and cannot be null");
            }
            this.ParsedInstructions = parsedInstructions;
            // to ensure "ingredients" is required (not null)
            if (ingredients == null)
            {
                throw new ArgumentNullException("ingredients is a required property for InlineResponse20016 and cannot be null");
            }
            this.Ingredients = ingredients;
            // to ensure "equipment" is required (not null)
            if (equipment == null)
            {
                throw new ArgumentNullException("equipment is a required property for InlineResponse20016 and cannot be null");
            }
            this.Equipment = equipment;
        }

        /// <summary>
        /// Gets or Sets ParsedInstructions
        /// </summary>
        [DataMember(Name = "parsedInstructions", IsRequired = true, EmitDefaultValue = false)]
        public List<Object> ParsedInstructions { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>
        [DataMember(Name = "ingredients", IsRequired = true, EmitDefaultValue = false)]
        public List<Object> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets Equipment
        /// </summary>
        [DataMember(Name = "equipment", IsRequired = true, EmitDefaultValue = false)]
        public List<Object> Equipment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse20016 {\n");
            sb.Append("  ParsedInstructions: ").Append(ParsedInstructions).Append("\n");
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
            return this.Equals(input as InlineResponse20016);
        }

        /// <summary>
        /// Returns true if InlineResponse20016 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20016 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20016 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParsedInstructions == input.ParsedInstructions ||
                    this.ParsedInstructions != null &&
                    input.ParsedInstructions != null &&
                    this.ParsedInstructions.SequenceEqual(input.ParsedInstructions)
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
                if (this.ParsedInstructions != null)
                {
                    hashCode = (hashCode * 59) + this.ParsedInstructions.GetHashCode();
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
            yield break;
        }
    }

}
