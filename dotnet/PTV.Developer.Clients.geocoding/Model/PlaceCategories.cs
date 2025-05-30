/*
 * Geocoding
 *
 * With the Geocoding service you can find locations by converting street addresses into GPS-coordinates and vice versa. The Places service allows to search for millions of shops and prominent points of interest in various categories.
 *
 * The version of the OpenAPI document: 1.17
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
using OpenAPIDateConverter = PTV.Developer.Clients.geocoding.Client.OpenAPIDateConverter;

namespace PTV.Developer.Clients.geocoding.Model
{
    /// <summary>
    /// Response type for place category requests.
    /// </summary>
    [DataContract(Name = "PlaceCategories")]
    public partial class PlaceCategories : IEquatable<PlaceCategories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceCategories" /> class.
        /// </summary>
        /// <param name="placeCategories">The individual place categories..</param>
        public PlaceCategories(List<PlaceCategory> placeCategories = default(List<PlaceCategory>))
        {
            this._PlaceCategories = placeCategories;
        }

        /// <summary>
        /// The individual place categories.
        /// </summary>
        /// <value>The individual place categories.</value>
        [DataMember(Name = "placeCategories", EmitDefaultValue = false)]
        public List<PlaceCategory> _PlaceCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlaceCategories {\n");
            sb.Append("  _PlaceCategories: ").Append(_PlaceCategories).Append("\n");
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
            return this.Equals(input as PlaceCategories);
        }

        /// <summary>
        /// Returns true if PlaceCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of PlaceCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaceCategories input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._PlaceCategories == input._PlaceCategories ||
                    this._PlaceCategories != null &&
                    input._PlaceCategories != null &&
                    this._PlaceCategories.SequenceEqual(input._PlaceCategories)
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
                if (this._PlaceCategories != null)
                {
                    hashCode = (hashCode * 59) + this._PlaceCategories.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
