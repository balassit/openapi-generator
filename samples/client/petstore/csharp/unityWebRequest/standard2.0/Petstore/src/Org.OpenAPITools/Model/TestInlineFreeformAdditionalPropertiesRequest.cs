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
    /// TestInlineFreeformAdditionalPropertiesRequest
    /// </summary>
    [DataContract(Name = "testInlineFreeformAdditionalProperties_request")]
    public partial class TestInlineFreeformAdditionalPropertiesRequest : IEquatable<TestInlineFreeformAdditionalPropertiesRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestInlineFreeformAdditionalPropertiesRequest" /> class.
        /// </summary>
        /// <param name="someProperty">someProperty.</param>

        public TestInlineFreeformAdditionalPropertiesRequest(string someProperty = default(string))
        {
            this.SomeProperty = someProperty;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets SomeProperty
        /// </summary>
        [DataMember(Name = "someProperty", EmitDefaultValue = false)]
        public string SomeProperty { get; set; }

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
            sb.Append("class TestInlineFreeformAdditionalPropertiesRequest {\n");
            sb.Append("  SomeProperty: ").Append(SomeProperty).Append("\n");
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
            return this.Equals(input as TestInlineFreeformAdditionalPropertiesRequest);
        }

        /// <summary>
        /// Returns true if TestInlineFreeformAdditionalPropertiesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TestInlineFreeformAdditionalPropertiesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestInlineFreeformAdditionalPropertiesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SomeProperty == input.SomeProperty ||
                    (this.SomeProperty != null &&
                    this.SomeProperty.Equals(input.SomeProperty))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.SomeProperty != null)
                {
                    hashCode = (hashCode * 59) + this.SomeProperty.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
