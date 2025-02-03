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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ObjectWithDeprecatedFields
    /// </summary>
    [DataContract(Name = "ObjectWithDeprecatedFields")]
    public partial class ObjectWithDeprecatedFields : IEquatable<ObjectWithDeprecatedFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectWithDeprecatedFields" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="id">id.</param>
        /// <param name="deprecatedRef">deprecatedRef.</param>
        /// <param name="bars">bars.</param>

        public ObjectWithDeprecatedFields(string? uuid = default(string), decimal? id = default(decimal), DeprecatedObject? deprecatedRef = default(DeprecatedObject), List<string> bars = default(List<string>))
        {
            this.Uuid = uuid;
            this.Id = id;
            this.DeprecatedRef = deprecatedRef;
            this.Bars = bars;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string? Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [Obsolete]
        public decimal? Id { get; set; }

        /// <summary>
        /// Gets or Sets DeprecatedRef
        /// </summary>
        [DataMember(Name = "deprecatedRef", EmitDefaultValue = false)]
        [Obsolete]
        public DeprecatedObject? DeprecatedRef { get; set; }

        /// <summary>
        /// Gets or Sets Bars
        /// </summary>
        [DataMember(Name = "bars", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> Bars { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectWithDeprecatedFields {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeprecatedRef: ").Append(DeprecatedRef).Append("\n");
            sb.Append("  Bars: ").Append(Bars).Append("\n");
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
            return this.Equals(input as ObjectWithDeprecatedFields);
        }

        /// <summary>
        /// Returns true if ObjectWithDeprecatedFields instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectWithDeprecatedFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectWithDeprecatedFields input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.DeprecatedRef == input.DeprecatedRef ||
                    (this.DeprecatedRef != null &&
                    this.DeprecatedRef.Equals(input.DeprecatedRef))
                ) && 
                (
                    this.Bars == input.Bars ||
                    this.Bars != null &&
                    input.Bars != null &&
                    this.Bars.SequenceEqual(input.Bars)
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
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.DeprecatedRef != null)
                {
                    hashCode = (hashCode * 59) + this.DeprecatedRef.GetHashCode();
                }
                if (this.Bars != null)
                {
                    hashCode = (hashCode * 59) + this.Bars.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
