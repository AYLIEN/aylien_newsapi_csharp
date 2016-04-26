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
    public partial class EntityLinks :  IEquatable<EntityLinks>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityLinks" /> class.
        /// Initializes a new instance of the <see cref="EntityLinks" />class.
        /// </summary>
        /// <param name="Dbpedia">A dbpedia resource URL.</param>

        public EntityLinks(string Dbpedia = null)
        {
            this.Dbpedia = Dbpedia;
            
        }

    
        /// <summary>
        /// A dbpedia resource URL
        /// </summary>
        /// <value>A dbpedia resource URL</value>
        [DataMember(Name="dbpedia", EmitDefaultValue=false)]
        public string Dbpedia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityLinks {\n");
            sb.Append("  Dbpedia: ").Append(Dbpedia).Append("\n");
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
            return this.Equals(obj as EntityLinks);
        }

        /// <summary>
        /// Returns true if EntityLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dbpedia == other.Dbpedia ||
                    this.Dbpedia != null &&
                    this.Dbpedia.Equals(other.Dbpedia)
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
                if (this.Dbpedia != null)
                    hash = hash * 59 + this.Dbpedia.GetHashCode();
                return hash;
            }
        }

    }
}
