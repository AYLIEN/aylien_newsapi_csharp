#region License
/*
Copyright 2017 Aylien, Inc. All Rights Reserved.

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
    /// Media
    /// </summary>
    [DataContract]
    public partial class Media :  IEquatable<Media>, IValidatableObject
    {
        /// <summary>
        /// The type of media
        /// </summary>
        /// <value>The type of media</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Image for "image"
            /// </summary>
            [EnumMember(Value = "image")]
            Image,
            
            /// <summary>
            /// Enum Video for "video"
            /// </summary>
            [EnumMember(Value = "video")]
            Video
        }

        /// <summary>
        /// The format of media
        /// </summary>
        /// <value>The format of media</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum BMP for "BMP"
            /// </summary>
            [EnumMember(Value = "BMP")]
            BMP,
            
            /// <summary>
            /// Enum GIF for "GIF"
            /// </summary>
            [EnumMember(Value = "GIF")]
            GIF,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG,
            
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG,
            
            /// <summary>
            /// Enum TIFF for "TIFF"
            /// </summary>
            [EnumMember(Value = "TIFF")]
            TIFF,
            
            /// <summary>
            /// Enum PSD for "PSD"
            /// </summary>
            [EnumMember(Value = "PSD")]
            PSD,
            
            /// <summary>
            /// Enum ICO for "ICO"
            /// </summary>
            [EnumMember(Value = "ICO")]
            ICO,
            
            /// <summary>
            /// Enum CUR for "CUR"
            /// </summary>
            [EnumMember(Value = "CUR")]
            CUR,
            
            /// <summary>
            /// Enum WEBP for "WEBP"
            /// </summary>
            [EnumMember(Value = "WEBP")]
            WEBP,
            
            /// <summary>
            /// Enum SVG for "SVG"
            /// </summary>
            [EnumMember(Value = "SVG")]
            SVG
        }

        /// <summary>
        /// The type of media
        /// </summary>
        /// <value>The type of media</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The format of media
        /// </summary>
        /// <value>The format of media</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Media" /> class.
        /// </summary>
        /// <param name="Type">The type of media.</param>
        /// <param name="Url">A URL which points to the media file.</param>
        /// <param name="Format">The format of media.</param>
        /// <param name="ContentLength">The content length of media.</param>
        /// <param name="Width">The width of media.</param>
        /// <param name="Height">The height of media.</param>
        public Media(TypeEnum? Type = default(TypeEnum?), string Url = default(string), FormatEnum? Format = default(FormatEnum?), int? ContentLength = default(int?), int? Width = default(int?), int? Height = default(int?))
        {
            this.Type = Type;
            this.Url = Url;
            this.Format = Format;
            this.ContentLength = ContentLength;
            this.Width = Width;
            this.Height = Height;
        }
        
        /// <summary>
        /// A URL which points to the media file
        /// </summary>
        /// <value>A URL which points to the media file</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// The content length of media
        /// </summary>
        /// <value>The content length of media</value>
        [DataMember(Name="content_length", EmitDefaultValue=false)]
        public int? ContentLength { get; set; }
        /// <summary>
        /// The width of media
        /// </summary>
        /// <value>The width of media</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }
        /// <summary>
        /// The height of media
        /// </summary>
        /// <value>The height of media</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Media {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(obj as Media);
        }

        /// <summary>
        /// Returns true if Media instances are equal
        /// </summary>
        /// <param name="other">Instance of Media to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Media other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.ContentLength == other.ContentLength ||
                    this.ContentLength != null &&
                    this.ContentLength.Equals(other.ContentLength)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
