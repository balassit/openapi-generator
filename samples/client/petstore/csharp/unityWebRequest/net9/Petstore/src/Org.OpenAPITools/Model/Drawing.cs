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
    /// Drawing
    /// </summary>
    [DataContract(Name = "Drawing")]
    public partial class Drawing : IEquatable<Drawing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drawing" /> class.
        /// </summary>
        /// <param name="mainShape">mainShape.</param>
        /// <param name="shapeOrNull">shapeOrNull.</param>
        /// <param name="nullableShape">nullableShape.</param>
        /// <param name="shapes">shapes.</param>
        public Drawing(Shape mainShape = default(Shape), ShapeOrNull? shapeOrNull = default(ShapeOrNull), NullableShape? nullableShape = default(NullableShape), List<Shape> shapes = default(List<Shape>))
        {
            this.MainShape = mainShape;
            this.ShapeOrNull = shapeOrNull;
            this.NullableShape = nullableShape;
            this.Shapes = shapes;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets MainShape
        /// </summary>
        [DataMember(Name = "mainShape", EmitDefaultValue = false)]
        public Shape MainShape { get; set; }

        /// <summary>
        /// Gets or Sets ShapeOrNull
        /// </summary>
        [DataMember(Name = "shapeOrNull", EmitDefaultValue = true)]
        public ShapeOrNull? ShapeOrNull { get; set; }

        /// <summary>
        /// Gets or Sets NullableShape
        /// </summary>
        [DataMember(Name = "nullableShape", EmitDefaultValue = true)]
        public NullableShape? NullableShape { get; set; }

        /// <summary>
        /// Gets or Sets Shapes
        /// </summary>
        [DataMember(Name = "shapes", EmitDefaultValue = false)]
        public List<Shape> Shapes { get; set; }

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
            sb.Append("class Drawing {\n");
            sb.Append("  MainShape: ").Append(MainShape).Append("\n");
            sb.Append("  ShapeOrNull: ").Append(ShapeOrNull).Append("\n");
            sb.Append("  NullableShape: ").Append(NullableShape).Append("\n");
            sb.Append("  Shapes: ").Append(Shapes).Append("\n");
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
            return this.Equals(input as Drawing);
        }

        /// <summary>
        /// Returns true if Drawing instances are equal
        /// </summary>
        /// <param name="input">Instance of Drawing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Drawing input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MainShape == input.MainShape ||
                    (this.MainShape != null &&
                    this.MainShape.Equals(input.MainShape))
                ) && 
                (
                    this.ShapeOrNull == input.ShapeOrNull ||
                    (this.ShapeOrNull != null &&
                    this.ShapeOrNull.Equals(input.ShapeOrNull))
                ) && 
                (
                    this.NullableShape == input.NullableShape ||
                    (this.NullableShape != null &&
                    this.NullableShape.Equals(input.NullableShape))
                ) && 
                (
                    this.Shapes == input.Shapes ||
                    this.Shapes != null &&
                    input.Shapes != null &&
                    this.Shapes.SequenceEqual(input.Shapes)
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
                if (this.MainShape != null)
                {
                    hashCode = (hashCode * 59) + this.MainShape.GetHashCode();
                }
                if (this.ShapeOrNull != null)
                {
                    hashCode = (hashCode * 59) + this.ShapeOrNull.GetHashCode();
                }
                if (this.NullableShape != null)
                {
                    hashCode = (hashCode * 59) + this.NullableShape.GetHashCode();
                }
                if (this.Shapes != null)
                {
                    hashCode = (hashCode * 59) + this.Shapes.GetHashCode();
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
