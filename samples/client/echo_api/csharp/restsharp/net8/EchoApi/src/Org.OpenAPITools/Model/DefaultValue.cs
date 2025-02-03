/*
 * Echo Server API
 *
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// to test the default value of properties
    /// </summary>
    [DataContract(Name = "DefaultValue")]
    public partial class DefaultValue : IEquatable<DefaultValue>, IValidatableObject
    {
        /// <summary>
        /// Defines ArrayStringEnumDefault
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ArrayStringEnumDefaultEnum
        {
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 1,

            /// <summary>
            /// Enum Failure for value: failure
            /// </summary>
            [EnumMember(Value = "failure")]
            Failure = 2,

            /// <summary>
            /// Enum Unclassified for value: unclassified
            /// </summary>
            [EnumMember(Value = "unclassified")]
            Unclassified = 3
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultValue" /> class.
        /// </summary>
        /// <param name="arrayStringEnumRefDefault">arrayStringEnumRefDefault.</param>
        /// <param name="arrayStringEnumDefault">arrayStringEnumDefault.</param>
        /// <param name="arrayStringDefault">arrayStringDefault.</param>
        /// <param name="arrayIntegerDefault">arrayIntegerDefault.</param>
        /// <param name="arrayString">arrayString.</param>
        /// <param name="arrayStringNullable">arrayStringNullable.</param>
        /// <param name="arrayStringExtensionNullable">arrayStringExtensionNullable.</param>
        /// <param name="stringNullable">stringNullable.</param>
        public DefaultValue(List<StringEnumRef> arrayStringEnumRefDefault = default(List<StringEnumRef>), List<ArrayStringEnumDefaultEnum> arrayStringEnumDefault = default(List<ArrayStringEnumDefaultEnum>), List<string> arrayStringDefault = default(List<string>), List<int> arrayIntegerDefault = default(List<int>), List<string> arrayString = default(List<string>), List<string> arrayStringNullable = default(List<string>), List<string> arrayStringExtensionNullable = default(List<string>), string? stringNullable = default(string))
        {
            this.ArrayStringEnumRefDefault = arrayStringEnumRefDefault;
            this.ArrayStringEnumDefault = arrayStringEnumDefault;
            this.ArrayStringDefault = arrayStringDefault;
            this.ArrayIntegerDefault = arrayIntegerDefault;
            this.ArrayString = arrayString;
            this.ArrayStringNullable = arrayStringNullable;
            this.ArrayStringExtensionNullable = arrayStringExtensionNullable;
            this.StringNullable = stringNullable;
        }

        /// <summary>
        /// Gets or Sets ArrayStringEnumRefDefault
        /// </summary>
        [DataMember(Name = "array_string_enum_ref_default", EmitDefaultValue = false)]
        public List<StringEnumRef> ArrayStringEnumRefDefault { get; set; }

        /// <summary>
        /// Gets or Sets ArrayStringEnumDefault
        /// </summary>
        [DataMember(Name = "array_string_enum_default", EmitDefaultValue = false)]
        public List<DefaultValue.ArrayStringEnumDefaultEnum> ArrayStringEnumDefault { get; set; }

        /// <summary>
        /// Gets or Sets ArrayStringDefault
        /// </summary>
        [DataMember(Name = "array_string_default", EmitDefaultValue = false)]
        public List<string> ArrayStringDefault { get; set; }

        /// <summary>
        /// Gets or Sets ArrayIntegerDefault
        /// </summary>
        [DataMember(Name = "array_integer_default", EmitDefaultValue = false)]
        public List<int> ArrayIntegerDefault { get; set; }

        /// <summary>
        /// Gets or Sets ArrayString
        /// </summary>
        [DataMember(Name = "array_string", EmitDefaultValue = false)]
        public List<string> ArrayString { get; set; }

        /// <summary>
        /// Gets or Sets ArrayStringNullable
        /// </summary>
        [DataMember(Name = "array_string_nullable", EmitDefaultValue = true)]
        public List<string> ArrayStringNullable { get; set; }

        /// <summary>
        /// Gets or Sets ArrayStringExtensionNullable
        /// </summary>
        [DataMember(Name = "array_string_extension_nullable", EmitDefaultValue = true)]
        public List<string> ArrayStringExtensionNullable { get; set; }

        /// <summary>
        /// Gets or Sets StringNullable
        /// </summary>
        [DataMember(Name = "string_nullable", EmitDefaultValue = true)]
        public string? StringNullable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DefaultValue {\n");
            sb.Append("  ArrayStringEnumRefDefault: ").Append(ArrayStringEnumRefDefault).Append("\n");
            sb.Append("  ArrayStringEnumDefault: ").Append(ArrayStringEnumDefault).Append("\n");
            sb.Append("  ArrayStringDefault: ").Append(ArrayStringDefault).Append("\n");
            sb.Append("  ArrayIntegerDefault: ").Append(ArrayIntegerDefault).Append("\n");
            sb.Append("  ArrayString: ").Append(ArrayString).Append("\n");
            sb.Append("  ArrayStringNullable: ").Append(ArrayStringNullable).Append("\n");
            sb.Append("  ArrayStringExtensionNullable: ").Append(ArrayStringExtensionNullable).Append("\n");
            sb.Append("  StringNullable: ").Append(StringNullable).Append("\n");
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
            return this.Equals(input as DefaultValue);
        }

        /// <summary>
        /// Returns true if DefaultValue instances are equal
        /// </summary>
        /// <param name="input">Instance of DefaultValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultValue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArrayStringEnumRefDefault == input.ArrayStringEnumRefDefault ||
                    this.ArrayStringEnumRefDefault != null &&
                    input.ArrayStringEnumRefDefault != null &&
                    this.ArrayStringEnumRefDefault.SequenceEqual(input.ArrayStringEnumRefDefault)
                ) && 
                (
                    this.ArrayStringEnumDefault == input.ArrayStringEnumDefault ||
                    this.ArrayStringEnumDefault != null &&
                    input.ArrayStringEnumDefault != null &&
                    this.ArrayStringEnumDefault.SequenceEqual(input.ArrayStringEnumDefault)
                ) && 
                (
                    this.ArrayStringDefault == input.ArrayStringDefault ||
                    this.ArrayStringDefault != null &&
                    input.ArrayStringDefault != null &&
                    this.ArrayStringDefault.SequenceEqual(input.ArrayStringDefault)
                ) && 
                (
                    this.ArrayIntegerDefault == input.ArrayIntegerDefault ||
                    this.ArrayIntegerDefault != null &&
                    input.ArrayIntegerDefault != null &&
                    this.ArrayIntegerDefault.SequenceEqual(input.ArrayIntegerDefault)
                ) && 
                (
                    this.ArrayString == input.ArrayString ||
                    this.ArrayString != null &&
                    input.ArrayString != null &&
                    this.ArrayString.SequenceEqual(input.ArrayString)
                ) && 
                (
                    this.ArrayStringNullable == input.ArrayStringNullable ||
                    this.ArrayStringNullable != null &&
                    input.ArrayStringNullable != null &&
                    this.ArrayStringNullable.SequenceEqual(input.ArrayStringNullable)
                ) && 
                (
                    this.ArrayStringExtensionNullable == input.ArrayStringExtensionNullable ||
                    this.ArrayStringExtensionNullable != null &&
                    input.ArrayStringExtensionNullable != null &&
                    this.ArrayStringExtensionNullable.SequenceEqual(input.ArrayStringExtensionNullable)
                ) && 
                (
                    this.StringNullable == input.StringNullable ||
                    (this.StringNullable != null &&
                    this.StringNullable.Equals(input.StringNullable))
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
                if (this.ArrayStringEnumRefDefault != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayStringEnumRefDefault.GetHashCode();
                }
                if (this.ArrayStringEnumDefault != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayStringEnumDefault.GetHashCode();
                }
                if (this.ArrayStringDefault != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayStringDefault.GetHashCode();
                }
                if (this.ArrayIntegerDefault != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayIntegerDefault.GetHashCode();
                }
                if (this.ArrayString != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayString.GetHashCode();
                }
                if (this.ArrayStringNullable != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayStringNullable.GetHashCode();
                }
                if (this.ArrayStringExtensionNullable != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayStringExtensionNullable.GetHashCode();
                }
                if (this.StringNullable != null)
                {
                    hashCode = (hashCode * 59) + this.StringNullable.GetHashCode();
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
