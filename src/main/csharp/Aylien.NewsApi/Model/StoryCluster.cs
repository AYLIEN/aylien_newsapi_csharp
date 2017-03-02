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
    /// StoryCluster
    /// </summary>
    [DataContract]
    public partial class StoryCluster :  IEquatable<StoryCluster>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryCluster" /> class.
        /// </summary>
        /// <param name="Id">A unique identification for the cluster.</param>
        /// <param name="Phrases">Suggested labels for the cluster.</param>
        /// <param name="Size">Size of the cluster.</param>
        /// <param name="Stories">Story ids which are in the cluster.</param>
        /// <param name="Score">The cluster score.</param>
        public StoryCluster(int? Id = default(int?), List<string> Phrases = default(List<string>), int? Size = default(int?), List<long?> Stories = default(List<long?>), double? Score = default(double?))
        {
            this.Id = Id;
            this.Phrases = Phrases;
            this.Size = Size;
            this.Stories = Stories;
            this.Score = Score;
        }
        
        /// <summary>
        /// A unique identification for the cluster
        /// </summary>
        /// <value>A unique identification for the cluster</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Suggested labels for the cluster
        /// </summary>
        /// <value>Suggested labels for the cluster</value>
        [DataMember(Name="phrases", EmitDefaultValue=false)]
        public List<string> Phrases { get; set; }
        /// <summary>
        /// Size of the cluster
        /// </summary>
        /// <value>Size of the cluster</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
        /// <summary>
        /// Story ids which are in the cluster
        /// </summary>
        /// <value>Story ids which are in the cluster</value>
        [DataMember(Name="stories", EmitDefaultValue=false)]
        public List<long?> Stories { get; set; }
        /// <summary>
        /// The cluster score
        /// </summary>
        /// <value>The cluster score</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoryCluster {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Phrases: ").Append(Phrases).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Stories: ").Append(Stories).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(obj as StoryCluster);
        }

        /// <summary>
        /// Returns true if StoryCluster instances are equal
        /// </summary>
        /// <param name="other">Instance of StoryCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoryCluster other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Phrases == other.Phrases ||
                    this.Phrases != null &&
                    this.Phrases.SequenceEqual(other.Phrases)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Stories == other.Stories ||
                    this.Stories != null &&
                    this.Stories.SequenceEqual(other.Stories)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Phrases != null)
                    hash = hash * 59 + this.Phrases.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Stories != null)
                    hash = hash * 59 + this.Stories.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
