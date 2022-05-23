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
    /// EdFiStateEducationAgencyReference
    /// </summary>
    [DataContract]
    public partial class EdFiStateEducationAgencyReference :  IEquatable<EdFiStateEducationAgencyReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStateEducationAgencyReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStateEducationAgencyReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStateEducationAgencyReference" /> class.
        /// </summary>
        /// <param name="stateEducationAgencyId">The identifier assigned to a state education agency. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStateEducationAgencyReference(int? stateEducationAgencyId = default(int?), Link link = default(Link))
        {
            // to ensure "stateEducationAgencyId" is required (not null)
            if (stateEducationAgencyId == null)
            {
                throw new InvalidDataException("stateEducationAgencyId is a required property for EdFiStateEducationAgencyReference and cannot be null");
            }
            else
            {
                this.StateEducationAgencyId = stateEducationAgencyId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier assigned to a state education agency.
        /// </summary>
        /// <value>The identifier assigned to a state education agency.</value>
        [DataMember(Name="stateEducationAgencyId", EmitDefaultValue=false)]
        public int? StateEducationAgencyId { get; set; }

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
            sb.Append("class EdFiStateEducationAgencyReference {\n");
            sb.Append("  StateEducationAgencyId: ").Append(StateEducationAgencyId).Append("\n");
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
            return this.Equals(input as EdFiStateEducationAgencyReference);
        }

        /// <summary>
        /// Returns true if EdFiStateEducationAgencyReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStateEducationAgencyReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStateEducationAgencyReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StateEducationAgencyId == input.StateEducationAgencyId ||
                    (this.StateEducationAgencyId != null &&
                    this.StateEducationAgencyId.Equals(input.StateEducationAgencyId))
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
                if (this.StateEducationAgencyId != null)
                    hashCode = hashCode * 59 + this.StateEducationAgencyId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}