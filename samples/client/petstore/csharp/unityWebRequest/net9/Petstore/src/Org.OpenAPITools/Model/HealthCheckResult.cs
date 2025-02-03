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
    /// Just a string to inform instance is up and running. Make it nullable in hope to get it as pointer in generated model.
    /// </summary>
    [DataContract(Name = "HealthCheckResult")]
    public partial class HealthCheckResult : IEquatable<HealthCheckResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckResult" /> class.
        /// </summary>
        /// <param name="nullableMessage">nullableMessage.</param>

        public HealthCheckResult(string nullableMessage = default(string))
        {
            this.NullableMessage = nullableMessage;
        }

        /// <summary>
        /// Gets or Sets NullableMessage
        /// </summary>
        [DataMember(Name = "NullableMessage", EmitDefaultValue = true)]
        public string NullableMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HealthCheckResult {\n");
            sb.Append("  NullableMessage: ").Append(NullableMessage).Append("\n");
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
            return this.Equals(input as HealthCheckResult);
        }

        /// <summary>
        /// Returns true if HealthCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HealthCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthCheckResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NullableMessage == input.NullableMessage ||
                    (this.NullableMessage != null &&
                    this.NullableMessage.Equals(input.NullableMessage))
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
                if (this.NullableMessage != null)
                {
                    hashCode = (hashCode * 59) + this.NullableMessage.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
