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
        static void Main(string[] args)
        {

            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            var type = "type_example";  // string | This parameter is used for defining the type of autocompletes.
            var term = "term_example";  // string | This parameter is used for finding autocomplete objects that contain the specified value.
            var language = "language_example";  // string | This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)  (default to en)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page. (optional)  (default to 3)

            try
            {
                // List autocompletes
                Autocompletes result = apiInstance.ListAutocompletes(type, term, language, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAutocompletes: " + e.Message);
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
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListCoverages**
> Coverages ListCoverages (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)

List coverages

This endpoint is used for finding story coverages based on the parameters provided. The maximum number of related stories returned is 100.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
using System.Collections.Generic;

namespace Example
{
    public class ListCoveragesExample
    {
        static void Main(string[] args)
        {
            
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stroies by story id. (optional) 
            var title = "title_example";  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = "body_example";  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = "text_example";  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = "publishedAtStart_example";  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = "publishedAtEnd_example";  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = "categoriesTaxonomy_example";  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional) 
            var sentimentTitlePolarity = "sentimentTitlePolarity_example";  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = "sentimentBodyPolarity_example";  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = "authorName_example";  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
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
            var cluster = true;  // bool? | This parameter enables clustering for the returned stories. (optional)  (default to false)
            var clusterAlgorithm = "clusterAlgorithm_example";  // string | This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional)  (default to lingo)
            var _return = new List<string>(); // List<string> | This parameter is used for specifying return fields. (optional) 
            var storyId = 789;  // long? | A story id (optional) 
            var storyUrl = "storyUrl_example";  // string | An article or webpage (optional) 
            var storyTitle = "storyTitle_example";  // string | Title of the article (optional) 
            var storyBody = "storyBody_example";  // string | Body of the article (optional) 
            var storyPublishedAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). (optional) 
            var storyLanguage = storyLanguage_example;  // string | This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)  (default to auto)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page. (optional)  (default to 3)

            try
            {
                // List coverages
                Coverages result = apiInstance.ListCoverages(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, storyPublishedAt, storyLanguage, perPage);
                
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCoverages: " + e.Message);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<long?>**](long?.md)| This parameter is used for finding stroies by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List<string>**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. | [optional] [default to true]
 **categoriesId** | [**List<string>**](string.md)| This parameter is used for finding stories by categories id. | [optional] 
 **categoriesLevel** | [**List<int?>**](int?.md)| This parameter is used for finding stories by categories level. | [optional] 
 **entitiesTitleText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. | [optional] 
 **entitiesTitleType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. | [optional] 
 **entitiesTitleLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. | [optional] 
 **entitiesBodyText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. | [optional] 
 **entitiesBodyType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. | [optional] 
 **entitiesBodyLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List<string>**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List<string>**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. | [optional] [default to lingo]
 **_return** | [**List<string>**](string.md)| This parameter is used for specifying return fields. | [optional] 
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
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListHistograms**
> Histograms ListHistograms (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)

List histograms

This endpoint is used for getting histograms based on the `field` parameter passed to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
using System.Collections.Generic;

namespace Example
{
    public class ListHistogramsExample
    {
        static void Main(string[] args)
        {
            
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stroies by story id. (optional) 
            var title = "title_example";  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = "body_example";  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = "text_example";  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = "publishedAtStart_example";  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = "publishedAtEnd_example";  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = "categoriesTaxonomy_example";  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional) 
            var sentimentTitlePolarity = "sentimentTitlePolarity_example";  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = "sentimentBodyPolarity_example";  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = "authorName_example";  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
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
            var intervalStart = 56;  // int? | This parameter is used for setting the start data point of histogram intervals. (optional) 
            var intervalEnd = 56;  // int? | This parameter is used for setting the end data point of histogram intervals. (optional) 
            var intervalWidth = 56;  // int? | This parameter is used for setting the width of histogram intervals. (optional) 
            var field = "field_example";  // string | This parameter is used for specifying the y-axis variable for the histogram. (optional)  (default to social_shares_count)

            try
            {
                // List histograms
                Histograms result = apiInstance.ListHistograms(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, intervalStart, intervalEnd, intervalWidth, field);
                
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListHistograms: " + e.Message);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<long?>**](long?.md)| This parameter is used for finding stroies by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List<string>**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. | [optional] [default to true]
 **categoriesId** | [**List<string>**](string.md)| This parameter is used for finding stories by categories id. | [optional] 
 **categoriesLevel** | [**List<int?>**](int?.md)| This parameter is used for finding stories by categories level. | [optional] 
 **entitiesTitleText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. | [optional] 
 **entitiesTitleType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. | [optional] 
 **entitiesTitleLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. | [optional] 
 **entitiesBodyText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. | [optional] 
 **entitiesBodyType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. | [optional] 
 **entitiesBodyLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List<string>**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List<string>**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
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
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListRelatedStories**
> RelatedStories ListRelatedStories (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)

List related stories

This endpoint is used for finding related stories based on the parameters provided. The maximum number of related stories returned is 100.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
using System.Collections.Generic;

namespace Example
{
    public class ListRelatedStoriesExample
    {
        static void Main(string[] args)
        {
            
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stroies by story id. (optional) 
            var title = "title_example";  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = "body_example";  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = "text_example";  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = "publishedAtStart_example";  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = "publishedAtEnd_example";  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = "categoriesTaxonomy_example";  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional) 
            var sentimentTitlePolarity = "sentimentTitlePolarity_example";  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = "sentimentBodyPolarity_example";  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = "authorName_example";  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
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
            var cluster = true;  // bool? | This parameter enables clustering for the returned stories. (optional)  (default to false)
            var clusterAlgorithm = "clusterAlgorithm_example";  // string | This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional)  (default to lingo)
            var _return = new List<string>(); // List<string> | This parameter is used for specifying return fields. (optional) 
            var storyId = 789;  // long? | A story id (optional) 
            var storyUrl = "storyUrl_example";  // string | An article or webpage (optional) 
            var storyTitle = "storyTitle_example";  // string | Title of the article (optional) 
            var storyBody = "storyBody_example";  // string | Body of the article (optional) 
            var boostBy = "boostBy_example";  // string | This parameter is used for boosting the result by the specified value. (optional) 
            var storyLanguage = "storyLanguage_example";  // string | This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional)  (default to auto)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page. (optional)  (default to 3)

            try
            {
                // List related stories
                RelatedStories result = apiInstance.ListRelatedStories(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, storyId, storyUrl, storyTitle, storyBody, boostBy, storyLanguage, perPage);
                
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListRelatedStories: " + e.Message);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<long?>**](long?.md)| This parameter is used for finding stroies by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List<string>**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. | [optional] [default to true]
 **categoriesId** | [**List<string>**](string.md)| This parameter is used for finding stories by categories id. | [optional] 
 **categoriesLevel** | [**List<int?>**](int?.md)| This parameter is used for finding stories by categories level. | [optional] 
 **entitiesTitleText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. | [optional] 
 **entitiesTitleType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. | [optional] 
 **entitiesTitleLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. | [optional] 
 **entitiesBodyText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. | [optional] 
 **entitiesBodyType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. | [optional] 
 **entitiesBodyLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List<string>**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List<string>**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. | [optional] [default to lingo]
 **_return** | [**List<string>**](string.md)| This parameter is used for specifying return fields. | [optional] 
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
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListStories**
> Stories ListStories (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)

List Stories

This endpoint is used for getting a list of stories.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
using System.Collections.Generic;

namespace Example
{
    public class ListStoriesExample
    {
        static void Main(string[] args)
        {
            
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stroies by story id. (optional) 
            var title = "title_example";  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = "body_example";  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = "text_example";  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = "publishedAtStart_example";  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = "publishedAtEnd_example";  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = "categoriesTaxonomy_example";  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional) 
            var sentimentTitlePolarity = "sentimentTitlePolarity_example";  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = "sentimentBodyPolarity_example";  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = "authorName_example";  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
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
            var cluster = true;  // bool? | This parameter enables clustering for the returned stories. (optional)  (default to false)
            var clusterAlgorithm = "clusterAlgorithm_example";  // string | This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. (optional)  (default to lingo)
            var _return = new List<string>(); // List<string> | This parameter is used for specifying return fields. (optional) 
            var sortBy = "sortBy_example";  // string | This parameter is used for changing the order column of the results. (optional)  (default to published_at)
            var sortDirection = "sortDirection_example";  // string | This parameter is used for changing the order direction of the result. (optional)  (default to desc)
            var cursor = "cursor_example";  // string | This parameter is used for finding a specific page. (optional)  (default to *)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page. (optional)  (default to 10)

            try
            {
                // List Stories
                Stories result = apiInstance.ListStories(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, cluster, clusterAlgorithm, _return, sortBy, sortDirection, cursor, perPage);
                
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListStories: " + e.Message);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<long?>**](long?.md)| This parameter is used for finding stroies by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List<string>**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. | [optional] [default to true]
 **categoriesId** | [**List<string>**](string.md)| This parameter is used for finding stories by categories id. | [optional] 
 **categoriesLevel** | [**List<int?>**](int?.md)| This parameter is used for finding stories by categories level. | [optional] 
 **entitiesTitleText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. | [optional] 
 **entitiesTitleType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. | [optional] 
 **entitiesTitleLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. | [optional] 
 **entitiesBodyText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. | [optional] 
 **entitiesBodyType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. | [optional] 
 **entitiesBodyLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List<string>**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List<string>**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. | [optional] [default to lingo]
 **_return** | [**List<string>**](string.md)| This parameter is used for specifying return fields. | [optional] 
 **sortBy** | **string**| This parameter is used for changing the order column of the results. | [optional] [default to published_at]
 **sortDirection** | **string**| This parameter is used for changing the order direction of the result. | [optional] [default to desc]
 **cursor** | **string**| This parameter is used for finding a specific page. | [optional] [default to *]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page. | [optional] [default to 10]

### Return type

[**Stories**](Stories.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListTimeSeries**
> TimeSeriesList ListTimeSeries (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)

List time series

This endpoint is used for getting time series by stories.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
using System.Collections.Generic;

namespace Example
{
    public class ListTimeSeriesExample
    {
        static void Main(string[] args)
        {
            
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stroies by story id. (optional) 
            var title = "title_example";  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = "body_example";  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = "text_example";  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var categoriesTaxonomy = "categoriesTaxonomy_example";  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional) 
            var sentimentTitlePolarity = "sentimentTitlePolarity_example";  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = "sentimentBodyPolarity_example";  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = "authorName_example";  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
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
            var publishedAtStart = "publishedAtStart_example";  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)  (default to NOW-7DAYS/DAY)
            var publishedAtEnd = "publishedAtEnd_example";  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional)  (default to NOW/DAY)
            var period = "period_example";  // string | The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are `+` following an integer number greater than 0 and one of the Date Math keywords. e.g. `+1DAY`, `+2MINUTES` and `+1MONTH`. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). (optional)  (default to +1DAY)

            try
            {
                // List time series
                TimeSeriesList result = apiInstance.ListTimeSeries(id, title, body, text, language, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, publishedAtStart, publishedAtEnd, period);
                
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListTimeSeries: " + e.Message);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<long?>**](long?.md)| This parameter is used for finding stroies by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List<string>**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. | [optional] [default to true]
 **categoriesId** | [**List<string>**](string.md)| This parameter is used for finding stories by categories id. | [optional] 
 **categoriesLevel** | [**List<int?>**](int?.md)| This parameter is used for finding stories by categories level. | [optional] 
 **entitiesTitleText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. | [optional] 
 **entitiesTitleType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. | [optional] 
 **entitiesTitleLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. | [optional] 
 **entitiesBodyText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. | [optional] 
 **entitiesBodyType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. | [optional] 
 **entitiesBodyLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List<string>**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List<string>**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] [default to NOW-7DAYS/DAY]
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] [default to NOW/DAY]
 **period** | **string**| The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math). | [optional] [default to +1DAY]

### Return type

[**TimeSeriesList**](TimeSeriesList.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListTrends**
> Trends ListTrends (List<long?> id = null, string title = null, string body = null, string text = null, List<string> language = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<int?> categoriesLevel = null, List<string> entitiesTitleText = null, List<string> entitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> entitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string sentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, string authorName = null, List<int?> sourceId = null, List<string> sourceName = null, List<string> sourceDomain = null, List<string> sourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> sourceScopesState = null, List<string> sourceScopesCity = null, List<string> sourceScopesLevel = null, string field = null)

List trends

This endpoint is used for finding trends based on stories.

### Example
```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
using System.Collections.Generic;

namespace Example
{
    public class ListTrendsExample
    {
        static void Main(string[] args)
        {
            
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            var id = new List<long?>(); // List<long?> | This parameter is used for finding stroies by story id. (optional) 
            var title = "title_example";  // string | This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var body = "body_example";  // string | This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var text = "text_example";  // string | This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). (optional) 
            var language = new List<string>(); // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. (optional) 
            var publishedAtStart = "publishedAtStart_example";  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var publishedAtEnd = "publishedAtEnd_example";  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). (optional) 
            var categoriesTaxonomy = "categoriesTaxonomy_example";  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. (optional) 
            var categoriesLevel = new List<int?>(); // List<int?> | This parameter is used for finding stories by categories level. (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. (optional) 
            var sentimentTitlePolarity = "sentimentTitlePolarity_example";  // string | This parameter is used for finding stories whose title sentiment is the specified value. (optional) 
            var sentimentBodyPolarity = "sentimentBodyPolarity_example";  // string | This parameter is used for finding stories whose body sentiment is the specified value. (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value. (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value. (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value. (optional) 
            var authorId = new List<int?>(); // List<int?> | This parameter is used for finding stories whose author id is the specified value. (optional) 
            var authorName = "authorName_example";  // string | This parameter is used for finding stories whose author full name contains the specified value. (optional) 
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
            var field = "field_example";  // string | This parameter is used to specify the trend field. (optional) 

            try
            {
                // List trends
                Trends result = apiInstance.ListTrends(id, title, body, text, language, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, categoriesLevel, entitiesTitleText, entitiesTitleType, entitiesTitleLinksDbpedia, entitiesBodyText, entitiesBodyType, entitiesBodyLinksDbpedia, sentimentTitlePolarity, sentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaVideosCountMin, mediaVideosCountMax, authorId, authorName, sourceId, sourceName, sourceDomain, sourceLocationsCountry, sourceLocationsState, sourceLocationsCity, sourceScopesCountry, sourceScopesState, sourceScopesCity, sourceScopesLevel, field);
                
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListTrends: " + e.Message);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<long?>**](long?.md)| This parameter is used for finding stroies by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | [**List<string>**](string.md)| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. | [optional] [default to true]
 **categoriesId** | [**List<string>**](string.md)| This parameter is used for finding stories by categories id. | [optional] 
 **categoriesLevel** | [**List<int?>**](int?.md)| This parameter is used for finding stories by categories level. | [optional] 
 **entitiesTitleText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. | [optional] 
 **entitiesTitleType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. | [optional] 
 **entitiesTitleLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. | [optional] 
 **entitiesBodyText** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. | [optional] 
 **entitiesBodyType** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. | [optional] 
 **entitiesBodyLinksDbpedia** | [**List<string>**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | [**List<int?>**](int?.md)| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **sourceName** | [**List<string>**](string.md)| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | [**List<string>**](string.md)| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | [**List<string>**](string.md)| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **field** | **string**| This parameter is used to specify the trend field. | [optional] 

### Return type

[**Trends**](Trends.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

