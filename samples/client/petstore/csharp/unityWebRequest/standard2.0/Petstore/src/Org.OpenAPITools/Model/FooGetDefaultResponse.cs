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
    /// FooGetDefaultResponse
    /// </summary>
    [DataContract(Name = "_foo_get_default_response")]
    public partial class FooGetDefaultResponse : IEquatable<FooGetDefaultResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FooGetDefaultResponse" /> class.
        /// </summary>
        /// <param name="varString">varString.</param>

        public FooGetDefaultResponse(Foo varString = default(Foo))
        {
            this.String = varString;
        }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [DataMember(Name = "string", EmitDefaultValue = false)]
        public Foo String { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FooGetDefaultResponse {\n");
            sb.Append("  String: ").Append(String).Append("\n");
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
            return this.Equals(input as FooGetDefaultResponse);
        }

        /// <summary>
        /// Returns true if FooGetDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FooGetDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FooGetDefaultResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.String == input.String ||
                    (this.String != null &&
                    this.String.Equals(input.String))
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
                if (this.String != null)
                {
                    hashCode = (hashCode * 59) + this.String.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
