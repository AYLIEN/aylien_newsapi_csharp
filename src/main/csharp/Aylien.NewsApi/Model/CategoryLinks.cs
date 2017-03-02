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
    /// CategoryLinks
    /// </summary>
    [DataContract]
    public partial class CategoryLinks :  IEquatable<CategoryLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryLinks" /> class.
        /// </summary>
        /// <param name="Self">A URL pointing to the category.</param>
        /// <param name="Parent">A URL pointing to the parent category.</param>
        public CategoryLinks(string Self = default(string), string Parent = default(string))
        {
            this.Self = Self;
            this.Parent = Parent;
        }
        
        /// <summary>
        /// A URL pointing to the category
        /// </summary>
        /// <value>A URL pointing to the category</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }
        /// <summary>
        /// A URL pointing to the parent category
        /// </summary>
        /// <value>A URL pointing to the parent category</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return this.Equals(obj as CategoryLinks);
        }

        /// <summary>
        /// Returns true if CategoryLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of CategoryLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
