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
    /// Entities
    /// </summary>
    [DataContract]
    public partial class Entities :  IEquatable<Entities>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entities" /> class.
        /// </summary>
        /// <param name="Title">An array of extracted entities from the story title.</param>
        /// <param name="Body">An array of extracted entities from the story body.</param>
        public Entities(List<Entity> Title = default(List<Entity>), List<Entity> Body = default(List<Entity>))
        {
            this.Title = Title;
            this.Body = Body;
        }
        
        /// <summary>
        /// An array of extracted entities from the story title
        /// </summary>
        /// <value>An array of extracted entities from the story title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public List<Entity> Title { get; set; }
        /// <summary>
        /// An array of extracted entities from the story body
        /// </summary>
        /// <value>An array of extracted entities from the story body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public List<Entity> Body { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entities {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(obj as Entities);
        }

        /// <summary>
        /// Returns true if Entities instances are equal
        /// </summary>
        /// <param name="other">Instance of Entities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.SequenceEqual(other.Title)
                ) && 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.SequenceEqual(other.Body)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
