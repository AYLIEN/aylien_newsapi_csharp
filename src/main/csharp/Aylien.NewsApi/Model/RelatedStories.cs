#region License
/*
Copyright 2017 Aylien, Inc. All Rights Reserved.

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
    /// RelatedStories
    /// </summary>
    [DataContract]
    public partial class RelatedStories :  IEquatable<RelatedStories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedStories" /> class.
        /// </summary>
        /// <param name="StoryTitle">The input story title.</param>
        /// <param name="StoryBody">The input story body.</param>
        /// <param name="StoryLanguage">The input story language.</param>
        /// <param name="_RelatedStories">An array of related stories for the input story.</param>
        /// <param name="Clusters">An array of clusters.</param>
        public RelatedStories(string StoryTitle = default(string), string StoryBody = default(string), string StoryLanguage = default(string), List<Story> _RelatedStories = default(List<Story>), List<StoryCluster> Clusters = default(List<StoryCluster>))
        {
            this.StoryTitle = StoryTitle;
            this.StoryBody = StoryBody;
            this.StoryLanguage = StoryLanguage;
            this._RelatedStories = _RelatedStories;
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
        /// The input story language
        /// </summary>
        /// <value>The input story language</value>
        [DataMember(Name="story_language", EmitDefaultValue=false)]
        public string StoryLanguage { get; set; }
        /// <summary>
        /// An array of related stories for the input story
        /// </summary>
        /// <value>An array of related stories for the input story</value>
        [DataMember(Name="related_stories", EmitDefaultValue=false)]
        public List<Story> _RelatedStories { get; set; }
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
            sb.Append("class RelatedStories {\n");
            sb.Append("  StoryTitle: ").Append(StoryTitle).Append("\n");
            sb.Append("  StoryBody: ").Append(StoryBody).Append("\n");
            sb.Append("  StoryLanguage: ").Append(StoryLanguage).Append("\n");
            sb.Append("  _RelatedStories: ").Append(_RelatedStories).Append("\n");
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
            return this.Equals(obj as RelatedStories);
        }

        /// <summary>
        /// Returns true if RelatedStories instances are equal
        /// </summary>
        /// <param name="other">Instance of RelatedStories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedStories other)
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
                    this.StoryLanguage == other.StoryLanguage ||
                    this.StoryLanguage != null &&
                    this.StoryLanguage.Equals(other.StoryLanguage)
                ) && 
                (
                    this._RelatedStories == other._RelatedStories ||
                    this._RelatedStories != null &&
                    this._RelatedStories.SequenceEqual(other._RelatedStories)
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
                if (this.StoryLanguage != null)
                    hash = hash * 59 + this.StoryLanguage.GetHashCode();
                if (this._RelatedStories != null)
                    hash = hash * 59 + this._RelatedStories.GetHashCode();
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
