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
    /// Cluster
    /// </summary>
    [DataContract]
    public partial class Cluster :  IEquatable<Cluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        /// <param name="earliestStory">Publication date of the earliest story in cluster.</param>
        /// <param name="id">ID of the cluster which is a unique identification.</param>
        /// <param name="latestStory">Publication date of the latest story in cluster.</param>
        /// <param name="location">location.</param>
        /// <param name="representativeStory">representativeStory.</param>
        /// <param name="storyCount">Number of stories associated with the cluster.</param>
        /// <param name="time">Time of the event.</param>
        public Cluster(DateTime earliestStory = default(DateTime), long id = default(long), DateTime latestStory = default(DateTime), Location location = default(Location), RepresentativeStory representativeStory = default(RepresentativeStory), int storyCount = default(int), DateTime time = default(DateTime))
        {
            this.EarliestStory = earliestStory;
            this.Id = id;
            this.LatestStory = latestStory;
            this.Location = location;
            this.RepresentativeStory = representativeStory;
            this.StoryCount = storyCount;
            this.Time = time;
        }
        
        /// <summary>
        /// Publication date of the earliest story in cluster
        /// </summary>
        /// <value>Publication date of the earliest story in cluster</value>
        [DataMember(Name="earliest_story", EmitDefaultValue=false)]
        public DateTime EarliestStory { get; set; }

        /// <summary>
        /// ID of the cluster which is a unique identification
        /// </summary>
        /// <value>ID of the cluster which is a unique identification</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Publication date of the latest story in cluster
        /// </summary>
        /// <value>Publication date of the latest story in cluster</value>
        [DataMember(Name="latest_story", EmitDefaultValue=false)]
        public DateTime LatestStory { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or Sets RepresentativeStory
        /// </summary>
        [DataMember(Name="representative_story", EmitDefaultValue=false)]
        public RepresentativeStory RepresentativeStory { get; set; }

        /// <summary>
        /// Number of stories associated with the cluster
        /// </summary>
        /// <value>Number of stories associated with the cluster</value>
        [DataMember(Name="story_count", EmitDefaultValue=false)]
        public int StoryCount { get; set; }

        /// <summary>
        /// Time of the event
        /// </summary>
        /// <value>Time of the event</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cluster {\n");
            sb.Append("  EarliestStory: ").Append(EarliestStory).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LatestStory: ").Append(LatestStory).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  RepresentativeStory: ").Append(RepresentativeStory).Append("\n");
            sb.Append("  StoryCount: ").Append(StoryCount).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as Cluster);
        }

        /// <summary>
        /// Returns true if Cluster instances are equal
        /// </summary>
        /// <param name="input">Instance of Cluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarliestStory == input.EarliestStory ||
                    (this.EarliestStory != null &&
                    this.EarliestStory.Equals(input.EarliestStory))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LatestStory == input.LatestStory ||
                    (this.LatestStory != null &&
                    this.LatestStory.Equals(input.LatestStory))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.RepresentativeStory == input.RepresentativeStory ||
                    (this.RepresentativeStory != null &&
                    this.RepresentativeStory.Equals(input.RepresentativeStory))
                ) && 
                (
                    this.StoryCount == input.StoryCount ||
                    (this.StoryCount != null &&
                    this.StoryCount.Equals(input.StoryCount))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.EarliestStory != null)
                    hashCode = hashCode * 59 + this.EarliestStory.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LatestStory != null)
                    hashCode = hashCode * 59 + this.LatestStory.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.RepresentativeStory != null)
                    hashCode = hashCode * 59 + this.RepresentativeStory.GetHashCode();
                if (this.StoryCount != null)
                    hashCode = hashCode * 59 + this.StoryCount.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }

}
