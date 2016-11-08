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
    /// Trends
    /// </summary>
    [DataContract]
    public partial class Trends :  IEquatable<Trends>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trends" /> class.
        /// </summary>
        /// <param name="_Trends">An array of trends.</param>
        /// <param name="Field">The field of trends.</param>
        public Trends(List<Trend> _Trends = null, string Field = null)
        {
            this._Trends = _Trends;
            this.Field = Field;
        }
        
        /// <summary>
        /// An array of trends
        /// </summary>
        /// <value>An array of trends</value>
        [DataMember(Name="trends", EmitDefaultValue=false)]
        public List<Trend> _Trends { get; set; }
        /// <summary>
        /// The field of trends
        /// </summary>
        /// <value>The field of trends</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trends {\n");
            sb.Append("  _Trends: ").Append(_Trends).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(obj as Trends);
        }

        /// <summary>
        /// Returns true if Trends instances are equal
        /// </summary>
        /// <param name="other">Instance of Trends to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trends other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Trends == other._Trends ||
                    this._Trends != null &&
                    this._Trends.SequenceEqual(other._Trends)
                ) && 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
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
                if (this._Trends != null)
                    hash = hash * 59 + this._Trends.GetHashCode();
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
