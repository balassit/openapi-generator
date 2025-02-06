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
    /// DanishPig
    /// </summary>
    [DataContract(Name = "DanishPig")]
    public partial class DanishPig : IEquatable<DanishPig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DanishPig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DanishPig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DanishPig" /> class.
        /// </summary>
        /// <param name="className">className (required).</param>
        public DanishPig(string className = default(string))
        {
            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new ArgumentNullException("className is a required property for DanishPig and cannot be null");
            }
            this.ClassName = className;
        }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", IsRequired = true, EmitDefaultValue = false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DanishPig {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
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
            return this.Equals(input as DanishPig);
        }

        /// <summary>
        /// Returns true if DanishPig instances are equal
        /// </summary>
        /// <param name="input">Instance of DanishPig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DanishPig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
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
                if (this.ClassName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassName.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
