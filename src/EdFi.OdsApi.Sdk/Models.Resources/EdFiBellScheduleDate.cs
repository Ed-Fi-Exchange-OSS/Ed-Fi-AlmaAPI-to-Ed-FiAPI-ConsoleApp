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
    /// EdFiBellScheduleDate
    /// </summary>
    [DataContract]
    public partial class EdFiBellScheduleDate :  IEquatable<EdFiBellScheduleDate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBellScheduleDate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiBellScheduleDate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBellScheduleDate" /> class.
        /// </summary>
        /// <param name="date">The dates for which the BellSchedule applies. (required).</param>
        public EdFiBellScheduleDate(DateTime? date = default(DateTime?))
        {
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for EdFiBellScheduleDate and cannot be null");
            }
            else
            {
                this.Date = date;
            }
        }
        
        /// <summary>
        /// The dates for which the BellSchedule applies.
        /// </summary>
        /// <value>The dates for which the BellSchedule applies.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiBellScheduleDate {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as EdFiBellScheduleDate);
        }

        /// <summary>
        /// Returns true if EdFiBellScheduleDate instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiBellScheduleDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiBellScheduleDate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                return hashCode;
            }
        }
    }

}
