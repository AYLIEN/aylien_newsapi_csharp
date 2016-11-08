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
    /// ShareCounts
    /// </summary>
    [DataContract]
    public partial class ShareCounts :  IEquatable<ShareCounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCounts" /> class.
        /// </summary>
        /// <param name="Facebook">Facebook shares count.</param>
        /// <param name="GooglePlus">Google Plus shares count.</param>
        /// <param name="Linkedin">LinkedIn shares count.</param>
        /// <param name="Reddit">Reddit shares count.</param>
        public ShareCounts(List<ShareCount> Facebook = null, List<ShareCount> GooglePlus = null, List<ShareCount> Linkedin = null, List<ShareCount> Reddit = null)
        {
            this.Facebook = Facebook;
            this.GooglePlus = GooglePlus;
            this.Linkedin = Linkedin;
            this.Reddit = Reddit;
        }
        
        /// <summary>
        /// Facebook shares count
        /// </summary>
        /// <value>Facebook shares count</value>
        [DataMember(Name="facebook", EmitDefaultValue=false)]
        public List<ShareCount> Facebook { get; set; }
        /// <summary>
        /// Google Plus shares count
        /// </summary>
        /// <value>Google Plus shares count</value>
        [DataMember(Name="google_plus", EmitDefaultValue=false)]
        public List<ShareCount> GooglePlus { get; set; }
        /// <summary>
        /// LinkedIn shares count
        /// </summary>
        /// <value>LinkedIn shares count</value>
        [DataMember(Name="linkedin", EmitDefaultValue=false)]
        public List<ShareCount> Linkedin { get; set; }
        /// <summary>
        /// Reddit shares count
        /// </summary>
        /// <value>Reddit shares count</value>
        [DataMember(Name="reddit", EmitDefaultValue=false)]
        public List<ShareCount> Reddit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareCounts {\n");
            sb.Append("  Facebook: ").Append(Facebook).Append("\n");
            sb.Append("  GooglePlus: ").Append(GooglePlus).Append("\n");
            sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
            sb.Append("  Reddit: ").Append(Reddit).Append("\n");
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
            return this.Equals(obj as ShareCounts);
        }

        /// <summary>
        /// Returns true if ShareCounts instances are equal
        /// </summary>
        /// <param name="other">Instance of ShareCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareCounts other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Facebook == other.Facebook ||
                    this.Facebook != null &&
                    this.Facebook.SequenceEqual(other.Facebook)
                ) && 
                (
                    this.GooglePlus == other.GooglePlus ||
                    this.GooglePlus != null &&
                    this.GooglePlus.SequenceEqual(other.GooglePlus)
                ) && 
                (
                    this.Linkedin == other.Linkedin ||
                    this.Linkedin != null &&
                    this.Linkedin.SequenceEqual(other.Linkedin)
                ) && 
                (
                    this.Reddit == other.Reddit ||
                    this.Reddit != null &&
                    this.Reddit.SequenceEqual(other.Reddit)
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
                if (this.Facebook != null)
                    hash = hash * 59 + this.Facebook.GetHashCode();
                if (this.GooglePlus != null)
                    hash = hash * 59 + this.GooglePlus.GetHashCode();
                if (this.Linkedin != null)
                    hash = hash * 59 + this.Linkedin.GetHashCode();
                if (this.Reddit != null)
                    hash = hash * 59 + this.Reddit.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
