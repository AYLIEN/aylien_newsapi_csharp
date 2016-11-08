#region License
/*
Copyright 2016 Aylien, Inc. All Rights Reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Aylien.NewsApi.Model
{
    /// <summary>
    /// Coverages
    /// </summary>
    [DataContract]
    public partial class Coverages :  IEquatable<Coverages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coverages" /> class.
        /// </summary>
        /// <param name="StoryTitle">The input story title.</param>
        /// <param name="StoryBody">The input story body.</param>
        /// <param name="StoryPublishedAt">The input story published date.</param>
        /// <param name="StoryLanguage">The input story language.</param>
        /// <param name="_Coverages">An array of coverages for the input story.</param>
        /// <param name="Clusters">An array of clusters.</param>
        public Coverages(string StoryTitle = null, string StoryBody = null, DateTime? StoryPublishedAt = null, string StoryLanguage = null, List<Story> _Coverages = null, List<StoryCluster> Clusters = null)
        {
            this.StoryTitle = StoryTitle;
            this.StoryBody = StoryBody;
            this.StoryPublishedAt = StoryPublishedAt;
            this.StoryLanguage = StoryLanguage;
            this._Coverages = _Coverages;
            this.Clusters = Clusters;
        }
        
        /// <summary>
        /// The input story title
        /// </summary>
        /// <value>The input story title</value>
        [DataMember(Name="story_title", EmitDefaultValue=false)]
        public string StoryTitle { get; set; }
        /// <summary>
        /// The input story body
        /// </summary>
        /// <value>The input story body</value>
        [DataMember(Name="story_body", EmitDefaultValue=false)]
        public string StoryBody { get; set; }
        /// <summary>
        /// The input story published date
        /// </summary>
        /// <value>The input story published date</value>
        [DataMember(Name="story_published_at", EmitDefaultValue=false)]
        public DateTime? StoryPublishedAt { get; set; }
        /// <summary>
        /// The input story language
        /// </summary>
        /// <value>The input story language</value>
        [DataMember(Name="story_language", EmitDefaultValue=false)]
        public string StoryLanguage { get; set; }
        /// <summary>
        /// An array of coverages for the input story
        /// </summary>
        /// <value>An array of coverages for the input story</value>
        [DataMember(Name="coverages", EmitDefaultValue=false)]
        public List<Story> _Coverages { get; set; }
        /// <summary>
        /// An array of clusters
        /// </summary>
        /// <value>An array of clusters</value>
        [DataMember(Name="clusters", EmitDefaultValue=false)]
        public List<StoryCluster> Clusters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Coverages {\n");
            sb.Append("  StoryTitle: ").Append(StoryTitle).Append("\n");
            sb.Append("  StoryBody: ").Append(StoryBody).Append("\n");
            sb.Append("  StoryPublishedAt: ").Append(StoryPublishedAt).Append("\n");
            sb.Append("  StoryLanguage: ").Append(StoryLanguage).Append("\n");
            sb.Append("  _Coverages: ").Append(_Coverages).Append("\n");
            sb.Append("  Clusters: ").Append(Clusters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Coverages);
        }

        /// <summary>
        /// Returns true if Coverages instances are equal
        /// </summary>
        /// <param name="other">Instance of Coverages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Coverages other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StoryTitle == other.StoryTitle ||
                    this.StoryTitle != null &&
                    this.StoryTitle.Equals(other.StoryTitle)
                ) && 
                (
                    this.StoryBody == other.StoryBody ||
                    this.StoryBody != null &&
                    this.StoryBody.Equals(other.StoryBody)
                ) && 
                (
                    this.StoryPublishedAt == other.StoryPublishedAt ||
                    this.StoryPublishedAt != null &&
                    this.StoryPublishedAt.Equals(other.StoryPublishedAt)
                ) && 
                (
                    this.StoryLanguage == other.StoryLanguage ||
                    this.StoryLanguage != null &&
                    this.StoryLanguage.Equals(other.StoryLanguage)
                ) && 
                (
                    this._Coverages == other._Coverages ||
                    this._Coverages != null &&
                    this._Coverages.SequenceEqual(other._Coverages)
                ) && 
                (
                    this.Clusters == other.Clusters ||
                    this.Clusters != null &&
                    this.Clusters.SequenceEqual(other.Clusters)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.StoryTitle != null)
                    hash = hash * 59 + this.StoryTitle.GetHashCode();
                if (this.StoryBody != null)
                    hash = hash * 59 + this.StoryBody.GetHashCode();
                if (this.StoryPublishedAt != null)
                    hash = hash * 59 + this.StoryPublishedAt.GetHashCode();
                if (this.StoryLanguage != null)
                    hash = hash * 59 + this.StoryLanguage.GetHashCode();
                if (this._Coverages != null)
                    hash = hash * 59 + this._Coverages.GetHashCode();
                if (this.Clusters != null)
                    hash = hash * 59 + this.Clusters.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
