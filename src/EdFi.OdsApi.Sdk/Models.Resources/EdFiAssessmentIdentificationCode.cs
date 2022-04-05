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
    /// EdFiAssessmentIdentificationCode
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentIdentificationCode :  IEquatable<EdFiAssessmentIdentificationCode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentIdentificationCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentIdentificationCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentIdentificationCode" /> class.
        /// </summary>
        /// <param name="assessmentIdentificationSystemDescriptor">A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment. (required).</param>
        /// <param name="assigningOrganizationIdentificationCode">The organization code or name assigning the assessment identification code..</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to an assessment by a school, school system, state, or other agency or entity. (required).</param>
        public EdFiAssessmentIdentificationCode(string assessmentIdentificationSystemDescriptor = default(string), string assigningOrganizationIdentificationCode = default(string), string identificationCode = default(string))
        {
            // to ensure "assessmentIdentificationSystemDescriptor" is required (not null)
            if (assessmentIdentificationSystemDescriptor == null)
            {
                throw new InvalidDataException("assessmentIdentificationSystemDescriptor is a required property for EdFiAssessmentIdentificationCode and cannot be null");
            }
            else
            {
                this.AssessmentIdentificationSystemDescriptor = assessmentIdentificationSystemDescriptor;
            }
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new InvalidDataException("identificationCode is a required property for EdFiAssessmentIdentificationCode and cannot be null");
            }
            else
            {
                this.IdentificationCode = identificationCode;
            }
            this.AssigningOrganizationIdentificationCode = assigningOrganizationIdentificationCode;
        }
        
        /// <summary>
        /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment.
        /// </summary>
        /// <value>A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment.</value>
        [DataMember(Name="assessmentIdentificationSystemDescriptor", EmitDefaultValue=false)]
        public string AssessmentIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// The organization code or name assigning the assessment identification code.
        /// </summary>
        /// <value>The organization code or name assigning the assessment identification code.</value>
        [DataMember(Name="assigningOrganizationIdentificationCode", EmitDefaultValue=false)]
        public string AssigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentIdentificationCode {\n");
            sb.Append("  AssessmentIdentificationSystemDescriptor: ").Append(AssessmentIdentificationSystemDescriptor).Append("\n");
            sb.Append("  AssigningOrganizationIdentificationCode: ").Append(AssigningOrganizationIdentificationCode).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
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
            return this.Equals(input as EdFiAssessmentIdentificationCode);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentIdentificationCode instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentIdentificationCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentIdentificationCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentIdentificationSystemDescriptor == input.AssessmentIdentificationSystemDescriptor ||
                    (this.AssessmentIdentificationSystemDescriptor != null &&
                    this.AssessmentIdentificationSystemDescriptor.Equals(input.AssessmentIdentificationSystemDescriptor))
                ) && 
                (
                    this.AssigningOrganizationIdentificationCode == input.AssigningOrganizationIdentificationCode ||
                    (this.AssigningOrganizationIdentificationCode != null &&
                    this.AssigningOrganizationIdentificationCode.Equals(input.AssigningOrganizationIdentificationCode))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
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
                if (this.AssessmentIdentificationSystemDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentIdentificationSystemDescriptor.GetHashCode();
                if (this.AssigningOrganizationIdentificationCode != null)
                    hashCode = hashCode * 59 + this.AssigningOrganizationIdentificationCode.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
                return hashCode;
            }
        }
    }

}
