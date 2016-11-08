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
    /// Rank
    /// </summary>
    [DataContract]
    public partial class Rank :  IEquatable<Rank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rank" /> class.
        /// </summary>
        /// <param name="_Rank">The rank.</param>
        /// <param name="Country">The country code which the rank is in it.</param>
        /// <param name="FetchedAt">The fetched date of the rank.</param>
        public Rank(int? _Rank = null, string Country = null, DateTime? FetchedAt = null)
        {
            this._Rank = _Rank;
            this.Country = Country;
            this.FetchedAt = FetchedAt;
        }
        
        /// <summary>
        /// The rank
        /// </summary>
        /// <value>The rank</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? _Rank { get; set; }
        /// <summary>
        /// The country code which the rank is in it
        /// </summary>
        /// <value>The country code which the rank is in it</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// The fetched date of the rank
        /// </summary>
        /// <value>The fetched date of the rank</value>
        [DataMember(Name="fetched_at", EmitDefaultValue=false)]
        public DateTime? FetchedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rank {\n");
            sb.Append("  _Rank: ").Append(_Rank).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as Rank);
        }

        /// <summary>
        /// Returns true if Rank instances are equal
        /// </summary>
        /// <param name="other">Instance of Rank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rank other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Rank == other._Rank ||
                    this._Rank != null &&
                    this._Rank.Equals(other._Rank)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this._Rank != null)
                    hash = hash * 59 + this._Rank.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.FetchedAt != null)
                    hash = hash * 59 + this.FetchedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
