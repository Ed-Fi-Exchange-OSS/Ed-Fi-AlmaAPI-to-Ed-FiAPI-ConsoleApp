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
    /// EdFiGradebookEntryReference
    /// </summary>
    [DataContract]
    public partial class EdFiGradebookEntryReference :  IEquatable<EdFiGradebookEntryReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGradebookEntryReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryReference" /> class.
        /// </summary>
        /// <param name="dateAssigned">The date the assignment, homework, or assessment was assigned or executed. (required).</param>
        /// <param name="gradebookEntryTitle">The name or title of the activity to be recorded in the GradebookEntry. (required).</param>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="schoolYear">The identifier for the school year. (required).</param>
        /// <param name="sectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (required).</param>
        /// <param name="link">link.</param>
        public EdFiGradebookEntryReference(DateTime? dateAssigned = default(DateTime?), string gradebookEntryTitle = default(string), string localCourseCode = default(string), int? schoolId = default(int?), int? schoolYear = default(int?), string sectionIdentifier = default(string), string sessionName = default(string), Link link = default(Link))
        {
            // to ensure "dateAssigned" is required (not null)
            if (dateAssigned == null)
            {
                throw new InvalidDataException("dateAssigned is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.DateAssigned = dateAssigned;
            }
            // to ensure "gradebookEntryTitle" is required (not null)
            if (gradebookEntryTitle == null)
            {
                throw new InvalidDataException("gradebookEntryTitle is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.GradebookEntryTitle = gradebookEntryTitle;
            }
            // to ensure "localCourseCode" is required (not null)
            if (localCourseCode == null)
            {
                throw new InvalidDataException("localCourseCode is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.LocalCourseCode = localCourseCode;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            // to ensure "schoolYear" is required (not null)
            if (schoolYear == null)
            {
                throw new InvalidDataException("schoolYear is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SchoolYear = schoolYear;
            }
            // to ensure "sectionIdentifier" is required (not null)
            if (sectionIdentifier == null)
            {
                throw new InvalidDataException("sectionIdentifier is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SectionIdentifier = sectionIdentifier;
            }
            // to ensure "sessionName" is required (not null)
            if (sessionName == null)
            {
                throw new InvalidDataException("sessionName is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SessionName = sessionName;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The date the assignment, homework, or assessment was assigned or executed.
        /// </summary>
        /// <value>The date the assignment, homework, or assessment was assigned or executed.</value>
        [DataMember(Name="dateAssigned", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateAssigned { get; set; }

        /// <summary>
        /// The name or title of the activity to be recorded in the GradebookEntry.
        /// </summary>
        /// <value>The name or title of the activity to be recorded in the GradebookEntry.</value>
        [DataMember(Name="gradebookEntryTitle", EmitDefaultValue=false)]
        public string GradebookEntryTitle { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name="localCourseCode", EmitDefaultValue=false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name="schoolYear", EmitDefaultValue=false)]
        public int? SchoolYear { get; set; }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name="sectionIdentifier", EmitDefaultValue=false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).
        /// </summary>
        /// <value>The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).</value>
        [DataMember(Name="sessionName", EmitDefaultValue=false)]
        public string SessionName { get; set; }

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
            sb.Append("class EdFiGradebookEntryReference {\n");
            sb.Append("  DateAssigned: ").Append(DateAssigned).Append("\n");
            sb.Append("  GradebookEntryTitle: ").Append(GradebookEntryTitle).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
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
            return this.Equals(input as EdFiGradebookEntryReference);
        }

        /// <summary>
        /// Returns true if EdFiGradebookEntryReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGradebookEntryReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGradebookEntryReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateAssigned == input.DateAssigned ||
                    (this.DateAssigned != null &&
                    this.DateAssigned.Equals(input.DateAssigned))
                ) && 
                (
                    this.GradebookEntryTitle == input.GradebookEntryTitle ||
                    (this.GradebookEntryTitle != null &&
                    this.GradebookEntryTitle.Equals(input.GradebookEntryTitle))
                ) && 
                (
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    (this.SchoolYear != null &&
                    this.SchoolYear.Equals(input.SchoolYear))
                ) && 
                (
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
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
                if (this.DateAssigned != null)
                    hashCode = hashCode * 59 + this.DateAssigned.GetHashCode();
                if (this.GradebookEntryTitle != null)
                    hashCode = hashCode * 59 + this.GradebookEntryTitle.GetHashCode();
                if (this.LocalCourseCode != null)
                    hashCode = hashCode * 59 + this.LocalCourseCode.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.SchoolYear != null)
                    hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
                if (this.SectionIdentifier != null)
                    hashCode = hashCode * 59 + this.SectionIdentifier.GetHashCode();
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}