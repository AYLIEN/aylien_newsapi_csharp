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
    /// Sentiment
    /// </summary>
    [DataContract]
    public partial class Sentiment :  IEquatable<Sentiment>
    {
        /// <summary>
        /// Gets or Sets Polarity
        /// </summary>
        [DataMember(Name="polarity", EmitDefaultValue=false)]
        public SentimentPolarity? Polarity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sentiment" /> class.
        /// </summary>
        /// <param name="polarity">polarity.</param>
        /// <param name="score">Polarity score of the sentiment.</param>
        public Sentiment(SentimentPolarity polarity = default(SentimentPolarity), double score = default(double))
        {
            this.Polarity = polarity;
            this.Score = score;
        }
        

        /// <summary>
        /// Polarity score of the sentiment
        /// </summary>
        /// <value>Polarity score of the sentiment</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sentiment {\n");
            sb.Append("  Polarity: ").Append(Polarity).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as Sentiment);
        }

        /// <summary>
        /// Returns true if Sentiment instances are equal
        /// </summary>
        /// <param name="input">Instance of Sentiment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sentiment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Polarity == input.Polarity ||
                    (this.Polarity != null &&
                    this.Polarity.Equals(input.Polarity))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
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
                if (this.Polarity != null)
                    hashCode = hashCode * 59 + this.Polarity.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                return hashCode;
            }
        }
    }

}
