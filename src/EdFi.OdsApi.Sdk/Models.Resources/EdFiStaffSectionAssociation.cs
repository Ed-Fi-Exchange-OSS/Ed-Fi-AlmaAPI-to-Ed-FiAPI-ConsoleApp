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
    /// EdFiStaffSectionAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStaffSectionAssociation :  IEquatable<EdFiStaffSectionAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffSectionAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffSectionAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffSectionAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sectionReference">sectionReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="beginDate">Month, day, and year of a teacher&#39;s assignment to the Section. If blank, defaults to the first day of the first grading period for the Section..</param>
        /// <param name="classroomPositionDescriptor">The type of position the Staff member holds in the specific class/section; for example:        Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher... (required).</param>
        /// <param name="endDate">Month, day, and year of the last day of a staff member&#39;s assignment to the Section..</param>
        /// <param name="highlyQualifiedTeacher">An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for this section being taught..</param>
        /// <param name="percentageContribution">Indicates the percentage of the total scheduled course time, academic standards, and/or learning activities delivered in this section by this staff member. A teacher of record designation may be based solely or partially on this contribution percentage..</param>
        /// <param name="teacherStudentDataLinkExclusion">Indicates that the entire section is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStaffSectionAssociation(string id = default(string), EdFiSectionReference sectionReference = default(EdFiSectionReference), EdFiStaffReference staffReference = default(EdFiStaffReference), DateTime? beginDate = default(DateTime?), string classroomPositionDescriptor = default(string), DateTime? endDate = default(DateTime?), bool? highlyQualifiedTeacher = default(bool?), double? percentageContribution = default(double?), bool? teacherStudentDataLinkExclusion = default(bool?), string etag = default(string))
        {
            // to ensure "sectionReference" is required (not null)
            if (sectionReference == null)
            {
                throw new InvalidDataException("sectionReference is a required property for EdFiStaffSectionAssociation and cannot be null");
            }
            else
            {
                this.SectionReference = sectionReference;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for EdFiStaffSectionAssociation and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            // to ensure "classroomPositionDescriptor" is required (not null)
            if (classroomPositionDescriptor == null)
            {
                throw new InvalidDataException("classroomPositionDescriptor is a required property for EdFiStaffSectionAssociation and cannot be null");
            }
            else
            {
                this.ClassroomPositionDescriptor = classroomPositionDescriptor;
            }
            this.Id = id;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.HighlyQualifiedTeacher = highlyQualifiedTeacher;
            this.PercentageContribution = percentageContribution;
            this.TeacherStudentDataLinkExclusion = teacherStudentDataLinkExclusion;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SectionReference
        /// </summary>
        [DataMember(Name="sectionReference", EmitDefaultValue=false)]
        public EdFiSectionReference SectionReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// Month, day, and year of a teacher&#39;s assignment to the Section. If blank, defaults to the first day of the first grading period for the Section.
        /// </summary>
        /// <value>Month, day, and year of a teacher&#39;s assignment to the Section. If blank, defaults to the first day of the first grading period for the Section.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The type of position the Staff member holds in the specific class/section; for example:        Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher...
        /// </summary>
        /// <value>The type of position the Staff member holds in the specific class/section; for example:        Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher...</value>
        [DataMember(Name="classroomPositionDescriptor", EmitDefaultValue=false)]
        public string ClassroomPositionDescriptor { get; set; }

        /// <summary>
        /// Month, day, and year of the last day of a staff member&#39;s assignment to the Section.
        /// </summary>
        /// <value>Month, day, and year of the last day of a staff member&#39;s assignment to the Section.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for this section being taught.
        /// </summary>
        /// <value>An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for this section being taught.</value>
        [DataMember(Name="highlyQualifiedTeacher", EmitDefaultValue=false)]
        public bool? HighlyQualifiedTeacher { get; set; }

        /// <summary>
        /// Indicates the percentage of the total scheduled course time, academic standards, and/or learning activities delivered in this section by this staff member. A teacher of record designation may be based solely or partially on this contribution percentage.
        /// </summary>
        /// <value>Indicates the percentage of the total scheduled course time, academic standards, and/or learning activities delivered in this section by this staff member. A teacher of record designation may be based solely or partially on this contribution percentage.</value>
        [DataMember(Name="percentageContribution", EmitDefaultValue=false)]
        public double? PercentageContribution { get; set; }

        /// <summary>
        /// Indicates that the entire section is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation.
        /// </summary>
        /// <value>Indicates that the entire section is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation.</value>
        [DataMember(Name="teacherStudentDataLinkExclusion", EmitDefaultValue=false)]
        public bool? TeacherStudentDataLinkExclusion { get; set; }

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
            sb.Append("class EdFiStaffSectionAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionReference: ").Append(SectionReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  ClassroomPositionDescriptor: ").Append(ClassroomPositionDescriptor).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  HighlyQualifiedTeacher: ").Append(HighlyQualifiedTeacher).Append("\n");
            sb.Append("  PercentageContribution: ").Append(PercentageContribution).Append("\n");
            sb.Append("  TeacherStudentDataLinkExclusion: ").Append(TeacherStudentDataLinkExclusion).Append("\n");
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
            return this.Equals(input as EdFiStaffSectionAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStaffSectionAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffSectionAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffSectionAssociation input)
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
                    this.SectionReference == input.SectionReference ||
                    (this.SectionReference != null &&
                    this.SectionReference.Equals(input.SectionReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.ClassroomPositionDescriptor == input.ClassroomPositionDescriptor ||
                    (this.ClassroomPositionDescriptor != null &&
                    this.ClassroomPositionDescriptor.Equals(input.ClassroomPositionDescriptor))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.HighlyQualifiedTeacher == input.HighlyQualifiedTeacher ||
                    (this.HighlyQualifiedTeacher != null &&
                    this.HighlyQualifiedTeacher.Equals(input.HighlyQualifiedTeacher))
                ) && 
                (
                    this.PercentageContribution == input.PercentageContribution ||
                    (this.PercentageContribution != null &&
                    this.PercentageContribution.Equals(input.PercentageContribution))
                ) && 
                (
                    this.TeacherStudentDataLinkExclusion == input.TeacherStudentDataLinkExclusion ||
                    (this.TeacherStudentDataLinkExclusion != null &&
                    this.TeacherStudentDataLinkExclusion.Equals(input.TeacherStudentDataLinkExclusion))
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
                if (this.SectionReference != null)
                    hashCode = hashCode * 59 + this.SectionReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.ClassroomPositionDescriptor != null)
                    hashCode = hashCode * 59 + this.ClassroomPositionDescriptor.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.HighlyQualifiedTeacher != null)
                    hashCode = hashCode * 59 + this.HighlyQualifiedTeacher.GetHashCode();
                if (this.PercentageContribution != null)
                    hashCode = hashCode * 59 + this.PercentageContribution.GetHashCode();
                if (this.TeacherStudentDataLinkExclusion != null)
                    hashCode = hashCode * 59 + this.TeacherStudentDataLinkExclusion.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
