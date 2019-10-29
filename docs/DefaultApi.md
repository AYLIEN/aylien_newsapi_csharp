# Aylien.NewsApi.Api.DefaultApi

All URIs are relative to *https://api.aylien.com/news*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAutocompletes**](DefaultApi.md#listautocompletes) | **GET** /autocompletes | List autocompletes
[**ListClusters**](DefaultApi.md#listclusters) | **GET** /clusters | List Clusters
[**ListCoverages**](DefaultApi.md#listcoverages) | **GET** /coverages | List coverages
[**ListHistograms**](DefaultApi.md#listhistograms) | **GET** /histograms | List histograms
[**ListRelatedStories**](DefaultApi.md#listrelatedstories) | **GET** /related_stories | List related stories
[**ListStories**](DefaultApi.md#liststories) | **GET** /stories | List Stories
[**ListTimeSeries**](DefaultApi.md#listtimeseries) | **GET** /time_series | List time series
[**ListTrends**](DefaultApi.md#listtrends) | **GET** /trends | List trends



## ListAutocompletes

> Autocompletes ListAutocompletes (string type, string term, string language = null, int? perPage = null)

List autocompletes

The autocompletes endpoint a string of characters provided to it, and then returns suggested terms that are the most likely full words or strings. The terms returned by the News API are based on parameters the type parameters you can see below. For example, if you provide the autocompletes endpoint with the term `New York C` and select the type `dbpedia_resources`, the API will return links to the DBpedia resources `New_York_City`, `New_York_City_Subway`, `New_York_City_Police_Department`, and so on. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListAutocompletesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var type = source_names;  // string | This parameter is used for defining the type of autocompletes. 
            var term = News;  // string | This parameter is used for finding autocomplete objects that contain the specified value. 
            var language = language_example;  // string | This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional)  (default to en)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page.  (optional)  (default to 3)

            try
            {
                // List autocompletes
                Autocompletes result = apiInstance.ListAutocompletes(type, term, language, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAutocompletes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| This parameter is used for defining the type of autocompletes.  | 
 **term** | **string**| This parameter is used for finding autocomplete objects that contain the specified value.  | 
 **language** | **string**| This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] [default to en]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page.  | [optional] [default to 3]

### Return type

[**Autocompletes**](Autocompletes.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of autocompletes |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListClusters

> Clusters ListClusters (List<long> id = null, List<long> notId = null, int? storyCountMin = null, int? storyCountMax = null, string timeStart = null, string timeEnd = null, string earliestStoryStart = null, string earliestStoryEnd = null, string latestStoryStart = null, string latestStoryEnd = null, List<string> locationCountry = null, List<string> notLocationCountry = null)

List Clusters

The clusters endpoint is used to return clusters based on parameters you set in your query. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListClustersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = new List<long>(); // List<long> | This parameter is used for finding clusters by cluster id.  (optional) 
            var notId = new List<long>(); // List<long> | This parameter is used for excluding clusters by cluster id.  (optional) 
            var storyCountMin = 56;  // int? | This parameter is used for finding clusters with more than or equal to a specific amount of stories associated with them.  (optional) 
            var storyCountMax = 56;  // int? | This parameter is used for finding clusters with less than or equal to a specific amount of stories associated with them.  (optional) 
            var timeStart = timeStart_example;  // string | This parameter is used for finding clusters whose creation time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var timeEnd = timeEnd_example;  // string | This parameter is used for finding clusters whose creation time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var earliestStoryStart = earliestStoryStart_example;  // string | This parameter is used for finding clusters whose publication date of its earliest story is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var earliestStoryEnd = earliestStoryEnd_example;  // string | This parameter is used for finding clusters whose publication date of its earliest story is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var latestStoryStart = latestStoryStart_example;  // string | This parameter is used for finding clusters whose publication date of its latest story is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var latestStoryEnd = latestStoryEnd_example;  // string | This parameter is used for finding clusters whose publication date of its latest story is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var locationCountry = new List<string>(); // List<string> | This parameter is used for finding clusters belonging to a specific country. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notLocationCountry = new List<string>(); // List<string> | This parameter is used for excluding clusters belonging to a specific country. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 

            try
            {
                // List Clusters
                Clusters result = apiInstance.ListClusters(id, notId, storyCountMin, storyCountMax, timeStart, timeEnd, earliestStoryStart, earliestStoryEnd, latestStoryStart, latestStoryEnd, locationCountry, notLocationCountry);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListClusters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long&gt;**](long.md)| This parameter is used for finding clusters by cluster id.  | [optional] 
 **notId** | [**List&lt;long&gt;**](long.md)| This parameter is used for excluding clusters by cluster id.  | [optional] 
 **storyCountMin** | **int?**| This parameter is used for finding clusters with more than or equal to a specific amount of stories associated with them.  | [optional] 
 **storyCountMax** | **int?**| This parameter is used for finding clusters with less than or equal to a specific amount of stories associated with them.  | [optional] 
 **timeStart** | **string**| This parameter is used for finding clusters whose creation time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **timeEnd** | **string**| This parameter is used for finding clusters whose creation time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **earliestStoryStart** | **string**| This parameter is used for finding clusters whose publication date of its earliest story is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **earliestStoryEnd** | **string**| This parameter is used for finding clusters whose publication date of its earliest story is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **latestStoryStart** | **string**| This parameter is used for finding clusters whose publication date of its latest story is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **latestStoryEnd** | **string**| This parameter is used for finding clusters whose publication date of its latest story is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **locationCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding clusters belonging to a specific country. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notLocationCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding clusters belonging to a specific country. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 

### Return type

[**Clusters**](Clusters.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of clusters |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCoverages

> Coverages ListCoverages (List<long> id = null, List<long> notId = null, string title = null, string body = null, string text = null, string translationsEnTitle = null, string translationsEnBody = null, string translationsEnText = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int> categoriesLevel = null, List<int> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int> authorId = null, List<int> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int> sourceId = null, List<int> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, List<string> clusters = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)

List coverages

The coverages endpoint allows you to understand the reach a document has had. For example, you can track the coverage of a press release or a Tweet based on how many times it has been mentioned in stories. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListCoveragesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = new List<long>(); // List<long> | This parameter is used for finding stories by story id.  (optional) 
            var notId = new List<long>(); // List<long> | This parameter is used for excluding stories by story id.  (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnTitle = translationsEnTitle_example;  // string | This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnBody = translationsEnBody_example;  // string | This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnText = translationsEnText_example;  // string | This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var language = language_example;  // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var notLanguage = language_example;  // List<string> | This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesId = new List<string>(); // List<string> | This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesLevel = new List<int>(); // List<int> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesLevel = new List<int>(); // List<int> | This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value.  (optional) 
            var notSentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for excluding stories whose title sentiment is the specified value.  (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value.  (optional) 
            var notSentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for excluding stories whose body sentiment is the specified value.  (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value.  (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value.  (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value.  (optional) 
            var mediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for finding stories whose images format are the specified value.  (optional) 
            var notMediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for excluding stories whose images format are the specified value.  (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  (optional) 
            var authorId = new List<int>(); // List<int> | This parameter is used for finding stories whose author id is the specified value.  (optional) 
            var notAuthorId = new List<int>(); // List<int> | This parameter is used for excluding stories whose author id is the specified value.  (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value.  (optional) 
            var notAuthorName = authorName_example;  // string | This parameter is used for excluding stories whose author full name contains the specified value.  (optional) 
            var sourceId = new List<int>(); // List<int> | This parameter is used for finding stories whose source id is the specified value.  (optional) 
            var notSourceId = new List<int>(); // List<int> | This parameter is used for excluding stories whose source id is the specified value.  (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value.  (optional) 
            var notSourceName = new List<string>(); // List<string> | This parameter is used for excluding stories whose source name contains the specified value.  (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value.  (optional) 
            var notSourceDomain = new List<string>(); // List<string> | This parameter is used for excluding stories whose source domain is the specified value.  (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  (optional) 
            var clusters = new List<string>(); // List<string> | This parameter is used for finding stories with belonging to one of clusters in a specific set of clusters You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering).  (optional) 
            var _return = _return_example;  // List<string> | This parameter is used for specifying return fields. (optional) 
            var storyId = 789;  // long? | A story id (optional) 
            var storyUrl = storyUrl_example;  // string | An article or webpage (optional) 
            var storyTitle = storyTitle_example;  // string | Title of the article (optional) 
            var storyBody = storyBody_example;  // string | Body of the article (optional) 
            var storyPublishedAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime).  (optional) 
            var storyLanguage = storyLanguage_example;  // string | This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional)  (default to auto)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page.  (optional)  (default to 3)

            try
            {
                // List coverages
                Coverages result = apiInstance.ListCoverages(id, notId, title, body, text, translationsEnTitle, translationsEnBody, translationsEnText, language, notLanguage, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, notCategoriesId, categoriesLevel, notCategoriesLevel, entitiesTitleText, notEntitiesTitleText, entitiesTitleType, notEntitiesTitleType, entitiesTitleLinksDbpedia, notEntitiesTitleLinksDbpedia, entitiesBodyText, notEntitiesBodyText, entitiesBodyType, notEntitiesBodyType, entitiesBodyLinksDbpedia, notEntitiesBodyLinksDbpedia, sentimentTitlePolarity, notSentimentTitlePolarity, sentimentBodyPolarity, notSentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, notMediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, notAuthorId, authorName, notAuthorName, sourceId, notSourceId, sourceName, notSourceName, sourceDomain, notSourceDomain, sourceLocationsCountry, notSourceLocationsCountry, sourceLocationsState, notSourceLocationsState, sourceLocationsCity, notSourceLocationsCity, sourceScopesCountry, notSourceScopesCountry, sourceScopesState, notSourceScopesState, sourceScopesCity, notSourceScopesCity, sourceScopesLevel, notSourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, clusters, _return, storyId, storyUrl, storyTitle, storyBody, storyPublishedAt, storyLanguage, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCoverages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long&gt;**](long.md)| This parameter is used for finding stories by story id.  | [optional] 
 **notId** | [**List&lt;long&gt;**](long.md)| This parameter is used for excluding stories by story id.  | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnTitle** | **string**| This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnBody** | **string**| This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnText** | **string**| This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value.  | [optional] 
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value.  | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value.  | [optional] 
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value.  | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value.  | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value.  | [optional] 
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value.  | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  | [optional] 
 **authorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose author id is the specified value.  | [optional] 
 **notAuthorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose author id is the specified value.  | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value.  | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value.  | [optional] 
 **sourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose source id is the specified value.  | [optional] 
 **notSourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose source id is the specified value.  | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value.  | [optional] 
 **notSourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source name contains the specified value.  | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value.  | [optional] 
 **notSourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source domain is the specified value.  | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  | [optional] 
 **clusters** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories with belonging to one of clusters in a specific set of clusters You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering).  | [optional] 
 **_return** | **List&lt;string&gt;**| This parameter is used for specifying return fields. | [optional] 
 **storyId** | **long?**| A story id | [optional] 
 **storyUrl** | **string**| An article or webpage | [optional] 
 **storyTitle** | **string**| Title of the article | [optional] 
 **storyBody** | **string**| Body of the article | [optional] 
 **storyPublishedAt** | **DateTime?**| Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime).  | [optional] 
 **storyLanguage** | **string**| This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] [default to auto]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page.  | [optional] [default to 3]

### Return type

[**Coverages**](Coverages.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of coverages |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListHistograms

> Histograms ListHistograms (List<long> id = null, List<long> notId = null, string title = null, string body = null, string text = null, string translationsEnTitle = null, string translationsEnBody = null, string translationsEnText = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int> categoriesLevel = null, List<int> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int> authorId = null, List<int> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int> sourceId = null, List<int> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)

List histograms

For the numerical metadata that the News API gathers (such as word counts or social shares for example), you can use the histograms endpoint to access and display this information. As this endpoint does not return actual stories, the results you are given will not count towards your story allowance provided by your subscription, so you can effectively query this endpoint free of charge. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListHistogramsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = new List<long>(); // List<long> | This parameter is used for finding stories by story id.  (optional) 
            var notId = new List<long>(); // List<long> | This parameter is used for excluding stories by story id.  (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnTitle = translationsEnTitle_example;  // string | This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnBody = translationsEnBody_example;  // string | This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnText = translationsEnText_example;  // string | This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var language = language_example;  // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var notLanguage = language_example;  // List<string> | This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesId = new List<string>(); // List<string> | This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesLevel = new List<int>(); // List<int> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesLevel = new List<int>(); // List<int> | This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value.  (optional) 
            var notSentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for excluding stories whose title sentiment is the specified value.  (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value.  (optional) 
            var notSentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for excluding stories whose body sentiment is the specified value.  (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value.  (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value.  (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value.  (optional) 
            var mediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for finding stories whose images format are the specified value.  (optional) 
            var notMediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for excluding stories whose images format are the specified value.  (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  (optional) 
            var authorId = new List<int>(); // List<int> | This parameter is used for finding stories whose author id is the specified value.  (optional) 
            var notAuthorId = new List<int>(); // List<int> | This parameter is used for excluding stories whose author id is the specified value.  (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value.  (optional) 
            var notAuthorName = authorName_example;  // string | This parameter is used for excluding stories whose author full name contains the specified value.  (optional) 
            var sourceId = new List<int>(); // List<int> | This parameter is used for finding stories whose source id is the specified value.  (optional) 
            var notSourceId = new List<int>(); // List<int> | This parameter is used for excluding stories whose source id is the specified value.  (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value.  (optional) 
            var notSourceName = new List<string>(); // List<string> | This parameter is used for excluding stories whose source name contains the specified value.  (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value.  (optional) 
            var notSourceDomain = new List<string>(); // List<string> | This parameter is used for excluding stories whose source domain is the specified value.  (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  (optional) 
            var intervalStart = 56;  // int? | This parameter is used for setting the start data point of histogram intervals.  (optional) 
            var intervalEnd = 56;  // int? | This parameter is used for setting the end data point of histogram intervals.  (optional) 
            var intervalWidth = 56;  // int? | This parameter is used for setting the width of histogram intervals.  (optional) 
            var field = field_example;  // string | This parameter is used for specifying the y-axis variable for the histogram.  (optional)  (default to social_shares_count)

            try
            {
                // List histograms
                Histograms result = apiInstance.ListHistograms(id, notId, title, body, text, translationsEnTitle, translationsEnBody, translationsEnText, language, notLanguage, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, notCategoriesId, categoriesLevel, notCategoriesLevel, entitiesTitleText, notEntitiesTitleText, entitiesTitleType, notEntitiesTitleType, entitiesTitleLinksDbpedia, notEntitiesTitleLinksDbpedia, entitiesBodyText, notEntitiesBodyText, entitiesBodyType, notEntitiesBodyType, entitiesBodyLinksDbpedia, notEntitiesBodyLinksDbpedia, sentimentTitlePolarity, notSentimentTitlePolarity, sentimentBodyPolarity, notSentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, notMediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, notAuthorId, authorName, notAuthorName, sourceId, notSourceId, sourceName, notSourceName, sourceDomain, notSourceDomain, sourceLocationsCountry, notSourceLocationsCountry, sourceLocationsState, notSourceLocationsState, sourceLocationsCity, notSourceLocationsCity, sourceScopesCountry, notSourceScopesCountry, sourceScopesState, notSourceScopesState, sourceScopesCity, notSourceScopesCity, sourceScopesLevel, notSourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, intervalStart, intervalEnd, intervalWidth, field);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListHistograms: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long&gt;**](long.md)| This parameter is used for finding stories by story id.  | [optional] 
 **notId** | [**List&lt;long&gt;**](long.md)| This parameter is used for excluding stories by story id.  | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnTitle** | **string**| This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnBody** | **string**| This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnText** | **string**| This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value.  | [optional] 
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value.  | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value.  | [optional] 
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value.  | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value.  | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value.  | [optional] 
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value.  | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  | [optional] 
 **authorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose author id is the specified value.  | [optional] 
 **notAuthorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose author id is the specified value.  | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value.  | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value.  | [optional] 
 **sourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose source id is the specified value.  | [optional] 
 **notSourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose source id is the specified value.  | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value.  | [optional] 
 **notSourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source name contains the specified value.  | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value.  | [optional] 
 **notSourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source domain is the specified value.  | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  | [optional] 
 **intervalStart** | **int?**| This parameter is used for setting the start data point of histogram intervals.  | [optional] 
 **intervalEnd** | **int?**| This parameter is used for setting the end data point of histogram intervals.  | [optional] 
 **intervalWidth** | **int?**| This parameter is used for setting the width of histogram intervals.  | [optional] 
 **field** | **string**| This parameter is used for specifying the y-axis variable for the histogram.  | [optional] [default to social_shares_count]

### Return type

[**Histograms**](Histograms.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of the histogram intervals |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListRelatedStories

> RelatedStories ListRelatedStories (List<long> id = null, List<long> notId = null, string title = null, string body = null, string text = null, string translationsEnTitle = null, string translationsEnBody = null, string translationsEnText = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int> categoriesLevel = null, List<int> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int> authorId = null, List<int> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int> sourceId = null, List<int> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, List<string> clusters = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)

List related stories

This endpoint is used for finding semantically similar stories based on the parameters you provide as inputs. For example, if you want to find stories similar to a Tweet or any text extract you input, the related stories endpoint will analyze the entities present and the meaning of the text, and find stories with a similar meaning. The maximum number of related stories returned is 100. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListRelatedStoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = new List<long>(); // List<long> | This parameter is used for finding stories by story id.  (optional) 
            var notId = new List<long>(); // List<long> | This parameter is used for excluding stories by story id.  (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnTitle = translationsEnTitle_example;  // string | This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnBody = translationsEnBody_example;  // string | This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnText = translationsEnText_example;  // string | This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var language = language_example;  // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var notLanguage = language_example;  // List<string> | This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesId = new List<string>(); // List<string> | This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesLevel = new List<int>(); // List<int> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesLevel = new List<int>(); // List<int> | This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value.  (optional) 
            var notSentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for excluding stories whose title sentiment is the specified value.  (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value.  (optional) 
            var notSentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for excluding stories whose body sentiment is the specified value.  (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value.  (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value.  (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value.  (optional) 
            var mediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for finding stories whose images format are the specified value.  (optional) 
            var notMediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for excluding stories whose images format are the specified value.  (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  (optional) 
            var authorId = new List<int>(); // List<int> | This parameter is used for finding stories whose author id is the specified value.  (optional) 
            var notAuthorId = new List<int>(); // List<int> | This parameter is used for excluding stories whose author id is the specified value.  (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value.  (optional) 
            var notAuthorName = authorName_example;  // string | This parameter is used for excluding stories whose author full name contains the specified value.  (optional) 
            var sourceId = new List<int>(); // List<int> | This parameter is used for finding stories whose source id is the specified value.  (optional) 
            var notSourceId = new List<int>(); // List<int> | This parameter is used for excluding stories whose source id is the specified value.  (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value.  (optional) 
            var notSourceName = new List<string>(); // List<string> | This parameter is used for excluding stories whose source name contains the specified value.  (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value.  (optional) 
            var notSourceDomain = new List<string>(); // List<string> | This parameter is used for excluding stories whose source domain is the specified value.  (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  (optional) 
            var clusters = new List<string>(); // List<string> | This parameter is used for finding stories with belonging to one of clusters in a specific set of clusters You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering).  (optional) 
            var _return = _return_example;  // List<string> | This parameter is used for specifying return fields. (optional) 
            var storyId = 789;  // long? | A story id (optional) 
            var storyUrl = storyUrl_example;  // string | An article or webpage (optional) 
            var storyTitle = storyTitle_example;  // string | Title of the article (optional) 
            var storyBody = storyBody_example;  // string | Body of the article (optional) 
            var boostBy = boostBy_example;  // string | This parameter is used for boosting the result by the specified value.  (optional) 
            var storyLanguage = storyLanguage_example;  // string | This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional)  (default to auto)
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page.  (optional)  (default to 3)

            try
            {
                // List related stories
                RelatedStories result = apiInstance.ListRelatedStories(id, notId, title, body, text, translationsEnTitle, translationsEnBody, translationsEnText, language, notLanguage, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, notCategoriesId, categoriesLevel, notCategoriesLevel, entitiesTitleText, notEntitiesTitleText, entitiesTitleType, notEntitiesTitleType, entitiesTitleLinksDbpedia, notEntitiesTitleLinksDbpedia, entitiesBodyText, notEntitiesBodyText, entitiesBodyType, notEntitiesBodyType, entitiesBodyLinksDbpedia, notEntitiesBodyLinksDbpedia, sentimentTitlePolarity, notSentimentTitlePolarity, sentimentBodyPolarity, notSentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, notMediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, notAuthorId, authorName, notAuthorName, sourceId, notSourceId, sourceName, notSourceName, sourceDomain, notSourceDomain, sourceLocationsCountry, notSourceLocationsCountry, sourceLocationsState, notSourceLocationsState, sourceLocationsCity, notSourceLocationsCity, sourceScopesCountry, notSourceScopesCountry, sourceScopesState, notSourceScopesState, sourceScopesCity, notSourceScopesCity, sourceScopesLevel, notSourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, clusters, _return, storyId, storyUrl, storyTitle, storyBody, boostBy, storyLanguage, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListRelatedStories: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long&gt;**](long.md)| This parameter is used for finding stories by story id.  | [optional] 
 **notId** | [**List&lt;long&gt;**](long.md)| This parameter is used for excluding stories by story id.  | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnTitle** | **string**| This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnBody** | **string**| This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnText** | **string**| This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value.  | [optional] 
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value.  | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value.  | [optional] 
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value.  | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value.  | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value.  | [optional] 
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value.  | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  | [optional] 
 **authorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose author id is the specified value.  | [optional] 
 **notAuthorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose author id is the specified value.  | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value.  | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value.  | [optional] 
 **sourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose source id is the specified value.  | [optional] 
 **notSourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose source id is the specified value.  | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value.  | [optional] 
 **notSourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source name contains the specified value.  | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value.  | [optional] 
 **notSourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source domain is the specified value.  | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  | [optional] 
 **clusters** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories with belonging to one of clusters in a specific set of clusters You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering).  | [optional] 
 **_return** | **List&lt;string&gt;**| This parameter is used for specifying return fields. | [optional] 
 **storyId** | **long?**| A story id | [optional] 
 **storyUrl** | **string**| An article or webpage | [optional] 
 **storyTitle** | **string**| Title of the article | [optional] 
 **storyBody** | **string**| Body of the article | [optional] 
 **boostBy** | **string**| This parameter is used for boosting the result by the specified value.  | [optional] 
 **storyLanguage** | **string**| This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] [default to auto]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page.  | [optional] [default to 3]

### Return type

[**RelatedStories**](RelatedStories.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of related stories |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListStories

> Stories ListStories (List<long> id = null, List<long> notId = null, string title = null, string body = null, string text = null, string translationsEnTitle = null, string translationsEnBody = null, string translationsEnText = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int> categoriesLevel = null, List<int> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int> authorId = null, List<int> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int> sourceId = null, List<int> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, List<string> clusters = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)

List Stories

The stories endpoint is used to return stories based on parameters you set in your query. The News API crawler gathers articles in near real-time and stores information about them, or metadata. Below you can see all of the query parameters, which you can use to narrow down your query. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListStoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = new List<long>(); // List<long> | This parameter is used for finding stories by story id.  (optional) 
            var notId = new List<long>(); // List<long> | This parameter is used for excluding stories by story id.  (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnTitle = translationsEnTitle_example;  // string | This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnBody = translationsEnBody_example;  // string | This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnText = translationsEnText_example;  // string | This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var language = language_example;  // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var notLanguage = language_example;  // List<string> | This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesId = new List<string>(); // List<string> | This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesLevel = new List<int>(); // List<int> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesLevel = new List<int>(); // List<int> | This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value.  (optional) 
            var notSentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for excluding stories whose title sentiment is the specified value.  (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value.  (optional) 
            var notSentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for excluding stories whose body sentiment is the specified value.  (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value.  (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value.  (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value.  (optional) 
            var mediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for finding stories whose images format are the specified value.  (optional) 
            var notMediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for excluding stories whose images format are the specified value.  (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  (optional) 
            var authorId = new List<int>(); // List<int> | This parameter is used for finding stories whose author id is the specified value.  (optional) 
            var notAuthorId = new List<int>(); // List<int> | This parameter is used for excluding stories whose author id is the specified value.  (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value.  (optional) 
            var notAuthorName = authorName_example;  // string | This parameter is used for excluding stories whose author full name contains the specified value.  (optional) 
            var sourceId = new List<int>(); // List<int> | This parameter is used for finding stories whose source id is the specified value.  (optional) 
            var notSourceId = new List<int>(); // List<int> | This parameter is used for excluding stories whose source id is the specified value.  (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value.  (optional) 
            var notSourceName = new List<string>(); // List<string> | This parameter is used for excluding stories whose source name contains the specified value.  (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value.  (optional) 
            var notSourceDomain = new List<string>(); // List<string> | This parameter is used for excluding stories whose source domain is the specified value.  (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  (optional) 
            var clusters = new List<string>(); // List<string> | This parameter is used for finding stories with belonging to one of clusters in a specific set of clusters You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering).  (optional) 
            var _return = _return_example;  // List<string> | This parameter is used for specifying return fields. (optional) 
            var sortBy = sortBy_example;  // string | This parameter is used for changing the order column of the results. You can read about sorting results [here](https://newsapi.aylien.com/docs/sorting-results).  (optional)  (default to published_at)
            var sortDirection = sortDirection_example;  // string | This parameter is used for changing the order direction of the result. You can read about sorting results [here](https://newsapi.aylien.com/docs/sorting-results).  (optional)  (default to desc)
            var cursor = cursor_example;  // string | This parameter is used for finding a specific page. You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results).  (optional)  (default to "*")
            var perPage = 56;  // int? | This parameter is used for specifying number of items in each page You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results)  (optional)  (default to 10)

            try
            {
                // List Stories
                Stories result = apiInstance.ListStories(id, notId, title, body, text, translationsEnTitle, translationsEnBody, translationsEnText, language, notLanguage, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, notCategoriesId, categoriesLevel, notCategoriesLevel, entitiesTitleText, notEntitiesTitleText, entitiesTitleType, notEntitiesTitleType, entitiesTitleLinksDbpedia, notEntitiesTitleLinksDbpedia, entitiesBodyText, notEntitiesBodyText, entitiesBodyType, notEntitiesBodyType, entitiesBodyLinksDbpedia, notEntitiesBodyLinksDbpedia, sentimentTitlePolarity, notSentimentTitlePolarity, sentimentBodyPolarity, notSentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, notMediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, notAuthorId, authorName, notAuthorName, sourceId, notSourceId, sourceName, notSourceName, sourceDomain, notSourceDomain, sourceLocationsCountry, notSourceLocationsCountry, sourceLocationsState, notSourceLocationsState, sourceLocationsCity, notSourceLocationsCity, sourceScopesCountry, notSourceScopesCountry, sourceScopesState, notSourceScopesState, sourceScopesCity, notSourceScopesCity, sourceScopesLevel, notSourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, clusters, _return, sortBy, sortDirection, cursor, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListStories: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long&gt;**](long.md)| This parameter is used for finding stories by story id.  | [optional] 
 **notId** | [**List&lt;long&gt;**](long.md)| This parameter is used for excluding stories by story id.  | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnTitle** | **string**| This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnBody** | **string**| This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnText** | **string**| This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value.  | [optional] 
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value.  | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value.  | [optional] 
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value.  | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value.  | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value.  | [optional] 
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value.  | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  | [optional] 
 **authorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose author id is the specified value.  | [optional] 
 **notAuthorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose author id is the specified value.  | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value.  | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value.  | [optional] 
 **sourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose source id is the specified value.  | [optional] 
 **notSourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose source id is the specified value.  | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value.  | [optional] 
 **notSourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source name contains the specified value.  | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value.  | [optional] 
 **notSourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source domain is the specified value.  | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  | [optional] 
 **clusters** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories with belonging to one of clusters in a specific set of clusters You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering).  | [optional] 
 **_return** | **List&lt;string&gt;**| This parameter is used for specifying return fields. | [optional] 
 **sortBy** | **string**| This parameter is used for changing the order column of the results. You can read about sorting results [here](https://newsapi.aylien.com/docs/sorting-results).  | [optional] [default to published_at]
 **sortDirection** | **string**| This parameter is used for changing the order direction of the result. You can read about sorting results [here](https://newsapi.aylien.com/docs/sorting-results).  | [optional] [default to desc]
 **cursor** | **string**| This parameter is used for finding a specific page. You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results).  | [optional] [default to &quot;*&quot;]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results)  | [optional] [default to 10]

### Return type

[**Stories**](Stories.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of stories |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListTimeSeries

> TimeSeriesList ListTimeSeries (List<long> id = null, List<long> notId = null, string title = null, string body = null, string text = null, string translationsEnTitle = null, string translationsEnBody = null, string translationsEnText = null, List<string> language = null, List<string> notLanguage = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int> categoriesLevel = null, List<int> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int> authorId = null, List<int> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int> sourceId = null, List<int> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)

List time series

The time series endpoint allows you to track information contained in stories over time. This information can be anything from mentions of a topic or entities, sentiment about a topic, or the volume of stories published by a source, to name but a few. The full list of parameters is given below. Using the [Date Math Syntax](https://newsapi.aylien.com/docs/working-with-dates), you can easily set your query to return information from any time period, from the current point in time to when the News API started collecting stories. The returned information can be rounded to a time also specified by you, for example by setting the results into hourly, daily, or weekly data points. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListTimeSeriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = new List<long>(); // List<long> | This parameter is used for finding stories by story id.  (optional) 
            var notId = new List<long>(); // List<long> | This parameter is used for excluding stories by story id.  (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnTitle = translationsEnTitle_example;  // string | This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnBody = translationsEnBody_example;  // string | This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnText = translationsEnText_example;  // string | This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var language = language_example;  // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var notLanguage = language_example;  // List<string> | This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesId = new List<string>(); // List<string> | This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesLevel = new List<int>(); // List<int> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesLevel = new List<int>(); // List<int> | This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value.  (optional) 
            var notSentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for excluding stories whose title sentiment is the specified value.  (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value.  (optional) 
            var notSentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for excluding stories whose body sentiment is the specified value.  (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value.  (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value.  (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value.  (optional) 
            var mediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for finding stories whose images format are the specified value.  (optional) 
            var notMediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for excluding stories whose images format are the specified value.  (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  (optional) 
            var authorId = new List<int>(); // List<int> | This parameter is used for finding stories whose author id is the specified value.  (optional) 
            var notAuthorId = new List<int>(); // List<int> | This parameter is used for excluding stories whose author id is the specified value.  (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value.  (optional) 
            var notAuthorName = authorName_example;  // string | This parameter is used for excluding stories whose author full name contains the specified value.  (optional) 
            var sourceId = new List<int>(); // List<int> | This parameter is used for finding stories whose source id is the specified value.  (optional) 
            var notSourceId = new List<int>(); // List<int> | This parameter is used for excluding stories whose source id is the specified value.  (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value.  (optional) 
            var notSourceName = new List<string>(); // List<string> | This parameter is used for excluding stories whose source name contains the specified value.  (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value.  (optional) 
            var notSourceDomain = new List<string>(); // List<string> | This parameter is used for excluding stories whose source domain is the specified value.  (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional)  (default to "NOW-7DAYS/DAY")
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional)  (default to "NOW/DAY")
            var period = period_example;  // string | The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are `+` following an integer number greater than 0 and one of the Date Math keywords. e.g. `+1DAY`, `+2MINUTES` and `+1MONTH`. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math).  (optional)  (default to "+1DAY")

            try
            {
                // List time series
                TimeSeriesList result = apiInstance.ListTimeSeries(id, notId, title, body, text, translationsEnTitle, translationsEnBody, translationsEnText, language, notLanguage, categoriesTaxonomy, categoriesConfident, categoriesId, notCategoriesId, categoriesLevel, notCategoriesLevel, entitiesTitleText, notEntitiesTitleText, entitiesTitleType, notEntitiesTitleType, entitiesTitleLinksDbpedia, notEntitiesTitleLinksDbpedia, entitiesBodyText, notEntitiesBodyText, entitiesBodyType, notEntitiesBodyType, entitiesBodyLinksDbpedia, notEntitiesBodyLinksDbpedia, sentimentTitlePolarity, notSentimentTitlePolarity, sentimentBodyPolarity, notSentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, notMediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, notAuthorId, authorName, notAuthorName, sourceId, notSourceId, sourceName, notSourceName, sourceDomain, notSourceDomain, sourceLocationsCountry, notSourceLocationsCountry, sourceLocationsState, notSourceLocationsState, sourceLocationsCity, notSourceLocationsCity, sourceScopesCountry, notSourceScopesCountry, sourceScopesState, notSourceScopesState, sourceScopesCity, notSourceScopesCity, sourceScopesLevel, notSourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax, publishedAtStart, publishedAtEnd, period);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListTimeSeries: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List&lt;long&gt;**](long.md)| This parameter is used for finding stories by story id.  | [optional] 
 **notId** | [**List&lt;long&gt;**](long.md)| This parameter is used for excluding stories by story id.  | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnTitle** | **string**| This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnBody** | **string**| This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnText** | **string**| This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value.  | [optional] 
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value.  | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value.  | [optional] 
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value.  | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value.  | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value.  | [optional] 
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value.  | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  | [optional] 
 **authorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose author id is the specified value.  | [optional] 
 **notAuthorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose author id is the specified value.  | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value.  | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value.  | [optional] 
 **sourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose source id is the specified value.  | [optional] 
 **notSourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose source id is the specified value.  | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value.  | [optional] 
 **notSourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source name contains the specified value.  | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value.  | [optional] 
 **notSourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source domain is the specified value.  | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] [default to &quot;NOW-7DAYS/DAY&quot;]
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] [default to &quot;NOW/DAY&quot;]
 **period** | **string**| The size of each date range is expressed as an interval to be added to the lower bound. It supports Date Math Syntax. Valid options are &#x60;+&#x60; following an integer number greater than 0 and one of the Date Math keywords. e.g. &#x60;+1DAY&#x60;, &#x60;+2MINUTES&#x60; and &#x60;+1MONTH&#x60;. Here are [Supported keywords](https://newsapi.aylien.com/docs/working-with-dates#date-math).  | [optional] [default to &quot;+1DAY&quot;]

### Return type

[**TimeSeriesList**](TimeSeriesList.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of time series |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListTrends

> Trends ListTrends (string field, List<long> id = null, List<long> notId = null, string title = null, string body = null, string text = null, string translationsEnTitle = null, string translationsEnBody = null, string translationsEnText = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int> categoriesLevel = null, List<int> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int> authorId = null, List<int> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int> sourceId = null, List<int> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null)

List trends

The trends endpoint allows you to identify the most-mentioned entities, concepts and keywords relevant to your query. For example, this endpoint allows you to set parameters like a time period, a subject category, or an entity, and your request will return the most mentioned entities or keywords that are mentioned in relation to your query. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;

namespace Example
{
    public class ListTrendsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.aylien.com/news";
            // Configure API key authorization: app_id
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-ID", "Bearer");
            // Configure API key authorization: app_key
            Configuration.Default.AddApiKey("X-AYLIEN-NewsAPI-Application-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-AYLIEN-NewsAPI-Application-Key", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var field = keywords;  // string | This parameter is used to specify the trend field. 
            var id = new List<long>(); // List<long> | This parameter is used for finding stories by story id.  (optional) 
            var notId = new List<long>(); // List<long> | This parameter is used for excluding stories by story id.  (optional) 
            var title = title_example;  // string | This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var body = body_example;  // string | This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var text = text_example;  // string | This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnTitle = translationsEnTitle_example;  // string | This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnBody = translationsEnBody_example;  // string | This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var translationsEnText = translationsEnText_example;  // string | This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  (optional) 
            var language = language_example;  // List<string> | This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var notLanguage = language_example;  // List<string> | This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  (optional) 
            var publishedAtStart = publishedAtStart_example;  // string | This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var publishedAtEnd = publishedAtEnd_example;  // string | This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  (optional) 
            var categoriesTaxonomy = categoriesTaxonomy_example;  // string | This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesConfident = true;  // bool? | This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional)  (default to true)
            var categoriesId = new List<string>(); // List<string> | This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesId = new List<string>(); // List<string> | This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var categoriesLevel = new List<int>(); // List<int> | This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var notCategoriesLevel = new List<int>(); // List<int> | This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  (optional) 
            var entitiesTitleText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesTitleLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyText = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyText = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `text` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyType = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyType = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities `type` in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var entitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var notEntitiesBodyLinksDbpedia = new List<string>(); // List<string> | This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  (optional) 
            var sentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for finding stories whose title sentiment is the specified value.  (optional) 
            var notSentimentTitlePolarity = sentimentTitlePolarity_example;  // string | This parameter is used for excluding stories whose title sentiment is the specified value.  (optional) 
            var sentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for finding stories whose body sentiment is the specified value.  (optional) 
            var notSentimentBodyPolarity = sentimentBodyPolarity_example;  // string | This parameter is used for excluding stories whose body sentiment is the specified value.  (optional) 
            var mediaImagesCountMin = 56;  // int? | This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  (optional) 
            var mediaImagesCountMax = 56;  // int? | This parameter is used for finding stories whose number of images is less than or equal to the specified value.  (optional) 
            var mediaImagesWidthMin = 56;  // int? | This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesWidthMax = 56;  // int? | This parameter is used for finding stories whose width of images are less than or equal to the specified value.  (optional) 
            var mediaImagesHeightMin = 56;  // int? | This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  (optional) 
            var mediaImagesHeightMax = 56;  // int? | This parameter is used for finding stories whose height of images are less than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMin = 56;  // int? | This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  (optional) 
            var mediaImagesContentLengthMax = 56;  // int? | This parameter is used for finding stories whose images content length are less than or equal to the specified value.  (optional) 
            var mediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for finding stories whose images format are the specified value.  (optional) 
            var notMediaImagesFormat = mediaImagesFormat_example;  // List<string> | This parameter is used for excluding stories whose images format are the specified value.  (optional) 
            var mediaVideosCountMin = 56;  // int? | This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  (optional) 
            var mediaVideosCountMax = 56;  // int? | This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  (optional) 
            var authorId = new List<int>(); // List<int> | This parameter is used for finding stories whose author id is the specified value.  (optional) 
            var notAuthorId = new List<int>(); // List<int> | This parameter is used for excluding stories whose author id is the specified value.  (optional) 
            var authorName = authorName_example;  // string | This parameter is used for finding stories whose author full name contains the specified value.  (optional) 
            var notAuthorName = authorName_example;  // string | This parameter is used for excluding stories whose author full name contains the specified value.  (optional) 
            var sourceId = new List<int>(); // List<int> | This parameter is used for finding stories whose source id is the specified value.  (optional) 
            var notSourceId = new List<int>(); // List<int> | This parameter is used for excluding stories whose source id is the specified value.  (optional) 
            var sourceName = new List<string>(); // List<string> | This parameter is used for finding stories whose source name contains the specified value.  (optional) 
            var notSourceName = new List<string>(); // List<string> | This parameter is used for excluding stories whose source name contains the specified value.  (optional) 
            var sourceDomain = new List<string>(); // List<string> | This parameter is used for finding stories whose source domain is the specified value.  (optional) 
            var notSourceDomain = new List<string>(); // List<string> | This parameter is used for excluding stories whose source domain is the specified value.  (optional) 
            var sourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsState = new List<string>(); // List<string> | This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLocationsCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceLocationsCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCountry = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCountry = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesState = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesState = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesCity = new List<string>(); // List<string> | This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesCity = new List<string>(); // List<string> | This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var notSourceScopesLevel = sourceScopesLevel_example;  // List<string> | This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  (optional) 
            var sourceLinksInCountMin = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceLinksInCountMax = 56;  // int? | This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  (optional) 
            var sourceRankingsAlexaRankMin = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaRankMax = 56;  // int? | This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var sourceRankingsAlexaCountry = new List<string>(); // List<string> | This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  (optional) 
            var socialSharesCountFacebookMin = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountFacebookMax = 56;  // int? | This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMin = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountGooglePlusMax = 56;  // int? | This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMin = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountLinkedinMax = 56;  // int? | This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMin = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  (optional) 
            var socialSharesCountRedditMax = 56;  // int? | This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  (optional) 

            try
            {
                // List trends
                Trends result = apiInstance.ListTrends(field, id, notId, title, body, text, translationsEnTitle, translationsEnBody, translationsEnText, language, notLanguage, publishedAtStart, publishedAtEnd, categoriesTaxonomy, categoriesConfident, categoriesId, notCategoriesId, categoriesLevel, notCategoriesLevel, entitiesTitleText, notEntitiesTitleText, entitiesTitleType, notEntitiesTitleType, entitiesTitleLinksDbpedia, notEntitiesTitleLinksDbpedia, entitiesBodyText, notEntitiesBodyText, entitiesBodyType, notEntitiesBodyType, entitiesBodyLinksDbpedia, notEntitiesBodyLinksDbpedia, sentimentTitlePolarity, notSentimentTitlePolarity, sentimentBodyPolarity, notSentimentBodyPolarity, mediaImagesCountMin, mediaImagesCountMax, mediaImagesWidthMin, mediaImagesWidthMax, mediaImagesHeightMin, mediaImagesHeightMax, mediaImagesContentLengthMin, mediaImagesContentLengthMax, mediaImagesFormat, notMediaImagesFormat, mediaVideosCountMin, mediaVideosCountMax, authorId, notAuthorId, authorName, notAuthorName, sourceId, notSourceId, sourceName, notSourceName, sourceDomain, notSourceDomain, sourceLocationsCountry, notSourceLocationsCountry, sourceLocationsState, notSourceLocationsState, sourceLocationsCity, notSourceLocationsCity, sourceScopesCountry, notSourceScopesCountry, sourceScopesState, notSourceScopesState, sourceScopesCity, notSourceScopesCity, sourceScopesLevel, notSourceScopesLevel, sourceLinksInCountMin, sourceLinksInCountMax, sourceRankingsAlexaRankMin, sourceRankingsAlexaRankMax, sourceRankingsAlexaCountry, socialSharesCountFacebookMin, socialSharesCountFacebookMax, socialSharesCountGooglePlusMin, socialSharesCountGooglePlusMax, socialSharesCountLinkedinMin, socialSharesCountLinkedinMax, socialSharesCountRedditMin, socialSharesCountRedditMax);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListTrends: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **field** | **string**| This parameter is used to specify the trend field.  | 
 **id** | [**List&lt;long&gt;**](long.md)| This parameter is used for finding stories by story id.  | [optional] 
 **notId** | [**List&lt;long&gt;**](long.md)| This parameter is used for excluding stories by story id.  | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnTitle** | **string**| This parameter is used for finding stories whose translation title contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnBody** | **string**| This parameter is used for finding stories whose translation body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **translationsEnText** | **string**| This parameter is used for finding stories whose translation title or body contains a specific keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators).  | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes.  | [optional] 
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates).  | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] [default to true]
 **categoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesId** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **categoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **notCategoriesLevel** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories).  | [optional] 
 **entitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesTitleLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyText** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyType** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **entitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **notEntitiesBodyLinksDbpedia** | [**List&lt;string&gt;**](string.md)| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities).  | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value.  | [optional] 
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value.  | [optional] 
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value.  | [optional] 
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value.  | [optional] 
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value.  | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value.  | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value.  | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value.  | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value.  | [optional] 
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value.  | [optional] 
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value.  | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value.  | [optional] 
 **authorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose author id is the specified value.  | [optional] 
 **notAuthorId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose author id is the specified value.  | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value.  | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value.  | [optional] 
 **sourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for finding stories whose source id is the specified value.  | [optional] 
 **notSourceId** | [**List&lt;int&gt;**](int.md)| This parameter is used for excluding stories whose source id is the specified value.  | [optional] 
 **sourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source name contains the specified value.  | [optional] 
 **notSourceName** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source name contains the specified value.  | [optional] 
 **sourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source domain is the specified value.  | [optional] 
 **notSourceDomain** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source domain is the specified value.  | [optional] 
 **sourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceLocationsCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesState** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesCity** | [**List&lt;string&gt;**](string.md)| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations).  | [optional] 
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count).  | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **sourceRankingsAlexaCountry** | [**List&lt;string&gt;**](string.md)| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks).  | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value.  | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value.  | [optional] 

### Return type

[**Trends**](Trends.md)

### Authorization

[app_id](../README.md#app_id), [app_key](../README.md#app_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object including an array of trends |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **492** | Too Many Requests |  * X-RateLimit-Limit - The number of allowed requests in the current period. <br>  * X-RateLimit-Remaining - The number of remaining requests in the current period. <br>  * X-RateLimit-Reset - The remaining window before the rate limit resets in UTC [epoch seconds](https://en.wikipedia.org/wiki/Unix_time).  <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

