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
    /// ActivityOutputElementRepresentation
    /// </summary>
    [DataContract(Name = "ActivityOutputElementRepresentation")]
    public partial class ActivityOutputElementRepresentation : IEquatable<ActivityOutputElementRepresentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOutputElementRepresentation" /> class.
        /// </summary>
        /// <param name="prop1">prop1.</param>
        /// <param name="prop2">prop2.</param>

        public ActivityOutputElementRepresentation(string? prop1 = default(string), Object? prop2 = default(Object))
        {
            this.Prop1 = prop1;
            this.Prop2 = prop2;
        }

        /// <summary>
        /// Gets or Sets Prop1
        /// </summary>
        [DataMember(Name = "prop1", EmitDefaultValue = false)]
        public string? Prop1 { get; set; }

        /// <summary>
        /// Gets or Sets Prop2
        /// </summary>
        [DataMember(Name = "prop2", EmitDefaultValue = false)]
        public Object? Prop2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivityOutputElementRepresentation {\n");
            sb.Append("  Prop1: ").Append(Prop1).Append("\n");
            sb.Append("  Prop2: ").Append(Prop2).Append("\n");
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
            return this.Equals(input as ActivityOutputElementRepresentation);
        }

        /// <summary>
        /// Returns true if ActivityOutputElementRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityOutputElementRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOutputElementRepresentation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Prop1 == input.Prop1 ||
                    (this.Prop1 != null &&
                    this.Prop1.Equals(input.Prop1))
                ) && 
                (
                    this.Prop2 == input.Prop2 ||
                    (this.Prop2 != null &&
                    this.Prop2.Equals(input.Prop2))
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
                if (this.Prop1 != null)
                {
                    hashCode = (hashCode * 59) + this.Prop1.GetHashCode();
                }
                if (this.Prop2 != null)
                {
                    hashCode = (hashCode * 59) + this.Prop2.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
