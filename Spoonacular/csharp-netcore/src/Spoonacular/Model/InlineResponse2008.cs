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
    /// InlineResponse2008
    /// </summary>
    [DataContract(Name = "inline_response_200_8")]
    public partial class InlineResponse2008 : IEquatable<InlineResponse2008>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2008" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2008() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2008" /> class.
        /// </summary>
        /// <param name="sweetness">sweetness (required).</param>
        /// <param name="saltiness">saltiness (required).</param>
        /// <param name="sourness">sourness (required).</param>
        /// <param name="bitterness">bitterness (required).</param>
        /// <param name="savoriness">savoriness (required).</param>
        /// <param name="fattiness">fattiness (required).</param>
        /// <param name="spiciness">spiciness (required).</param>
        public InlineResponse2008(decimal sweetness = default(decimal), decimal saltiness = default(decimal), decimal sourness = default(decimal), decimal bitterness = default(decimal), decimal savoriness = default(decimal), decimal fattiness = default(decimal), decimal spiciness = default(decimal))
        {
            this.Sweetness = sweetness;
            this.Saltiness = saltiness;
            this.Sourness = sourness;
            this.Bitterness = bitterness;
            this.Savoriness = savoriness;
            this.Fattiness = fattiness;
            this.Spiciness = spiciness;
        }

        /// <summary>
        /// Gets or Sets Sweetness
        /// </summary>
        [DataMember(Name = "sweetness", IsRequired = true, EmitDefaultValue = false)]
        public decimal Sweetness { get; set; }

        /// <summary>
        /// Gets or Sets Saltiness
        /// </summary>
        [DataMember(Name = "saltiness", IsRequired = true, EmitDefaultValue = false)]
        public decimal Saltiness { get; set; }

        /// <summary>
        /// Gets or Sets Sourness
        /// </summary>
        [DataMember(Name = "sourness", IsRequired = true, EmitDefaultValue = false)]
        public decimal Sourness { get; set; }

        /// <summary>
        /// Gets or Sets Bitterness
        /// </summary>
        [DataMember(Name = "bitterness", IsRequired = true, EmitDefaultValue = false)]
        public decimal Bitterness { get; set; }

        /// <summary>
        /// Gets or Sets Savoriness
        /// </summary>
        [DataMember(Name = "savoriness", IsRequired = true, EmitDefaultValue = false)]
        public decimal Savoriness { get; set; }

        /// <summary>
        /// Gets or Sets Fattiness
        /// </summary>
        [DataMember(Name = "fattiness", IsRequired = true, EmitDefaultValue = false)]
        public decimal Fattiness { get; set; }

        /// <summary>
        /// Gets or Sets Spiciness
        /// </summary>
        [DataMember(Name = "spiciness", IsRequired = true, EmitDefaultValue = false)]
        public decimal Spiciness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse2008 {\n");
            sb.Append("  Sweetness: ").Append(Sweetness).Append("\n");
            sb.Append("  Saltiness: ").Append(Saltiness).Append("\n");
            sb.Append("  Sourness: ").Append(Sourness).Append("\n");
            sb.Append("  Bitterness: ").Append(Bitterness).Append("\n");
            sb.Append("  Savoriness: ").Append(Savoriness).Append("\n");
            sb.Append("  Fattiness: ").Append(Fattiness).Append("\n");
            sb.Append("  Spiciness: ").Append(Spiciness).Append("\n");
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
            return this.Equals(input as InlineResponse2008);
        }

        /// <summary>
        /// Returns true if InlineResponse2008 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2008 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2008 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sweetness == input.Sweetness ||
                    this.Sweetness.Equals(input.Sweetness)
                ) && 
                (
                    this.Saltiness == input.Saltiness ||
                    this.Saltiness.Equals(input.Saltiness)
                ) && 
                (
                    this.Sourness == input.Sourness ||
                    this.Sourness.Equals(input.Sourness)
                ) && 
                (
                    this.Bitterness == input.Bitterness ||
                    this.Bitterness.Equals(input.Bitterness)
                ) && 
                (
                    this.Savoriness == input.Savoriness ||
                    this.Savoriness.Equals(input.Savoriness)
                ) && 
                (
                    this.Fattiness == input.Fattiness ||
                    this.Fattiness.Equals(input.Fattiness)
                ) && 
                (
                    this.Spiciness == input.Spiciness ||
                    this.Spiciness.Equals(input.Spiciness)
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
                hashCode = (hashCode * 59) + this.Sweetness.GetHashCode();
                hashCode = (hashCode * 59) + this.Saltiness.GetHashCode();
                hashCode = (hashCode * 59) + this.Sourness.GetHashCode();
                hashCode = (hashCode * 59) + this.Bitterness.GetHashCode();
                hashCode = (hashCode * 59) + this.Savoriness.GetHashCode();
                hashCode = (hashCode * 59) + this.Fattiness.GetHashCode();
                hashCode = (hashCode * 59) + this.Spiciness.GetHashCode();
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
