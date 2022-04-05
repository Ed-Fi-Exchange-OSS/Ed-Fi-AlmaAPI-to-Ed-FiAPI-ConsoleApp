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
    /// TpdmEvaluationRating
    /// </summary>
    [DataContract]
    public partial class TpdmEvaluationRating :  IEquatable<TpdmEvaluationRating>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRating" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationRating() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRating" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="evaluationDate">The date for the person&#39;s evaluation. (required).</param>
        /// <param name="evaluationReference">evaluationReference (required).</param>
        /// <param name="performanceEvaluationRatingReference">performanceEvaluationRatingReference (required).</param>
        /// <param name="sectionReference">sectionReference.</param>
        /// <param name="evaluationRatingLevelDescriptor">The rating level achieved based upon the rating or score..</param>
        /// <param name="evaluationRatingStatusDescriptor">The Status of the poerformance evaluation..</param>
        /// <param name="results">An unordered collection of evaluationRatingResults. The numerical summary rating or score for the evaluation..</param>
        /// <param name="reviewers">An unordered collection of evaluationRatingReviewers. The person(s) that conducted the performance evaluation..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmEvaluationRating(string id = default(string), DateTime? evaluationDate = default(DateTime?), TpdmEvaluationReference evaluationReference = default(TpdmEvaluationReference), TpdmPerformanceEvaluationRatingReference performanceEvaluationRatingReference = default(TpdmPerformanceEvaluationRatingReference), EdFiSectionReference sectionReference = default(EdFiSectionReference), string evaluationRatingLevelDescriptor = default(string), string evaluationRatingStatusDescriptor = default(string), List<TpdmEvaluationRatingResult> results = default(List<TpdmEvaluationRatingResult>), List<TpdmEvaluationRatingReviewer> reviewers = default(List<TpdmEvaluationRatingReviewer>), string etag = default(string))
        {
            // to ensure "evaluationDate" is required (not null)
            if (evaluationDate == null)
            {
                throw new InvalidDataException("evaluationDate is a required property for TpdmEvaluationRating and cannot be null");
            }
            else
            {
                this.EvaluationDate = evaluationDate;
            }
            // to ensure "evaluationReference" is required (not null)
            if (evaluationReference == null)
            {
                throw new InvalidDataException("evaluationReference is a required property for TpdmEvaluationRating and cannot be null");
            }
            else
            {
                this.EvaluationReference = evaluationReference;
            }
            // to ensure "performanceEvaluationRatingReference" is required (not null)
            if (performanceEvaluationRatingReference == null)
            {
                throw new InvalidDataException("performanceEvaluationRatingReference is a required property for TpdmEvaluationRating and cannot be null");
            }
            else
            {
                this.PerformanceEvaluationRatingReference = performanceEvaluationRatingReference;
            }
            this.Id = id;
            this.SectionReference = sectionReference;
            this.EvaluationRatingLevelDescriptor = evaluationRatingLevelDescriptor;
            this.EvaluationRatingStatusDescriptor = evaluationRatingStatusDescriptor;
            this.Results = results;
            this.Reviewers = reviewers;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The date for the person&#39;s evaluation.
        /// </summary>
        /// <value>The date for the person&#39;s evaluation.</value>
        [DataMember(Name="evaluationDate", EmitDefaultValue=false)]
        public DateTime? EvaluationDate { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationReference
        /// </summary>
        [DataMember(Name="evaluationReference", EmitDefaultValue=false)]
        public TpdmEvaluationReference EvaluationReference { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceEvaluationRatingReference
        /// </summary>
        [DataMember(Name="performanceEvaluationRatingReference", EmitDefaultValue=false)]
        public TpdmPerformanceEvaluationRatingReference PerformanceEvaluationRatingReference { get; set; }

        /// <summary>
        /// Gets or Sets SectionReference
        /// </summary>
        [DataMember(Name="sectionReference", EmitDefaultValue=false)]
        public EdFiSectionReference SectionReference { get; set; }

        /// <summary>
        /// The rating level achieved based upon the rating or score.
        /// </summary>
        /// <value>The rating level achieved based upon the rating or score.</value>
        [DataMember(Name="evaluationRatingLevelDescriptor", EmitDefaultValue=false)]
        public string EvaluationRatingLevelDescriptor { get; set; }

        /// <summary>
        /// The Status of the poerformance evaluation.
        /// </summary>
        /// <value>The Status of the poerformance evaluation.</value>
        [DataMember(Name="evaluationRatingStatusDescriptor", EmitDefaultValue=false)]
        public string EvaluationRatingStatusDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of evaluationRatingResults. The numerical summary rating or score for the evaluation.
        /// </summary>
        /// <value>An unordered collection of evaluationRatingResults. The numerical summary rating or score for the evaluation.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<TpdmEvaluationRatingResult> Results { get; set; }

        /// <summary>
        /// An unordered collection of evaluationRatingReviewers. The person(s) that conducted the performance evaluation.
        /// </summary>
        /// <value>An unordered collection of evaluationRatingReviewers. The person(s) that conducted the performance evaluation.</value>
        [DataMember(Name="reviewers", EmitDefaultValue=false)]
        public List<TpdmEvaluationRatingReviewer> Reviewers { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmEvaluationRating {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EvaluationDate: ").Append(EvaluationDate).Append("\n");
            sb.Append("  EvaluationReference: ").Append(EvaluationReference).Append("\n");
            sb.Append("  PerformanceEvaluationRatingReference: ").Append(PerformanceEvaluationRatingReference).Append("\n");
            sb.Append("  SectionReference: ").Append(SectionReference).Append("\n");
            sb.Append("  EvaluationRatingLevelDescriptor: ").Append(EvaluationRatingLevelDescriptor).Append("\n");
            sb.Append("  EvaluationRatingStatusDescriptor: ").Append(EvaluationRatingStatusDescriptor).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as TpdmEvaluationRating);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationRating instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationRating input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EvaluationDate == input.EvaluationDate ||
                    (this.EvaluationDate != null &&
                    this.EvaluationDate.Equals(input.EvaluationDate))
                ) && 
                (
                    this.EvaluationReference == input.EvaluationReference ||
                    (this.EvaluationReference != null &&
                    this.EvaluationReference.Equals(input.EvaluationReference))
                ) && 
                (
                    this.PerformanceEvaluationRatingReference == input.PerformanceEvaluationRatingReference ||
                    (this.PerformanceEvaluationRatingReference != null &&
                    this.PerformanceEvaluationRatingReference.Equals(input.PerformanceEvaluationRatingReference))
                ) && 
                (
                    this.SectionReference == input.SectionReference ||
                    (this.SectionReference != null &&
                    this.SectionReference.Equals(input.SectionReference))
                ) && 
                (
                    this.EvaluationRatingLevelDescriptor == input.EvaluationRatingLevelDescriptor ||
                    (this.EvaluationRatingLevelDescriptor != null &&
                    this.EvaluationRatingLevelDescriptor.Equals(input.EvaluationRatingLevelDescriptor))
                ) && 
                (
                    this.EvaluationRatingStatusDescriptor == input.EvaluationRatingStatusDescriptor ||
                    (this.EvaluationRatingStatusDescriptor != null &&
                    this.EvaluationRatingStatusDescriptor.Equals(input.EvaluationRatingStatusDescriptor))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.Reviewers == input.Reviewers ||
                    this.Reviewers != null &&
                    this.Reviewers.SequenceEqual(input.Reviewers)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EvaluationDate != null)
                    hashCode = hashCode * 59 + this.EvaluationDate.GetHashCode();
                if (this.EvaluationReference != null)
                    hashCode = hashCode * 59 + this.EvaluationReference.GetHashCode();
                if (this.PerformanceEvaluationRatingReference != null)
                    hashCode = hashCode * 59 + this.PerformanceEvaluationRatingReference.GetHashCode();
                if (this.SectionReference != null)
                    hashCode = hashCode * 59 + this.SectionReference.GetHashCode();
                if (this.EvaluationRatingLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.EvaluationRatingLevelDescriptor.GetHashCode();
                if (this.EvaluationRatingStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.EvaluationRatingStatusDescriptor.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Reviewers != null)
                    hashCode = hashCode * 59 + this.Reviewers.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
