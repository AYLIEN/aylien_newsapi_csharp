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
    /// TimeSeries
    /// </summary>
    [DataContract]
    public partial class TimeSeries :  IEquatable<TimeSeries>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeries" /> class.
        /// </summary>
        /// <param name="PublishedAt">The published date of the time series bin.</param>
        /// <param name="Count">The count of time series bin.</param>
        public TimeSeries(DateTime? PublishedAt = null, int? Count = null)
        {
            this.PublishedAt = PublishedAt;
            this.Count = Count;
        }
        
        /// <summary>
        /// The published date of the time series bin
        /// </summary>
        /// <value>The published date of the time series bin</value>
        [DataMember(Name="published_at", EmitDefaultValue=false)]
        public DateTime? PublishedAt { get; set; }
        /// <summary>
        /// The count of time series bin
        /// </summary>
        /// <value>The count of time series bin</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeries {\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as TimeSeries);
        }

        /// <summary>
        /// Returns true if TimeSeries instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PublishedAt == other.PublishedAt ||
                    this.PublishedAt != null &&
                    this.PublishedAt.Equals(other.PublishedAt)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.PublishedAt != null)
                    hash = hash * 59 + this.PublishedAt.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                return hash;
            }
        }
    }

}
