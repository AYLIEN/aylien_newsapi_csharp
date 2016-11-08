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
    /// Summary
    /// </summary>
    [DataContract]
    public partial class Summary :  IEquatable<Summary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Summary" /> class.
        /// </summary>
        /// <param name="Sentences">An array of the suggested summary sentences.</param>
        public Summary(List<string> Sentences = null)
        {
            this.Sentences = Sentences;
        }
        
        /// <summary>
        /// An array of the suggested summary sentences
        /// </summary>
        /// <value>An array of the suggested summary sentences</value>
        [DataMember(Name="sentences", EmitDefaultValue=false)]
        public List<string> Sentences { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Summary {\n");
            sb.Append("  Sentences: ").Append(Sentences).Append("\n");
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
            return this.Equals(obj as Summary);
        }

        /// <summary>
        /// Returns true if Summary instances are equal
        /// </summary>
        /// <param name="other">Instance of Summary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Summary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sentences == other.Sentences ||
                    this.Sentences != null &&
                    this.Sentences.SequenceEqual(other.Sentences)
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
                if (this.Sentences != null)
                    hash = hash * 59 + this.Sentences.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
