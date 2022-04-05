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
    /// EdFiDisciplineActionStudentDisciplineIncidentAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiDisciplineActionStudentDisciplineIncidentAssociation :  IEquatable<EdFiDisciplineActionStudentDisciplineIncidentAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineActionStudentDisciplineIncidentAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineActionStudentDisciplineIncidentAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineActionStudentDisciplineIncidentAssociation" /> class.
        /// </summary>
        /// <param name="studentDisciplineIncidentAssociationReference">studentDisciplineIncidentAssociationReference (required).</param>
        public EdFiDisciplineActionStudentDisciplineIncidentAssociation(EdFiStudentDisciplineIncidentAssociationReference studentDisciplineIncidentAssociationReference = default(EdFiStudentDisciplineIncidentAssociationReference))
        {
            // to ensure "studentDisciplineIncidentAssociationReference" is required (not null)
            if (studentDisciplineIncidentAssociationReference == null)
            {
                throw new InvalidDataException("studentDisciplineIncidentAssociationReference is a required property for EdFiDisciplineActionStudentDisciplineIncidentAssociation and cannot be null");
            }
            else
            {
                this.StudentDisciplineIncidentAssociationReference = studentDisciplineIncidentAssociationReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets StudentDisciplineIncidentAssociationReference
        /// </summary>
        [DataMember(Name="studentDisciplineIncidentAssociationReference", EmitDefaultValue=false)]
        public EdFiStudentDisciplineIncidentAssociationReference StudentDisciplineIncidentAssociationReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiDisciplineActionStudentDisciplineIncidentAssociation {\n");
            sb.Append("  StudentDisciplineIncidentAssociationReference: ").Append(StudentDisciplineIncidentAssociationReference).Append("\n");
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
            return this.Equals(input as EdFiDisciplineActionStudentDisciplineIncidentAssociation);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineActionStudentDisciplineIncidentAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineActionStudentDisciplineIncidentAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineActionStudentDisciplineIncidentAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StudentDisciplineIncidentAssociationReference == input.StudentDisciplineIncidentAssociationReference ||
                    (this.StudentDisciplineIncidentAssociationReference != null &&
                    this.StudentDisciplineIncidentAssociationReference.Equals(input.StudentDisciplineIncidentAssociationReference))
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
                if (this.StudentDisciplineIncidentAssociationReference != null)
                    hashCode = hashCode * 59 + this.StudentDisciplineIncidentAssociationReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
