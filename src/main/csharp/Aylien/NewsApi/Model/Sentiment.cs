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
    public partial class Sentiment :  IEquatable<Sentiment>
    { 

        /// <summary>
        /// Polarity of the sentiment
        /// </summary>
        /// <value>Polarity of the sentiment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PolarityEnum {
            
			///<Summary>
			/// Positive sentiment
			///</Summary>
            [EnumMember(Value = "positive")]
            Positive,
            
			///<Summary>
			/// Neutral sentiment
			///</Summary>
            [EnumMember(Value = "neutral")]
            Neutral,
            
			///<Summary>
			/// Negative sentiment
			///</Summary>
            [EnumMember(Value = "negative")]
            Negative
        }

    
        /// <summary>
        /// Polarity of the sentiment
        /// </summary>
        /// <value>Polarity of the sentiment</value>
        [DataMember(Name="polarity", EmitDefaultValue=false)]
        public PolarityEnum? Polarity { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Sentiment" /> class.
        /// Initializes a new instance of the <see cref="Sentiment" />class.
        /// </summary>
        /// <param name="Polarity">Polarity of the sentiment.</param>
        /// <param name="Score">Polarity score of the sentiment.</param>

        public Sentiment(PolarityEnum? Polarity = null, double? Score = null)
        {
            this.Polarity = Polarity;
            this.Score = Score;
            
        }

    
        /// <summary>
        /// Polarity score of the sentiment
        /// </summary>
        /// <value>Polarity score of the sentiment</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }
    
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
            return this.Equals(obj as Sentiment);
        }

        /// <summary>
        /// Returns true if Sentiment instances are equal
        /// </summary>
        /// <param name="other">Instance of Sentiment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sentiment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Polarity == other.Polarity ||
                    this.Polarity != null &&
                    this.Polarity.Equals(other.Polarity)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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
                if (this.Polarity != null)
                    hash = hash * 59 + this.Polarity.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                return hash;
            }
        }

    }
}
