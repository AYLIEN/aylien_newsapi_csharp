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
    public partial class Stories :  IEquatable<Stories>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Stories" /> class.
        /// Initializes a new instance of the <see cref="Stories" />class.
        /// </summary>
        /// <param name="_Stories">An array of stories.</param>
        /// <param name="Clusters">An array of clusters.</param>
        /// <param name="NextPageCursor">The next page cursor.</param>

        public Stories(List<Story> _Stories = null, List<StoryCluster> Clusters = null, string NextPageCursor = null)
        {
            this._Stories = _Stories;
            this.Clusters = Clusters;
            this.NextPageCursor = NextPageCursor;
            
        }

    
        /// <summary>
        /// An array of stories
        /// </summary>
        /// <value>An array of stories</value>
        [DataMember(Name="stories", EmitDefaultValue=false)]
        public List<Story> _Stories { get; set; }
    
        /// <summary>
        /// An array of clusters
        /// </summary>
        /// <value>An array of clusters</value>
        [DataMember(Name="clusters", EmitDefaultValue=false)]
        public List<StoryCluster> Clusters { get; set; }
    
        /// <summary>
        /// The next page cursor
        /// </summary>
        /// <value>The next page cursor</value>
        [DataMember(Name="next_page_cursor", EmitDefaultValue=false)]
        public string NextPageCursor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stories {\n");
            sb.Append("  _Stories: ").Append(_Stories).Append("\n");
            sb.Append("  Clusters: ").Append(Clusters).Append("\n");
            sb.Append("  NextPageCursor: ").Append(NextPageCursor).Append("\n");
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
            return this.Equals(obj as Stories);
        }

        /// <summary>
        /// Returns true if Stories instances are equal
        /// </summary>
        /// <param name="other">Instance of Stories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stories other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Stories == other._Stories ||
                    this._Stories != null &&
                    this._Stories.SequenceEqual(other._Stories)
                ) && 
                (
                    this.Clusters == other.Clusters ||
                    this.Clusters != null &&
                    this.Clusters.SequenceEqual(other.Clusters)
                ) && 
                (
                    this.NextPageCursor == other.NextPageCursor ||
                    this.NextPageCursor != null &&
                    this.NextPageCursor.Equals(other.NextPageCursor)
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
                if (this._Stories != null)
                    hash = hash * 59 + this._Stories.GetHashCode();
                if (this.Clusters != null)
                    hash = hash * 59 + this.Clusters.GetHashCode();
                if (this.NextPageCursor != null)
                    hash = hash * 59 + this.NextPageCursor.GetHashCode();
                return hash;
            }
        }

    }
}
