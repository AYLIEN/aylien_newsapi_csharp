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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Aylien.NewsApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        #region Synchronous Operations
        /// <summary>
        /// List autocompletes
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Autocompletes</returns>
        Autocompletes ListAutocompletes(string type, string term, string language = null, int? perPage = null);

        /// <summary>
        /// List autocompletes
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>ApiResponse of Autocompletes</returns>
        ApiResponse<Autocompletes> ListAutocompletesWithHttpInfo(string type, string term, string language = null, int? perPage = null);
        /// <summary>
        /// List coverages
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Coverages</returns>
        Coverages ListCoverages(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null);

        /// <summary>
        /// List coverages
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>ApiResponse of Coverages</returns>
        ApiResponse<Coverages> ListCoveragesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null);
        /// <summary>
        /// List histograms
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>Histograms</returns>
        Histograms ListHistograms(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null);

        /// <summary>
        /// List histograms
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>ApiResponse of Histograms</returns>
        ApiResponse<Histograms> ListHistogramsWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null);
        /// <summary>
        /// List related stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>RelatedStories</returns>
        RelatedStories ListRelatedStories(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null);

        /// <summary>
        /// List related stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>ApiResponse of RelatedStories</returns>
        ApiResponse<RelatedStories> ListRelatedStoriesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null);
        /// <summary>
        /// List Stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting a list of stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>Stories</returns>
        Stories ListStories(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null);

        /// <summary>
        /// List Stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting a list of stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>ApiResponse of Stories</returns>
        ApiResponse<Stories> ListStoriesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null);
        /// <summary>
        /// List time series
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting time series by stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>TimeSeriesList</returns>
        TimeSeriesList ListTimeSeries(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null);

        /// <summary>
        /// List time series
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting time series by stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>ApiResponse of TimeSeriesList</returns>
        ApiResponse<TimeSeriesList> ListTimeSeriesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null);
        /// <summary>
        /// List trends
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding trends based on stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>Trends</returns>
        Trends ListTrends(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null);

        /// <summary>
        /// List trends
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding trends based on stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>ApiResponse of Trends</returns>
        ApiResponse<Trends> ListTrendsWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List autocompletes
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of Autocompletes</returns>
        System.Threading.Tasks.Task<Autocompletes> ListAutocompletesAsync(string type, string term, string language = null, int? perPage = null);

        /// <summary>
        /// List autocompletes
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of ApiResponse (Autocompletes)</returns>
        System.Threading.Tasks.Task<ApiResponse<Autocompletes>> ListAutocompletesAsyncWithHttpInfo(string type, string term, string language = null, int? perPage = null);
        /// <summary>
        /// List coverages
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of Coverages</returns>
        System.Threading.Tasks.Task<Coverages> ListCoveragesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null);

        /// <summary>
        /// List coverages
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of ApiResponse (Coverages)</returns>
        System.Threading.Tasks.Task<ApiResponse<Coverages>> ListCoveragesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null);
        /// <summary>
        /// List histograms
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>Task of Histograms</returns>
        System.Threading.Tasks.Task<Histograms> ListHistogramsAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null);

        /// <summary>
        /// List histograms
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>Task of ApiResponse (Histograms)</returns>
        System.Threading.Tasks.Task<ApiResponse<Histograms>> ListHistogramsAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null);
        /// <summary>
        /// List related stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of RelatedStories</returns>
        System.Threading.Tasks.Task<RelatedStories> ListRelatedStoriesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null);

        /// <summary>
        /// List related stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of ApiResponse (RelatedStories)</returns>
        System.Threading.Tasks.Task<ApiResponse<RelatedStories>> ListRelatedStoriesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null);
        /// <summary>
        /// List Stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting a list of stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>Task of Stories</returns>
        System.Threading.Tasks.Task<Stories> ListStoriesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null);

        /// <summary>
        /// List Stories
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting a list of stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>Task of ApiResponse (Stories)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stories>> ListStoriesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null);
        /// <summary>
        /// List time series
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting time series by stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>Task of TimeSeriesList</returns>
        System.Threading.Tasks.Task<TimeSeriesList> ListTimeSeriesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null);

        /// <summary>
        /// List time series
        /// </summary>
        /// <remarks>
        /// This endpoint is used for getting time series by stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>Task of ApiResponse (TimeSeriesList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeSeriesList>> ListTimeSeriesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null);
        /// <summary>
        /// List trends
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding trends based on stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>Task of Trends</returns>
        System.Threading.Tasks.Task<Trends> ListTrendsAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null);

        /// <summary>
        /// List trends
        /// </summary>
        /// <remarks>
        /// This endpoint is used for finding trends based on stories.
        /// </remarks>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>Task of ApiResponse (Trends)</returns>
        System.Threading.Tasks.Task<ApiResponse<Trends>> ListTrendsAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// List autocompletes This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Autocompletes</returns>
        public Autocompletes ListAutocompletes(string type, string term, string language = null, int? perPage = null)
        {
            ApiResponse<Autocompletes> localVarResponse = ListAutocompletesWithHttpInfo(type, term, language, perPage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List autocompletes This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>ApiResponse of Autocompletes</returns>
        public ApiResponse<Autocompletes> ListAutocompletesWithHttpInfo(string type, string term, string language = null, int? perPage = null)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling DefaultApi->ListAutocompletes");
            // verify the required parameter 'term' is set
            if (term == null)
                throw new ApiException(400, "Missing required parameter 'term' when calling DefaultApi->ListAutocompletes");

            var localVarPath = "/autocompletes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (type != null) localVarQueryParams.Add(new Tuple<String, String>("type", Configuration.ApiClient.ParameterToString(type))); // query parameter
            if (term != null) localVarQueryParams.Add(new Tuple<String, String>("term", Configuration.ApiClient.ParameterToString(term))); // query parameter
            if (language != null) localVarQueryParams.Add(new Tuple<String, String>("language", Configuration.ApiClient.ParameterToString(language))); // query parameter
            if (perPage != null) localVarQueryParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }

            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListAutocompletes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListAutocompletes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Autocompletes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Autocompletes)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Autocompletes)));

        }

        /// <summary>
        /// List autocompletes This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of Autocompletes</returns>
        public async System.Threading.Tasks.Task<Autocompletes> ListAutocompletesAsync(string type, string term, string language = null, int? perPage = null)
        {
            ApiResponse<Autocompletes> localVarResponse = await ListAutocompletesAsyncWithHttpInfo(type, term, language, perPage);
            return localVarResponse.Data;

        }

        /// <summary>
        /// List autocompletes This endpoint is used for getting list of autocompletes by providing a specific term and type.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">This parameter is used for defining the type of autocompletes.</param>
        /// <param name="term">This parameter is used for finding autocomplete objects that contain the specified value.</param>
        /// <param name="language">This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to en)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of ApiResponse (Autocompletes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Autocompletes>> ListAutocompletesAsyncWithHttpInfo(string type, string term, string language = null, int? perPage = null)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling DefaultApi->ListAutocompletes");
            // verify the required parameter 'term' is set
            if (term == null)
                throw new ApiException(400, "Missing required parameter 'term' when calling DefaultApi->ListAutocompletes");

            var localVarPath = "/autocompletes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (type != null) localVarQueryParams.Add(new Tuple<String, String>("type", Configuration.ApiClient.ParameterToString(type))); // query parameter
            if (term != null) localVarQueryParams.Add(new Tuple<String, String>("term", Configuration.ApiClient.ParameterToString(term))); // query parameter
            if (language != null) localVarQueryParams.Add(new Tuple<String, String>("language", Configuration.ApiClient.ParameterToString(language))); // query parameter
            if (perPage != null) localVarQueryParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }
            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListAutocompletes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListAutocompletes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Autocompletes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Autocompletes)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Autocompletes)));

        }

        /// <summary>
        /// List coverages This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Coverages</returns>
        public Coverages ListCoverages(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)
        {
            ApiResponse<Coverages> localVarResponse = ListCoveragesWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, storyPublishedAt, storyLanguage, perPage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List coverages This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>ApiResponse of Coverages</returns>
        public ApiResponse<Coverages> ListCoveragesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)
        {

            var localVarPath = "/coverages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarFormParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (title != null) localVarFormParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // form parameter
            if (body != null) localVarFormParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // form parameter
            if (text != null) localVarFormParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // form parameter
            if (language != null)
                foreach (var val in language)
                    localVarFormParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (publishedAtStart != null) localVarFormParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // form parameter
            if (publishedAtEnd != null) localVarFormParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // form parameter
            if (categoriesTaxonomy != null) localVarFormParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // form parameter
            if (categoriesConfident != null) localVarFormParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // form parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarFormParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sentimentTitlePolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // form parameter
            if (sentimentBodyPolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // form parameter
            if (mediaImagesCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // form parameter
            if (mediaImagesCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // form parameter
            if (mediaVideosCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // form parameter
            if (mediaVideosCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // form parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarFormParams.Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (authorName != null) localVarFormParams.Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // form parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarFormParams.Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarFormParams.Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarFormParams.Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (cluster != null) localVarFormParams.Add(new Tuple<String, String>("cluster", Configuration.ApiClient.ParameterToString(cluster))); // form parameter
            if (clusterAlgorithm != null) localVarFormParams.Add(new Tuple<String, String>("cluster.algorithm", Configuration.ApiClient.ParameterToString(clusterAlgorithm))); // form parameter

            if (_return != null)
                foreach (var val in _return)
                    localVarFormParams.Add(new Tuple<String, String>("return[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (storyId != null) localVarFormParams.Add(new Tuple<String, String>("story_id", Configuration.ApiClient.ParameterToString(storyId))); // form parameter
            if (storyUrl != null) localVarFormParams.Add(new Tuple<String, String>("story_url", Configuration.ApiClient.ParameterToString(storyUrl))); // form parameter
            if (storyTitle != null) localVarFormParams.Add(new Tuple<String, String>("story_title", Configuration.ApiClient.ParameterToString(storyTitle))); // form parameter
            if (storyBody != null) localVarFormParams.Add(new Tuple<String, String>("story_body", Configuration.ApiClient.ParameterToString(storyBody))); // form parameter
            if (storyPublishedAt != null) localVarFormParams.Add(new Tuple<String, String>("story_published_at", Configuration.ApiClient.ParameterToString(storyPublishedAt))); // form parameter
            if (storyLanguage != null) localVarFormParams.Add(new Tuple<String, String>("story_language", Configuration.ApiClient.ParameterToString(storyLanguage))); // form parameter
            if (perPage != null) localVarFormParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // form parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }

            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListCoverages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListCoverages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Coverages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Coverages)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Coverages)));

        }

        /// <summary>
        /// List coverages This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of Coverages</returns>
        public async System.Threading.Tasks.Task<Coverages> ListCoveragesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)
        {
            ApiResponse<Coverages> localVarResponse = await ListCoveragesAsyncWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, storyPublishedAt, storyLanguage, perPage);
            return localVarResponse.Data;

        }

        /// <summary>
        /// List coverages This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="storyPublishedAt">Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of ApiResponse (Coverages)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Coverages>> ListCoveragesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)
        {

            var localVarPath = "/coverages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarFormParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (title != null) localVarFormParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // form parameter
            if (body != null) localVarFormParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // form parameter
            if (text != null) localVarFormParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // form parameter
            if (language != null)
                foreach (var val in language)
                    localVarFormParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (publishedAtStart != null) localVarFormParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // form parameter
            if (publishedAtEnd != null) localVarFormParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // form parameter
            if (categoriesTaxonomy != null) localVarFormParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // form parameter
            if (categoriesConfident != null) localVarFormParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // form parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarFormParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sentimentTitlePolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // form parameter
            if (sentimentBodyPolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // form parameter
            if (mediaImagesCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // form parameter
            if (mediaImagesCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // form parameter
            if (mediaVideosCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // form parameter
            if (mediaVideosCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // form parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarFormParams.Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (authorName != null) localVarFormParams.Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // form parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarFormParams.Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarFormParams.Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarFormParams.Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (cluster != null) localVarFormParams.Add(new Tuple<String, String>("cluster", Configuration.ApiClient.ParameterToString(cluster))); // form parameter
            if (clusterAlgorithm != null) localVarFormParams.Add(new Tuple<String, String>("cluster.algorithm", Configuration.ApiClient.ParameterToString(clusterAlgorithm))); // form parameter
            if (_return != null)
                foreach (var val in _return)
                    localVarFormParams.Add(new Tuple<String, String>("return[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (storyId != null) localVarFormParams.Add(new Tuple<String, String>("story_id", Configuration.ApiClient.ParameterToString(storyId))); // form parameter
            if (storyUrl != null) localVarFormParams.Add(new Tuple<String, String>("story_url", Configuration.ApiClient.ParameterToString(storyUrl))); // form parameter
            if (storyTitle != null) localVarFormParams.Add(new Tuple<String, String>("story_title", Configuration.ApiClient.ParameterToString(storyTitle))); // form parameter
            if (storyBody != null) localVarFormParams.Add(new Tuple<String, String>("story_body", Configuration.ApiClient.ParameterToString(storyBody))); // form parameter
            if (storyPublishedAt != null) localVarFormParams.Add(new Tuple<String, String>("story_published_at", Configuration.ApiClient.ParameterToString(storyPublishedAt))); // form parameter
            if (storyLanguage != null) localVarFormParams.Add(new Tuple<String, String>("story_language", Configuration.ApiClient.ParameterToString(storyLanguage))); // form parameter
            if (perPage != null) localVarFormParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // form parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }
            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListCoverages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListCoverages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Coverages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Coverages)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Coverages)));

        }

        /// <summary>
        /// List histograms This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>Histograms</returns>
        public Histograms ListHistograms(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)
        {
            ApiResponse<Histograms> localVarResponse = ListHistogramsWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, intervalStart, intervalEnd, intervalWidth, field);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List histograms This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>ApiResponse of Histograms</returns>
        public ApiResponse<Histograms> ListHistogramsWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)
        {

            var localVarPath = "/histograms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams.Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams.Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams.Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams.Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams.Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams.Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams.Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams.Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams.Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams.Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams.Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (intervalStart != null) localVarQueryParams.Add(new Tuple<String, String>("interval.start", Configuration.ApiClient.ParameterToString(intervalStart))); // query parameter
            if (intervalEnd != null) localVarQueryParams.Add(new Tuple<String, String>("interval.end", Configuration.ApiClient.ParameterToString(intervalEnd))); // query parameter
            if (intervalWidth != null) localVarQueryParams.Add(new Tuple<String, String>("interval.width", Configuration.ApiClient.ParameterToString(intervalWidth))); // query parameter
            if (field != null) localVarQueryParams.Add(new Tuple<String, String>("field", Configuration.ApiClient.ParameterToString(field))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }

            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListHistograms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListHistograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Histograms>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Histograms)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Histograms)));

        }

        /// <summary>
        /// List histograms This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>Task of Histograms</returns>
        public async System.Threading.Tasks.Task<Histograms> ListHistogramsAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)
        {
            ApiResponse<Histograms> localVarResponse = await ListHistogramsAsyncWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, intervalStart, intervalEnd, intervalWidth, field);
            return localVarResponse.Data;

        }

        /// <summary>
        /// List histograms This endpoint is used for getting histograms based on the &#x60;field&#x60; parameter passed to the API.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="intervalStart">This parameter is used for setting the start data point of histogram intervals. (optional)</param>
        /// <param name="intervalEnd">This parameter is used for setting the end data point of histogram intervals. (optional)</param>
        /// <param name="intervalWidth">This parameter is used for setting the width of histogram intervals. (optional)</param>
        /// <param name="field">This parameter is used for specifying the y-axis variable for the histogram. (optional, default to social_shares_count)</param>
        /// <returns>Task of ApiResponse (Histograms)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Histograms>> ListHistogramsAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)
        {

            var localVarPath = "/histograms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams.Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams.Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams.Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams.Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams.Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams.Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams.Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams.Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams.Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams.Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams.Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (intervalStart != null) localVarQueryParams.Add(new Tuple<String, String>("interval.start", Configuration.ApiClient.ParameterToString(intervalStart))); // query parameter
            if (intervalEnd != null) localVarQueryParams.Add(new Tuple<String, String>("interval.end", Configuration.ApiClient.ParameterToString(intervalEnd))); // query parameter
            if (intervalWidth != null) localVarQueryParams.Add(new Tuple<String, String>("interval.width", Configuration.ApiClient.ParameterToString(intervalWidth))); // query parameter
            if (field != null) localVarQueryParams.Add(new Tuple<String, String>("field", Configuration.ApiClient.ParameterToString(field))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }
            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListHistograms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListHistograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Histograms>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Histograms)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Histograms)));

        }

        /// <summary>
        /// List related stories This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>RelatedStories</returns>
        public RelatedStories ListRelatedStories(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)
        {
            ApiResponse<RelatedStories> localVarResponse = ListRelatedStoriesWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, boostBy, storyLanguage, perPage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List related stories This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>ApiResponse of RelatedStories</returns>
        public ApiResponse<RelatedStories> ListRelatedStoriesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)
        {

            var localVarPath = "/related_stories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarFormParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (title != null) localVarFormParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // form parameter
            if (body != null) localVarFormParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // form parameter
            if (text != null) localVarFormParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // form parameter
            if (language != null)
                foreach (var val in language)
                    localVarFormParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (publishedAtStart != null) localVarFormParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // form parameter
            if (publishedAtEnd != null) localVarFormParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // form parameter
            if (categoriesTaxonomy != null) localVarFormParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // form parameter
            if (categoriesConfident != null) localVarFormParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // form parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarFormParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sentimentTitlePolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // form parameter
            if (sentimentBodyPolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // form parameter
            if (mediaImagesCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // form parameter
            if (mediaImagesCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // form parameter
            if (mediaVideosCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // form parameter
            if (mediaVideosCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // form parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarFormParams.Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (authorName != null) localVarFormParams.Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // form parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarFormParams.Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarFormParams.Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarFormParams.Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (cluster != null) localVarFormParams.Add(new Tuple<String, String>("cluster", Configuration.ApiClient.ParameterToString(cluster))); // form parameter
            if (clusterAlgorithm != null) localVarFormParams.Add(new Tuple<String, String>("cluster.algorithm", Configuration.ApiClient.ParameterToString(clusterAlgorithm))); // form parameter
            if (_return != null)
                foreach (var val in _return)
                    localVarFormParams.Add(new Tuple<String, String>("return[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (storyId != null) localVarFormParams.Add(new Tuple<String, String>("story_id", Configuration.ApiClient.ParameterToString(storyId))); // form parameter
            if (storyUrl != null) localVarFormParams.Add(new Tuple<String, String>("story_url", Configuration.ApiClient.ParameterToString(storyUrl))); // form parameter
            if (storyTitle != null) localVarFormParams.Add(new Tuple<String, String>("story_title", Configuration.ApiClient.ParameterToString(storyTitle))); // form parameter
            if (storyBody != null) localVarFormParams.Add(new Tuple<String, String>("story_body", Configuration.ApiClient.ParameterToString(storyBody))); // form parameter
            if (boostBy != null) localVarFormParams.Add(new Tuple<String, String>("boost_by", Configuration.ApiClient.ParameterToString(boostBy))); // form parameter
            if (storyLanguage != null) localVarFormParams.Add(new Tuple<String, String>("story_language", Configuration.ApiClient.ParameterToString(storyLanguage))); // form parameter
            if (perPage != null) localVarFormParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // form parameter


            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }

            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListRelatedStories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListRelatedStories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RelatedStories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RelatedStories)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelatedStories)));

        }

        /// <summary>
        /// List related stories This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of RelatedStories</returns>
        public async System.Threading.Tasks.Task<RelatedStories> ListRelatedStoriesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)
        {
            ApiResponse<RelatedStories> localVarResponse = await ListRelatedStoriesAsyncWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, boostBy, storyLanguage, perPage);
            return localVarResponse.Data;

        }

        /// <summary>
        /// List related stories This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="storyId">A story id (optional)</param>
        /// <param name="storyUrl">An article or webpage (optional)</param>
        /// <param name="storyTitle">Title of the article (optional)</param>
        /// <param name="storyBody">Body of the article (optional)</param>
        /// <param name="boostBy">This parameter is used for boosting the result by the specified value. (optional)</param>
        /// <param name="storyLanguage">This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional, default to auto)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 3)</param>
        /// <returns>Task of ApiResponse (RelatedStories)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RelatedStories>> ListRelatedStoriesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)
        {

            var localVarPath = "/related_stories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarFormParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (title != null) localVarFormParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // form parameter
            if (body != null) localVarFormParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // form parameter
            if (text != null) localVarFormParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // form parameter
            if (language != null)
                foreach (var val in language)
                    localVarFormParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (publishedAtStart != null) localVarFormParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // form parameter
            if (publishedAtEnd != null) localVarFormParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // form parameter
            if (categoriesTaxonomy != null) localVarFormParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // form parameter
            if (categoriesConfident != null) localVarFormParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // form parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarFormParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarFormParams.Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sentimentTitlePolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // form parameter
            if (sentimentBodyPolarity != null) localVarFormParams.Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // form parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarFormParams.Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (mediaImagesCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // form parameter
            if (mediaImagesCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // form parameter
            if (mediaVideosCountMin != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // form parameter
            if (mediaVideosCountMax != null) localVarFormParams.Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // form parameter
            if (authorName != null) localVarFormParams.Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // form parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarFormParams.Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarFormParams.Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarFormParams.Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarFormParams.Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (cluster != null) localVarFormParams.Add(new Tuple<String, String>("cluster", Configuration.ApiClient.ParameterToString(cluster))); // form parameter
            if (clusterAlgorithm != null) localVarFormParams.Add(new Tuple<String, String>("cluster.algorithm", Configuration.ApiClient.ParameterToString(clusterAlgorithm))); // form parameter
            if (_return != null)
                foreach (var val in _return)
                    localVarFormParams.Add(new Tuple<String, String>("return[]", Configuration.ApiClient.ParameterToString(val))); // form parameter
            if (storyId != null) localVarFormParams.Add(new Tuple<String, String>("story_id", Configuration.ApiClient.ParameterToString(storyId))); // form parameter
            if (storyUrl != null) localVarFormParams.Add(new Tuple<String, String>("story_url", Configuration.ApiClient.ParameterToString(storyUrl))); // form parameter
            if (storyTitle != null) localVarFormParams.Add(new Tuple<String, String>("story_title", Configuration.ApiClient.ParameterToString(storyTitle))); // form parameter
            if (storyBody != null) localVarFormParams.Add(new Tuple<String, String>("story_body", Configuration.ApiClient.ParameterToString(storyBody))); // form parameter
            if (boostBy != null) localVarFormParams.Add(new Tuple<String, String>("boost_by", Configuration.ApiClient.ParameterToString(boostBy))); // form parameter
            if (storyLanguage != null) localVarFormParams.Add(new Tuple<String, String>("story_language", Configuration.ApiClient.ParameterToString(storyLanguage))); // form parameter
            if (perPage != null) localVarFormParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // form parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }
            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListRelatedStories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListRelatedStories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RelatedStories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RelatedStories)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelatedStories)));

        }

        /// <summary>
        /// List Stories This endpoint is used for getting a list of stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>Stories</returns>
        public Stories ListStories(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)
        {
            ApiResponse<Stories> localVarResponse = ListStoriesWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, sortBy, sortDirection, cursor, perPage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Stories This endpoint is used for getting a list of stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>ApiResponse of Stories</returns>
        public ApiResponse<Stories> ListStoriesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)
        {

            var localVarPath = "/stories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams .Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams .Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams .Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams .Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams .Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams .Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams .Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams .Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams .Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams .Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams .Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams .Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (cluster != null) localVarQueryParams.Add(new Tuple<String, String>("cluster", Configuration.ApiClient.ParameterToString(cluster))); // query parameter
            if (clusterAlgorithm != null) localVarQueryParams.Add(new Tuple<String, String>("cluster.algorithm", Configuration.ApiClient.ParameterToString(clusterAlgorithm))); // query parameter
            if (_return != null)
                foreach (var val in _return)
                    localVarQueryParams.Add(new Tuple<String, String>("return[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sortBy != null) localVarQueryParams.Add(new Tuple<String, String>("sort_by", Configuration.ApiClient.ParameterToString(sortBy))); // query parameter
            if (sortDirection != null) localVarQueryParams.Add(new Tuple<String, String>("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection))); // query parameter
            if (cursor != null) localVarQueryParams.Add(new Tuple<String, String>("cursor", Configuration.ApiClient.ParameterToString(cursor))); // query parameter
            if (perPage != null) localVarQueryParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }

            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListStories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListStories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stories)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stories)));

        }

        /// <summary>
        /// List Stories This endpoint is used for getting a list of stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>Task of Stories</returns>
        public async System.Threading.Tasks.Task<Stories> ListStoriesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)
        {
            ApiResponse<Stories> localVarResponse = await ListStoriesAsyncWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, sortBy, sortDirection, cursor, perPage);
            return localVarResponse.Data;

        }

        /// <summary>
        /// List Stories This endpoint is used for getting a list of stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="cluster">This parameter enables clustering for the returned stories. (optional, default to false)</param>
        /// <param name="clusterAlgorithm">This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional, default to lingo)</param>
        /// <param name="_return">This parameter is used for specifying return fields. (optional)</param>
        /// <param name="sortBy">This parameter is used for changing the order column of the results. (optional, default to published_at)</param>
        /// <param name="sortDirection">This parameter is used for changing the order direction of the result. (optional, default to desc)</param>
        /// <param name="cursor">This parameter is used for finding a specific page. (optional, default to *)</param>
        /// <param name="perPage">This parameter is used for specifying number of items in each page. (optional, default to 10)</param>
        /// <returns>Task of ApiResponse (Stories)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stories>> ListStoriesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)
        {

            var localVarPath = "/stories";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams .Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams .Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams .Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams .Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams .Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (cluster != null) localVarQueryParams.Add(new Tuple<String, String>("cluster", Configuration.ApiClient.ParameterToString(cluster))); // query parameter
            if (clusterAlgorithm != null) localVarQueryParams.Add(new Tuple<String, String>("cluster.algorithm", Configuration.ApiClient.ParameterToString(clusterAlgorithm))); // query parameter
            if (_return != null)
                foreach (var val in _return)
                    localVarQueryParams.Add(new Tuple<String, String>("return[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sortBy != null) localVarQueryParams.Add(new Tuple<String, String>("sort_by", Configuration.ApiClient.ParameterToString(sortBy))); // query parameter
            if (sortDirection != null) localVarQueryParams.Add(new Tuple<String, String>("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection))); // query parameter
            if (cursor != null) localVarQueryParams.Add(new Tuple<String, String>("cursor", Configuration.ApiClient.ParameterToString(cursor))); // query parameter
            if (perPage != null) localVarQueryParams.Add(new Tuple<String, String>("per_page", Configuration.ApiClient.ParameterToString(perPage))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }
            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListStories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListStories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stories)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stories)));

        }

        /// <summary>
        /// List time series This endpoint is used for getting time series by stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>TimeSeriesList</returns>
        public TimeSeriesList ListTimeSeries(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)
        {
            ApiResponse<TimeSeriesList> localVarResponse = ListTimeSeriesWithHttpInfo(id, title, body, text, language, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, publishedAtStart, publishedAtEnd, period);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List time series This endpoint is used for getting time series by stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>ApiResponse of TimeSeriesList</returns>
        public ApiResponse<TimeSeriesList> ListTimeSeriesWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)
        {

            var localVarPath = "/time_series";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams .Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams .Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams .Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams .Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams .Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams .Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams .Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams .Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams .Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams .Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams .Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams .Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (period != null) localVarQueryParams.Add(new Tuple<String, String>("period", Configuration.ApiClient.ParameterToString(period))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }

            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListTimeSeries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListTimeSeries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeSeriesList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeSeriesList)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeSeriesList)));

        }

        /// <summary>
        /// List time series This endpoint is used for getting time series by stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>Task of TimeSeriesList</returns>
        public async System.Threading.Tasks.Task<TimeSeriesList> ListTimeSeriesAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)
        {
            ApiResponse<TimeSeriesList> localVarResponse = await ListTimeSeriesAsyncWithHttpInfo(id, title, body, text, language, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, publishedAtStart, publishedAtEnd, period);
            return localVarResponse.Data;

        }

        /// <summary>
        /// List time series This endpoint is used for getting time series by stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW-7DAYS/DAY)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional, default to NOW/DAY)</param>
        /// <param name="period">The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional, default to +1DAY)</param>
        /// <returns>Task of ApiResponse (TimeSeriesList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeSeriesList>> ListTimeSeriesAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)
        {

            var localVarPath = "/time_series";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams .Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams .Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams .Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams .Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams .Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams .Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams .Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams .Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams .Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams .Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams .Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams .Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (period != null) localVarQueryParams.Add(new Tuple<String, String>("period", Configuration.ApiClient.ParameterToString(period))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }
            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListTimeSeries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListTimeSeries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeSeriesList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeSeriesList)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeSeriesList)));

        }

        /// <summary>
        /// List trends This endpoint is used for finding trends based on stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>Trends</returns>
        public Trends ListTrends(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null)
        {
            ApiResponse<Trends> localVarResponse = ListTrendsWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, field);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List trends This endpoint is used for finding trends based on stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>ApiResponse of Trends</returns>
        public ApiResponse<Trends> ListTrendsWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null)
        {

            var localVarPath = "/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams .Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams .Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams .Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams .Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams .Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams .Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams .Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams .Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams .Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams .Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams .Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams .Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams .Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams .Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams .Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams .Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams .Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (field != null) localVarQueryParams.Add(new Tuple<String, String>("field", Configuration.ApiClient.ParameterToString(field))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }

            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListTrends: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Trends>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Trends)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trends)));

        }

        /// <summary>
        /// List trends This endpoint is used for finding trends based on stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>Task of Trends</returns>
        public async System.Threading.Tasks.Task<Trends> ListTrendsAsync(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null)
        {
            ApiResponse<Trends> localVarResponse = await ListTrendsAsyncWithHttpInfo(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, field);
            return localVarResponse.Data;

        }

        /// <summary>
        /// List trends This endpoint is used for finding trends based on stories.
        /// </summary>
        /// <exception cref="Aylien.NewsApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">This parameter is used for finding stroies by story id. (optional)</param>
        /// <param name="title">This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="body">This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="text">This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional)</param>
        /// <param name="language">This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)</param>
        /// <param name="publishedAtStart">This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="publishedAtEnd">This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)</param>
        /// <param name="categoriesTaxonomy">This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional)</param>
        /// <param name="categoriesConfident">This parameter is used for finding stories whose categories are confident. (optional, default to true)</param>
        /// <param name="categoriesId">This parameter is used for finding stories by categories id. (optional)</param>
        /// <param name="categoriesLevel">This parameter is used for finding stories by categories level. (optional)</param>
        /// <param name="entitiesTitleText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. (optional)</param>
        /// <param name="entitiesTitleLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional)</param>
        /// <param name="entitiesBodyText">This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyType">This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. (optional)</param>
        /// <param name="entitiesBodyLinksDbpedia">This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional)</param>
        /// <param name="sentimentTitlePolarity">This parameter is used for finding stories whose title sentiment is the specified value. (optional)</param>
        /// <param name="sentimentBodyPolarity">This parameter is used for finding stories whose body sentiment is the specified value. (optional)</param>
        /// <param name="mediaImagesCountMin">This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaImagesCountMax">This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMin">This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional)</param>
        /// <param name="mediaVideosCountMax">This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional)</param>
        /// <param name="authorId">This parameter is used for finding stories whose author id is the specified value. (optional)</param>
        /// <param name="authorName">This parameter is used for finding stories whose author full name contains the specified value. (optional)</param>
        /// <param name="sourceId">This parameter is used for finding stories whose source id is the specified value. (optional)</param>
        /// <param name="sourceName">This parameter is used for finding stories whose source name contains the specified value. (optional)</param>
        /// <param name="sourceDomain">This parameter is used for finding stories whose source domain is the specified value. (optional)</param>
        /// <param name="sourceLocationsCountry">This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsState">This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceLocationsCity">This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCountry">This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesState">This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesCity">This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="sourceScopesLevel">This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional)</param>
        /// <param name="field">This parameter is used to specify the trend field. (optional)</param>
        /// <returns>Task of ApiResponse (Trends)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Trends>> ListTrendsAsyncWithHttpInfo(List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null)
        {

            var localVarPath = "/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new List<Tuple<String, String>>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null)
                foreach (var val in id)
                    localVarQueryParams.Add(new Tuple<String, String>("id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (title != null) localVarQueryParams.Add(new Tuple<String, String>("title", Configuration.ApiClient.ParameterToString(title))); // query parameter
            if (body != null) localVarQueryParams.Add(new Tuple<String, String>("body", Configuration.ApiClient.ParameterToString(body))); // query parameter
            if (text != null) localVarQueryParams.Add(new Tuple<String, String>("text", Configuration.ApiClient.ParameterToString(text))); // query parameter
            if (language != null)
                foreach (var val in language)
                    localVarQueryParams.Add(new Tuple<String, String>("language[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (publishedAtStart != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.start", Configuration.ApiClient.ParameterToString(publishedAtStart))); // query parameter
            if (publishedAtEnd != null) localVarQueryParams.Add(new Tuple<String, String>("published_at.end", Configuration.ApiClient.ParameterToString(publishedAtEnd))); // query parameter
            if (categoriesTaxonomy != null) localVarQueryParams.Add(new Tuple<String, String>("categories.taxonomy", Configuration.ApiClient.ParameterToString(categoriesTaxonomy))); // query parameter
            if (categoriesConfident != null) localVarQueryParams.Add(new Tuple<String, String>("categories.confident", Configuration.ApiClient.ParameterToString(categoriesConfident))); // query parameter
            if (categoriesId != null)
                foreach (var val in categoriesId)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (categoriesLevel != null)
                foreach (var val in categoriesLevel)
                    localVarQueryParams.Add(new Tuple<String, String>("categories.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleText != null)
                foreach (var val in entitiesTitleText)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleType != null)
                foreach (var val in entitiesTitleType)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesTitleLinksDbpedia != null)
                foreach (var val in entitiesTitleLinksDbpedia)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.title.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyText != null)
                foreach (var val in entitiesBodyText)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.text[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyType != null)
                foreach (var val in entitiesBodyType)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.type[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (entitiesBodyLinksDbpedia != null)
                foreach (var val in entitiesBodyLinksDbpedia)
                    localVarQueryParams.Add(new Tuple<String, String>("entities.body.links.dbpedia[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sentimentTitlePolarity != null) localVarQueryParams.Add(new Tuple<String, String>("sentiment.title.polarity", Configuration.ApiClient.ParameterToString(sentimentTitlePolarity))); // query parameter
            if (sentimentBodyPolarity != null) localVarQueryParams.Add(new Tuple<String, String>("sentiment.body.polarity", Configuration.ApiClient.ParameterToString(sentimentBodyPolarity))); // query parameter
            if (mediaImagesCountMin != null) localVarQueryParams.Add(new Tuple<String, String>("media.images.count.min", Configuration.ApiClient.ParameterToString(mediaImagesCountMin))); // query parameter
            if (mediaImagesCountMax != null) localVarQueryParams.Add(new Tuple<String, String>("media.images.count.max", Configuration.ApiClient.ParameterToString(mediaImagesCountMax))); // query parameter
            if (mediaVideosCountMin != null) localVarQueryParams.Add(new Tuple<String, String>("media.videos.count.min", Configuration.ApiClient.ParameterToString(mediaVideosCountMin))); // query parameter
            if (mediaVideosCountMax != null) localVarQueryParams.Add(new Tuple<String, String>("media.videos.count.max", Configuration.ApiClient.ParameterToString(mediaVideosCountMax))); // query parameter
            if (authorId != null)
                foreach (var val in authorId)
                    localVarQueryParams.Add(new Tuple<String, String>("author.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (authorName != null) localVarQueryParams.Add(new Tuple<String, String>("author.name", Configuration.ApiClient.ParameterToString(authorName))); // query parameter
            if (sourceId != null)
                foreach (var val in sourceId)
                    localVarQueryParams.Add(new Tuple<String, String>("source.id[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceName != null)
                foreach (var val in sourceName)
                    localVarQueryParams.Add(new Tuple<String, String>("source.name[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceDomain != null)
                foreach (var val in sourceDomain)
                    localVarQueryParams.Add(new Tuple<String, String>("source.domain[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCountry != null)
                foreach (var val in sourceLocationsCountry)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsState != null)
                foreach (var val in sourceLocationsState)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceLocationsCity != null)
                foreach (var val in sourceLocationsCity)
                    localVarQueryParams.Add(new Tuple<String, String>("source.locations.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCountry != null)
                foreach (var val in sourceScopesCountry)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.country[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesState != null)
                foreach (var val in sourceScopesState)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.state[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesCity != null)
                foreach (var val in sourceScopesCity)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.city[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (sourceScopesLevel != null)
                foreach (var val in sourceScopesLevel)
                    localVarQueryParams.Add(new Tuple<String, String>("source.scopes.level[]", Configuration.ApiClient.ParameterToString(val))); // query parameter
            if (field != null) localVarQueryParams.Add(new Tuple<String, String>("field", Configuration.ApiClient.ParameterToString(field))); // query parameter

            // authentication (app_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-Key"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-Key");
            }
            // authentication (app_id) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID")))
            {
                localVarHeaderParams["X-AYLIEN-NewsAPI-Application-ID"] = Configuration.GetApiKeyWithPrefix("X-AYLIEN-NewsAPI-Application-ID");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListTrends: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Trends>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Trends)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Trends)));

        }

    }
}
