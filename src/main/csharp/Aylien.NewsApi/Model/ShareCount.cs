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
    /// ShareCount
    /// </summary>
    [DataContract]
    public partial class ShareCount :  IEquatable<ShareCount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCount" /> class.
        /// </summary>
        /// <param name="Count">The number of shares.</param>
        /// <param name="FetchedAt">The fetched date of the shares.</param>
        public ShareCount(int? Count = null, DateTime? FetchedAt = null)
        {
            this.Count = Count;
            this.FetchedAt = FetchedAt;
        }
        
        /// <summary>
        /// The number of shares
        /// </summary>
        /// <value>The number of shares</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// The fetched date of the shares
        /// </summary>
        /// <value>The fetched date of the shares</value>
        [DataMember(Name="fetched_at", EmitDefaultValue=false)]
        public DateTime? FetchedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareCount {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  FetchedAt: ").Append(FetchedAt).Append("\n");
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
            return this.Equals(obj as ShareCount);
        }

        /// <summary>
        /// Returns true if ShareCount instances are equal
        /// </summary>
        /// <param name="other">Instance of ShareCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.FetchedAt == other.FetchedAt ||
                    this.FetchedAt != null &&
                    this.FetchedAt.Equals(other.FetchedAt)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.FetchedAt != null)
                    hash = hash * 59 + this.FetchedAt.GetHashCode();
                return hash;
            }
        }
    }

}
