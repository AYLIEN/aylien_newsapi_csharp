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
    /// Histograms
    /// </summary>
    [DataContract]
    public partial class Histograms :  IEquatable<Histograms>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Histograms" /> class.
        /// </summary>
        /// <param name="field">field.</param>
        /// <param name="intervalEnd">The end interval of the histogram.</param>
        /// <param name="intervalStart">The start interval of the histogram.</param>
        /// <param name="intervalWidth">The width of the histogram.</param>
        /// <param name="intervals">The intervals of the histograms.</param>
        public Histograms(string field = default(string), int intervalEnd = default(int), int intervalStart = default(int), int intervalWidth = default(int), List<HistogramInterval> intervals = default(List<HistogramInterval>))
        {
            this.Field = field;
            this.IntervalEnd = intervalEnd;
            this.IntervalStart = intervalStart;
            this.IntervalWidth = intervalWidth;
            this.Intervals = intervals;
        }
        
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// The end interval of the histogram
        /// </summary>
        /// <value>The end interval of the histogram</value>
        [DataMember(Name="interval.end", EmitDefaultValue=false)]
        public int IntervalEnd { get; set; }

        /// <summary>
        /// The start interval of the histogram
        /// </summary>
        /// <value>The start interval of the histogram</value>
        [DataMember(Name="interval.start", EmitDefaultValue=false)]
        public int IntervalStart { get; set; }

        /// <summary>
        /// The width of the histogram
        /// </summary>
        /// <value>The width of the histogram</value>
        [DataMember(Name="interval.width", EmitDefaultValue=false)]
        public int IntervalWidth { get; set; }

        /// <summary>
        /// The intervals of the histograms
        /// </summary>
        /// <value>The intervals of the histograms</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<HistogramInterval> Intervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Histograms {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  IntervalEnd: ").Append(IntervalEnd).Append("\n");
            sb.Append("  IntervalStart: ").Append(IntervalStart).Append("\n");
            sb.Append("  IntervalWidth: ").Append(IntervalWidth).Append("\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
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
            return this.Equals(input as Histograms);
        }

        /// <summary>
        /// Returns true if Histograms instances are equal
        /// </summary>
        /// <param name="input">Instance of Histograms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Histograms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.IntervalEnd == input.IntervalEnd ||
                    (this.IntervalEnd != null &&
                    this.IntervalEnd.Equals(input.IntervalEnd))
                ) && 
                (
                    this.IntervalStart == input.IntervalStart ||
                    (this.IntervalStart != null &&
                    this.IntervalStart.Equals(input.IntervalStart))
                ) && 
                (
                    this.IntervalWidth == input.IntervalWidth ||
                    (this.IntervalWidth != null &&
                    this.IntervalWidth.Equals(input.IntervalWidth))
                ) && 
                (
                    this.Intervals == input.Intervals ||
                    this.Intervals != null &&
                    input.Intervals != null &&
                    this.Intervals.SequenceEqual(input.Intervals)
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
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.IntervalEnd != null)
                    hashCode = hashCode * 59 + this.IntervalEnd.GetHashCode();
                if (this.IntervalStart != null)
                    hashCode = hashCode * 59 + this.IntervalStart.GetHashCode();
                if (this.IntervalWidth != null)
                    hashCode = hashCode * 59 + this.IntervalWidth.GetHashCode();
                if (this.Intervals != null)
                    hashCode = hashCode * 59 + this.Intervals.GetHashCode();
                return hashCode;
            }
        }
    }

}
