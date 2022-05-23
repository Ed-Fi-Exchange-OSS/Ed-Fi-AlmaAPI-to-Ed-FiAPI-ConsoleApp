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
    /// EdFiInterventionPrescriptionReference
    /// </summary>
    [DataContract]
    public partial class EdFiInterventionPrescriptionReference :  IEquatable<EdFiInterventionPrescriptionReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionPrescriptionReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="interventionPrescriptionIdentificationCode">A unique number or alphanumeric code assigned to an intervention prescription. (required).</param>
        /// <param name="link">link.</param>
        public EdFiInterventionPrescriptionReference(int? educationOrganizationId = default(int?), string interventionPrescriptionIdentificationCode = default(string), Link link = default(Link))
        {
            // to ensure "educationOrganizationId" is required (not null)
            if (educationOrganizationId == null)
            {
                throw new InvalidDataException("educationOrganizationId is a required property for EdFiInterventionPrescriptionReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = educationOrganizationId;
            }
            // to ensure "interventionPrescriptionIdentificationCode" is required (not null)
            if (interventionPrescriptionIdentificationCode == null)
            {
                throw new InvalidDataException("interventionPrescriptionIdentificationCode is a required property for EdFiInterventionPrescriptionReference and cannot be null");
            }
            else
            {
                this.InterventionPrescriptionIdentificationCode = interventionPrescriptionIdentificationCode;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an intervention prescription.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an intervention prescription.</value>
        [DataMember(Name="interventionPrescriptionIdentificationCode", EmitDefaultValue=false)]
        public string InterventionPrescriptionIdentificationCode { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionPrescriptionReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  InterventionPrescriptionIdentificationCode: ").Append(InterventionPrescriptionIdentificationCode).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiInterventionPrescriptionReference);
        }

        /// <summary>
        /// Returns true if EdFiInterventionPrescriptionReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionPrescriptionReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionPrescriptionReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.InterventionPrescriptionIdentificationCode == input.InterventionPrescriptionIdentificationCode ||
                    (this.InterventionPrescriptionIdentificationCode != null &&
                    this.InterventionPrescriptionIdentificationCode.Equals(input.InterventionPrescriptionIdentificationCode))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.InterventionPrescriptionIdentificationCode != null)
                    hashCode = hashCode * 59 + this.InterventionPrescriptionIdentificationCode.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}