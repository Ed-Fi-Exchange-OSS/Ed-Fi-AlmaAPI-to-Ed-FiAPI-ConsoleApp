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
    /// TpdmRubricDimension
    /// </summary>
    [DataContract]
    public partial class TpdmRubricDimension :  IEquatable<TpdmRubricDimension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRubricDimension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmRubricDimension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRubricDimension" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="rubricRating">The rating achieved for the rubric dimension. (required).</param>
        /// <param name="evaluationElementReference">evaluationElementReference (required).</param>
        /// <param name="criterionDescription">The criterion description for the rubric dimension. (required).</param>
        /// <param name="dimensionOrder">The order for the rubric dimension..</param>
        /// <param name="rubricRatingLevelDescriptor">The rating level achieved for the rubric dimension..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmRubricDimension(string id = default(string), int? rubricRating = default(int?), TpdmEvaluationElementReference evaluationElementReference = default(TpdmEvaluationElementReference), string criterionDescription = default(string), int? dimensionOrder = default(int?), string rubricRatingLevelDescriptor = default(string), string etag = default(string))
        {
            // to ensure "rubricRating" is required (not null)
            if (rubricRating == null)
            {
                throw new InvalidDataException("rubricRating is a required property for TpdmRubricDimension and cannot be null");
            }
            else
            {
                this.RubricRating = rubricRating;
            }
            // to ensure "evaluationElementReference" is required (not null)
            if (evaluationElementReference == null)
            {
                throw new InvalidDataException("evaluationElementReference is a required property for TpdmRubricDimension and cannot be null");
            }
            else
            {
                this.EvaluationElementReference = evaluationElementReference;
            }
            // to ensure "criterionDescription" is required (not null)
            if (criterionDescription == null)
            {
                throw new InvalidDataException("criterionDescription is a required property for TpdmRubricDimension and cannot be null");
            }
            else
            {
                this.CriterionDescription = criterionDescription;
            }
            this.Id = id;
            this.DimensionOrder = dimensionOrder;
            this.RubricRatingLevelDescriptor = rubricRatingLevelDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The rating achieved for the rubric dimension.
        /// </summary>
        /// <value>The rating achieved for the rubric dimension.</value>
        [DataMember(Name="rubricRating", EmitDefaultValue=false)]
        public int? RubricRating { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationElementReference
        /// </summary>
        [DataMember(Name="evaluationElementReference", EmitDefaultValue=false)]
        public TpdmEvaluationElementReference EvaluationElementReference { get; set; }

        /// <summary>
        /// The criterion description for the rubric dimension.
        /// </summary>
        /// <value>The criterion description for the rubric dimension.</value>
        [DataMember(Name="criterionDescription", EmitDefaultValue=false)]
        public string CriterionDescription { get; set; }

        /// <summary>
        /// The order for the rubric dimension.
        /// </summary>
        /// <value>The order for the rubric dimension.</value>
        [DataMember(Name="dimensionOrder", EmitDefaultValue=false)]
        public int? DimensionOrder { get; set; }

        /// <summary>
        /// The rating level achieved for the rubric dimension.
        /// </summary>
        /// <value>The rating level achieved for the rubric dimension.</value>
        [DataMember(Name="rubricRatingLevelDescriptor", EmitDefaultValue=false)]
        public string RubricRatingLevelDescriptor { get; set; }

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
            sb.Append("class TpdmRubricDimension {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RubricRating: ").Append(RubricRating).Append("\n");
            sb.Append("  EvaluationElementReference: ").Append(EvaluationElementReference).Append("\n");
            sb.Append("  CriterionDescription: ").Append(CriterionDescription).Append("\n");
            sb.Append("  DimensionOrder: ").Append(DimensionOrder).Append("\n");
            sb.Append("  RubricRatingLevelDescriptor: ").Append(RubricRatingLevelDescriptor).Append("\n");
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
            return this.Equals(input as TpdmRubricDimension);
        }

        /// <summary>
        /// Returns true if TpdmRubricDimension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmRubricDimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmRubricDimension input)
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
                    this.RubricRating == input.RubricRating ||
                    (this.RubricRating != null &&
                    this.RubricRating.Equals(input.RubricRating))
                ) && 
                (
                    this.EvaluationElementReference == input.EvaluationElementReference ||
                    (this.EvaluationElementReference != null &&
                    this.EvaluationElementReference.Equals(input.EvaluationElementReference))
                ) && 
                (
                    this.CriterionDescription == input.CriterionDescription ||
                    (this.CriterionDescription != null &&
                    this.CriterionDescription.Equals(input.CriterionDescription))
                ) && 
                (
                    this.DimensionOrder == input.DimensionOrder ||
                    (this.DimensionOrder != null &&
                    this.DimensionOrder.Equals(input.DimensionOrder))
                ) && 
                (
                    this.RubricRatingLevelDescriptor == input.RubricRatingLevelDescriptor ||
                    (this.RubricRatingLevelDescriptor != null &&
                    this.RubricRatingLevelDescriptor.Equals(input.RubricRatingLevelDescriptor))
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
                if (this.RubricRating != null)
                    hashCode = hashCode * 59 + this.RubricRating.GetHashCode();
                if (this.EvaluationElementReference != null)
                    hashCode = hashCode * 59 + this.EvaluationElementReference.GetHashCode();
                if (this.CriterionDescription != null)
                    hashCode = hashCode * 59 + this.CriterionDescription.GetHashCode();
                if (this.DimensionOrder != null)
                    hashCode = hashCode * 59 + this.DimensionOrder.GetHashCode();
                if (this.RubricRatingLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.RubricRatingLevelDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}