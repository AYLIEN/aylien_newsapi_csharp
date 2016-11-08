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
    /// HistogramInterval
    /// </summary>
    [DataContract]
    public partial class HistogramInterval :  IEquatable<HistogramInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramInterval" /> class.
        /// </summary>
        /// <param name="Bin">Histogram bin.</param>
        /// <param name="Count">Histogram bin size.</param>
        public HistogramInterval(int? Bin = null, int? Count = null)
        {
            this.Bin = Bin;
            this.Count = Count;
        }
        
        /// <summary>
        /// Histogram bin
        /// </summary>
        /// <value>Histogram bin</value>
        [DataMember(Name="bin", EmitDefaultValue=false)]
        public int? Bin { get; set; }
        /// <summary>
        /// Histogram bin size
        /// </summary>
        /// <value>Histogram bin size</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistogramInterval {\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
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
            return this.Equals(obj as HistogramInterval);
        }

        /// <summary>
        /// Returns true if HistogramInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of HistogramInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistogramInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Bin == other.Bin ||
                    this.Bin != null &&
                    this.Bin.Equals(other.Bin)
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
                if (this.Bin != null)
                    hash = hash * 59 + this.Bin.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
