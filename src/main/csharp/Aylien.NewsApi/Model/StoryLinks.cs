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
    /// StoryLinks
    /// </summary>
    [DataContract]
    public partial class StoryLinks :  IEquatable<StoryLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryLinks" /> class.
        /// </summary>
        /// <param name="Permalink">The story permalink URL.</param>
        /// <param name="RelatedStories">The related stories URL.</param>
        /// <param name="Coverages">The coverages URL.</param>
        /// <param name="Canonical">The story canonical URL.</param>
        public StoryLinks(string Permalink = default(string), string RelatedStories = default(string), string Coverages = default(string), string Canonical = default(string))
        {
            this.Permalink = Permalink;
            this.RelatedStories = RelatedStories;
            this.Coverages = Coverages;
            this.Canonical = Canonical;
        }
        
        /// <summary>
        /// The story permalink URL
        /// </summary>
        /// <value>The story permalink URL</value>
        [DataMember(Name="permalink", EmitDefaultValue=false)]
        public string Permalink { get; set; }
        /// <summary>
        /// The related stories URL
        /// </summary>
        /// <value>The related stories URL</value>
        [DataMember(Name="related_stories", EmitDefaultValue=false)]
        public string RelatedStories { get; set; }
        /// <summary>
        /// The coverages URL
        /// </summary>
        /// <value>The coverages URL</value>
        [DataMember(Name="coverages", EmitDefaultValue=false)]
        public string Coverages { get; set; }
        /// <summary>
        /// The story canonical URL
        /// </summary>
        /// <value>The story canonical URL</value>
        [DataMember(Name="canonical", EmitDefaultValue=false)]
        public string Canonical { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoryLinks {\n");
            sb.Append("  Permalink: ").Append(Permalink).Append("\n");
            sb.Append("  RelatedStories: ").Append(RelatedStories).Append("\n");
            sb.Append("  Coverages: ").Append(Coverages).Append("\n");
            sb.Append("  Canonical: ").Append(Canonical).Append("\n");
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
            return this.Equals(obj as StoryLinks);
        }

        /// <summary>
        /// Returns true if StoryLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of StoryLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoryLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Permalink == other.Permalink ||
                    this.Permalink != null &&
                    this.Permalink.Equals(other.Permalink)
                ) && 
                (
                    this.RelatedStories == other.RelatedStories ||
                    this.RelatedStories != null &&
                    this.RelatedStories.Equals(other.RelatedStories)
                ) && 
                (
                    this.Coverages == other.Coverages ||
                    this.Coverages != null &&
                    this.Coverages.Equals(other.Coverages)
                ) && 
                (
                    this.Canonical == other.Canonical ||
                    this.Canonical != null &&
                    this.Canonical.Equals(other.Canonical)
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
                if (this.Permalink != null)
                    hash = hash * 59 + this.Permalink.GetHashCode();
                if (this.RelatedStories != null)
                    hash = hash * 59 + this.RelatedStories.GetHashCode();
                if (this.Coverages != null)
                    hash = hash * 59 + this.Coverages.GetHashCode();
                if (this.Canonical != null)
                    hash = hash * 59 + this.Canonical.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
