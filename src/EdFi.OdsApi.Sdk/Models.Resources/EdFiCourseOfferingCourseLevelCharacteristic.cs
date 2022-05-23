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
    /// EdFiCourseOfferingCourseLevelCharacteristic
    /// </summary>
    [DataContract]
    public partial class EdFiCourseOfferingCourseLevelCharacteristic :  IEquatable<EdFiCourseOfferingCourseLevelCharacteristic>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingCourseLevelCharacteristic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseOfferingCourseLevelCharacteristic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingCourseLevelCharacteristic" /> class.
        /// </summary>
        /// <param name="courseLevelCharacteristicDescriptor">The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level. (required).</param>
        public EdFiCourseOfferingCourseLevelCharacteristic(string courseLevelCharacteristicDescriptor = default(string))
        {
            // to ensure "courseLevelCharacteristicDescriptor" is required (not null)
            if (courseLevelCharacteristicDescriptor == null)
            {
                throw new InvalidDataException("courseLevelCharacteristicDescriptor is a required property for EdFiCourseOfferingCourseLevelCharacteristic and cannot be null");
            }
            else
            {
                this.CourseLevelCharacteristicDescriptor = courseLevelCharacteristicDescriptor;
            }
        }
        
        /// <summary>
        /// The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level.
        /// </summary>
        /// <value>The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level.</value>
        [DataMember(Name="courseLevelCharacteristicDescriptor", EmitDefaultValue=false)]
        public string CourseLevelCharacteristicDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourseOfferingCourseLevelCharacteristic {\n");
            sb.Append("  CourseLevelCharacteristicDescriptor: ").Append(CourseLevelCharacteristicDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCourseOfferingCourseLevelCharacteristic);
        }

        /// <summary>
        /// Returns true if EdFiCourseOfferingCourseLevelCharacteristic instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseOfferingCourseLevelCharacteristic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseOfferingCourseLevelCharacteristic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CourseLevelCharacteristicDescriptor == input.CourseLevelCharacteristicDescriptor ||
                    (this.CourseLevelCharacteristicDescriptor != null &&
                    this.CourseLevelCharacteristicDescriptor.Equals(input.CourseLevelCharacteristicDescriptor))
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
                if (this.CourseLevelCharacteristicDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseLevelCharacteristicDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}