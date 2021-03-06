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
    /// EdFiEducationOrganizationPeerAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiEducationOrganizationPeerAssociation :  IEquatable<EdFiEducationOrganizationPeerAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationPeerAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationPeerAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationPeerAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="peerEducationOrganizationReference">peerEducationOrganizationReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiEducationOrganizationPeerAssociation(string id = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiEducationOrganizationReference peerEducationOrganizationReference = default(EdFiEducationOrganizationReference), string etag = default(string))
        {
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiEducationOrganizationPeerAssociation and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "peerEducationOrganizationReference" is required (not null)
            if (peerEducationOrganizationReference == null)
            {
                throw new InvalidDataException("peerEducationOrganizationReference is a required property for EdFiEducationOrganizationPeerAssociation and cannot be null");
            }
            else
            {
                this.PeerEducationOrganizationReference = peerEducationOrganizationReference;
            }
            this.Id = id;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets PeerEducationOrganizationReference
        /// </summary>
        [DataMember(Name="peerEducationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference PeerEducationOrganizationReference { get; set; }

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
            sb.Append("class EdFiEducationOrganizationPeerAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  PeerEducationOrganizationReference: ").Append(PeerEducationOrganizationReference).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationPeerAssociation);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationPeerAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationPeerAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationPeerAssociation input)
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
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.PeerEducationOrganizationReference == input.PeerEducationOrganizationReference ||
                    (this.PeerEducationOrganizationReference != null &&
                    this.PeerEducationOrganizationReference.Equals(input.PeerEducationOrganizationReference))
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
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.PeerEducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.PeerEducationOrganizationReference.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
