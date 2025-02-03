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
    /// Apple
    /// </summary>
    [DataContract(Name = "apple")]
    public partial class Apple : IEquatable<Apple>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apple" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar.</param>
        /// <param name="origin">origin.</param>
        /// <param name="colorCode">colorCode.</param>

        public Apple(string? cultivar = default(string), string? origin = default(string), string? colorCode = default(string))
        {
            this.Cultivar = cultivar;
            this.Origin = origin;
            this.ColorCode = colorCode;
        }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [DataMember(Name = "cultivar", EmitDefaultValue = false)]
        public string? Cultivar { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string? Origin { get; set; }

        /// <summary>
        /// Gets or Sets ColorCode
        /// </summary>
        [DataMember(Name = "color_code", EmitDefaultValue = false)]
        public string? ColorCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Apple {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  ColorCode: ").Append(ColorCode).Append("\n");
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
            return this.Equals(input as Apple);
        }

        /// <summary>
        /// Returns true if Apple instances are equal
        /// </summary>
        /// <param name="input">Instance of Apple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apple input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cultivar == input.Cultivar ||
                    (this.Cultivar != null &&
                    this.Cultivar.Equals(input.Cultivar))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.ColorCode == input.ColorCode ||
                    (this.ColorCode != null &&
                    this.ColorCode.Equals(input.ColorCode))
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
                if (this.Cultivar != null)
                {
                    hashCode = (hashCode * 59) + this.Cultivar.GetHashCode();
                }
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.ColorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ColorCode.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
