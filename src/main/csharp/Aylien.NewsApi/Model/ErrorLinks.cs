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
    /// ErrorLinks
    /// </summary>
    [DataContract]
    public partial class ErrorLinks : IEquatable<ErrorLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLinks" /> class.
        /// </summary>
        /// <param name="About">About.</param>
        public ErrorLinks(string About = null)
        {
            this.About = About;
        }

        /// <summary>
        /// Gets or Sets About
        /// </summary>
        [DataMember(Name = "about", EmitDefaultValue = false)]
        public string About { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorLinks {\n");
            sb.Append("  About: ").Append(About).Append("\n");
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
            return this.Equals(obj as ErrorLinks);
        }

        /// <summary>
        /// Returns true if ErrorLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.About == other.About ||
                    this.About != null &&
                    this.About.Equals(other.About)
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
                if (this.About != null)
                    hash = hash * 59 + this.About.GetHashCode();
                return hash;
            }
        }
    }

}
