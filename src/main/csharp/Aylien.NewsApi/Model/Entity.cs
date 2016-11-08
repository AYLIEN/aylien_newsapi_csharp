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
    /// Entity
    /// </summary>
    [DataContract]
    public partial class Entity :  IEquatable<Entity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="Text">The entity text.</param>
        /// <param name="Score">The entity score.</param>
        /// <param name="Types">An array of the dbpedia types.</param>
        /// <param name="Links">Related links to the entity.</param>
        /// <param name="Indices">The indices of the entity text.</param>
        public Entity(string Text = null, double? Score = null, List<string> Types = null, EntityLinks Links = null, List<List<int?>> Indices = null)
        {
            this.Text = Text;
            this.Score = Score;
            this.Types = Types;
            this.Links = Links;
            this.Indices = Indices;
        }
        
        /// <summary>
        /// The entity text
        /// </summary>
        /// <value>The entity text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// The entity score
        /// </summary>
        /// <value>The entity score</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }
        /// <summary>
        /// An array of the dbpedia types
        /// </summary>
        /// <value>An array of the dbpedia types</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
        /// <summary>
        /// Related links to the entity
        /// </summary>
        /// <value>Related links to the entity</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public EntityLinks Links { get; set; }
        /// <summary>
        /// The indices of the entity text
        /// </summary>
        /// <value>The indices of the entity text</value>
        [DataMember(Name="indices", EmitDefaultValue=false)]
        public List<List<int?>> Indices { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entity {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Indices: ").Append(Indices).Append("\n");
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
            return this.Equals(obj as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="other">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Indices == other.Indices ||
                    this.Indices != null &&
                    this.Indices.SequenceEqual(other.Indices)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Indices != null)
                    hash = hash * 59 + this.Indices.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Score (double?) maximum
            if(this.Score > (double?)1.0)
            {
                yield return new ValidationResult("Invalid value for Score, must be a value less than or equal to 1.0.", new [] { "Score" });
            }

            // Score (double?) minimum
            if(this.Score < (double?)0.0)
            {
                yield return new ValidationResult("Invalid value for Score, must be a value greater than or equal to 0.0.", new [] { "Score" });
            }

            yield break;
        }
    }

}
