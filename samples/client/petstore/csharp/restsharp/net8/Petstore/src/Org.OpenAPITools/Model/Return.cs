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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Model for testing reserved words
    /// </summary>
    [DataContract(Name = "Return")]
    public partial class Return : IEquatable<Return>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Return" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Return() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Return" /> class.
        /// </summary>
        /// <param name="varReturn">varReturn.</param>
        /// <param name="varLock">varLock (required).</param>
        /// <param name="varAbstract">varAbstract (required).</param>
        /// <param name="varUnsafe">varUnsafe.</param>
        public Return(int varReturn = default(int), string varLock = default(string), string varAbstract = default(string), string varUnsafe = default(string))
        {
            // to ensure "varLock" is required (not null)
            if (varLock == null)
            {
                throw new ArgumentNullException("varLock is a required property for Return and cannot be null");
            }
            this.Lock = varLock;
            // to ensure "varAbstract" is required (not null)
            if (varAbstract == null)
            {
                throw new ArgumentNullException("varAbstract is a required property for Return and cannot be null");
            }
            this.Abstract = varAbstract;
            this.VarReturn = varReturn;
            this.Unsafe = varUnsafe;
        }

        /// <summary>
        /// Gets or Sets VarReturn
        /// </summary>
        [DataMember(Name = "return", EmitDefaultValue = true)]
        public int VarReturn { get; set; }

        /// <summary>
        /// Gets or Sets Lock
        /// </summary>
        [DataMember(Name = "lock", IsRequired = true, EmitDefaultValue = false)]
        public string Lock { get; set; }

        /// <summary>
        /// Gets or Sets Abstract
        /// </summary>
        [DataMember(Name = "abstract", IsRequired = true, EmitDefaultValue = true)]
        public string Abstract { get; set; }

        /// <summary>
        /// Gets or Sets Unsafe
        /// </summary>
        [DataMember(Name = "unsafe", EmitDefaultValue = false)]
        public string Unsafe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Return {\n");
            sb.Append("  VarReturn: ").Append(VarReturn).Append("\n");
            sb.Append("  Lock: ").Append(Lock).Append("\n");
            sb.Append("  Abstract: ").Append(Abstract).Append("\n");
            sb.Append("  Unsafe: ").Append(Unsafe).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Return).AreEqual;
        }

        /// <summary>
        /// Returns true if Return instances are equal
        /// </summary>
        /// <param name="input">Instance of Return to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Return input)
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
                hashCode = (hashCode * 59) + this.VarReturn.GetHashCode();
                if (this.Lock != null)
                {
                    hashCode = (hashCode * 59) + this.Lock.GetHashCode();
                }
                if (this.Abstract != null)
                {
                    hashCode = (hashCode * 59) + this.Abstract.GetHashCode();
                }
                if (this.Unsafe != null)
                {
                    hashCode = (hashCode * 59) + this.Unsafe.GetHashCode();
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
