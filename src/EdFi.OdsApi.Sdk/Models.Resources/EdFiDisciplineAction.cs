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
    /// EdFiDisciplineAction
    /// </summary>
    [DataContract]
    public partial class EdFiDisciplineAction :  IEquatable<EdFiDisciplineAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineAction" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="disciplineActionIdentifier">Identifier assigned by the education organization to the DisciplineAction. (required).</param>
        /// <param name="disciplineDate">The date of the DisciplineAction. (required).</param>
        /// <param name="disciplines">An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident. (required).</param>
        /// <param name="studentDisciplineIncidentAssociations">An unordered collection of disciplineActionStudentDisciplineIncidentAssociations. Reference to the DisciplineIncident associated with the DisciplineAction. (required).</param>
        /// <param name="assignmentSchoolReference">assignmentSchoolReference.</param>
        /// <param name="responsibilitySchoolReference">responsibilitySchoolReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="actualDisciplineActionLength">Indicates the actual length in school days of a student&#39;s disciplinary assignment..</param>
        /// <param name="disciplineActionLength">The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable..</param>
        /// <param name="disciplineActionLengthDifferenceReasonDescriptor">Indicates the reason for the difference, if any, between the official and actual lengths of a student&#39;s disciplinary assignment..</param>
        /// <param name="iepPlacementMeetingIndicator">An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student&#39;s Individualized Education Program (IEP) team to determine appropriate placement..</param>
        /// <param name="receivedEducationServicesDuringExpulsion">An indication of whether the student received educational services when removed from the regular school program for disciplinary reasons..</param>
        /// <param name="relatedToZeroTolerancePolicy">An indication of whether or not this disciplinary action taken against a student was imposed as a consequence of state or local zero tolerance policies..</param>
        /// <param name="staffs">An unordered collection of disciplineActionStaffs. The staff responsible for enforcing the DisciplineAction..</param>
        /// <param name="studentDisciplineIncidentBehaviorAssociations">An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiDisciplineAction(string id = default(string), string disciplineActionIdentifier = default(string), DateTime? disciplineDate = default(DateTime?), List<EdFiDisciplineActionDiscipline> disciplines = default(List<EdFiDisciplineActionDiscipline>), List<EdFiDisciplineActionStudentDisciplineIncidentAssociation> studentDisciplineIncidentAssociations = default(List<EdFiDisciplineActionStudentDisciplineIncidentAssociation>), EdFiSchoolReference assignmentSchoolReference = default(EdFiSchoolReference), EdFiSchoolReference responsibilitySchoolReference = default(EdFiSchoolReference), EdFiStudentReference studentReference = default(EdFiStudentReference), double? actualDisciplineActionLength = default(double?), double? disciplineActionLength = default(double?), string disciplineActionLengthDifferenceReasonDescriptor = default(string), bool? iepPlacementMeetingIndicator = default(bool?), bool? receivedEducationServicesDuringExpulsion = default(bool?), bool? relatedToZeroTolerancePolicy = default(bool?), List<EdFiDisciplineActionStaff> staffs = default(List<EdFiDisciplineActionStaff>), List<EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociation> studentDisciplineIncidentBehaviorAssociations = default(List<EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociation>), string etag = default(string))
        {
            // to ensure "disciplineActionIdentifier" is required (not null)
            if (disciplineActionIdentifier == null)
            {
                throw new InvalidDataException("disciplineActionIdentifier is a required property for EdFiDisciplineAction and cannot be null");
            }
            else
            {
                this.DisciplineActionIdentifier = disciplineActionIdentifier;
            }
            // to ensure "disciplineDate" is required (not null)
            if (disciplineDate == null)
            {
                throw new InvalidDataException("disciplineDate is a required property for EdFiDisciplineAction and cannot be null");
            }
            else
            {
                this.DisciplineDate = disciplineDate;
            }
            // to ensure "disciplines" is required (not null)
            if (disciplines == null)
            {
                throw new InvalidDataException("disciplines is a required property for EdFiDisciplineAction and cannot be null");
            }
            else
            {
                this.Disciplines = disciplines;
            }
            // to ensure "studentDisciplineIncidentAssociations" is required (not null)
            if (studentDisciplineIncidentAssociations == null)
            {
                throw new InvalidDataException("studentDisciplineIncidentAssociations is a required property for EdFiDisciplineAction and cannot be null");
            }
            else
            {
                this.StudentDisciplineIncidentAssociations = studentDisciplineIncidentAssociations;
            }
            // to ensure "responsibilitySchoolReference" is required (not null)
            if (responsibilitySchoolReference == null)
            {
                throw new InvalidDataException("responsibilitySchoolReference is a required property for EdFiDisciplineAction and cannot be null");
            }
            else
            {
                this.ResponsibilitySchoolReference = responsibilitySchoolReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiDisciplineAction and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            this.Id = id;
            this.AssignmentSchoolReference = assignmentSchoolReference;
            this.ActualDisciplineActionLength = actualDisciplineActionLength;
            this.DisciplineActionLength = disciplineActionLength;
            this.DisciplineActionLengthDifferenceReasonDescriptor = disciplineActionLengthDifferenceReasonDescriptor;
            this.IepPlacementMeetingIndicator = iepPlacementMeetingIndicator;
            this.ReceivedEducationServicesDuringExpulsion = receivedEducationServicesDuringExpulsion;
            this.RelatedToZeroTolerancePolicy = relatedToZeroTolerancePolicy;
            this.Staffs = staffs;
            this.StudentDisciplineIncidentBehaviorAssociations = studentDisciplineIncidentBehaviorAssociations;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier assigned by the education organization to the DisciplineAction.
        /// </summary>
        /// <value>Identifier assigned by the education organization to the DisciplineAction.</value>
        [DataMember(Name="disciplineActionIdentifier", EmitDefaultValue=false)]
        public string DisciplineActionIdentifier { get; set; }

        /// <summary>
        /// The date of the DisciplineAction.
        /// </summary>
        /// <value>The date of the DisciplineAction.</value>
        [DataMember(Name="disciplineDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DisciplineDate { get; set; }

        /// <summary>
        /// An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident.
        /// </summary>
        /// <value>An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident.</value>
        [DataMember(Name="disciplines", EmitDefaultValue=false)]
        public List<EdFiDisciplineActionDiscipline> Disciplines { get; set; }

        /// <summary>
        /// An unordered collection of disciplineActionStudentDisciplineIncidentAssociations. Reference to the DisciplineIncident associated with the DisciplineAction.
        /// </summary>
        /// <value>An unordered collection of disciplineActionStudentDisciplineIncidentAssociations. Reference to the DisciplineIncident associated with the DisciplineAction.</value>
        [DataMember(Name="studentDisciplineIncidentAssociations", EmitDefaultValue=false)]
        public List<EdFiDisciplineActionStudentDisciplineIncidentAssociation> StudentDisciplineIncidentAssociations { get; set; }

        /// <summary>
        /// Gets or Sets AssignmentSchoolReference
        /// </summary>
        [DataMember(Name="assignmentSchoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference AssignmentSchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets ResponsibilitySchoolReference
        /// </summary>
        [DataMember(Name="responsibilitySchoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference ResponsibilitySchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// Indicates the actual length in school days of a student&#39;s disciplinary assignment.
        /// </summary>
        /// <value>Indicates the actual length in school days of a student&#39;s disciplinary assignment.</value>
        [DataMember(Name="actualDisciplineActionLength", EmitDefaultValue=false)]
        public double? ActualDisciplineActionLength { get; set; }

        /// <summary>
        /// The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable.
        /// </summary>
        /// <value>The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable.</value>
        [DataMember(Name="disciplineActionLength", EmitDefaultValue=false)]
        public double? DisciplineActionLength { get; set; }

        /// <summary>
        /// Indicates the reason for the difference, if any, between the official and actual lengths of a student&#39;s disciplinary assignment.
        /// </summary>
        /// <value>Indicates the reason for the difference, if any, between the official and actual lengths of a student&#39;s disciplinary assignment.</value>
        [DataMember(Name="disciplineActionLengthDifferenceReasonDescriptor", EmitDefaultValue=false)]
        public string DisciplineActionLengthDifferenceReasonDescriptor { get; set; }

        /// <summary>
        /// An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student&#39;s Individualized Education Program (IEP) team to determine appropriate placement.
        /// </summary>
        /// <value>An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student&#39;s Individualized Education Program (IEP) team to determine appropriate placement.</value>
        [DataMember(Name="iepPlacementMeetingIndicator", EmitDefaultValue=false)]
        public bool? IepPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// An indication of whether the student received educational services when removed from the regular school program for disciplinary reasons.
        /// </summary>
        /// <value>An indication of whether the student received educational services when removed from the regular school program for disciplinary reasons.</value>
        [DataMember(Name="receivedEducationServicesDuringExpulsion", EmitDefaultValue=false)]
        public bool? ReceivedEducationServicesDuringExpulsion { get; set; }

        /// <summary>
        /// An indication of whether or not this disciplinary action taken against a student was imposed as a consequence of state or local zero tolerance policies.
        /// </summary>
        /// <value>An indication of whether or not this disciplinary action taken against a student was imposed as a consequence of state or local zero tolerance policies.</value>
        [DataMember(Name="relatedToZeroTolerancePolicy", EmitDefaultValue=false)]
        public bool? RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// An unordered collection of disciplineActionStaffs. The staff responsible for enforcing the DisciplineAction.
        /// </summary>
        /// <value>An unordered collection of disciplineActionStaffs. The staff responsible for enforcing the DisciplineAction.</value>
        [DataMember(Name="staffs", EmitDefaultValue=false)]
        public List<EdFiDisciplineActionStaff> Staffs { get; set; }

        /// <summary>
        /// An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action.
        /// </summary>
        /// <value>An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action.</value>
        [DataMember(Name="studentDisciplineIncidentBehaviorAssociations", EmitDefaultValue=false)]
        public List<EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociation> StudentDisciplineIncidentBehaviorAssociations { get; set; }

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
            sb.Append("class EdFiDisciplineAction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisciplineActionIdentifier: ").Append(DisciplineActionIdentifier).Append("\n");
            sb.Append("  DisciplineDate: ").Append(DisciplineDate).Append("\n");
            sb.Append("  Disciplines: ").Append(Disciplines).Append("\n");
            sb.Append("  StudentDisciplineIncidentAssociations: ").Append(StudentDisciplineIncidentAssociations).Append("\n");
            sb.Append("  AssignmentSchoolReference: ").Append(AssignmentSchoolReference).Append("\n");
            sb.Append("  ResponsibilitySchoolReference: ").Append(ResponsibilitySchoolReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  ActualDisciplineActionLength: ").Append(ActualDisciplineActionLength).Append("\n");
            sb.Append("  DisciplineActionLength: ").Append(DisciplineActionLength).Append("\n");
            sb.Append("  DisciplineActionLengthDifferenceReasonDescriptor: ").Append(DisciplineActionLengthDifferenceReasonDescriptor).Append("\n");
            sb.Append("  IepPlacementMeetingIndicator: ").Append(IepPlacementMeetingIndicator).Append("\n");
            sb.Append("  ReceivedEducationServicesDuringExpulsion: ").Append(ReceivedEducationServicesDuringExpulsion).Append("\n");
            sb.Append("  RelatedToZeroTolerancePolicy: ").Append(RelatedToZeroTolerancePolicy).Append("\n");
            sb.Append("  Staffs: ").Append(Staffs).Append("\n");
            sb.Append("  StudentDisciplineIncidentBehaviorAssociations: ").Append(StudentDisciplineIncidentBehaviorAssociations).Append("\n");
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
            return this.Equals(input as EdFiDisciplineAction);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineAction instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineAction input)
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
                    this.DisciplineActionIdentifier == input.DisciplineActionIdentifier ||
                    (this.DisciplineActionIdentifier != null &&
                    this.DisciplineActionIdentifier.Equals(input.DisciplineActionIdentifier))
                ) && 
                (
                    this.DisciplineDate == input.DisciplineDate ||
                    (this.DisciplineDate != null &&
                    this.DisciplineDate.Equals(input.DisciplineDate))
                ) && 
                (
                    this.Disciplines == input.Disciplines ||
                    this.Disciplines != null &&
                    this.Disciplines.SequenceEqual(input.Disciplines)
                ) && 
                (
                    this.StudentDisciplineIncidentAssociations == input.StudentDisciplineIncidentAssociations ||
                    this.StudentDisciplineIncidentAssociations != null &&
                    this.StudentDisciplineIncidentAssociations.SequenceEqual(input.StudentDisciplineIncidentAssociations)
                ) && 
                (
                    this.AssignmentSchoolReference == input.AssignmentSchoolReference ||
                    (this.AssignmentSchoolReference != null &&
                    this.AssignmentSchoolReference.Equals(input.AssignmentSchoolReference))
                ) && 
                (
                    this.ResponsibilitySchoolReference == input.ResponsibilitySchoolReference ||
                    (this.ResponsibilitySchoolReference != null &&
                    this.ResponsibilitySchoolReference.Equals(input.ResponsibilitySchoolReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.ActualDisciplineActionLength == input.ActualDisciplineActionLength ||
                    (this.ActualDisciplineActionLength != null &&
                    this.ActualDisciplineActionLength.Equals(input.ActualDisciplineActionLength))
                ) && 
                (
                    this.DisciplineActionLength == input.DisciplineActionLength ||
                    (this.DisciplineActionLength != null &&
                    this.DisciplineActionLength.Equals(input.DisciplineActionLength))
                ) && 
                (
                    this.DisciplineActionLengthDifferenceReasonDescriptor == input.DisciplineActionLengthDifferenceReasonDescriptor ||
                    (this.DisciplineActionLengthDifferenceReasonDescriptor != null &&
                    this.DisciplineActionLengthDifferenceReasonDescriptor.Equals(input.DisciplineActionLengthDifferenceReasonDescriptor))
                ) && 
                (
                    this.IepPlacementMeetingIndicator == input.IepPlacementMeetingIndicator ||
                    (this.IepPlacementMeetingIndicator != null &&
                    this.IepPlacementMeetingIndicator.Equals(input.IepPlacementMeetingIndicator))
                ) && 
                (
                    this.ReceivedEducationServicesDuringExpulsion == input.ReceivedEducationServicesDuringExpulsion ||
                    (this.ReceivedEducationServicesDuringExpulsion != null &&
                    this.ReceivedEducationServicesDuringExpulsion.Equals(input.ReceivedEducationServicesDuringExpulsion))
                ) && 
                (
                    this.RelatedToZeroTolerancePolicy == input.RelatedToZeroTolerancePolicy ||
                    (this.RelatedToZeroTolerancePolicy != null &&
                    this.RelatedToZeroTolerancePolicy.Equals(input.RelatedToZeroTolerancePolicy))
                ) && 
                (
                    this.Staffs == input.Staffs ||
                    this.Staffs != null &&
                    this.Staffs.SequenceEqual(input.Staffs)
                ) && 
                (
                    this.StudentDisciplineIncidentBehaviorAssociations == input.StudentDisciplineIncidentBehaviorAssociations ||
                    this.StudentDisciplineIncidentBehaviorAssociations != null &&
                    this.StudentDisciplineIncidentBehaviorAssociations.SequenceEqual(input.StudentDisciplineIncidentBehaviorAssociations)
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
                if (this.DisciplineActionIdentifier != null)
                    hashCode = hashCode * 59 + this.DisciplineActionIdentifier.GetHashCode();
                if (this.DisciplineDate != null)
                    hashCode = hashCode * 59 + this.DisciplineDate.GetHashCode();
                if (this.Disciplines != null)
                    hashCode = hashCode * 59 + this.Disciplines.GetHashCode();
                if (this.StudentDisciplineIncidentAssociations != null)
                    hashCode = hashCode * 59 + this.StudentDisciplineIncidentAssociations.GetHashCode();
                if (this.AssignmentSchoolReference != null)
                    hashCode = hashCode * 59 + this.AssignmentSchoolReference.GetHashCode();
                if (this.ResponsibilitySchoolReference != null)
                    hashCode = hashCode * 59 + this.ResponsibilitySchoolReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.ActualDisciplineActionLength != null)
                    hashCode = hashCode * 59 + this.ActualDisciplineActionLength.GetHashCode();
                if (this.DisciplineActionLength != null)
                    hashCode = hashCode * 59 + this.DisciplineActionLength.GetHashCode();
                if (this.DisciplineActionLengthDifferenceReasonDescriptor != null)
                    hashCode = hashCode * 59 + this.DisciplineActionLengthDifferenceReasonDescriptor.GetHashCode();
                if (this.IepPlacementMeetingIndicator != null)
                    hashCode = hashCode * 59 + this.IepPlacementMeetingIndicator.GetHashCode();
                if (this.ReceivedEducationServicesDuringExpulsion != null)
                    hashCode = hashCode * 59 + this.ReceivedEducationServicesDuringExpulsion.GetHashCode();
                if (this.RelatedToZeroTolerancePolicy != null)
                    hashCode = hashCode * 59 + this.RelatedToZeroTolerancePolicy.GetHashCode();
                if (this.Staffs != null)
                    hashCode = hashCode * 59 + this.Staffs.GetHashCode();
                if (this.StudentDisciplineIncidentBehaviorAssociations != null)
                    hashCode = hashCode * 59 + this.StudentDisciplineIncidentBehaviorAssociations.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
