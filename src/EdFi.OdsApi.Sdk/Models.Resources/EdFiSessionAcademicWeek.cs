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
    /// EdFiSessionAcademicWeek
    /// </summary>
    [DataContract]
    public partial class EdFiSessionAcademicWeek :  IEquatable<EdFiSessionAcademicWeek>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSessionAcademicWeek" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSessionAcademicWeek() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSessionAcademicWeek" /> class.
        /// </summary>
        /// <param name="academicWeekReference">academicWeekReference (required).</param>
        public EdFiSessionAcademicWeek(EdFiAcademicWeekReference academicWeekReference = default(EdFiAcademicWeekReference))
        {
            // to ensure "academicWeekReference" is required (not null)
            if (academicWeekReference == null)
            {
                throw new InvalidDataException("academicWeekReference is a required property for EdFiSessionAcademicWeek and cannot be null");
            }
            else
            {
                this.AcademicWeekReference = academicWeekReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets AcademicWeekReference
        /// </summary>
        [DataMember(Name="academicWeekReference", EmitDefaultValue=false)]
        public EdFiAcademicWeekReference AcademicWeekReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSessionAcademicWeek {\n");
            sb.Append("  AcademicWeekReference: ").Append(AcademicWeekReference).Append("\n");
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
            return this.Equals(input as EdFiSessionAcademicWeek);
        }

        /// <summary>
        /// Returns true if EdFiSessionAcademicWeek instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSessionAcademicWeek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSessionAcademicWeek input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcademicWeekReference == input.AcademicWeekReference ||
                    (this.AcademicWeekReference != null &&
                    this.AcademicWeekReference.Equals(input.AcademicWeekReference))
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
                if (this.AcademicWeekReference != null)
                    hashCode = hashCode * 59 + this.AcademicWeekReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
