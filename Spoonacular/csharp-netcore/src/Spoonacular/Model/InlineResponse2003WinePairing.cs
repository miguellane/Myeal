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
    /// InlineResponse2003WinePairing
    /// </summary>
    [DataContract(Name = "inline_response_200_3_winePairing")]
    public partial class InlineResponse2003WinePairing : IEquatable<InlineResponse2003WinePairing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003WinePairing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2003WinePairing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003WinePairing" /> class.
        /// </summary>
        /// <param name="pairedWines">pairedWines (required).</param>
        /// <param name="pairingText">pairingText (required).</param>
        /// <param name="productMatches">productMatches (required).</param>
        public InlineResponse2003WinePairing(List<string> pairedWines = default(List<string>), string pairingText = default(string), List<InlineResponse2003WinePairingProductMatches> productMatches = default(List<InlineResponse2003WinePairingProductMatches>))
        {
            // to ensure "pairedWines" is required (not null)
            if (pairedWines == null)
            {
                throw new ArgumentNullException("pairedWines is a required property for InlineResponse2003WinePairing and cannot be null");
            }
            this.PairedWines = pairedWines;
            // to ensure "pairingText" is required (not null)
            if (pairingText == null)
            {
                throw new ArgumentNullException("pairingText is a required property for InlineResponse2003WinePairing and cannot be null");
            }
            this.PairingText = pairingText;
            // to ensure "productMatches" is required (not null)
            if (productMatches == null)
            {
                throw new ArgumentNullException("productMatches is a required property for InlineResponse2003WinePairing and cannot be null");
            }
            this.ProductMatches = productMatches;
        }

        /// <summary>
        /// Gets or Sets PairedWines
        /// </summary>
        [DataMember(Name = "pairedWines", IsRequired = true, EmitDefaultValue = false)]
        public List<string> PairedWines { get; set; }

        /// <summary>
        /// Gets or Sets PairingText
        /// </summary>
        [DataMember(Name = "pairingText", IsRequired = true, EmitDefaultValue = false)]
        public string PairingText { get; set; }

        /// <summary>
        /// Gets or Sets ProductMatches
        /// </summary>
        [DataMember(Name = "productMatches", IsRequired = true, EmitDefaultValue = false)]
        public List<InlineResponse2003WinePairingProductMatches> ProductMatches { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse2003WinePairing {\n");
            sb.Append("  PairedWines: ").Append(PairedWines).Append("\n");
            sb.Append("  PairingText: ").Append(PairingText).Append("\n");
            sb.Append("  ProductMatches: ").Append(ProductMatches).Append("\n");
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
            return this.Equals(input as InlineResponse2003WinePairing);
        }

        /// <summary>
        /// Returns true if InlineResponse2003WinePairing instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2003WinePairing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003WinePairing input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PairedWines == input.PairedWines ||
                    this.PairedWines != null &&
                    input.PairedWines != null &&
                    this.PairedWines.SequenceEqual(input.PairedWines)
                ) && 
                (
                    this.PairingText == input.PairingText ||
                    (this.PairingText != null &&
                    this.PairingText.Equals(input.PairingText))
                ) && 
                (
                    this.ProductMatches == input.ProductMatches ||
                    this.ProductMatches != null &&
                    input.ProductMatches != null &&
                    this.ProductMatches.SequenceEqual(input.ProductMatches)
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
                if (this.PairedWines != null)
                {
                    hashCode = (hashCode * 59) + this.PairedWines.GetHashCode();
                }
                if (this.PairingText != null)
                {
                    hashCode = (hashCode * 59) + this.PairingText.GetHashCode();
                }
                if (this.ProductMatches != null)
                {
                    hashCode = (hashCode * 59) + this.ProductMatches.GetHashCode();
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
            // PairingText (string) minLength
            if (this.PairingText != null && this.PairingText.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PairingText, length must be greater than 1.", new [] { "PairingText" });
            }

            yield break;
        }
    }

}
