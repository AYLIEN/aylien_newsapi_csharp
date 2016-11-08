# Aylien.NewsApi.Api.DefaultApi

All URIs are relative to *https://api.newsapi.aylien.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAutocompletes**](DefaultApi.md#listautocompletes) | **GET** /autocompletes | List autocompletes
[**ListCoverages**](DefaultApi.md#listcoverages) | **POST** /coverages | List coverages
[**ListHistograms**](DefaultApi.md#listhistograms) | **GET** /histograms | List histograms
[**ListRelatedStories**](DefaultApi.md#listrelatedstories) | **POST** /related_stories | List related stories
[**ListStories**](DefaultApi.md#liststories) | **GET** /stories | List Stories
[**ListTimeSeries**](DefaultApi.md#listtimeseries) | **GET** /time_series | List time series
[**ListTrends**](DefaultApi.md#listtrends) | **GET** /trends | List trends


<a name="listautocompletes"></a>
# **ListAutocompletes**
> Autocompletes ListAutocompletes (string type, string term, string language = null, int? perPage = null)

List autocompletes

This endpoint is used for getting list of autocompletes by providing a specific term and type.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListAutocompletesExample
    {
        public void main()
        {
            
            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-Key", "Bearer");
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-ID", "Bearer");

            var apiInstance = new DefaultApi();
            var type = type_example;  // string | This parameter is used for defining the type of autocompletes.
            var term = term_example;  // string | This parameter is used for finding autocomplete objects that contain the specified value.
            var language = language_example;  // string | This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)  (default to en)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page. (optional)  (default to 3)

            try
            {
                // List autocompletes
                Autocompletes result = apiInstance.ListAutocompletes(type, term, language, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAutocompletes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| This parameter is used for defining the type of autocompletes. | 
 **term** | **string**| This parameter is used for finding autocomplete objects that contain the specified value. | 
 **language** | **string**| This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] [default to en]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page. | [optional] [default to 3]

### Return type

[**Autocompletes**](Autocompletes.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcoverages"></a>
# **ListCoverages**
> Coverages ListCoverages (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)

List coverages

This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListCoveragesExample
    {
        public void main()
        {
            
            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-Key", "Bearer");
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-ID", "Bearer");

            var apiInstance = new DefaultApi();
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stories by story id. (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value. (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value. (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value. (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value. (optional) 
            var mediaImagesFormat = new List<string>(); // List<string> | This parameter is used for finding stories whose images format are the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
            var sourceId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose source id is the specified value. (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value. (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value. (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesLevel = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. (optional) 
            var cluster = true;  // bool? | This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). (optional)  (default to false)
            var clusterAlgorithm = clusterAlgorithm_example;  // string | This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). (optional)  (default to lingo)
            var _return = new List<string>(); // List<string> | This parameter is used for specifying return fields. (optional) 
            var storyId = 789;  // long? | A story id (optional) 
            var storyUrl = storyUrl_example;  // string | An article or webpage (optional) 
            var storyTitle = storyTitle_example;  // string | Title of the article (optional) 
            var storyBody = storyBody_example;  // string | Body of the article (optional) 
            var storyPublishedAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional) 
            var storyLanguage = storyLanguage_example;  // string | This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)  (default to auto)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page. (optional)  (default to 3)

            try
            {
                // List coverages
                Coverages result = apiInstance.ListCoverages(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, storyPublishedAt, storyLanguage, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCoverages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long?&gt;**](long?.md)| This parameter is used for finding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose images format are the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to lingo]
 **_return** | [**List&lt;string&gt;**](string.md)| This parameter is used for specifying return fields. | [optional] 
 **storyId** | **long?**| A story id | [optional] 
 **storyUrl** | **string**| An article or webpage | [optional] 
 **storyTitle** | **string**| Title of the article | [optional] 
 **storyBody** | **string**| Body of the article | [optional] 
 **storyPublishedAt** | **DateTime?**| Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). | [optional] 
 **storyLanguage** | **string**| This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] [default to auto]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page. | [optional] [default to 3]

### Return type

[**Coverages**](Coverages.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhistograms"></a>
# **ListHistograms**
> Histograms ListHistograms (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)

List histograms

This endpoint is used for getting histograms based on the `field` parameter passed to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListHistogramsExample
    {
        public void main()
        {
            
            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-Key", "Bearer");
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-ID", "Bearer");

            var apiInstance = new DefaultApi();
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stories by story id. (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value. (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value. (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value. (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value. (optional) 
            var mediaImagesFormat = new List<string>(); // List<string> | This parameter is used for finding stories whose images format are the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
            var sourceId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose source id is the specified value. (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value. (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value. (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesLevel = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. (optional) 
            var intervalStart = 56;  // int? | This parameter is used for setting the start data point of histogram intervals. (optional) 
            var intervalEnd = 56;  // int? | This parameter is used for setting the end data point of histogram intervals. (optional) 
            var intervalWidth = 56;  // int? | This parameter is used for setting the width of histogram intervals. (optional) 
            var field = field_example;  // string | This parameter is used for specifying the y-axis variable for the histogram. (optional)  (default to social_shares_count)

            try
            {
                // List histograms
                Histograms result = apiInstance.ListHistograms(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, intervalStart, intervalEnd, intervalWidth, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListHistograms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long?&gt;**](long?.md)| This parameter is used for finding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose images format are the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **intervalStart** | **int?**| This parameter is used for setting the start data point of histogram intervals. | [optional] 
 **intervalEnd** | **int?**| This parameter is used for setting the end data point of histogram intervals. | [optional] 
 **intervalWidth** | **int?**| This parameter is used for setting the width of histogram intervals. | [optional] 
 **field** | **string**| This parameter is used for specifying the y-axis variable for the histogram. | [optional] [default to social_shares_count]

### Return type

[**Histograms**](Histograms.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrelatedstories"></a>
# **ListRelatedStories**
> RelatedStories ListRelatedStories (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)

List related stories

This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListRelatedStoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-Key", "Bearer");
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-ID", "Bearer");

            var apiInstance = new DefaultApi();
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stories by story id. (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value. (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value. (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value. (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value. (optional) 
            var mediaImagesFormat = new List<string>(); // List<string> | This parameter is used for finding stories whose images format are the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
            var sourceId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose source id is the specified value. (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value. (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value. (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesLevel = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. (optional) 
            var cluster = true;  // bool? | This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). (optional)  (default to false)
            var clusterAlgorithm = clusterAlgorithm_example;  // string | This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). (optional)  (default to lingo)
            var _return = new List<string>(); // List<string> | This parameter is used for specifying return fields. (optional) 
            var storyId = 789;  // long? | A story id (optional) 
            var storyUrl = storyUrl_example;  // string | An article or webpage (optional) 
            var storyTitle = storyTitle_example;  // string | Title of the article (optional) 
            var storyBody = storyBody_example;  // string | Body of the article (optional) 
            var boostBy = boostBy_example;  // string | This parameter is used for boosting the result by the specified value. (optional) 
            var storyLanguage = storyLanguage_example;  // string | This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)  (default to auto)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page. (optional)  (default to 3)

            try
            {
                // List related stories
                RelatedStories result = apiInstance.ListRelatedStories(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, boostBy, storyLanguage, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListRelatedStories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long?&gt;**](long?.md)| This parameter is used for finding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose images format are the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to lingo]
 **_return** | [**List&lt;string&gt;**](string.md)| This parameter is used for specifying return fields. | [optional] 
 **storyId** | **long?**| A story id | [optional] 
 **storyUrl** | **string**| An article or webpage | [optional] 
 **storyTitle** | **string**| Title of the article | [optional] 
 **storyBody** | **string**| Body of the article | [optional] 
 **boostBy** | **string**| This parameter is used for boosting the result by the specified value. | [optional] 
 **storyLanguage** | **string**| This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] [default to auto]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page. | [optional] [default to 3]

### Return type

[**RelatedStories**](RelatedStories.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststories"></a>
# **ListStories**
> Stories ListStories (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)

List Stories

This endpoint is used for getting a list of stories.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListStoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-Key", "Bearer");
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-ID", "Bearer");

            var apiInstance = new DefaultApi();
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stories by story id. (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value. (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value. (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value. (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value. (optional) 
            var mediaImagesFormat = new List<string>(); // List<string> | This parameter is used for finding stories whose images format are the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
            var sourceId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose source id is the specified value. (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value. (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value. (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesLevel = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. (optional) 
            var cluster = true;  // bool? | This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). (optional)  (default to false)
            var clusterAlgorithm = clusterAlgorithm_example;  // string | This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). (optional)  (default to lingo)
            var _return = new List<string>(); // List<string> | This parameter is used for specifying return fields. (optional) 
            var sortBy = sortBy_example;  // string | This parameter is used for changing the order column of the results. (optional)  (default to published_at)
            var sortDirection = sortDirection_example;  // string | This parameter is used for changing the order direction of the result. (optional)  (default to desc)
            var cursor = cursor_example;  // string | This parameter is used for finding a specific page. You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results). (optional)  (default to *)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results) (optional)  (default to 10)

            try
            {
                // List Stories
                Stories result = apiInstance.ListStories(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, cluster, clusterAlgorithm, _return, sortBy, sortDirection, cursor, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListStories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long?&gt;**](long?.md)| This parameter is used for finding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose images format are the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to lingo]
 **_return** | [**List&lt;string&gt;**](string.md)| This parameter is used for specifying return fields. | [optional] 
 **sortBy** | **string**| This parameter is used for changing the order column of the results. | [optional] [default to published_at]
 **sortDirection** | **string**| This parameter is used for changing the order direction of the result. | [optional] [default to desc]
 **cursor** | **string**| This parameter is used for finding a specific page. You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results). | [optional] [default to *]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results) | [optional] [default to 10]

### Return type

[**Stories**](Stories.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtimeseries"></a>
# **ListTimeSeries**
> TimeSeriesList ListTimeSeries (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)

List time series

This endpoint is used for getting time series by stories.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListTimeSeriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-Key", "Bearer");
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-ID", "Bearer");

            var apiInstance = new DefaultApi();
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stories by story id. (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value. (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value. (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value. (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value. (optional) 
            var mediaImagesFormat = new List<string>(); // List<string> | This parameter is used for finding stories whose images format are the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
            var sourceId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose source id is the specified value. (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value. (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value. (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesLevel = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)  (default to NOW-7DAYS/DAY)
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)  (default to NOW/DAY)
            var period = period_example;  // string | The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are `+` following an integer number greater than 0 and one of the Date Math keywords. e.g. `+1DAY`, `+2MINUTES` and `+1MONTH`. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional)  (default to +1DAY)

            try
            {
                // List time series
                TimeSeriesList result = apiInstance.ListTimeSeries(id, title, body, text, language, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, publishedAtStart, publishedAtEnd, period);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListTimeSeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long?&gt;**](long?.md)| This parameter is used for finding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose images format are the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] [default to NOW-7DAYS/DAY]
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] [default to NOW/DAY]
 **period** | **string**| The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). | [optional] [default to +1DAY]

### Return type

[**TimeSeriesList**](TimeSeriesList.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtrends"></a>
# **ListTrends**
> Trends ListTrends (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, string field = null)

List trends

This endpoint is used for finding trends based on stories.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListTrendsExample
    {
        public void main()
        {
            
            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-Key", "Bearer");
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AYLIEN-NewsAPI-Application-ID", "Bearer");

            var apiInstance = new DefaultApi();
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stories by story id. (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value. (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value. (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value. (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value. (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value. (optional) 
            var mediaImagesFormat = new List<string>(); // List<string> | This parameter is used for finding stories whose images format are the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
            var sourceId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose source id is the specified value. (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value. (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value. (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceScopesLevel = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. (optional) 
            var field = field_example;  // string | This parameter is used to specify the trend field. (optional) 

            try
            {
                // List trends
                Trends result = apiInstance.ListTrends(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long?&gt;**](long?.md)| This parameter is used for finding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose images format are the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List&lt;int?&gt;**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **field** | **string**| This parameter is used to specify the trend field. | [optional] 

### Return type

[**Trends**](Trends.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

