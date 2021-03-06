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
    /// EdFiSurveySectionResponse
    /// </summary>
    [DataContract]
    public partial class EdFiSurveySectionResponse :  IEquatable<EdFiSurveySectionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveySectionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveySectionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveySectionResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="surveyResponseReference">surveyResponseReference (required).</param>
        /// <param name="surveySectionReference">surveySectionReference (required).</param>
        /// <param name="sectionRating">Numeric rating computed from the survey responses for the section..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiSurveySectionResponse(string id = default(string), EdFiSurveyResponseReference surveyResponseReference = default(EdFiSurveyResponseReference), EdFiSurveySectionReference surveySectionReference = default(EdFiSurveySectionReference), double? sectionRating = default(double?), string etag = default(string))
        {
            // to ensure "surveyResponseReference" is required (not null)
            if (surveyResponseReference == null)
            {
                throw new InvalidDataException("surveyResponseReference is a required property for EdFiSurveySectionResponse and cannot be null");
            }
            else
            {
                this.SurveyResponseReference = surveyResponseReference;
            }
            // to ensure "surveySectionReference" is required (not null)
            if (surveySectionReference == null)
            {
                throw new InvalidDataException("surveySectionReference is a required property for EdFiSurveySectionResponse and cannot be null");
            }
            else
            {
                this.SurveySectionReference = surveySectionReference;
            }
            this.Id = id;
            this.SectionRating = sectionRating;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SurveyResponseReference
        /// </summary>
        [DataMember(Name="surveyResponseReference", EmitDefaultValue=false)]
        public EdFiSurveyResponseReference SurveyResponseReference { get; set; }

        /// <summary>
        /// Gets or Sets SurveySectionReference
        /// </summary>
        [DataMember(Name="surveySectionReference", EmitDefaultValue=false)]
        public EdFiSurveySectionReference SurveySectionReference { get; set; }

        /// <summary>
        /// Numeric rating computed from the survey responses for the section.
        /// </summary>
        /// <value>Numeric rating computed from the survey responses for the section.</value>
        [DataMember(Name="sectionRating", EmitDefaultValue=false)]
        public double? SectionRating { get; set; }

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
            sb.Append("class EdFiSurveySectionResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SurveyResponseReference: ").Append(SurveyResponseReference).Append("\n");
            sb.Append("  SurveySectionReference: ").Append(SurveySectionReference).Append("\n");
            sb.Append("  SectionRating: ").Append(SectionRating).Append("\n");
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
            return this.Equals(input as EdFiSurveySectionResponse);
        }

        /// <summary>
        /// Returns true if EdFiSurveySectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSurveySectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSurveySectionResponse input)
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
                    this.SurveyResponseReference == input.SurveyResponseReference ||
                    (this.SurveyResponseReference != null &&
                    this.SurveyResponseReference.Equals(input.SurveyResponseReference))
                ) && 
                (
                    this.SurveySectionReference == input.SurveySectionReference ||
                    (this.SurveySectionReference != null &&
                    this.SurveySectionReference.Equals(input.SurveySectionReference))
                ) && 
                (
                    this.SectionRating == input.SectionRating ||
                    (this.SectionRating != null &&
                    this.SectionRating.Equals(input.SectionRating))
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
                if (this.SurveyResponseReference != null)
                    hashCode = hashCode * 59 + this.SurveyResponseReference.GetHashCode();
                if (this.SurveySectionReference != null)
                    hashCode = hashCode * 59 + this.SurveySectionReference.GetHashCode();
                if (this.SectionRating != null)
                    hashCode = hashCode * 59 + this.SectionRating.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
