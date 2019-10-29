/* 
 * AYLIEN News API
 *
 * The AYLIEN News API is the most powerful way of sourcing, searching and syndicating analyzed and enriched news content. It is accessed by sending HTTP requests to our server, which returns information to your client. 
 *
 * The version of the OpenAPI document: 3.0
 * Contact: support@aylien.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Aylien.NewsApi.Client.OpenAPIDateConverter;

namespace Aylien.NewsApi.Model
{
    /// <summary>
    /// RepresentativeStory
    /// </summary>
    [DataContract]
    public partial class RepresentativeStory :  IEquatable<RepresentativeStory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentativeStory" /> class.
        /// </summary>
        /// <param name="id">ID of the story which is a unique identification.</param>
        /// <param name="permalink">The story permalink URL.</param>
        /// <param name="publishedAt">Published date of the story.</param>
        /// <param name="title">Title of the story.</param>
        public RepresentativeStory(long id = default(long), string permalink = default(string), DateTime publishedAt = default(DateTime), string title = default(string))
        {
            this.Id = id;
            this.Permalink = permalink;
            this.PublishedAt = publishedAt;
            this.Title = title;
        }
        
        /// <summary>
        /// ID of the story which is a unique identification
        /// </summary>
        /// <value>ID of the story which is a unique identification</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// The story permalink URL
        /// </summary>
        /// <value>The story permalink URL</value>
        [DataMember(Name="permalink", EmitDefaultValue=false)]
        public string Permalink { get; set; }

        /// <summary>
        /// Published date of the story
        /// </summary>
        /// <value>Published date of the story</value>
        [DataMember(Name="published_at", EmitDefaultValue=false)]
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Title of the story
        /// </summary>
        /// <value>Title of the story</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepresentativeStory {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Permalink: ").Append(Permalink).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as RepresentativeStory);
        }

        /// <summary>
        /// Returns true if RepresentativeStory instances are equal
        /// </summary>
        /// <param name="input">Instance of RepresentativeStory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepresentativeStory input)
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
                    this.Permalink == input.Permalink ||
                    (this.Permalink != null &&
                    this.Permalink.Equals(input.Permalink))
                ) && 
                (
                    this.PublishedAt == input.PublishedAt ||
                    (this.PublishedAt != null &&
                    this.PublishedAt.Equals(input.PublishedAt))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Permalink != null)
                    hashCode = hashCode * 59 + this.Permalink.GetHashCode();
                if (this.PublishedAt != null)
                    hashCode = hashCode * 59 + this.PublishedAt.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }
    }

}