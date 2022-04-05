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
    /// TpdmPerformanceEvaluationRatingReviewer
    /// </summary>
    [DataContract]
    public partial class TpdmPerformanceEvaluationRatingReviewer :  IEquatable<TpdmPerformanceEvaluationRatingReviewer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmPerformanceEvaluationRatingReviewer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmPerformanceEvaluationRatingReviewer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmPerformanceEvaluationRatingReviewer" /> class.
        /// </summary>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="reviewerPersonReference">reviewerPersonReference.</param>
        /// <param name="receivedTraining">receivedTraining.</param>
        public TpdmPerformanceEvaluationRatingReviewer(string firstName = default(string), string lastSurname = default(string), EdFiPersonReference reviewerPersonReference = default(EdFiPersonReference), TpdmPerformanceEvaluationRatingReviewerReceivedTraining receivedTraining = default(TpdmPerformanceEvaluationRatingReviewerReceivedTraining))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for TpdmPerformanceEvaluationRatingReviewer and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastSurname" is required (not null)
            if (lastSurname == null)
            {
                throw new InvalidDataException("lastSurname is a required property for TpdmPerformanceEvaluationRatingReviewer and cannot be null");
            }
            else
            {
                this.LastSurname = lastSurname;
            }
            this.ReviewerPersonReference = reviewerPersonReference;
            this.ReceivedTraining = receivedTraining;
        }
        
        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name="lastSurname", EmitDefaultValue=false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// Gets or Sets ReviewerPersonReference
        /// </summary>
        [DataMember(Name="reviewerPersonReference", EmitDefaultValue=false)]
        public EdFiPersonReference ReviewerPersonReference { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedTraining
        /// </summary>
        [DataMember(Name="receivedTraining", EmitDefaultValue=false)]
        public TpdmPerformanceEvaluationRatingReviewerReceivedTraining ReceivedTraining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmPerformanceEvaluationRatingReviewer {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  ReviewerPersonReference: ").Append(ReviewerPersonReference).Append("\n");
            sb.Append("  ReceivedTraining: ").Append(ReceivedTraining).Append("\n");
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
            return this.Equals(input as TpdmPerformanceEvaluationRatingReviewer);
        }

        /// <summary>
        /// Returns true if TpdmPerformanceEvaluationRatingReviewer instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmPerformanceEvaluationRatingReviewer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmPerformanceEvaluationRatingReviewer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.ReviewerPersonReference == input.ReviewerPersonReference ||
                    (this.ReviewerPersonReference != null &&
                    this.ReviewerPersonReference.Equals(input.ReviewerPersonReference))
                ) && 
                (
                    this.ReceivedTraining == input.ReceivedTraining ||
                    (this.ReceivedTraining != null &&
                    this.ReceivedTraining.Equals(input.ReceivedTraining))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.ReviewerPersonReference != null)
                    hashCode = hashCode * 59 + this.ReviewerPersonReference.GetHashCode();
                if (this.ReceivedTraining != null)
                    hashCode = hashCode * 59 + this.ReceivedTraining.GetHashCode();
                return hashCode;
            }
        }
    }

}
