/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// EdFiGraduationPlanCreditsByCreditCategory
    /// </summary>
    [DataContract]
    public partial class EdFiGraduationPlanCreditsByCreditCategory :  IEquatable<EdFiGraduationPlanCreditsByCreditCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanCreditsByCreditCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGraduationPlanCreditsByCreditCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanCreditsByCreditCategory" /> class.
        /// </summary>
        /// <param name="creditCategoryDescriptor">A categorization for the course transcript credits awarded in the course transcript. (required).</param>
        /// <param name="creditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="creditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="credits">The value of credits or units of value awarded for the completion of a course. (required).</param>
        public EdFiGraduationPlanCreditsByCreditCategory(string creditCategoryDescriptor = default(string), string creditTypeDescriptor = default(string), double? creditConversion = default(double?), double? credits = default(double?))
        {
            // to ensure "creditCategoryDescriptor" is required (not null)
            if (creditCategoryDescriptor == null)
            {
                throw new InvalidDataException("creditCategoryDescriptor is a required property for EdFiGraduationPlanCreditsByCreditCategory and cannot be null");
            }
            else
            {
                this.CreditCategoryDescriptor = creditCategoryDescriptor;
            }
            // to ensure "credits" is required (not null)
            if (credits == null)
            {
                throw new InvalidDataException("credits is a required property for EdFiGraduationPlanCreditsByCreditCategory and cannot be null");
            }
            else
            {
                this.Credits = credits;
            }
            this.CreditTypeDescriptor = creditTypeDescriptor;
            this.CreditConversion = creditConversion;
        }
        
        /// <summary>
        /// A categorization for the course transcript credits awarded in the course transcript.
        /// </summary>
        /// <value>A categorization for the course transcript credits awarded in the course transcript.</value>
        [DataMember(Name="creditCategoryDescriptor", EmitDefaultValue=false)]
        public string CreditCategoryDescriptor { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="creditTypeDescriptor", EmitDefaultValue=false)]
        public string CreditTypeDescriptor { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="creditConversion", EmitDefaultValue=false)]
        public double? CreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="credits", EmitDefaultValue=false)]
        public double? Credits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiGraduationPlanCreditsByCreditCategory {\n");
            sb.Append("  CreditCategoryDescriptor: ").Append(CreditCategoryDescriptor).Append("\n");
            sb.Append("  CreditTypeDescriptor: ").Append(CreditTypeDescriptor).Append("\n");
            sb.Append("  CreditConversion: ").Append(CreditConversion).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
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
            return this.Equals(input as EdFiGraduationPlanCreditsByCreditCategory);
        }

        /// <summary>
        /// Returns true if EdFiGraduationPlanCreditsByCreditCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGraduationPlanCreditsByCreditCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGraduationPlanCreditsByCreditCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreditCategoryDescriptor == input.CreditCategoryDescriptor ||
                    (this.CreditCategoryDescriptor != null &&
                    this.CreditCategoryDescriptor.Equals(input.CreditCategoryDescriptor))
                ) && 
                (
                    this.CreditTypeDescriptor == input.CreditTypeDescriptor ||
                    (this.CreditTypeDescriptor != null &&
                    this.CreditTypeDescriptor.Equals(input.CreditTypeDescriptor))
                ) && 
                (
                    this.CreditConversion == input.CreditConversion ||
                    (this.CreditConversion != null &&
                    this.CreditConversion.Equals(input.CreditConversion))
                ) && 
                (
                    this.Credits == input.Credits ||
                    (this.Credits != null &&
                    this.Credits.Equals(input.Credits))
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
                if (this.CreditCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.CreditCategoryDescriptor.GetHashCode();
                if (this.CreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.CreditTypeDescriptor.GetHashCode();
                if (this.CreditConversion != null)
                    hashCode = hashCode * 59 + this.CreditConversion.GetHashCode();
                if (this.Credits != null)
                    hashCode = hashCode * 59 + this.Credits.GetHashCode();
                return hashCode;
            }
        }
    }

}
