/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Capitalization
    /// </summary>
    [DataContract]
        public partial class Capitalization :  IEquatable<Capitalization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capitalization" /> class.
        /// </summary>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">Name of the pet .</param>
        public Capitalization(string  = default(string), string  = default(string), string  = default(string), string  = default(string), string  = default(string), string  = default(string))
        {
            this.SmallCamel = ;
            this.CapitalCamel = ;
            this.SmallSnake = ;
            this.CapitalSnake = ;
            this.SCAETHFlowPoints = ;
            this.ATT_NAME = ;
        }
        
        /// <summary>
        /// Gets or Sets SmallCamel
        /// </summary>
        [DataMember(Name="smallCamel", EmitDefaultValue=false)]
        public string SmallCamel { get; set; }

        /// <summary>
        /// Gets or Sets CapitalCamel
        /// </summary>
        [DataMember(Name="CapitalCamel", EmitDefaultValue=false)]
        public string CapitalCamel { get; set; }

        /// <summary>
        /// Gets or Sets SmallSnake
        /// </summary>
        [DataMember(Name="small_Snake", EmitDefaultValue=false)]
        public string SmallSnake { get; set; }

        /// <summary>
        /// Gets or Sets CapitalSnake
        /// </summary>
        [DataMember(Name="Capital_Snake", EmitDefaultValue=false)]
        public string CapitalSnake { get; set; }

        /// <summary>
        /// Gets or Sets SCAETHFlowPoints
        /// </summary>
        [DataMember(Name="SCA_ETH_Flow_Points", EmitDefaultValue=false)]
        public string SCAETHFlowPoints { get; set; }

        /// <summary>
        /// Name of the pet 
        /// </summary>
        /// <value>Name of the pet </value>
        [DataMember(Name="ATT_NAME", EmitDefaultValue=false)]
        public string ATT_NAME { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Capitalization {\n");
            sb.Append("  SmallCamel: ").Append(SmallCamel).Append("\n");
            sb.Append("  CapitalCamel: ").Append(CapitalCamel).Append("\n");
            sb.Append("  SmallSnake: ").Append(SmallSnake).Append("\n");
            sb.Append("  CapitalSnake: ").Append(CapitalSnake).Append("\n");
            sb.Append("  SCAETHFlowPoints: ").Append(SCAETHFlowPoints).Append("\n");
            sb.Append("  ATT_NAME: ").Append(ATT_NAME).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Capitalization);
        }

        /// <summary>
        /// Returns true if Capitalization instances are equal
        /// </summary>
        /// <param name="input">Instance of Capitalization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Capitalization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmallCamel == input.SmallCamel ||
                    (this.SmallCamel != null &&
                    this.SmallCamel.Equals(input.SmallCamel))
                ) && 
                (
                    this.CapitalCamel == input.CapitalCamel ||
                    (this.CapitalCamel != null &&
                    this.CapitalCamel.Equals(input.CapitalCamel))
                ) && 
                (
                    this.SmallSnake == input.SmallSnake ||
                    (this.SmallSnake != null &&
                    this.SmallSnake.Equals(input.SmallSnake))
                ) && 
                (
                    this.CapitalSnake == input.CapitalSnake ||
                    (this.CapitalSnake != null &&
                    this.CapitalSnake.Equals(input.CapitalSnake))
                ) && 
                (
                    this.SCAETHFlowPoints == input.SCAETHFlowPoints ||
                    (this.SCAETHFlowPoints != null &&
                    this.SCAETHFlowPoints.Equals(input.SCAETHFlowPoints))
                ) && 
                (
                    this.ATT_NAME == input.ATT_NAME ||
                    (this.ATT_NAME != null &&
                    this.ATT_NAME.Equals(input.ATT_NAME))
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
                if (this.SmallCamel != null)
                    hashCode = hashCode * 59 + this.SmallCamel.GetHashCode();
                if (this.CapitalCamel != null)
                    hashCode = hashCode * 59 + this.CapitalCamel.GetHashCode();
                if (this.SmallSnake != null)
                    hashCode = hashCode * 59 + this.SmallSnake.GetHashCode();
                if (this.CapitalSnake != null)
                    hashCode = hashCode * 59 + this.CapitalSnake.GetHashCode();
                if (this.SCAETHFlowPoints != null)
                    hashCode = hashCode * 59 + this.SCAETHFlowPoints.GetHashCode();
                if (this.ATT_NAME != null)
                    hashCode = hashCode * 59 + this.ATT_NAME.GetHashCode();
                return hashCode;
            }
        }

    }
}
