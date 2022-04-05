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
    /// TpdmEvaluationReference
    /// </summary>
    [DataContract]
    public partial class TpdmEvaluationReference :  IEquatable<TpdmEvaluationReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="evaluationPeriodDescriptor">The period for the evaluation. (required).</param>
        /// <param name="evaluationTitle">The name or title of the evaluation. (required).</param>
        /// <param name="performanceEvaluationTitle">An assigned unique identifier for the performance evaluation. (required).</param>
        /// <param name="performanceEvaluationTypeDescriptor">The type of performance evaluation conducted. (required).</param>
        /// <param name="schoolYear">The identifier for the school year. (required).</param>
        /// <param name="termDescriptor">The term for the session during the school year. (required).</param>
        /// <param name="link">link.</param>
        public TpdmEvaluationReference(int? educationOrganizationId = default(int?), string evaluationPeriodDescriptor = default(string), string evaluationTitle = default(string), string performanceEvaluationTitle = default(string), string performanceEvaluationTypeDescriptor = default(string), int? schoolYear = default(int?), string termDescriptor = default(string), Link link = default(Link))
        {
            // to ensure "educationOrganizationId" is required (not null)
            if (educationOrganizationId == null)
            {
                throw new InvalidDataException("educationOrganizationId is a required property for TpdmEvaluationReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = educationOrganizationId;
            }
            // to ensure "evaluationPeriodDescriptor" is required (not null)
            if (evaluationPeriodDescriptor == null)
            {
                throw new InvalidDataException("evaluationPeriodDescriptor is a required property for TpdmEvaluationReference and cannot be null");
            }
            else
            {
                this.EvaluationPeriodDescriptor = evaluationPeriodDescriptor;
            }
            // to ensure "evaluationTitle" is required (not null)
            if (evaluationTitle == null)
            {
                throw new InvalidDataException("evaluationTitle is a required property for TpdmEvaluationReference and cannot be null");
            }
            else
            {
                this.EvaluationTitle = evaluationTitle;
            }
            // to ensure "performanceEvaluationTitle" is required (not null)
            if (performanceEvaluationTitle == null)
            {
                throw new InvalidDataException("performanceEvaluationTitle is a required property for TpdmEvaluationReference and cannot be null");
            }
            else
            {
                this.PerformanceEvaluationTitle = performanceEvaluationTitle;
            }
            // to ensure "performanceEvaluationTypeDescriptor" is required (not null)
            if (performanceEvaluationTypeDescriptor == null)
            {
                throw new InvalidDataException("performanceEvaluationTypeDescriptor is a required property for TpdmEvaluationReference and cannot be null");
            }
            else
            {
                this.PerformanceEvaluationTypeDescriptor = performanceEvaluationTypeDescriptor;
            }
            // to ensure "schoolYear" is required (not null)
            if (schoolYear == null)
            {
                throw new InvalidDataException("schoolYear is a required property for TpdmEvaluationReference and cannot be null");
            }
            else
            {
                this.SchoolYear = schoolYear;
            }
            // to ensure "termDescriptor" is required (not null)
            if (termDescriptor == null)
            {
                throw new InvalidDataException("termDescriptor is a required property for TpdmEvaluationReference and cannot be null");
            }
            else
            {
                this.TermDescriptor = termDescriptor;
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
        /// The period for the evaluation.
        /// </summary>
        /// <value>The period for the evaluation.</value>
        [DataMember(Name="evaluationPeriodDescriptor", EmitDefaultValue=false)]
        public string EvaluationPeriodDescriptor { get; set; }

        /// <summary>
        /// The name or title of the evaluation.
        /// </summary>
        /// <value>The name or title of the evaluation.</value>
        [DataMember(Name="evaluationTitle", EmitDefaultValue=false)]
        public string EvaluationTitle { get; set; }

        /// <summary>
        /// An assigned unique identifier for the performance evaluation.
        /// </summary>
        /// <value>An assigned unique identifier for the performance evaluation.</value>
        [DataMember(Name="performanceEvaluationTitle", EmitDefaultValue=false)]
        public string PerformanceEvaluationTitle { get; set; }

        /// <summary>
        /// The type of performance evaluation conducted.
        /// </summary>
        /// <value>The type of performance evaluation conducted.</value>
        [DataMember(Name="performanceEvaluationTypeDescriptor", EmitDefaultValue=false)]
        public string PerformanceEvaluationTypeDescriptor { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name="schoolYear", EmitDefaultValue=false)]
        public int? SchoolYear { get; set; }

        /// <summary>
        /// The term for the session during the school year.
        /// </summary>
        /// <value>The term for the session during the school year.</value>
        [DataMember(Name="termDescriptor", EmitDefaultValue=false)]
        public string TermDescriptor { get; set; }

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
            sb.Append("class TpdmEvaluationReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  EvaluationPeriodDescriptor: ").Append(EvaluationPeriodDescriptor).Append("\n");
            sb.Append("  EvaluationTitle: ").Append(EvaluationTitle).Append("\n");
            sb.Append("  PerformanceEvaluationTitle: ").Append(PerformanceEvaluationTitle).Append("\n");
            sb.Append("  PerformanceEvaluationTypeDescriptor: ").Append(PerformanceEvaluationTypeDescriptor).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
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
            return this.Equals(input as TpdmEvaluationReference);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationReference input)
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
                    this.EvaluationPeriodDescriptor == input.EvaluationPeriodDescriptor ||
                    (this.EvaluationPeriodDescriptor != null &&
                    this.EvaluationPeriodDescriptor.Equals(input.EvaluationPeriodDescriptor))
                ) && 
                (
                    this.EvaluationTitle == input.EvaluationTitle ||
                    (this.EvaluationTitle != null &&
                    this.EvaluationTitle.Equals(input.EvaluationTitle))
                ) && 
                (
                    this.PerformanceEvaluationTitle == input.PerformanceEvaluationTitle ||
                    (this.PerformanceEvaluationTitle != null &&
                    this.PerformanceEvaluationTitle.Equals(input.PerformanceEvaluationTitle))
                ) && 
                (
                    this.PerformanceEvaluationTypeDescriptor == input.PerformanceEvaluationTypeDescriptor ||
                    (this.PerformanceEvaluationTypeDescriptor != null &&
                    this.PerformanceEvaluationTypeDescriptor.Equals(input.PerformanceEvaluationTypeDescriptor))
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    (this.SchoolYear != null &&
                    this.SchoolYear.Equals(input.SchoolYear))
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
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
                if (this.EvaluationPeriodDescriptor != null)
                    hashCode = hashCode * 59 + this.EvaluationPeriodDescriptor.GetHashCode();
                if (this.EvaluationTitle != null)
                    hashCode = hashCode * 59 + this.EvaluationTitle.GetHashCode();
                if (this.PerformanceEvaluationTitle != null)
                    hashCode = hashCode * 59 + this.PerformanceEvaluationTitle.GetHashCode();
                if (this.PerformanceEvaluationTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.PerformanceEvaluationTypeDescriptor.GetHashCode();
                if (this.SchoolYear != null)
                    hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
                if (this.TermDescriptor != null)
                    hashCode = hashCode * 59 + this.TermDescriptor.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
