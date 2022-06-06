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
    /// InlineResponse2005
    /// </summary>
    [DataContract(Name = "inline_response_200_5")]
    public partial class InlineResponse2005 : IEquatable<InlineResponse2005>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2005" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2005() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2005" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="imageType">imageType (required).</param>
        /// <param name="readyInMinutes">readyInMinutes (required).</param>
        /// <param name="servings">servings (required).</param>
        /// <param name="sourceUrl">sourceUrl (required).</param>
        public InlineResponse2005(int id = default(int), string title = default(string), string imageType = default(string), int readyInMinutes = default(int), decimal servings = default(decimal), string sourceUrl = default(string))
        {
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for InlineResponse2005 and cannot be null");
            }
            this.Title = title;
            // to ensure "imageType" is required (not null)
            if (imageType == null)
            {
                throw new ArgumentNullException("imageType is a required property for InlineResponse2005 and cannot be null");
            }
            this.ImageType = imageType;
            this.ReadyInMinutes = readyInMinutes;
            this.Servings = servings;
            // to ensure "sourceUrl" is required (not null)
            if (sourceUrl == null)
            {
                throw new ArgumentNullException("sourceUrl is a required property for InlineResponse2005 and cannot be null");
            }
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [DataMember(Name = "imageType", IsRequired = true, EmitDefaultValue = false)]
        public string ImageType { get; set; }

        /// <summary>
        /// Gets or Sets ReadyInMinutes
        /// </summary>
        [DataMember(Name = "readyInMinutes", IsRequired = true, EmitDefaultValue = false)]
        public int ReadyInMinutes { get; set; }

        /// <summary>
        /// Gets or Sets Servings
        /// </summary>
        [DataMember(Name = "servings", IsRequired = true, EmitDefaultValue = false)]
        public decimal Servings { get; set; }

        /// <summary>
        /// Gets or Sets SourceUrl
        /// </summary>
        [DataMember(Name = "sourceUrl", IsRequired = true, EmitDefaultValue = false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse2005 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  ReadyInMinutes: ").Append(ReadyInMinutes).Append("\n");
            sb.Append("  Servings: ").Append(Servings).Append("\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
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
            return this.Equals(input as InlineResponse2005);
        }

        /// <summary>
        /// Returns true if InlineResponse2005 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2005 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ImageType == input.ImageType ||
                    (this.ImageType != null &&
                    this.ImageType.Equals(input.ImageType))
                ) && 
                (
                    this.ReadyInMinutes == input.ReadyInMinutes ||
                    this.ReadyInMinutes.Equals(input.ReadyInMinutes)
                ) && 
                (
                    this.Servings == input.Servings ||
                    this.Servings.Equals(input.Servings)
                ) && 
                (
                    this.SourceUrl == input.SourceUrl ||
                    (this.SourceUrl != null &&
                    this.SourceUrl.Equals(input.SourceUrl))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.ImageType != null)
                {
                    hashCode = (hashCode * 59) + this.ImageType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReadyInMinutes.GetHashCode();
                hashCode = (hashCode * 59) + this.Servings.GetHashCode();
                if (this.SourceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SourceUrl.GetHashCode();
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
            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            // ImageType (string) minLength
            if (this.ImageType != null && this.ImageType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageType, length must be greater than 1.", new [] { "ImageType" });
            }

            // SourceUrl (string) minLength
            if (this.SourceUrl != null && this.SourceUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceUrl, length must be greater than 1.", new [] { "SourceUrl" });
            }

            yield break;
        }
    }

}