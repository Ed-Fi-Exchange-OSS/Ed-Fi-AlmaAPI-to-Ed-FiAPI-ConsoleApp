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
    /// TpdmEvaluationObjectiveRatingResult
    /// </summary>
    [DataContract]
    public partial class TpdmEvaluationObjectiveRatingResult :  IEquatable<TpdmEvaluationObjectiveRatingResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjectiveRatingResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationObjectiveRatingResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjectiveRatingResult" /> class.
        /// </summary>
        /// <param name="rating">The numerical summary rating or score for the evaluation. (required).</param>
        /// <param name="ratingResultTitle">The title of Rating Result. (required).</param>
        /// <param name="resultDatatypeTypeDescriptor">The datatype of the result. (required).</param>
        public TpdmEvaluationObjectiveRatingResult(double? rating = default(double?), string ratingResultTitle = default(string), string resultDatatypeTypeDescriptor = default(string))
        {
            // to ensure "rating" is required (not null)
            if (rating == null)
            {
                throw new InvalidDataException("rating is a required property for TpdmEvaluationObjectiveRatingResult and cannot be null");
            }
            else
            {
                this.Rating = rating;
            }
            // to ensure "ratingResultTitle" is required (not null)
            if (ratingResultTitle == null)
            {
                throw new InvalidDataException("ratingResultTitle is a required property for TpdmEvaluationObjectiveRatingResult and cannot be null");
            }
            else
            {
                this.RatingResultTitle = ratingResultTitle;
            }
            // to ensure "resultDatatypeTypeDescriptor" is required (not null)
            if (resultDatatypeTypeDescriptor == null)
            {
                throw new InvalidDataException("resultDatatypeTypeDescriptor is a required property for TpdmEvaluationObjectiveRatingResult and cannot be null");
            }
            else
            {
                this.ResultDatatypeTypeDescriptor = resultDatatypeTypeDescriptor;
            }
        }
        
        /// <summary>
        /// The numerical summary rating or score for the evaluation.
        /// </summary>
        /// <value>The numerical summary rating or score for the evaluation.</value>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public double? Rating { get; set; }

        /// <summary>
        /// The title of Rating Result.
        /// </summary>
        /// <value>The title of Rating Result.</value>
        [DataMember(Name="ratingResultTitle", EmitDefaultValue=false)]
        public string RatingResultTitle { get; set; }

        /// <summary>
        /// The datatype of the result.
        /// </summary>
        /// <value>The datatype of the result.</value>
        [DataMember(Name="resultDatatypeTypeDescriptor", EmitDefaultValue=false)]
        public string ResultDatatypeTypeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmEvaluationObjectiveRatingResult {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  RatingResultTitle: ").Append(RatingResultTitle).Append("\n");
            sb.Append("  ResultDatatypeTypeDescriptor: ").Append(ResultDatatypeTypeDescriptor).Append("\n");
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
            return this.Equals(input as TpdmEvaluationObjectiveRatingResult);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationObjectiveRatingResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationObjectiveRatingResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationObjectiveRatingResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.RatingResultTitle == input.RatingResultTitle ||
                    (this.RatingResultTitle != null &&
                    this.RatingResultTitle.Equals(input.RatingResultTitle))
                ) && 
                (
                    this.ResultDatatypeTypeDescriptor == input.ResultDatatypeTypeDescriptor ||
                    (this.ResultDatatypeTypeDescriptor != null &&
                    this.ResultDatatypeTypeDescriptor.Equals(input.ResultDatatypeTypeDescriptor))
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
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.RatingResultTitle != null)
                    hashCode = hashCode * 59 + this.RatingResultTitle.GetHashCode();
                if (this.ResultDatatypeTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ResultDatatypeTypeDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
