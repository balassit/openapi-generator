/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
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
using FileParameter = Org.OpenAPITools.Client.FileParameter;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// LiteralStringClass
    /// </summary>
    [DataContract(Name = "LiteralStringClass")]
    public partial class LiteralStringClass : IEquatable<LiteralStringClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralStringClass" /> class.
        /// </summary>
        /// <param name="escapedLiteralString">escapedLiteralString (default to &quot;C:\\Users\\username&quot;).</param>
        /// <param name="unescapedLiteralString">unescapedLiteralString (default to &quot;C:\Users\username&quot;).</param>

        public LiteralStringClass(string? escapedLiteralString = @"C:\\Users\\username", string? unescapedLiteralString = @"C:\Users\username")
        {
            // use default value if no "escapedLiteralString" provided
            this.EscapedLiteralString = escapedLiteralString ?? @"C:\\Users\\username";
            // use default value if no "unescapedLiteralString" provided
            this.UnescapedLiteralString = unescapedLiteralString ?? @"C:\Users\username";
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets EscapedLiteralString
        /// </summary>
        [DataMember(Name = "escapedLiteralString", EmitDefaultValue = false)]
        public string? EscapedLiteralString { get; set; }

        /// <summary>
        /// Gets or Sets UnescapedLiteralString
        /// </summary>
        [DataMember(Name = "unescapedLiteralString", EmitDefaultValue = false)]
        public string? UnescapedLiteralString { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiteralStringClass {\n");
            sb.Append("  EscapedLiteralString: ").Append(EscapedLiteralString).Append("\n");
            sb.Append("  UnescapedLiteralString: ").Append(UnescapedLiteralString).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as LiteralStringClass).AreEqual;
        }

        /// <summary>
        /// Returns true if LiteralStringClass instances are equal
        /// </summary>
        /// <param name="input">Instance of LiteralStringClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiteralStringClass input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                if (this.EscapedLiteralString != null)
                {
                    hashCode = (hashCode * 59) + this.EscapedLiteralString.GetHashCode();
                }
                if (this.UnescapedLiteralString != null)
                {
                    hashCode = (hashCode * 59) + this.UnescapedLiteralString.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
