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
    /// InlineResponse2003ExtendedIngredients
    /// </summary>
    [DataContract(Name = "inline_response_200_3_extendedIngredients")]
    public partial class InlineResponse2003ExtendedIngredients : IEquatable<InlineResponse2003ExtendedIngredients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003ExtendedIngredients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2003ExtendedIngredients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003ExtendedIngredients" /> class.
        /// </summary>
        /// <param name="aisle">aisle (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="consitency">consitency (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="image">image (required).</param>
        /// <param name="measures">measures.</param>
        /// <param name="meta">meta.</param>
        /// <param name="name">name (required).</param>
        /// <param name="original">original (required).</param>
        /// <param name="originalName">originalName (required).</param>
        /// <param name="unit">unit (required).</param>
        public InlineResponse2003ExtendedIngredients(string aisle = default(string), decimal amount = default(decimal), string consitency = default(string), int id = default(int), string image = default(string), InlineResponse2003Measures measures = default(InlineResponse2003Measures), List<string> meta = default(List<string>), string name = default(string), string original = default(string), string originalName = default(string), string unit = default(string))
        {
            // to ensure "aisle" is required (not null)
            if (aisle == null)
            {
                throw new ArgumentNullException("aisle is a required property for InlineResponse2003ExtendedIngredients and cannot be null");
            }
            this.Aisle = aisle;
            this.Amount = amount;
            // to ensure "consitency" is required (not null)
            if (consitency == null)
            {
                throw new ArgumentNullException("consitency is a required property for InlineResponse2003ExtendedIngredients and cannot be null");
            }
            this.Consitency = consitency;
            this.Id = id;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for InlineResponse2003ExtendedIngredients and cannot be null");
            }
            this.Image = image;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for InlineResponse2003ExtendedIngredients and cannot be null");
            }
            this.Name = name;
            // to ensure "original" is required (not null)
            if (original == null)
            {
                throw new ArgumentNullException("original is a required property for InlineResponse2003ExtendedIngredients and cannot be null");
            }
            this.Original = original;
            // to ensure "originalName" is required (not null)
            if (originalName == null)
            {
                throw new ArgumentNullException("originalName is a required property for InlineResponse2003ExtendedIngredients and cannot be null");
            }
            this.OriginalName = originalName;
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new ArgumentNullException("unit is a required property for InlineResponse2003ExtendedIngredients and cannot be null");
            }
            this.Unit = unit;
            this.Measures = measures;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets Aisle
        /// </summary>
        [DataMember(Name = "aisle", IsRequired = true, EmitDefaultValue = false)]
        public string Aisle { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Consitency
        /// </summary>
        [DataMember(Name = "consitency", IsRequired = true, EmitDefaultValue = false)]
        public string Consitency { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Measures
        /// </summary>
        [DataMember(Name = "measures", EmitDefaultValue = false)]
        public InlineResponse2003Measures Measures { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public List<string> Meta { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Original
        /// </summary>
        [DataMember(Name = "original", IsRequired = true, EmitDefaultValue = false)]
        public string Original { get; set; }

        /// <summary>
        /// Gets or Sets OriginalName
        /// </summary>
        [DataMember(Name = "originalName", IsRequired = true, EmitDefaultValue = false)]
        public string OriginalName { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse2003ExtendedIngredients {\n");
            sb.Append("  Aisle: ").Append(Aisle).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Consitency: ").Append(Consitency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Measures: ").Append(Measures).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as InlineResponse2003ExtendedIngredients);
        }

        /// <summary>
        /// Returns true if InlineResponse2003ExtendedIngredients instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2003ExtendedIngredients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003ExtendedIngredients input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Aisle == input.Aisle ||
                    (this.Aisle != null &&
                    this.Aisle.Equals(input.Aisle))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Consitency == input.Consitency ||
                    (this.Consitency != null &&
                    this.Consitency.Equals(input.Consitency))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Measures == input.Measures ||
                    (this.Measures != null &&
                    this.Measures.Equals(input.Measures))
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Original == input.Original ||
                    (this.Original != null &&
                    this.Original.Equals(input.Original))
                ) && 
                (
                    this.OriginalName == input.OriginalName ||
                    (this.OriginalName != null &&
                    this.OriginalName.Equals(input.OriginalName))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Aisle != null)
                {
                    hashCode = (hashCode * 59) + this.Aisle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Consitency != null)
                {
                    hashCode = (hashCode * 59) + this.Consitency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Measures != null)
                {
                    hashCode = (hashCode * 59) + this.Measures.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Original != null)
                {
                    hashCode = (hashCode * 59) + this.Original.GetHashCode();
                }
                if (this.OriginalName != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalName.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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
            // Aisle (string) minLength
            if (this.Aisle != null && this.Aisle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Aisle, length must be greater than 1.", new [] { "Aisle" });
            }

            // Consitency (string) minLength
            if (this.Consitency != null && this.Consitency.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Consitency, length must be greater than 1.", new [] { "Consitency" });
            }

            // Image (string) minLength
            if (this.Image != null && this.Image.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Image, length must be greater than 1.", new [] { "Image" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Original (string) minLength
            if (this.Original != null && this.Original.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Original, length must be greater than 1.", new [] { "Original" });
            }

            // OriginalName (string) minLength
            if (this.OriginalName != null && this.OriginalName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OriginalName, length must be greater than 1.", new [] { "OriginalName" });
            }

            // Unit (string) minLength
            if (this.Unit != null && this.Unit.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Unit, length must be greater than 0.", new [] { "Unit" });
            }

            yield break;
        }
    }

}