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
    /// EdFiEducationContent
    /// </summary>
    [DataContract]
    public partial class EdFiEducationContent :  IEquatable<EdFiEducationContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentIdentifier">A unique identifier for the EducationContent. (required).</param>
        /// <param name="learningStandardReference">learningStandardReference.</param>
        /// <param name="additionalAuthorsIndicator">Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;..</param>
        /// <param name="appropriateGradeLevels">An unordered collection of educationContentAppropriateGradeLevels. Grade levels for which this education content is applicable-if omitted, considered generally applicable..</param>
        /// <param name="appropriateSexes">An unordered collection of educationContentAppropriateSexes. Sexes for which this education content is applicable. If omitted, considered generally applicable..</param>
        /// <param name="authors">An unordered collection of educationContentAuthors. The individual credited with the creation of the resource..</param>
        /// <param name="contentClassDescriptor">The predominate type or kind characterizing the learning resource..</param>
        /// <param name="cost">An amount that has to be paid or spent to buy or obtain the EducationContent..</param>
        /// <param name="costRateDescriptor">The rate by which the cost applies..</param>
        /// <param name="derivativeSourceEducationContents">An unordered collection of educationContentDerivativeSourceEducationContents. Relates the education content source to the education content..</param>
        /// <param name="derivativeSourceLearningResourceMetadataURIs">An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item..</param>
        /// <param name="derivativeSourceURIs">An unordered collection of educationContentDerivativeSourceURIs. The URI (typical a URL) pointing to an education content item..</param>
        /// <param name="description">An extended written representation of the education content..</param>
        /// <param name="interactivityStyleDescriptor">The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed..</param>
        /// <param name="languages">An unordered collection of educationContentLanguages. An indication of the languages in which the Education Content is designed..</param>
        /// <param name="learningResourceMetadataURI">The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item..</param>
        /// <param name="_namespace">Namespace for the EducationContent. (required).</param>
        /// <param name="publicationDate">The date on which this content was first published..</param>
        /// <param name="publicationYear">The year at which this content was first published..</param>
        /// <param name="publisher">The organization credited with publishing the resource..</param>
        /// <param name="shortDescription">A short description or name of the entity..</param>
        /// <param name="timeRequired">Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience..</param>
        /// <param name="useRightsURL">The URL where the owner specifies permissions for using the resource..</param>
        /// <param name="version">The version identifier for the content..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiEducationContent(string id = default(string), string contentIdentifier = default(string), EdFiLearningStandardReference learningStandardReference = default(EdFiLearningStandardReference), bool? additionalAuthorsIndicator = default(bool?), List<EdFiEducationContentAppropriateGradeLevel> appropriateGradeLevels = default(List<EdFiEducationContentAppropriateGradeLevel>), List<EdFiEducationContentAppropriateSex> appropriateSexes = default(List<EdFiEducationContentAppropriateSex>), List<EdFiEducationContentAuthor> authors = default(List<EdFiEducationContentAuthor>), string contentClassDescriptor = default(string), double? cost = default(double?), string costRateDescriptor = default(string), List<EdFiEducationContentDerivativeSourceEducationContent> derivativeSourceEducationContents = default(List<EdFiEducationContentDerivativeSourceEducationContent>), List<EdFiEducationContentDerivativeSourceLearningResourceMetadataURI> derivativeSourceLearningResourceMetadataURIs = default(List<EdFiEducationContentDerivativeSourceLearningResourceMetadataURI>), List<EdFiEducationContentDerivativeSourceURI> derivativeSourceURIs = default(List<EdFiEducationContentDerivativeSourceURI>), string description = default(string), string interactivityStyleDescriptor = default(string), List<EdFiEducationContentLanguage> languages = default(List<EdFiEducationContentLanguage>), string learningResourceMetadataURI = default(string), string _namespace = default(string), DateTime? publicationDate = default(DateTime?), int? publicationYear = default(int?), string publisher = default(string), string shortDescription = default(string), string timeRequired = default(string), string useRightsURL = default(string), string version = default(string), string etag = default(string))
        {
            // to ensure "contentIdentifier" is required (not null)
            if (contentIdentifier == null)
            {
                throw new InvalidDataException("contentIdentifier is a required property for EdFiEducationContent and cannot be null");
            }
            else
            {
                this.ContentIdentifier = contentIdentifier;
            }
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for EdFiEducationContent and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            this.Id = id;
            this.LearningStandardReference = learningStandardReference;
            this.AdditionalAuthorsIndicator = additionalAuthorsIndicator;
            this.AppropriateGradeLevels = appropriateGradeLevels;
            this.AppropriateSexes = appropriateSexes;
            this.Authors = authors;
            this.ContentClassDescriptor = contentClassDescriptor;
            this.Cost = cost;
            this.CostRateDescriptor = costRateDescriptor;
            this.DerivativeSourceEducationContents = derivativeSourceEducationContents;
            this.DerivativeSourceLearningResourceMetadataURIs = derivativeSourceLearningResourceMetadataURIs;
            this.DerivativeSourceURIs = derivativeSourceURIs;
            this.Description = description;
            this.InteractivityStyleDescriptor = interactivityStyleDescriptor;
            this.Languages = languages;
            this.LearningResourceMetadataURI = learningResourceMetadataURI;
            this.PublicationDate = publicationDate;
            this.PublicationYear = publicationYear;
            this.Publisher = publisher;
            this.ShortDescription = shortDescription;
            this.TimeRequired = timeRequired;
            this.UseRightsURL = useRightsURL;
            this.Version = version;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique identifier for the EducationContent.
        /// </summary>
        /// <value>A unique identifier for the EducationContent.</value>
        [DataMember(Name="contentIdentifier", EmitDefaultValue=false)]
        public string ContentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets LearningStandardReference
        /// </summary>
        [DataMember(Name="learningStandardReference", EmitDefaultValue=false)]
        public EdFiLearningStandardReference LearningStandardReference { get; set; }

        /// <summary>
        /// Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;.
        /// </summary>
        /// <value>Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;.</value>
        [DataMember(Name="additionalAuthorsIndicator", EmitDefaultValue=false)]
        public bool? AdditionalAuthorsIndicator { get; set; }

        /// <summary>
        /// An unordered collection of educationContentAppropriateGradeLevels. Grade levels for which this education content is applicable-if omitted, considered generally applicable.
        /// </summary>
        /// <value>An unordered collection of educationContentAppropriateGradeLevels. Grade levels for which this education content is applicable-if omitted, considered generally applicable.</value>
        [DataMember(Name="appropriateGradeLevels", EmitDefaultValue=false)]
        public List<EdFiEducationContentAppropriateGradeLevel> AppropriateGradeLevels { get; set; }

        /// <summary>
        /// An unordered collection of educationContentAppropriateSexes. Sexes for which this education content is applicable. If omitted, considered generally applicable.
        /// </summary>
        /// <value>An unordered collection of educationContentAppropriateSexes. Sexes for which this education content is applicable. If omitted, considered generally applicable.</value>
        [DataMember(Name="appropriateSexes", EmitDefaultValue=false)]
        public List<EdFiEducationContentAppropriateSex> AppropriateSexes { get; set; }

        /// <summary>
        /// An unordered collection of educationContentAuthors. The individual credited with the creation of the resource.
        /// </summary>
        /// <value>An unordered collection of educationContentAuthors. The individual credited with the creation of the resource.</value>
        [DataMember(Name="authors", EmitDefaultValue=false)]
        public List<EdFiEducationContentAuthor> Authors { get; set; }

        /// <summary>
        /// The predominate type or kind characterizing the learning resource.
        /// </summary>
        /// <value>The predominate type or kind characterizing the learning resource.</value>
        [DataMember(Name="contentClassDescriptor", EmitDefaultValue=false)]
        public string ContentClassDescriptor { get; set; }

        /// <summary>
        /// An amount that has to be paid or spent to buy or obtain the EducationContent.
        /// </summary>
        /// <value>An amount that has to be paid or spent to buy or obtain the EducationContent.</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }

        /// <summary>
        /// The rate by which the cost applies.
        /// </summary>
        /// <value>The rate by which the cost applies.</value>
        [DataMember(Name="costRateDescriptor", EmitDefaultValue=false)]
        public string CostRateDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of educationContentDerivativeSourceEducationContents. Relates the education content source to the education content.
        /// </summary>
        /// <value>An unordered collection of educationContentDerivativeSourceEducationContents. Relates the education content source to the education content.</value>
        [DataMember(Name="derivativeSourceEducationContents", EmitDefaultValue=false)]
        public List<EdFiEducationContentDerivativeSourceEducationContent> DerivativeSourceEducationContents { get; set; }

        /// <summary>
        /// An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name="derivativeSourceLearningResourceMetadataURIs", EmitDefaultValue=false)]
        public List<EdFiEducationContentDerivativeSourceLearningResourceMetadataURI> DerivativeSourceLearningResourceMetadataURIs { get; set; }

        /// <summary>
        /// An unordered collection of educationContentDerivativeSourceURIs. The URI (typical a URL) pointing to an education content item.
        /// </summary>
        /// <value>An unordered collection of educationContentDerivativeSourceURIs. The URI (typical a URL) pointing to an education content item.</value>
        [DataMember(Name="derivativeSourceURIs", EmitDefaultValue=false)]
        public List<EdFiEducationContentDerivativeSourceURI> DerivativeSourceURIs { get; set; }

        /// <summary>
        /// An extended written representation of the education content.
        /// </summary>
        /// <value>An extended written representation of the education content.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
        /// </summary>
        /// <value>The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.</value>
        [DataMember(Name="interactivityStyleDescriptor", EmitDefaultValue=false)]
        public string InteractivityStyleDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of educationContentLanguages. An indication of the languages in which the Education Content is designed.
        /// </summary>
        /// <value>An unordered collection of educationContentLanguages. An indication of the languages in which the Education Content is designed.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<EdFiEducationContentLanguage> Languages { get; set; }

        /// <summary>
        /// The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name="learningResourceMetadataURI", EmitDefaultValue=false)]
        public string LearningResourceMetadataURI { get; set; }

        /// <summary>
        /// Namespace for the EducationContent.
        /// </summary>
        /// <value>Namespace for the EducationContent.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The date on which this content was first published.
        /// </summary>
        /// <value>The date on which this content was first published.</value>
        [DataMember(Name="publicationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PublicationDate { get; set; }

        /// <summary>
        /// The year at which this content was first published.
        /// </summary>
        /// <value>The year at which this content was first published.</value>
        [DataMember(Name="publicationYear", EmitDefaultValue=false)]
        public int? PublicationYear { get; set; }

        /// <summary>
        /// The organization credited with publishing the resource.
        /// </summary>
        /// <value>The organization credited with publishing the resource.</value>
        [DataMember(Name="publisher", EmitDefaultValue=false)]
        public string Publisher { get; set; }

        /// <summary>
        /// A short description or name of the entity.
        /// </summary>
        /// <value>A short description or name of the entity.</value>
        [DataMember(Name="shortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
        /// </summary>
        /// <value>Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.</value>
        [DataMember(Name="timeRequired", EmitDefaultValue=false)]
        public string TimeRequired { get; set; }

        /// <summary>
        /// The URL where the owner specifies permissions for using the resource.
        /// </summary>
        /// <value>The URL where the owner specifies permissions for using the resource.</value>
        [DataMember(Name="useRightsURL", EmitDefaultValue=false)]
        public string UseRightsURL { get; set; }

        /// <summary>
        /// The version identifier for the content.
        /// </summary>
        /// <value>The version identifier for the content.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

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
            sb.Append("class EdFiEducationContent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentIdentifier: ").Append(ContentIdentifier).Append("\n");
            sb.Append("  LearningStandardReference: ").Append(LearningStandardReference).Append("\n");
            sb.Append("  AdditionalAuthorsIndicator: ").Append(AdditionalAuthorsIndicator).Append("\n");
            sb.Append("  AppropriateGradeLevels: ").Append(AppropriateGradeLevels).Append("\n");
            sb.Append("  AppropriateSexes: ").Append(AppropriateSexes).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  ContentClassDescriptor: ").Append(ContentClassDescriptor).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostRateDescriptor: ").Append(CostRateDescriptor).Append("\n");
            sb.Append("  DerivativeSourceEducationContents: ").Append(DerivativeSourceEducationContents).Append("\n");
            sb.Append("  DerivativeSourceLearningResourceMetadataURIs: ").Append(DerivativeSourceLearningResourceMetadataURIs).Append("\n");
            sb.Append("  DerivativeSourceURIs: ").Append(DerivativeSourceURIs).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InteractivityStyleDescriptor: ").Append(InteractivityStyleDescriptor).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  LearningResourceMetadataURI: ").Append(LearningResourceMetadataURI).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  PublicationYear: ").Append(PublicationYear).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  TimeRequired: ").Append(TimeRequired).Append("\n");
            sb.Append("  UseRightsURL: ").Append(UseRightsURL).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as EdFiEducationContent);
        }

        /// <summary>
        /// Returns true if EdFiEducationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationContent input)
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
                    this.ContentIdentifier == input.ContentIdentifier ||
                    (this.ContentIdentifier != null &&
                    this.ContentIdentifier.Equals(input.ContentIdentifier))
                ) && 
                (
                    this.LearningStandardReference == input.LearningStandardReference ||
                    (this.LearningStandardReference != null &&
                    this.LearningStandardReference.Equals(input.LearningStandardReference))
                ) && 
                (
                    this.AdditionalAuthorsIndicator == input.AdditionalAuthorsIndicator ||
                    (this.AdditionalAuthorsIndicator != null &&
                    this.AdditionalAuthorsIndicator.Equals(input.AdditionalAuthorsIndicator))
                ) && 
                (
                    this.AppropriateGradeLevels == input.AppropriateGradeLevels ||
                    this.AppropriateGradeLevels != null &&
                    this.AppropriateGradeLevels.SequenceEqual(input.AppropriateGradeLevels)
                ) && 
                (
                    this.AppropriateSexes == input.AppropriateSexes ||
                    this.AppropriateSexes != null &&
                    this.AppropriateSexes.SequenceEqual(input.AppropriateSexes)
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
                ) && 
                (
                    this.ContentClassDescriptor == input.ContentClassDescriptor ||
                    (this.ContentClassDescriptor != null &&
                    this.ContentClassDescriptor.Equals(input.ContentClassDescriptor))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CostRateDescriptor == input.CostRateDescriptor ||
                    (this.CostRateDescriptor != null &&
                    this.CostRateDescriptor.Equals(input.CostRateDescriptor))
                ) && 
                (
                    this.DerivativeSourceEducationContents == input.DerivativeSourceEducationContents ||
                    this.DerivativeSourceEducationContents != null &&
                    this.DerivativeSourceEducationContents.SequenceEqual(input.DerivativeSourceEducationContents)
                ) && 
                (
                    this.DerivativeSourceLearningResourceMetadataURIs == input.DerivativeSourceLearningResourceMetadataURIs ||
                    this.DerivativeSourceLearningResourceMetadataURIs != null &&
                    this.DerivativeSourceLearningResourceMetadataURIs.SequenceEqual(input.DerivativeSourceLearningResourceMetadataURIs)
                ) && 
                (
                    this.DerivativeSourceURIs == input.DerivativeSourceURIs ||
                    this.DerivativeSourceURIs != null &&
                    this.DerivativeSourceURIs.SequenceEqual(input.DerivativeSourceURIs)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InteractivityStyleDescriptor == input.InteractivityStyleDescriptor ||
                    (this.InteractivityStyleDescriptor != null &&
                    this.InteractivityStyleDescriptor.Equals(input.InteractivityStyleDescriptor))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.LearningResourceMetadataURI == input.LearningResourceMetadataURI ||
                    (this.LearningResourceMetadataURI != null &&
                    this.LearningResourceMetadataURI.Equals(input.LearningResourceMetadataURI))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.PublicationYear == input.PublicationYear ||
                    (this.PublicationYear != null &&
                    this.PublicationYear.Equals(input.PublicationYear))
                ) && 
                (
                    this.Publisher == input.Publisher ||
                    (this.Publisher != null &&
                    this.Publisher.Equals(input.Publisher))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.TimeRequired == input.TimeRequired ||
                    (this.TimeRequired != null &&
                    this.TimeRequired.Equals(input.TimeRequired))
                ) && 
                (
                    this.UseRightsURL == input.UseRightsURL ||
                    (this.UseRightsURL != null &&
                    this.UseRightsURL.Equals(input.UseRightsURL))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ContentIdentifier != null)
                    hashCode = hashCode * 59 + this.ContentIdentifier.GetHashCode();
                if (this.LearningStandardReference != null)
                    hashCode = hashCode * 59 + this.LearningStandardReference.GetHashCode();
                if (this.AdditionalAuthorsIndicator != null)
                    hashCode = hashCode * 59 + this.AdditionalAuthorsIndicator.GetHashCode();
                if (this.AppropriateGradeLevels != null)
                    hashCode = hashCode * 59 + this.AppropriateGradeLevels.GetHashCode();
                if (this.AppropriateSexes != null)
                    hashCode = hashCode * 59 + this.AppropriateSexes.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
                if (this.ContentClassDescriptor != null)
                    hashCode = hashCode * 59 + this.ContentClassDescriptor.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostRateDescriptor != null)
                    hashCode = hashCode * 59 + this.CostRateDescriptor.GetHashCode();
                if (this.DerivativeSourceEducationContents != null)
                    hashCode = hashCode * 59 + this.DerivativeSourceEducationContents.GetHashCode();
                if (this.DerivativeSourceLearningResourceMetadataURIs != null)
                    hashCode = hashCode * 59 + this.DerivativeSourceLearningResourceMetadataURIs.GetHashCode();
                if (this.DerivativeSourceURIs != null)
                    hashCode = hashCode * 59 + this.DerivativeSourceURIs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InteractivityStyleDescriptor != null)
                    hashCode = hashCode * 59 + this.InteractivityStyleDescriptor.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.LearningResourceMetadataURI != null)
                    hashCode = hashCode * 59 + this.LearningResourceMetadataURI.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.PublicationYear != null)
                    hashCode = hashCode * 59 + this.PublicationYear.GetHashCode();
                if (this.Publisher != null)
                    hashCode = hashCode * 59 + this.Publisher.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.TimeRequired != null)
                    hashCode = hashCode * 59 + this.TimeRequired.GetHashCode();
                if (this.UseRightsURL != null)
                    hashCode = hashCode * 59 + this.UseRightsURL.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
