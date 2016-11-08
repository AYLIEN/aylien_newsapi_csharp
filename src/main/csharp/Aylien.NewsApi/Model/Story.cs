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
    /// Story
    /// </summary>
    [DataContract]
    public partial class Story :  IEquatable<Story>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Story" /> class.
        /// </summary>
        /// <param name="Id">ID of the story which is a unique identification.</param>
        /// <param name="Title">Title of the story.</param>
        /// <param name="Body">Body of the story.</param>
        /// <param name="Summary">The suggested story summary.</param>
        /// <param name="Source">The story source.</param>
        /// <param name="Author">The story author.</param>
        /// <param name="Entities">Extracted entities from the story title or body.</param>
        /// <param name="Keywords">Extracted keywords mentioned in the story title or body.</param>
        /// <param name="Hashtags">An array of suggested Story hashtags.</param>
        /// <param name="CharactersCount">Character count of the story body.</param>
        /// <param name="WordsCount">Word count of the story body.</param>
        /// <param name="SentencesCount">Sentence count of the story body.</param>
        /// <param name="ParagraphsCount">Paragraph count of the story body.</param>
        /// <param name="Categories">Suggested categories for the story.</param>
        /// <param name="SocialSharesCount">Social shares count for the story.</param>
        /// <param name="Media">An array of extracted media such as images and videos.</param>
        /// <param name="Sentiment">Suggested sentiments for the story title or body.</param>
        /// <param name="Language">Language of the story.</param>
        /// <param name="PublishedAt">Published date of the story.</param>
        /// <param name="Links">Links which is related to the story.</param>
        public Story(long? Id = null, string Title = null, string Body = null, Summary Summary = null, Source Source = null, Author Author = null, Entities Entities = null, List<string> Keywords = null, List<string> Hashtags = null, int? CharactersCount = null, int? WordsCount = null, int? SentencesCount = null, int? ParagraphsCount = null, List<Category> Categories = null, ShareCounts SocialSharesCount = null, List<Media> Media = null, Sentiments Sentiment = null, string Language = null, DateTime? PublishedAt = null, StoryLinks Links = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.Body = Body;
            this.Summary = Summary;
            this.Source = Source;
            this.Author = Author;
            this.Entities = Entities;
            this.Keywords = Keywords;
            this.Hashtags = Hashtags;
            this.CharactersCount = CharactersCount;
            this.WordsCount = WordsCount;
            this.SentencesCount = SentencesCount;
            this.ParagraphsCount = ParagraphsCount;
            this.Categories = Categories;
            this.SocialSharesCount = SocialSharesCount;
            this.Media = Media;
            this.Sentiment = Sentiment;
            this.Language = Language;
            this.PublishedAt = PublishedAt;
            this.Links = Links;
        }
        
        /// <summary>
        /// ID of the story which is a unique identification
        /// </summary>
        /// <value>ID of the story which is a unique identification</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Title of the story
        /// </summary>
        /// <value>Title of the story</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Body of the story
        /// </summary>
        /// <value>Body of the story</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        /// <summary>
        /// The suggested story summary
        /// </summary>
        /// <value>The suggested story summary</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public Summary Summary { get; set; }
        /// <summary>
        /// The story source
        /// </summary>
        /// <value>The story source</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public Source Source { get; set; }
        /// <summary>
        /// The story author
        /// </summary>
        /// <value>The story author</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public Author Author { get; set; }
        /// <summary>
        /// Extracted entities from the story title or body
        /// </summary>
        /// <value>Extracted entities from the story title or body</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public Entities Entities { get; set; }
        /// <summary>
        /// Extracted keywords mentioned in the story title or body
        /// </summary>
        /// <value>Extracted keywords mentioned in the story title or body</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }
        /// <summary>
        /// An array of suggested Story hashtags
        /// </summary>
        /// <value>An array of suggested Story hashtags</value>
        [DataMember(Name="hashtags", EmitDefaultValue=false)]
        public List<string> Hashtags { get; set; }
        /// <summary>
        /// Character count of the story body
        /// </summary>
        /// <value>Character count of the story body</value>
        [DataMember(Name="characters_count", EmitDefaultValue=false)]
        public int? CharactersCount { get; set; }
        /// <summary>
        /// Word count of the story body
        /// </summary>
        /// <value>Word count of the story body</value>
        [DataMember(Name="words_count", EmitDefaultValue=false)]
        public int? WordsCount { get; set; }
        /// <summary>
        /// Sentence count of the story body
        /// </summary>
        /// <value>Sentence count of the story body</value>
        [DataMember(Name="sentences_count", EmitDefaultValue=false)]
        public int? SentencesCount { get; set; }
        /// <summary>
        /// Paragraph count of the story body
        /// </summary>
        /// <value>Paragraph count of the story body</value>
        [DataMember(Name="paragraphs_count", EmitDefaultValue=false)]
        public int? ParagraphsCount { get; set; }
        /// <summary>
        /// Suggested categories for the story
        /// </summary>
        /// <value>Suggested categories for the story</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }
        /// <summary>
        /// Social shares count for the story
        /// </summary>
        /// <value>Social shares count for the story</value>
        [DataMember(Name="social_shares_count", EmitDefaultValue=false)]
        public ShareCounts SocialSharesCount { get; set; }
        /// <summary>
        /// An array of extracted media such as images and videos
        /// </summary>
        /// <value>An array of extracted media such as images and videos</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public List<Media> Media { get; set; }
        /// <summary>
        /// Suggested sentiments for the story title or body
        /// </summary>
        /// <value>Suggested sentiments for the story title or body</value>
        [DataMember(Name="sentiment", EmitDefaultValue=false)]
        public Sentiments Sentiment { get; set; }
        /// <summary>
        /// Language of the story
        /// </summary>
        /// <value>Language of the story</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// Published date of the story
        /// </summary>
        /// <value>Published date of the story</value>
        [DataMember(Name="published_at", EmitDefaultValue=false)]
        public DateTime? PublishedAt { get; set; }
        /// <summary>
        /// Links which is related to the story
        /// </summary>
        /// <value>Links which is related to the story</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public StoryLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Story {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Hashtags: ").Append(Hashtags).Append("\n");
            sb.Append("  CharactersCount: ").Append(CharactersCount).Append("\n");
            sb.Append("  WordsCount: ").Append(WordsCount).Append("\n");
            sb.Append("  SentencesCount: ").Append(SentencesCount).Append("\n");
            sb.Append("  ParagraphsCount: ").Append(ParagraphsCount).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  SocialSharesCount: ").Append(SocialSharesCount).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as Story);
        }

        /// <summary>
        /// Returns true if Story instances are equal
        /// </summary>
        /// <param name="other">Instance of Story to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Story other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) && 
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.Equals(other.Entities)
                ) && 
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
                ) && 
                (
                    this.Hashtags == other.Hashtags ||
                    this.Hashtags != null &&
                    this.Hashtags.SequenceEqual(other.Hashtags)
                ) && 
                (
                    this.CharactersCount == other.CharactersCount ||
                    this.CharactersCount != null &&
                    this.CharactersCount.Equals(other.CharactersCount)
                ) && 
                (
                    this.WordsCount == other.WordsCount ||
                    this.WordsCount != null &&
                    this.WordsCount.Equals(other.WordsCount)
                ) && 
                (
                    this.SentencesCount == other.SentencesCount ||
                    this.SentencesCount != null &&
                    this.SentencesCount.Equals(other.SentencesCount)
                ) && 
                (
                    this.ParagraphsCount == other.ParagraphsCount ||
                    this.ParagraphsCount != null &&
                    this.ParagraphsCount.Equals(other.ParagraphsCount)
                ) && 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    this.SocialSharesCount == other.SocialSharesCount ||
                    this.SocialSharesCount != null &&
                    this.SocialSharesCount.Equals(other.SocialSharesCount)
                ) && 
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.SequenceEqual(other.Media)
                ) && 
                (
                    this.Sentiment == other.Sentiment ||
                    this.Sentiment != null &&
                    this.Sentiment.Equals(other.Sentiment)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.PublishedAt == other.PublishedAt ||
                    this.PublishedAt != null &&
                    this.PublishedAt.Equals(other.PublishedAt)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                if (this.Hashtags != null)
                    hash = hash * 59 + this.Hashtags.GetHashCode();
                if (this.CharactersCount != null)
                    hash = hash * 59 + this.CharactersCount.GetHashCode();
                if (this.WordsCount != null)
                    hash = hash * 59 + this.WordsCount.GetHashCode();
                if (this.SentencesCount != null)
                    hash = hash * 59 + this.SentencesCount.GetHashCode();
                if (this.ParagraphsCount != null)
                    hash = hash * 59 + this.ParagraphsCount.GetHashCode();
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                if (this.SocialSharesCount != null)
                    hash = hash * 59 + this.SocialSharesCount.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                if (this.Sentiment != null)
                    hash = hash * 59 + this.Sentiment.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.PublishedAt != null)
                    hash = hash * 59 + this.PublishedAt.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
