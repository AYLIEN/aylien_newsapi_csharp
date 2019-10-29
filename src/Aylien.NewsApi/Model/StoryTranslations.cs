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
    /// Translations of the story. Each language has it&#39;s own key and object
    /// </summary>
    [DataContract]
    public partial class StoryTranslations :  IEquatable<StoryTranslations>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryTranslations" /> class.
        /// </summary>
        /// <param name="en">en.</param>
        public StoryTranslations(StoryTranslationsEn en = default(StoryTranslationsEn))
        {
            this.En = en;
        }
        
        /// <summary>
        /// Gets or Sets En
        /// </summary>
        [DataMember(Name="en", EmitDefaultValue=false)]
        public StoryTranslationsEn En { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoryTranslations {\n");
            sb.Append("  En: ").Append(En).Append("\n");
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
            return this.Equals(input as StoryTranslations);
        }

        /// <summary>
        /// Returns true if StoryTranslations instances are equal
        /// </summary>
        /// <param name="input">Instance of StoryTranslations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoryTranslations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.En == input.En ||
                    (this.En != null &&
                    this.En.Equals(input.En))
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
                if (this.En != null)
                    hashCode = hashCode * 59 + this.En.GetHashCode();
                return hashCode;
            }
        }
    }

}