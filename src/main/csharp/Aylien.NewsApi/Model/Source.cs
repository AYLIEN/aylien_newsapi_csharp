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
    /// Source
    /// </summary>
    [DataContract]
    public partial class Source : IEquatable<Source>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="Id">The source id which is a unique value.</param>
        /// <param name="Name">The source name.</param>
        /// <param name="Domain">Domain name of the source which is extracted from the source URL.</param>
        /// <param name="LogoUrl">A URL which points to the source logo.</param>
        /// <param name="Locations">The source locations which are tend to be the physical locations of the source, e.g. BBC headquarter is located in London..</param>
        /// <param name="Scopes">The source scopes which is tend to be scope locations of the source, e.g. BBC scopes is international. .</param>
        public Source(int? Id = null, string Name = null, string Domain = null, string LogoUrl = null, List<Location> Locations = null, List<Scope> Scopes = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Domain = Domain;
            this.LogoUrl = LogoUrl;
            this.Locations = Locations;
            this.Scopes = Scopes;
        }

        /// <summary>
        /// The source id which is a unique value
        /// </summary>
        /// <value>The source id which is a unique value</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }
        /// <summary>
        /// The source name
        /// </summary>
        /// <value>The source name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Domain name of the source which is extracted from the source URL
        /// </summary>
        /// <value>Domain name of the source which is extracted from the source URL</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }
        /// <summary>
        /// A URL which points to the source logo
        /// </summary>
        /// <value>A URL which points to the source logo</value>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }
        /// <summary>
        /// The source locations which are tend to be the physical locations of the source, e.g. BBC headquarter is located in London.
        /// </summary>
        /// <value>The source locations which are tend to be the physical locations of the source, e.g. BBC headquarter is located in London.</value>
        [DataMember(Name = "locations", EmitDefaultValue = false)]
        public List<Location> Locations { get; set; }
        /// <summary>
        /// The source scopes which is tend to be scope locations of the source, e.g. BBC scopes is international. 
        /// </summary>
        /// <value>The source scopes which is tend to be scope locations of the source, e.g. BBC scopes is international. </value>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        public List<Scope> Scopes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Source {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(obj as Source);
        }

        /// <summary>
        /// Returns true if Source instances are equal
        /// </summary>
        /// <param name="other">Instance of Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Source other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.LogoUrl == other.LogoUrl ||
                    this.LogoUrl != null &&
                    this.LogoUrl.Equals(other.LogoUrl)
                ) &&
                (
                    this.Locations == other.Locations ||
                    this.Locations != null &&
                    this.Locations.SequenceEqual(other.Locations)
                ) &&
                (
                    this.Scopes == other.Scopes ||
                    this.Scopes != null &&
                    this.Scopes.SequenceEqual(other.Scopes)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.LogoUrl != null)
                    hash = hash * 59 + this.LogoUrl.GetHashCode();
                if (this.Locations != null)
                    hash = hash * 59 + this.Locations.GetHashCode();
                if (this.Scopes != null)
                    hash = hash * 59 + this.Scopes.GetHashCode();
                return hash;
            }
        }
    }

}
