/* 
 * AYLIEN News API
 *
 * The AYLIEN News API is the most powerful way of sourcing, searching and syndicating analyzed and enriched news content. It is accessed by sending HTTP requests to our server, which returns information to your client. 
 *
 * The version of the OpenAPI document: 3.0
 * Contact: support@aylien.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
using OpenAPIDateConverter = Aylien.NewsApi.Client.OpenAPIDateConverter;

namespace Aylien.NewsApi.Model
{
    /// <summary>
    /// Clusters
    /// </summary>
    [DataContract]
    public partial class Clusters :  IEquatable<Clusters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clusters" /> class.
        /// </summary>
        /// <param name="clusterCount">The total number of clusters.</param>
        /// <param name="clusters">An array of clusters.</param>
        /// <param name="nextPageCursor">The next page cursor.</param>
        public Clusters(long clusterCount = default(long), List<Cluster> clusters = default(List<Cluster>), string nextPageCursor = default(string))
        {
            this.ClusterCount = clusterCount;
            this._Clusters = clusters;
            this.NextPageCursor = nextPageCursor;
        }
        
        /// <summary>
        /// The total number of clusters
        /// </summary>
        /// <value>The total number of clusters</value>
        [DataMember(Name="cluster_count", EmitDefaultValue=false)]
        public long ClusterCount { get; set; }

        /// <summary>
        /// An array of clusters
        /// </summary>
        /// <value>An array of clusters</value>
        [DataMember(Name="clusters", EmitDefaultValue=false)]
        public List<Cluster> _Clusters { get; set; }

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
            sb.Append("class Clusters {\n");
            sb.Append("  ClusterCount: ").Append(ClusterCount).Append("\n");
            sb.Append("  _Clusters: ").Append(_Clusters).Append("\n");
            sb.Append("  NextPageCursor: ").Append(NextPageCursor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Clusters);
        }

        /// <summary>
        /// Returns true if Clusters instances are equal
        /// </summary>
        /// <param name="input">Instance of Clusters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Clusters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterCount == input.ClusterCount ||
                    (this.ClusterCount != null &&
                    this.ClusterCount.Equals(input.ClusterCount))
                ) && 
                (
                    this._Clusters == input._Clusters ||
                    this._Clusters != null &&
                    input._Clusters != null &&
                    this._Clusters.SequenceEqual(input._Clusters)
                ) && 
                (
                    this.NextPageCursor == input.NextPageCursor ||
                    (this.NextPageCursor != null &&
                    this.NextPageCursor.Equals(input.NextPageCursor))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ClusterCount != null)
                    hashCode = hashCode * 59 + this.ClusterCount.GetHashCode();
                if (this._Clusters != null)
                    hashCode = hashCode * 59 + this._Clusters.GetHashCode();
                if (this.NextPageCursor != null)
                    hashCode = hashCode * 59 + this.NextPageCursor.GetHashCode();
                return hashCode;
            }
        }
    }

}