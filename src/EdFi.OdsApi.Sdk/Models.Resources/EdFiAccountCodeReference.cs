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
    /// EdFiAccountCodeReference
    /// </summary>
    [DataContract]
    public partial class EdFiAccountCodeReference :  IEquatable<EdFiAccountCodeReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAccountCodeReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAccountCodeReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAccountCodeReference" /> class.
        /// </summary>
        /// <param name="accountClassificationDescriptor">The type of account code associated with the account. (required).</param>
        /// <param name="accountCodeNumber">An account code defined for the education accounting system by the education organization. (required).</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="fiscalYear">The financial accounting year. (required).</param>
        /// <param name="link">link.</param>
        public EdFiAccountCodeReference(string accountClassificationDescriptor = default(string), string accountCodeNumber = default(string), int? educationOrganizationId = default(int?), int? fiscalYear = default(int?), Link link = default(Link))
        {
            // to ensure "accountClassificationDescriptor" is required (not null)
            if (accountClassificationDescriptor == null)
            {
                throw new InvalidDataException("accountClassificationDescriptor is a required property for EdFiAccountCodeReference and cannot be null");
            }
            else
            {
                this.AccountClassificationDescriptor = accountClassificationDescriptor;
            }
            // to ensure "accountCodeNumber" is required (not null)
            if (accountCodeNumber == null)
            {
                throw new InvalidDataException("accountCodeNumber is a required property for EdFiAccountCodeReference and cannot be null");
            }
            else
            {
                this.AccountCodeNumber = accountCodeNumber;
            }
            // to ensure "educationOrganizationId" is required (not null)
            if (educationOrganizationId == null)
            {
                throw new InvalidDataException("educationOrganizationId is a required property for EdFiAccountCodeReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = educationOrganizationId;
            }
            // to ensure "fiscalYear" is required (not null)
            if (fiscalYear == null)
            {
                throw new InvalidDataException("fiscalYear is a required property for EdFiAccountCodeReference and cannot be null");
            }
            else
            {
                this.FiscalYear = fiscalYear;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The type of account code associated with the account.
        /// </summary>
        /// <value>The type of account code associated with the account.</value>
        [DataMember(Name="accountClassificationDescriptor", EmitDefaultValue=false)]
        public string AccountClassificationDescriptor { get; set; }

        /// <summary>
        /// An account code defined for the education accounting system by the education organization.
        /// </summary>
        /// <value>An account code defined for the education accounting system by the education organization.</value>
        [DataMember(Name="accountCodeNumber", EmitDefaultValue=false)]
        public string AccountCodeNumber { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// The financial accounting year.
        /// </summary>
        /// <value>The financial accounting year.</value>
        [DataMember(Name="fiscalYear", EmitDefaultValue=false)]
        public int? FiscalYear { get; set; }

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
            sb.Append("class EdFiAccountCodeReference {\n");
            sb.Append("  AccountClassificationDescriptor: ").Append(AccountClassificationDescriptor).Append("\n");
            sb.Append("  AccountCodeNumber: ").Append(AccountCodeNumber).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
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
            return this.Equals(input as EdFiAccountCodeReference);
        }

        /// <summary>
        /// Returns true if EdFiAccountCodeReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAccountCodeReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAccountCodeReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountClassificationDescriptor == input.AccountClassificationDescriptor ||
                    (this.AccountClassificationDescriptor != null &&
                    this.AccountClassificationDescriptor.Equals(input.AccountClassificationDescriptor))
                ) && 
                (
                    this.AccountCodeNumber == input.AccountCodeNumber ||
                    (this.AccountCodeNumber != null &&
                    this.AccountCodeNumber.Equals(input.AccountCodeNumber))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    (this.FiscalYear != null &&
                    this.FiscalYear.Equals(input.FiscalYear))
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
                if (this.AccountClassificationDescriptor != null)
                    hashCode = hashCode * 59 + this.AccountClassificationDescriptor.GetHashCode();
                if (this.AccountCodeNumber != null)
                    hashCode = hashCode * 59 + this.AccountCodeNumber.GetHashCode();
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.FiscalYear != null)
                    hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
