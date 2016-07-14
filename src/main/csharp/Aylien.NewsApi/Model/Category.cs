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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aylien.NewsApi.Model
{
    /// <summary>
    /// Category
    /// </summary>
    [DataContract]
    public partial class Category : IEquatable<Category>
    {
        /// <summary>
        /// The taxonomy of the category
        /// </summary>
        /// <value>The taxonomy of the category</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxonomyEnum
        {

            /// <summary>
            /// Enum Iabqag for "iab-qag"
            /// </summary>
            [EnumMember(Value = "iab-qag")]
            Iabqag,

            /// <summary>
            /// Enum Iptcsubjectcode for "iptc-subjectcode"
            /// </summary>
            [EnumMember(Value = "iptc-subjectcode")]
            Iptcsubjectcode
        }

        /// <summary>
        /// The taxonomy of the category
        /// </summary>
        /// <value>The taxonomy of the category</value>
        [DataMember(Name = "taxonomy", EmitDefaultValue = false)]
        public TaxonomyEnum? Taxonomy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="Id">The ID of the category.</param>
        /// <param name="Taxonomy">The taxonomy of the category.</param>
        /// <param name="Level">The level of the category.</param>
        /// <param name="Score">The score of the category.</param>
        /// <param name="Confident">It defines whether the extracted category is confident or not.</param>
        /// <param name="Links">Related links for the category.</param>
        public Category(string Id = null, TaxonomyEnum? Taxonomy = null, int? Level = null, double? Score = null, bool? Confident = null, CategoryLinks Links = null)
        {
            this.Id = Id;
            this.Taxonomy = Taxonomy;
            this.Level = Level;
            this.Score = Score;
            this.Confident = Confident;
            this.Links = Links;
        }

        /// <summary>
        /// The ID of the category
        /// </summary>
        /// <value>The ID of the category</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// The level of the category
        /// </summary>
        /// <value>The level of the category</value>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int? Level { get; set; }
        /// <summary>
        /// The score of the category
        /// </summary>
        /// <value>The score of the category</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public double? Score { get; set; }
        /// <summary>
        /// It defines whether the extracted category is confident or not
        /// </summary>
        /// <value>It defines whether the extracted category is confident or not</value>
        [DataMember(Name = "confident", EmitDefaultValue = false)]
        public bool? Confident { get; set; }
        /// <summary>
        /// Related links for the category
        /// </summary>
        /// <value>Related links for the category</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public CategoryLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Taxonomy: ").Append(Taxonomy).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Confident: ").Append(Confident).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="other">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category other)
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
                    this.Taxonomy == other.Taxonomy ||
                    this.Taxonomy != null &&
                    this.Taxonomy.Equals(other.Taxonomy)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) &&
                (
                    this.Confident == other.Confident ||
                    this.Confident != null &&
                    this.Confident.Equals(other.Confident)
                ) &&
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Taxonomy != null)
                    hash = hash * 59 + this.Taxonomy.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.Confident != null)
                    hash = hash * 59 + this.Confident.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }
    }

}
