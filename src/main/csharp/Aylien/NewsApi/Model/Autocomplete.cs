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
    /// 
    /// </summary>
    [DataContract]
    public partial class Autocomplete :  IEquatable<Autocomplete>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Autocomplete" /> class.
        /// Initializes a new instance of the <see cref="Autocomplete" />class.
        /// </summary>
        /// <param name="Id">ID of the autocomplete.</param>
        /// <param name="Text">Text of the autocomplete.</param>

        public Autocomplete(string Id = null, string Text = null)
        {
            this.Id = Id;
            this.Text = Text;
            
        }

    
        /// <summary>
        /// ID of the autocomplete
        /// </summary>
        /// <value>ID of the autocomplete</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Text of the autocomplete
        /// </summary>
        /// <value>Text of the autocomplete</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Autocomplete {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as Autocomplete);
        }

        /// <summary>
        /// Returns true if Autocomplete instances are equal
        /// </summary>
        /// <param name="other">Instance of Autocomplete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Autocomplete other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                return hash;
            }
        }

    }
}