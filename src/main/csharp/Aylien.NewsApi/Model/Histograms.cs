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
    /// Histograms
    /// </summary>
    [DataContract]
    public partial class Histograms :  IEquatable<Histograms>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Histograms" /> class.
        /// </summary>
        /// <param name="Intervals">The intervals of the histograms.</param>
        /// <param name="IntervalStart">The start interval of the histogram.</param>
        /// <param name="IntervalEnd">The end interval of the histogram.</param>
        /// <param name="IntervalWidth">The width of the histogram.</param>
        /// <param name="Field">Field.</param>
        public Histograms(List<HistogramInterval> Intervals = null, int? IntervalStart = null, int? IntervalEnd = null, int? IntervalWidth = null, string Field = null)
        {
            this.Intervals = Intervals;
            this.IntervalStart = IntervalStart;
            this.IntervalEnd = IntervalEnd;
            this.IntervalWidth = IntervalWidth;
            this.Field = Field;
        }
        
        /// <summary>
        /// The intervals of the histograms
        /// </summary>
        /// <value>The intervals of the histograms</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<HistogramInterval> Intervals { get; set; }
        /// <summary>
        /// The start interval of the histogram
        /// </summary>
        /// <value>The start interval of the histogram</value>
        [DataMember(Name="interval.start", EmitDefaultValue=false)]
        public int? IntervalStart { get; set; }
        /// <summary>
        /// The end interval of the histogram
        /// </summary>
        /// <value>The end interval of the histogram</value>
        [DataMember(Name="interval.end", EmitDefaultValue=false)]
        public int? IntervalEnd { get; set; }
        /// <summary>
        /// The width of the histogram
        /// </summary>
        /// <value>The width of the histogram</value>
        [DataMember(Name="interval.width", EmitDefaultValue=false)]
        public int? IntervalWidth { get; set; }
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Histograms {\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            sb.Append("  IntervalStart: ").Append(IntervalStart).Append("\n");
            sb.Append("  IntervalEnd: ").Append(IntervalEnd).Append("\n");
            sb.Append("  IntervalWidth: ").Append(IntervalWidth).Append("\n");
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
            return this.Equals(obj as Histograms);
        }

        /// <summary>
        /// Returns true if Histograms instances are equal
        /// </summary>
        /// <param name="other">Instance of Histograms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Histograms other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Intervals == other.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(other.Intervals)
                ) && 
                (
                    this.IntervalStart == other.IntervalStart ||
                    this.IntervalStart != null &&
                    this.IntervalStart.Equals(other.IntervalStart)
                ) && 
                (
                    this.IntervalEnd == other.IntervalEnd ||
                    this.IntervalEnd != null &&
                    this.IntervalEnd.Equals(other.IntervalEnd)
                ) && 
                (
                    this.IntervalWidth == other.IntervalWidth ||
                    this.IntervalWidth != null &&
                    this.IntervalWidth.Equals(other.IntervalWidth)
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
                if (this.Intervals != null)
                    hash = hash * 59 + this.Intervals.GetHashCode();
                if (this.IntervalStart != null)
                    hash = hash * 59 + this.IntervalStart.GetHashCode();
                if (this.IntervalEnd != null)
                    hash = hash * 59 + this.IntervalEnd.GetHashCode();
                if (this.IntervalWidth != null)
                    hash = hash * 59 + this.IntervalWidth.GetHashCode();
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                return hash;
            }
        }
    }

}
