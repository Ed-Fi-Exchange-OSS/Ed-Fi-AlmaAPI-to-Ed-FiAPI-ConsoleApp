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

namespace EdFi.OdsApi.Sdk.Models.EnrollmentComposites
{
    /// <summary>
    /// Student
    /// </summary>
    [DataContract]
    public partial class Student :  IEquatable<Student>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Student() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Student" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="birthDate">The month, day, and year on which an individual was born. (required).</param>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="middleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="personalTitlePrefix">A prefix used to denote the title, degree, position, or seniority of the person..</param>
        /// <param name="studentDemographics">An unordered collection of studentEducationOrganizationAssociations. .</param>
        /// <param name="studentSchoolEnrollments">An unordered collection of studentSchoolAssociations. .</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public Student(string id = default(string), DateTime? birthDate = default(DateTime?), string firstName = default(string), string lastSurname = default(string), string middleName = default(string), string personalTitlePrefix = default(string), List<StudentStudentEducationOrganizationAssociation> studentDemographics = default(List<StudentStudentEducationOrganizationAssociation>), List<StudentStudentSchoolAssociation> studentSchoolEnrollments = default(List<StudentStudentSchoolAssociation>), string studentUniqueId = default(string), string etag = default(string))
        {
            // to ensure "birthDate" is required (not null)
            if (birthDate == null)
            {
                throw new InvalidDataException("birthDate is a required property for Student and cannot be null");
            }
            else
            {
                this.BirthDate = birthDate;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for Student and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastSurname" is required (not null)
            if (lastSurname == null)
            {
                throw new InvalidDataException("lastSurname is a required property for Student and cannot be null");
            }
            else
            {
                this.LastSurname = lastSurname;
            }
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new InvalidDataException("studentUniqueId is a required property for Student and cannot be null");
            }
            else
            {
                this.StudentUniqueId = studentUniqueId;
            }
            this.Id = id;
            this.MiddleName = middleName;
            this.PersonalTitlePrefix = personalTitlePrefix;
            this.StudentDemographics = studentDemographics;
            this.StudentSchoolEnrollments = studentSchoolEnrollments;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual was born.
        /// </summary>
        /// <value>The month, day, and year on which an individual was born.</value>
        [DataMember(Name="birthDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BirthDate { get; set; }

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
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// A prefix used to denote the title, degree, position, or seniority of the person.
        /// </summary>
        /// <value>A prefix used to denote the title, degree, position, or seniority of the person.</value>
        [DataMember(Name="personalTitlePrefix", EmitDefaultValue=false)]
        public string PersonalTitlePrefix { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociations. 
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociations. </value>
        [DataMember(Name="studentDemographics", EmitDefaultValue=false)]
        public List<StudentStudentEducationOrganizationAssociation> StudentDemographics { get; set; }

        /// <summary>
        /// An unordered collection of studentSchoolAssociations. 
        /// </summary>
        /// <value>An unordered collection of studentSchoolAssociations. </value>
        [DataMember(Name="studentSchoolEnrollments", EmitDefaultValue=false)]
        public List<StudentStudentSchoolAssociation> StudentSchoolEnrollments { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name="studentUniqueId", EmitDefaultValue=false)]
        public string StudentUniqueId { get; set; }

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
            sb.Append("class Student {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  PersonalTitlePrefix: ").Append(PersonalTitlePrefix).Append("\n");
            sb.Append("  StudentDemographics: ").Append(StudentDemographics).Append("\n");
            sb.Append("  StudentSchoolEnrollments: ").Append(StudentSchoolEnrollments).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            return this.Equals(input as Student);
        }

        /// <summary>
        /// Returns true if Student instances are equal
        /// </summary>
        /// <param name="input">Instance of Student to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Student input)
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
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
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
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.PersonalTitlePrefix == input.PersonalTitlePrefix ||
                    (this.PersonalTitlePrefix != null &&
                    this.PersonalTitlePrefix.Equals(input.PersonalTitlePrefix))
                ) && 
                (
                    this.StudentDemographics == input.StudentDemographics ||
                    this.StudentDemographics != null &&
                    this.StudentDemographics.SequenceEqual(input.StudentDemographics)
                ) && 
                (
                    this.StudentSchoolEnrollments == input.StudentSchoolEnrollments ||
                    this.StudentSchoolEnrollments != null &&
                    this.StudentSchoolEnrollments.SequenceEqual(input.StudentSchoolEnrollments)
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
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
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.PersonalTitlePrefix != null)
                    hashCode = hashCode * 59 + this.PersonalTitlePrefix.GetHashCode();
                if (this.StudentDemographics != null)
                    hashCode = hashCode * 59 + this.StudentDemographics.GetHashCode();
                if (this.StudentSchoolEnrollments != null)
                    hashCode = hashCode * 59 + this.StudentSchoolEnrollments.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
