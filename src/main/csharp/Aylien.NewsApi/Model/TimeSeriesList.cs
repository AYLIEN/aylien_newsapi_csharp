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
    /// TimeSeriesList
    /// </summary>
    [DataContract]
    public partial class TimeSeriesList :  IEquatable<TimeSeriesList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesList" /> class.
        /// </summary>
        /// <param name="TimeSeries">An array of time series.</param>
        /// <param name="Period">The size of each date range expressed as an interval to be added to the lower bound..</param>
        /// <param name="PublishedAtStart">The start published date of the time series.</param>
        /// <param name="PublishedAtEnd">The end published date of the time series.</param>
        public TimeSeriesList(List<TimeSeries> TimeSeries = null, string Period = null, DateTime? PublishedAtStart = null, DateTime? PublishedAtEnd = null)
        {
            this.TimeSeries = TimeSeries;
            this.Period = Period;
            this.PublishedAtStart = PublishedAtStart;
            this.PublishedAtEnd = PublishedAtEnd;
        }
        
        /// <summary>
        /// An array of time series
        /// </summary>
        /// <value>An array of time series</value>
        [DataMember(Name="time_series", EmitDefaultValue=false)]
        public List<TimeSeries> TimeSeries { get; set; }
        /// <summary>
        /// The size of each date range expressed as an interval to be added to the lower bound.
        /// </summary>
        /// <value>The size of each date range expressed as an interval to be added to the lower bound.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }
        /// <summary>
        /// The start published date of the time series
        /// </summary>
        /// <value>The start published date of the time series</value>
        [DataMember(Name="published_at.start", EmitDefaultValue=false)]
        public DateTime? PublishedAtStart { get; set; }
        /// <summary>
        /// The end published date of the time series
        /// </summary>
        /// <value>The end published date of the time series</value>
        [DataMember(Name="published_at.end", EmitDefaultValue=false)]
        public DateTime? PublishedAtEnd { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesList {\n");
            sb.Append("  TimeSeries: ").Append(TimeSeries).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PublishedAtStart: ").Append(PublishedAtStart).Append("\n");
            sb.Append("  PublishedAtEnd: ").Append(PublishedAtEnd).Append("\n");
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
            return this.Equals(obj as TimeSeriesList);
        }

        /// <summary>
        /// Returns true if TimeSeriesList instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TimeSeries == other.TimeSeries ||
                    this.TimeSeries != null &&
                    this.TimeSeries.SequenceEqual(other.TimeSeries)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.PublishedAtStart == other.PublishedAtStart ||
                    this.PublishedAtStart != null &&
                    this.PublishedAtStart.Equals(other.PublishedAtStart)
                ) && 
                (
                    this.PublishedAtEnd == other.PublishedAtEnd ||
                    this.PublishedAtEnd != null &&
                    this.PublishedAtEnd.Equals(other.PublishedAtEnd)
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
                if (this.TimeSeries != null)
                    hash = hash * 59 + this.TimeSeries.GetHashCode();
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.PublishedAtStart != null)
                    hash = hash * 59 + this.PublishedAtStart.GetHashCode();
                if (this.PublishedAtEnd != null)
                    hash = hash * 59 + this.PublishedAtEnd.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
