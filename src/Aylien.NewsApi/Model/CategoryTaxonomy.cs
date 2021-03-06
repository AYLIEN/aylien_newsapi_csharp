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
    /// The taxonomy of the category
    /// </summary>
    /// <value>The taxonomy of the category</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CategoryTaxonomy
    {
        /// <summary>
        /// Enum IabQag for value: iab-qag
        /// </summary>
        [EnumMember(Value = "iab-qag")]
        IabQag = 1,

        /// <summary>
        /// Enum IptcSubjectcode for value: iptc-subjectcode
        /// </summary>
        [EnumMember(Value = "iptc-subjectcode")]
        IptcSubjectcode = 2

    }

}
