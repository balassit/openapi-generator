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
    /// Role report Hash
    /// </summary>
    [DataContract(Name = "RolesReportsHash")]
    public partial class RolesReportsHash : IEquatable<RolesReportsHash>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesReportsHash" /> class.
        /// </summary>
        /// <param name="roleUuid">roleUuid.</param>
        /// <param name="role">role.</param>

        public RolesReportsHash(Guid roleUuid = default(Guid), RolesReportsHashRole role = default(RolesReportsHashRole))
        {
            this.RoleUuid = roleUuid;
            this.Role = role;
        }

        /// <summary>
        /// Gets or Sets RoleUuid
        /// </summary>
        [DataMember(Name = "role_uuid", EmitDefaultValue = false)]
        public Guid RoleUuid { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public RolesReportsHashRole Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RolesReportsHash {\n");
            sb.Append("  RoleUuid: ").Append(RoleUuid).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as RolesReportsHash);
        }

        /// <summary>
        /// Returns true if RolesReportsHash instances are equal
        /// </summary>
        /// <param name="input">Instance of RolesReportsHash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RolesReportsHash input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoleUuid == input.RoleUuid ||
                    (this.RoleUuid != null &&
                    this.RoleUuid.Equals(input.RoleUuid))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.RoleUuid != null)
                {
                    hashCode = (hashCode * 59) + this.RoleUuid.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
