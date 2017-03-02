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
        static void Main(string[] args)
        {
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();

            var type = type_example;
            var term = term_example;
            var language = language_example;
            var perPage = 56;

            try
            {
                // List autocompletes
                Autocompletes result = apiInstance.ListAutocompletes(
                    type: type,
                    term: term,
                    language: language,
                    perPage: perPage
                );
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
 **type** | **string**| This parameter is used for defining the type of autocompletes. |  [enum: source_names, source_domains, entity_types, dbpedia_resources]
 **term** | **string**| This parameter is used for finding autocomplete objects that contain the specified value. | 
 **language** | **string**| This parameter is used for autocompletes whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] [default to en] [enum: en, de, fr, it, es, pt]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page. | [optional] [default to 3]

### Return type

[**Autocompletes**](Autocompletes.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcoverages"></a>
# **ListCoverages**
> Coverages ListCoverages (List<long?> id = null, List<long?> notId = null, string title = null, string body = null, string text = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int?> categoriesLevel = null, List<int?> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, List<int?> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int?> sourceId = null, List<int?> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, DateTime? storyPublishedAt = null, string storyLanguage = null, int? perPage = null)

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
        static void Main(string[] args)
        {
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();

            var id = new List<long?>();
            var notId = new List<long?>();
            var title = title_example;
            var body = body_example;
            var text = text_example;
            var language = new List<string>();
            var notLanguage = new List<string>();
            var publishedAtStart = publishedAtStart_example;
            var publishedAtEnd = publishedAtEnd_example;
            var categoriesTaxonomy = categoriesTaxonomy_example;
            var categoriesConfident = true;
            var categoriesId = new List<string>();
            var notCategoriesId = new List<string>();
            var categoriesLevel = new List<int?>();
            var notCategoriesLevel = new List<int?>();
            var entitiesTitleText = new List<string>();
            var notEntitiesTitleText = new List<string>();
            var entitiesTitleType = new List<string>();
            var notEntitiesTitleType = new List<string>();
            var entitiesTitleLinksDbpedia = new List<string>();
            var notEntitiesTitleLinksDbpedia = new List<string>();
            var entitiesBodyText = new List<string>();
            var notEntitiesBodyText = new List<string>();
            var entitiesBodyType = new List<string>();
            var notEntitiesBodyType = new List<string>();
            var entitiesBodyLinksDbpedia = new List<string>();
            var notEntitiesBodyLinksDbpedia = new List<string>();
            var sentimentTitlePolarity = sentimentTitlePolarity_example;
            var notSentimentTitlePolarity = notSentimentTitlePolarity_example;
            var sentimentBodyPolarity = sentimentBodyPolarity_example;
            var notSentimentBodyPolarity = notSentimentBodyPolarity_example;
            var mediaImagesCountMin = 56;
            var mediaImagesCountMax = 56;
            var mediaImagesWidthMin = 56;
            var mediaImagesWidthMax = 56;
            var mediaImagesHeightMin = 56;
            var mediaImagesHeightMax = 56;
            var mediaImagesContentLengthMin = 56;
            var mediaImagesContentLengthMax = 56;
            var mediaImagesFormat = new List<string>();
            var notMediaImagesFormat = new List<string>();
            var mediaVideosCountMin = 56;
            var mediaVideosCountMax = 56;
            var authorId = new List<int?>();
            var notAuthorId = new List<int?>();
            var authorName = authorName_example;
            var notAuthorName = notAuthorName_example;
            var sourceId = new List<int?>();
            var notSourceId = new List<int?>();
            var sourceName = new List<string>();
            var notSourceName = new List<string>();
            var sourceDomain = new List<string>();
            var notSourceDomain = new List<string>();
            var sourceLocationsCountry = new List<string>();
            var notSourceLocationsCountry = new List<string>();
            var sourceLocationsState = new List<string>();
            var notSourceLocationsState = new List<string>();
            var sourceLocationsCity = new List<string>();
            var notSourceLocationsCity = new List<string>();
            var sourceScopesCountry = new List<string>();
            var notSourceScopesCountry = new List<string>();
            var sourceScopesState = new List<string>();
            var notSourceScopesState = new List<string>();
            var sourceScopesCity = new List<string>();
            var notSourceScopesCity = new List<string>();
            var sourceScopesLevel = new List<string>();
            var notSourceScopesLevel = new List<string>();
            var sourceLinksInCountMin = 56;
            var sourceLinksInCountMax = 56;
            var sourceRankingsAlexaRankMin = 56;
            var sourceRankingsAlexaRankMax = 56;
            var sourceRankingsAlexaCountry = new List<string>();
            var socialSharesCountFacebookMin = 56;
            var socialSharesCountFacebookMax = 56;
            var socialSharesCountGooglePlusMin = 56;
            var socialSharesCountGooglePlusMax = 56;
            var socialSharesCountLinkedinMin = 56;
            var socialSharesCountLinkedinMax = 56;
            var socialSharesCountRedditMin = 56;
            var socialSharesCountRedditMax = 56;
            var cluster = true;
            var clusterAlgorithm = clusterAlgorithm_example;
            var _return = new List<string>();
            var storyId = 789;
            var storyUrl = storyUrl_example;
            var storyTitle = storyTitle_example;
            var storyBody = storyBody_example;
            var storyPublishedAt = 2013-10-20T19:20:30+01:00;
            var storyLanguage = storyLanguage_example;
            var perPage = 56;

            try
            {
                // List coverages
                Coverages result = apiInstance.ListCoverages(
                    id: id,
                    notId: notId,
                    title: title,
                    body: body,
                    text: text,
                    language: language,
                    notLanguage: notLanguage,
                    publishedAtStart: publishedAtStart,
                    publishedAtEnd: publishedAtEnd,
                    categoriesTaxonomy: categoriesTaxonomy,
                    categoriesConfident: categoriesConfident,
                    categoriesId: categoriesId,
                    notCategoriesId: notCategoriesId,
                    categoriesLevel: categoriesLevel,
                    notCategoriesLevel: notCategoriesLevel,
                    entitiesTitleText: entitiesTitleText,
                    notEntitiesTitleText: notEntitiesTitleText,
                    entitiesTitleType: entitiesTitleType,
                    notEntitiesTitleType: notEntitiesTitleType,
                    entitiesTitleLinksDbpedia: entitiesTitleLinksDbpedia,
                    notEntitiesTitleLinksDbpedia: notEntitiesTitleLinksDbpedia,
                    entitiesBodyText: entitiesBodyText,
                    notEntitiesBodyText: notEntitiesBodyText,
                    entitiesBodyType: entitiesBodyType,
                    notEntitiesBodyType: notEntitiesBodyType,
                    entitiesBodyLinksDbpedia: entitiesBodyLinksDbpedia,
                    notEntitiesBodyLinksDbpedia: notEntitiesBodyLinksDbpedia,
                    sentimentTitlePolarity: sentimentTitlePolarity,
                    notSentimentTitlePolarity: notSentimentTitlePolarity,
                    sentimentBodyPolarity: sentimentBodyPolarity,
                    notSentimentBodyPolarity: notSentimentBodyPolarity,
                    mediaImagesCountMin: mediaImagesCountMin,
                    mediaImagesCountMax: mediaImagesCountMax,
                    mediaImagesWidthMin: mediaImagesWidthMin,
                    mediaImagesWidthMax: mediaImagesWidthMax,
                    mediaImagesHeightMin: mediaImagesHeightMin,
                    mediaImagesHeightMax: mediaImagesHeightMax,
                    mediaImagesContentLengthMin: mediaImagesContentLengthMin,
                    mediaImagesContentLengthMax: mediaImagesContentLengthMax,
                    mediaImagesFormat: mediaImagesFormat,
                    notMediaImagesFormat: notMediaImagesFormat,
                    mediaVideosCountMin: mediaVideosCountMin,
                    mediaVideosCountMax: mediaVideosCountMax,
                    authorId: authorId,
                    notAuthorId: notAuthorId,
                    authorName: authorName,
                    notAuthorName: notAuthorName,
                    sourceId: sourceId,
                    notSourceId: notSourceId,
                    sourceName: sourceName,
                    notSourceName: notSourceName,
                    sourceDomain: sourceDomain,
                    notSourceDomain: notSourceDomain,
                    sourceLocationsCountry: sourceLocationsCountry,
                    notSourceLocationsCountry: notSourceLocationsCountry,
                    sourceLocationsState: sourceLocationsState,
                    notSourceLocationsState: notSourceLocationsState,
                    sourceLocationsCity: sourceLocationsCity,
                    notSourceLocationsCity: notSourceLocationsCity,
                    sourceScopesCountry: sourceScopesCountry,
                    notSourceScopesCountry: notSourceScopesCountry,
                    sourceScopesState: sourceScopesState,
                    notSourceScopesState: notSourceScopesState,
                    sourceScopesCity: sourceScopesCity,
                    notSourceScopesCity: notSourceScopesCity,
                    sourceScopesLevel: sourceScopesLevel,
                    notSourceScopesLevel: notSourceScopesLevel,
                    sourceLinksInCountMin: sourceLinksInCountMin,
                    sourceLinksInCountMax: sourceLinksInCountMax,
                    sourceRankingsAlexaRankMin: sourceRankingsAlexaRankMin,
                    sourceRankingsAlexaRankMax: sourceRankingsAlexaRankMax,
                    sourceRankingsAlexaCountry: sourceRankingsAlexaCountry,
                    socialSharesCountFacebookMin: socialSharesCountFacebookMin,
                    socialSharesCountFacebookMax: socialSharesCountFacebookMax,
                    socialSharesCountGooglePlusMin: socialSharesCountGooglePlusMin,
                    socialSharesCountGooglePlusMax: socialSharesCountGooglePlusMax,
                    socialSharesCountLinkedinMin: socialSharesCountLinkedinMin,
                    socialSharesCountLinkedinMax: socialSharesCountLinkedinMax,
                    socialSharesCountRedditMin: socialSharesCountRedditMin,
                    socialSharesCountRedditMax: socialSharesCountRedditMax,
                    cluster: cluster,
                    clusterAlgorithm: clusterAlgorithm,
                    _return: _return,
                    storyId: storyId,
                    storyUrl: storyUrl,
                    storyTitle: storyTitle,
                    storyBody: storyBody,
                    storyPublishedAt: storyPublishedAt,
                    storyLanguage: storyLanguage,
                    perPage: perPage
                );
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
 **id** | **List&lt;long?&gt;**| This parameter is used for finding stories by story id. | [optional] 
 **notId** | **List&lt;long?&gt;**| This parameter is used for excluding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional]  [enum: iab-qag, iptc-subjectcode]
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | **List&lt;string&gt;**| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesId** | **List&lt;string&gt;**| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | **List&lt;int?&gt;**| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesLevel** | **List&lt;int?&gt;**| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **notAuthorId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **notSourceId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose source id is the specified value. | [optional] 
 **sourceName** | **List&lt;string&gt;**| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **notSourceName** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | **List&lt;string&gt;**| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **notSourceDomain** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | **List&lt;string&gt;**| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to lingo] [enum: stc, lingo, kmeans]
 **_return** | **List&lt;string&gt;**| This parameter is used for specifying return fields. | [optional]  [enum: id, title, body, summary, source, author, entities, keywords, hashtags, characters_count, words_count, sentences_count, paragraphs_count, categories, social_shares_count, media, sentiment, language, published_at, links]
 **storyId** | **long?**| A story id | [optional] 
 **storyUrl** | **string**| An article or webpage | [optional] 
 **storyTitle** | **string**| Title of the article | [optional] 
 **storyBody** | **string**| Body of the article | [optional] 
 **storyPublishedAt** | **DateTime?**| Publish date of the article. If you use a url or title and body of an article for getting coverages, this parameter is required. The format used is a restricted form of the canonical representation of dateTime in the [XML Schema specification (ISO 8601)](https://www.w3.org/TR/xmlschema-2/#dateTime). | [optional] 
 **storyLanguage** | **string**| This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] [default to auto] [enum: auto, en, de, fr, it, es, pt]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page. | [optional] [default to 3]

### Return type

[**Coverages**](Coverages.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhistograms"></a>
# **ListHistograms**
> Histograms ListHistograms (List<long?> id = null, List<long?> notId = null, string title = null, string body = null, string text = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int?> categoriesLevel = null, List<int?> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, List<int?> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int?> sourceId = null, List<int?> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, int? intervalStart = null, int? intervalEnd = null, int? intervalWidth = null, string field = null)

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
        static void Main(string[] args)
        {
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();

            var id = new List<long?>();
            var notId = new List<long?>();
            var title = title_example;
            var body = body_example;
            var text = text_example;
            var language = new List<string>();
            var notLanguage = new List<string>();
            var publishedAtStart = publishedAtStart_example;
            var publishedAtEnd = publishedAtEnd_example;
            var categoriesTaxonomy = categoriesTaxonomy_example;
            var categoriesConfident = true;
            var categoriesId = new List<string>();
            var notCategoriesId = new List<string>();
            var categoriesLevel = new List<int?>();
            var notCategoriesLevel = new List<int?>();
            var entitiesTitleText = new List<string>();
            var notEntitiesTitleText = new List<string>();
            var entitiesTitleType = new List<string>();
            var notEntitiesTitleType = new List<string>();
            var entitiesTitleLinksDbpedia = new List<string>();
            var notEntitiesTitleLinksDbpedia = new List<string>();
            var entitiesBodyText = new List<string>();
            var notEntitiesBodyText = new List<string>();
            var entitiesBodyType = new List<string>();
            var notEntitiesBodyType = new List<string>();
            var entitiesBodyLinksDbpedia = new List<string>();
            var notEntitiesBodyLinksDbpedia = new List<string>();
            var sentimentTitlePolarity = sentimentTitlePolarity_example;
            var notSentimentTitlePolarity = notSentimentTitlePolarity_example;
            var sentimentBodyPolarity = sentimentBodyPolarity_example;
            var notSentimentBodyPolarity = notSentimentBodyPolarity_example;
            var mediaImagesCountMin = 56;
            var mediaImagesCountMax = 56;
            var mediaImagesWidthMin = 56;
            var mediaImagesWidthMax = 56;
            var mediaImagesHeightMin = 56;
            var mediaImagesHeightMax = 56;
            var mediaImagesContentLengthMin = 56;
            var mediaImagesContentLengthMax = 56;
            var mediaImagesFormat = new List<string>();
            var notMediaImagesFormat = new List<string>();
            var mediaVideosCountMin = 56;
            var mediaVideosCountMax = 56;
            var authorId = new List<int?>();
            var notAuthorId = new List<int?>();
            var authorName = authorName_example;
            var notAuthorName = notAuthorName_example;
            var sourceId = new List<int?>();
            var notSourceId = new List<int?>();
            var sourceName = new List<string>();
            var notSourceName = new List<string>();
            var sourceDomain = new List<string>();
            var notSourceDomain = new List<string>();
            var sourceLocationsCountry = new List<string>();
            var notSourceLocationsCountry = new List<string>();
            var sourceLocationsState = new List<string>();
            var notSourceLocationsState = new List<string>();
            var sourceLocationsCity = new List<string>();
            var notSourceLocationsCity = new List<string>();
            var sourceScopesCountry = new List<string>();
            var notSourceScopesCountry = new List<string>();
            var sourceScopesState = new List<string>();
            var notSourceScopesState = new List<string>();
            var sourceScopesCity = new List<string>();
            var notSourceScopesCity = new List<string>();
            var sourceScopesLevel = new List<string>();
            var notSourceScopesLevel = new List<string>();
            var sourceLinksInCountMin = 56;
            var sourceLinksInCountMax = 56;
            var sourceRankingsAlexaRankMin = 56;
            var sourceRankingsAlexaRankMax = 56;
            var sourceRankingsAlexaCountry = new List<string>();
            var socialSharesCountFacebookMin = 56;
            var socialSharesCountFacebookMax = 56;
            var socialSharesCountGooglePlusMin = 56;
            var socialSharesCountGooglePlusMax = 56;
            var socialSharesCountLinkedinMin = 56;
            var socialSharesCountLinkedinMax = 56;
            var socialSharesCountRedditMin = 56;
            var socialSharesCountRedditMax = 56;
            var intervalStart = 56;
            var intervalEnd = 56;
            var intervalWidth = 56;
            var field = field_example;

            try
            {
                // List histograms
                Histograms result = apiInstance.ListHistograms(
                    id: id,
                    notId: notId,
                    title: title,
                    body: body,
                    text: text,
                    language: language,
                    notLanguage: notLanguage,
                    publishedAtStart: publishedAtStart,
                    publishedAtEnd: publishedAtEnd,
                    categoriesTaxonomy: categoriesTaxonomy,
                    categoriesConfident: categoriesConfident,
                    categoriesId: categoriesId,
                    notCategoriesId: notCategoriesId,
                    categoriesLevel: categoriesLevel,
                    notCategoriesLevel: notCategoriesLevel,
                    entitiesTitleText: entitiesTitleText,
                    notEntitiesTitleText: notEntitiesTitleText,
                    entitiesTitleType: entitiesTitleType,
                    notEntitiesTitleType: notEntitiesTitleType,
                    entitiesTitleLinksDbpedia: entitiesTitleLinksDbpedia,
                    notEntitiesTitleLinksDbpedia: notEntitiesTitleLinksDbpedia,
                    entitiesBodyText: entitiesBodyText,
                    notEntitiesBodyText: notEntitiesBodyText,
                    entitiesBodyType: entitiesBodyType,
                    notEntitiesBodyType: notEntitiesBodyType,
                    entitiesBodyLinksDbpedia: entitiesBodyLinksDbpedia,
                    notEntitiesBodyLinksDbpedia: notEntitiesBodyLinksDbpedia,
                    sentimentTitlePolarity: sentimentTitlePolarity,
                    notSentimentTitlePolarity: notSentimentTitlePolarity,
                    sentimentBodyPolarity: sentimentBodyPolarity,
                    notSentimentBodyPolarity: notSentimentBodyPolarity,
                    mediaImagesCountMin: mediaImagesCountMin,
                    mediaImagesCountMax: mediaImagesCountMax,
                    mediaImagesWidthMin: mediaImagesWidthMin,
                    mediaImagesWidthMax: mediaImagesWidthMax,
                    mediaImagesHeightMin: mediaImagesHeightMin,
                    mediaImagesHeightMax: mediaImagesHeightMax,
                    mediaImagesContentLengthMin: mediaImagesContentLengthMin,
                    mediaImagesContentLengthMax: mediaImagesContentLengthMax,
                    mediaImagesFormat: mediaImagesFormat,
                    notMediaImagesFormat: notMediaImagesFormat,
                    mediaVideosCountMin: mediaVideosCountMin,
                    mediaVideosCountMax: mediaVideosCountMax,
                    authorId: authorId,
                    notAuthorId: notAuthorId,
                    authorName: authorName,
                    notAuthorName: notAuthorName,
                    sourceId: sourceId,
                    notSourceId: notSourceId,
                    sourceName: sourceName,
                    notSourceName: notSourceName,
                    sourceDomain: sourceDomain,
                    notSourceDomain: notSourceDomain,
                    sourceLocationsCountry: sourceLocationsCountry,
                    notSourceLocationsCountry: notSourceLocationsCountry,
                    sourceLocationsState: sourceLocationsState,
                    notSourceLocationsState: notSourceLocationsState,
                    sourceLocationsCity: sourceLocationsCity,
                    notSourceLocationsCity: notSourceLocationsCity,
                    sourceScopesCountry: sourceScopesCountry,
                    notSourceScopesCountry: notSourceScopesCountry,
                    sourceScopesState: sourceScopesState,
                    notSourceScopesState: notSourceScopesState,
                    sourceScopesCity: sourceScopesCity,
                    notSourceScopesCity: notSourceScopesCity,
                    sourceScopesLevel: sourceScopesLevel,
                    notSourceScopesLevel: notSourceScopesLevel,
                    sourceLinksInCountMin: sourceLinksInCountMin,
                    sourceLinksInCountMax: sourceLinksInCountMax,
                    sourceRankingsAlexaRankMin: sourceRankingsAlexaRankMin,
                    sourceRankingsAlexaRankMax: sourceRankingsAlexaRankMax,
                    sourceRankingsAlexaCountry: sourceRankingsAlexaCountry,
                    socialSharesCountFacebookMin: socialSharesCountFacebookMin,
                    socialSharesCountFacebookMax: socialSharesCountFacebookMax,
                    socialSharesCountGooglePlusMin: socialSharesCountGooglePlusMin,
                    socialSharesCountGooglePlusMax: socialSharesCountGooglePlusMax,
                    socialSharesCountLinkedinMin: socialSharesCountLinkedinMin,
                    socialSharesCountLinkedinMax: socialSharesCountLinkedinMax,
                    socialSharesCountRedditMin: socialSharesCountRedditMin,
                    socialSharesCountRedditMax: socialSharesCountRedditMax,
                    intervalStart: intervalStart,
                    intervalEnd: intervalEnd,
                    intervalWidth: intervalWidth,
                    field: field
                );
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
 **id** | **List&lt;long?&gt;**| This parameter is used for finding stories by story id. | [optional] 
 **notId** | **List&lt;long?&gt;**| This parameter is used for excluding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional]  [enum: iab-qag, iptc-subjectcode]
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | **List&lt;string&gt;**| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesId** | **List&lt;string&gt;**| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | **List&lt;int?&gt;**| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesLevel** | **List&lt;int?&gt;**| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **notAuthorId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **notSourceId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose source id is the specified value. | [optional] 
 **sourceName** | **List&lt;string&gt;**| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **notSourceName** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | **List&lt;string&gt;**| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **notSourceDomain** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | **List&lt;string&gt;**| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
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
 **field** | **string**| This parameter is used for specifying the y-axis variable for the histogram. | [optional] [default to social_shares_count] [enum: social_shares_count, social_shares_count.facebook, social_shares_count.linkedin, social_shares_count.reddit, social_shares_count.google_plus, characters_count, words_count, sentences_count, paragraphs_count, media.images.count, media.videos.count, source.links_in_count, source.rankings.alexa.rank, source.rankings.alexa.rank.AF, source.rankings.alexa.rank.AX, source.rankings.alexa.rank.AL, source.rankings.alexa.rank.DZ, source.rankings.alexa.rank.AS, source.rankings.alexa.rank.AD, source.rankings.alexa.rank.AO, source.rankings.alexa.rank.AI, source.rankings.alexa.rank.AQ, source.rankings.alexa.rank.AG, source.rankings.alexa.rank.AR, source.rankings.alexa.rank.AM, source.rankings.alexa.rank.AW, source.rankings.alexa.rank.AU, source.rankings.alexa.rank.AT, source.rankings.alexa.rank.AZ, source.rankings.alexa.rank.BS, source.rankings.alexa.rank.BH, source.rankings.alexa.rank.BD, source.rankings.alexa.rank.BB, source.rankings.alexa.rank.BY, source.rankings.alexa.rank.BE, source.rankings.alexa.rank.BZ, source.rankings.alexa.rank.BJ, source.rankings.alexa.rank.BM, source.rankings.alexa.rank.BT, source.rankings.alexa.rank.BO, source.rankings.alexa.rank.BQ, source.rankings.alexa.rank.BA, source.rankings.alexa.rank.BW, source.rankings.alexa.rank.BV, source.rankings.alexa.rank.BR, source.rankings.alexa.rank.IO, source.rankings.alexa.rank.BN, source.rankings.alexa.rank.BG, source.rankings.alexa.rank.BF, source.rankings.alexa.rank.BI, source.rankings.alexa.rank.KH, source.rankings.alexa.rank.CM, source.rankings.alexa.rank.CA, source.rankings.alexa.rank.CV, source.rankings.alexa.rank.KY, source.rankings.alexa.rank.CF, source.rankings.alexa.rank.TD, source.rankings.alexa.rank.CL, source.rankings.alexa.rank.CN, source.rankings.alexa.rank.CX, source.rankings.alexa.rank.CC, source.rankings.alexa.rank.CO, source.rankings.alexa.rank.KM, source.rankings.alexa.rank.CG, source.rankings.alexa.rank.CD, source.rankings.alexa.rank.CK, source.rankings.alexa.rank.CR, source.rankings.alexa.rank.CI, source.rankings.alexa.rank.HR, source.rankings.alexa.rank.CU, source.rankings.alexa.rank.CW, source.rankings.alexa.rank.CY, source.rankings.alexa.rank.CZ, source.rankings.alexa.rank.DK, source.rankings.alexa.rank.DJ, source.rankings.alexa.rank.DM, source.rankings.alexa.rank.DO, source.rankings.alexa.rank.EC, source.rankings.alexa.rank.EG, source.rankings.alexa.rank.SV, source.rankings.alexa.rank.GQ, source.rankings.alexa.rank.ER, source.rankings.alexa.rank.EE, source.rankings.alexa.rank.ET, source.rankings.alexa.rank.FK, source.rankings.alexa.rank.FO, source.rankings.alexa.rank.FJ, source.rankings.alexa.rank.FI, source.rankings.alexa.rank.FR, source.rankings.alexa.rank.GF, source.rankings.alexa.rank.PF, source.rankings.alexa.rank.TF, source.rankings.alexa.rank.GA, source.rankings.alexa.rank.GM, source.rankings.alexa.rank.GE, source.rankings.alexa.rank.DE, source.rankings.alexa.rank.GH, source.rankings.alexa.rank.GI, source.rankings.alexa.rank.GR, source.rankings.alexa.rank.GL, source.rankings.alexa.rank.GD, source.rankings.alexa.rank.GP, source.rankings.alexa.rank.GU, source.rankings.alexa.rank.GT, source.rankings.alexa.rank.GG, source.rankings.alexa.rank.GN, source.rankings.alexa.rank.GW, source.rankings.alexa.rank.GY, source.rankings.alexa.rank.HT, source.rankings.alexa.rank.HM, source.rankings.alexa.rank.VA, source.rankings.alexa.rank.HN, source.rankings.alexa.rank.HK, source.rankings.alexa.rank.HU, source.rankings.alexa.rank.IS, source.rankings.alexa.rank.IN, source.rankings.alexa.rank.ID, source.rankings.alexa.rank.IR, source.rankings.alexa.rank.IQ, source.rankings.alexa.rank.IE, source.rankings.alexa.rank.IM, source.rankings.alexa.rank.IL, source.rankings.alexa.rank.IT, source.rankings.alexa.rank.JM, source.rankings.alexa.rank.JP, source.rankings.alexa.rank.JE, source.rankings.alexa.rank.JO, source.rankings.alexa.rank.KZ, source.rankings.alexa.rank.KE, source.rankings.alexa.rank.KI, source.rankings.alexa.rank.KP, source.rankings.alexa.rank.KR, source.rankings.alexa.rank.KW, source.rankings.alexa.rank.KG, source.rankings.alexa.rank.LA, source.rankings.alexa.rank.LV, source.rankings.alexa.rank.LB, source.rankings.alexa.rank.LS, source.rankings.alexa.rank.LR, source.rankings.alexa.rank.LY, source.rankings.alexa.rank.LI, source.rankings.alexa.rank.LT, source.rankings.alexa.rank.LU, source.rankings.alexa.rank.MO, source.rankings.alexa.rank.MK, source.rankings.alexa.rank.MG, source.rankings.alexa.rank.MW, source.rankings.alexa.rank.MY, source.rankings.alexa.rank.MV, source.rankings.alexa.rank.ML, source.rankings.alexa.rank.MT, source.rankings.alexa.rank.MH, source.rankings.alexa.rank.MQ, source.rankings.alexa.rank.MR, source.rankings.alexa.rank.MU, source.rankings.alexa.rank.YT, source.rankings.alexa.rank.MX, source.rankings.alexa.rank.FM, source.rankings.alexa.rank.MD, source.rankings.alexa.rank.MC, source.rankings.alexa.rank.MN, source.rankings.alexa.rank.ME, source.rankings.alexa.rank.MS, source.rankings.alexa.rank.MA, source.rankings.alexa.rank.MZ, source.rankings.alexa.rank.MM, source.rankings.alexa.rank.NA, source.rankings.alexa.rank.NR, source.rankings.alexa.rank.NP, source.rankings.alexa.rank.NL, source.rankings.alexa.rank.NC, source.rankings.alexa.rank.NZ, source.rankings.alexa.rank.NI, source.rankings.alexa.rank.NE, source.rankings.alexa.rank.NG, source.rankings.alexa.rank.NU, source.rankings.alexa.rank.NF, source.rankings.alexa.rank.MP, source.rankings.alexa.rank.NO, source.rankings.alexa.rank.OM, source.rankings.alexa.rank.PK, source.rankings.alexa.rank.PW, source.rankings.alexa.rank.PS, source.rankings.alexa.rank.PA, source.rankings.alexa.rank.PG, source.rankings.alexa.rank.PY, source.rankings.alexa.rank.PE, source.rankings.alexa.rank.PH, source.rankings.alexa.rank.PN, source.rankings.alexa.rank.PL, source.rankings.alexa.rank.PT, source.rankings.alexa.rank.PR, source.rankings.alexa.rank.QA, source.rankings.alexa.rank.RE, source.rankings.alexa.rank.RO, source.rankings.alexa.rank.RU, source.rankings.alexa.rank.RW, source.rankings.alexa.rank.BL, source.rankings.alexa.rank.SH, source.rankings.alexa.rank.KN, source.rankings.alexa.rank.LC, source.rankings.alexa.rank.MF, source.rankings.alexa.rank.PM, source.rankings.alexa.rank.VC, source.rankings.alexa.rank.WS, source.rankings.alexa.rank.SM, source.rankings.alexa.rank.ST, source.rankings.alexa.rank.SA, source.rankings.alexa.rank.SN, source.rankings.alexa.rank.RS, source.rankings.alexa.rank.SC, source.rankings.alexa.rank.SL, source.rankings.alexa.rank.SG, source.rankings.alexa.rank.SX, source.rankings.alexa.rank.SK, source.rankings.alexa.rank.SI, source.rankings.alexa.rank.SB, source.rankings.alexa.rank.SO, source.rankings.alexa.rank.ZA, source.rankings.alexa.rank.GS, source.rankings.alexa.rank.SS, source.rankings.alexa.rank.ES, source.rankings.alexa.rank.LK, source.rankings.alexa.rank.SD, source.rankings.alexa.rank.SR, source.rankings.alexa.rank.SJ, source.rankings.alexa.rank.SZ, source.rankings.alexa.rank.SE, source.rankings.alexa.rank.CH, source.rankings.alexa.rank.SY, source.rankings.alexa.rank.TW, source.rankings.alexa.rank.TJ, source.rankings.alexa.rank.TZ, source.rankings.alexa.rank.TH, source.rankings.alexa.rank.TL, source.rankings.alexa.rank.TG, source.rankings.alexa.rank.TK, source.rankings.alexa.rank.TO, source.rankings.alexa.rank.TT, source.rankings.alexa.rank.TN, source.rankings.alexa.rank.TR, source.rankings.alexa.rank.TM, source.rankings.alexa.rank.TC, source.rankings.alexa.rank.TV, source.rankings.alexa.rank.UG, source.rankings.alexa.rank.UA, source.rankings.alexa.rank.AE, source.rankings.alexa.rank.GB, source.rankings.alexa.rank.US, source.rankings.alexa.rank.UM, source.rankings.alexa.rank.UY, source.rankings.alexa.rank.UZ, source.rankings.alexa.rank.VU, source.rankings.alexa.rank.VE, source.rankings.alexa.rank.VN, source.rankings.alexa.rank.VG, source.rankings.alexa.rank.VI, source.rankings.alexa.rank.WF, source.rankings.alexa.rank.EH, source.rankings.alexa.rank.YE, source.rankings.alexa.rank.ZM, source.rankings.alexa.rank.ZW]

### Return type

[**Histograms**](Histograms.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrelatedstories"></a>
# **ListRelatedStories**
> RelatedStories ListRelatedStories (List<long?> id = null, List<long?> notId = null, string title = null, string body = null, string text = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int?> categoriesLevel = null, List<int?> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, List<int?> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int?> sourceId = null, List<int?> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, long? storyId = null, string storyUrl = null, string storyTitle = null, string storyBody = null, string boostBy = null, string storyLanguage = null, int? perPage = null)

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
        static void Main(string[] args)
        {
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();

            var id = new List<long?>();
            var notId = new List<long?>();
            var title = title_example;
            var body = body_example;
            var text = text_example;
            var language = new List<string>();
            var notLanguage = new List<string>();
            var publishedAtStart = publishedAtStart_example;
            var publishedAtEnd = publishedAtEnd_example;
            var categoriesTaxonomy = categoriesTaxonomy_example;
            var categoriesConfident = true;
            var categoriesId = new List<string>();
            var notCategoriesId = new List<string>();
            var categoriesLevel = new List<int?>();
            var notCategoriesLevel = new List<int?>();
            var entitiesTitleText = new List<string>();
            var notEntitiesTitleText = new List<string>();
            var entitiesTitleType = new List<string>();
            var notEntitiesTitleType = new List<string>();
            var entitiesTitleLinksDbpedia = new List<string>();
            var notEntitiesTitleLinksDbpedia = new List<string>();
            var entitiesBodyText = new List<string>();
            var notEntitiesBodyText = new List<string>();
            var entitiesBodyType = new List<string>();
            var notEntitiesBodyType = new List<string>();
            var entitiesBodyLinksDbpedia = new List<string>();
            var notEntitiesBodyLinksDbpedia = new List<string>();
            var sentimentTitlePolarity = sentimentTitlePolarity_example;
            var notSentimentTitlePolarity = notSentimentTitlePolarity_example;
            var sentimentBodyPolarity = sentimentBodyPolarity_example;
            var notSentimentBodyPolarity = notSentimentBodyPolarity_example;
            var mediaImagesCountMin = 56;
            var mediaImagesCountMax = 56;
            var mediaImagesWidthMin = 56;
            var mediaImagesWidthMax = 56;
            var mediaImagesHeightMin = 56;
            var mediaImagesHeightMax = 56;
            var mediaImagesContentLengthMin = 56;
            var mediaImagesContentLengthMax = 56;
            var mediaImagesFormat = new List<string>();
            var notMediaImagesFormat = new List<string>();
            var mediaVideosCountMin = 56;
            var mediaVideosCountMax = 56;
            var authorId = new List<int?>();
            var notAuthorId = new List<int?>();
            var authorName = authorName_example;
            var notAuthorName = notAuthorName_example;
            var sourceId = new List<int?>();
            var notSourceId = new List<int?>();
            var sourceName = new List<string>();
            var notSourceName = new List<string>();
            var sourceDomain = new List<string>();
            var notSourceDomain = new List<string>();
            var sourceLocationsCountry = new List<string>();
            var notSourceLocationsCountry = new List<string>();
            var sourceLocationsState = new List<string>();
            var notSourceLocationsState = new List<string>();
            var sourceLocationsCity = new List<string>();
            var notSourceLocationsCity = new List<string>();
            var sourceScopesCountry = new List<string>();
            var notSourceScopesCountry = new List<string>();
            var sourceScopesState = new List<string>();
            var notSourceScopesState = new List<string>();
            var sourceScopesCity = new List<string>();
            var notSourceScopesCity = new List<string>();
            var sourceScopesLevel = new List<string>();
            var notSourceScopesLevel = new List<string>();
            var sourceLinksInCountMin = 56;
            var sourceLinksInCountMax = 56;
            var sourceRankingsAlexaRankMin = 56;
            var sourceRankingsAlexaRankMax = 56;
            var sourceRankingsAlexaCountry = new List<string>();
            var socialSharesCountFacebookMin = 56;
            var socialSharesCountFacebookMax = 56;
            var socialSharesCountGooglePlusMin = 56;
            var socialSharesCountGooglePlusMax = 56;
            var socialSharesCountLinkedinMin = 56;
            var socialSharesCountLinkedinMax = 56;
            var socialSharesCountRedditMin = 56;
            var socialSharesCountRedditMax = 56;
            var cluster = true;
            var clusterAlgorithm = clusterAlgorithm_example;
            var _return = new List<string>();
            var storyId = 789;
            var storyUrl = storyUrl_example;
            var storyTitle = storyTitle_example;
            var storyBody = storyBody_example;
            var boostBy = boostBy_example;
            var storyLanguage = storyLanguage_example;
            var perPage = 56;

            try
            {
                // List related stories
                RelatedStories result = apiInstance.ListRelatedStories(
                    id: id,
                    notId: notId,
                    title: title,
                    body: body,
                    text: text,
                    language: language,
                    notLanguage: notLanguage,
                    publishedAtStart: publishedAtStart,
                    publishedAtEnd: publishedAtEnd,
                    categoriesTaxonomy: categoriesTaxonomy,
                    categoriesConfident: categoriesConfident,
                    categoriesId: categoriesId,
                    notCategoriesId: notCategoriesId,
                    categoriesLevel: categoriesLevel,
                    notCategoriesLevel: notCategoriesLevel,
                    entitiesTitleText: entitiesTitleText,
                    notEntitiesTitleText: notEntitiesTitleText,
                    entitiesTitleType: entitiesTitleType,
                    notEntitiesTitleType: notEntitiesTitleType,
                    entitiesTitleLinksDbpedia: entitiesTitleLinksDbpedia,
                    notEntitiesTitleLinksDbpedia: notEntitiesTitleLinksDbpedia,
                    entitiesBodyText: entitiesBodyText,
                    notEntitiesBodyText: notEntitiesBodyText,
                    entitiesBodyType: entitiesBodyType,
                    notEntitiesBodyType: notEntitiesBodyType,
                    entitiesBodyLinksDbpedia: entitiesBodyLinksDbpedia,
                    notEntitiesBodyLinksDbpedia: notEntitiesBodyLinksDbpedia,
                    sentimentTitlePolarity: sentimentTitlePolarity,
                    notSentimentTitlePolarity: notSentimentTitlePolarity,
                    sentimentBodyPolarity: sentimentBodyPolarity,
                    notSentimentBodyPolarity: notSentimentBodyPolarity,
                    mediaImagesCountMin: mediaImagesCountMin,
                    mediaImagesCountMax: mediaImagesCountMax,
                    mediaImagesWidthMin: mediaImagesWidthMin,
                    mediaImagesWidthMax: mediaImagesWidthMax,
                    mediaImagesHeightMin: mediaImagesHeightMin,
                    mediaImagesHeightMax: mediaImagesHeightMax,
                    mediaImagesContentLengthMin: mediaImagesContentLengthMin,
                    mediaImagesContentLengthMax: mediaImagesContentLengthMax,
                    mediaImagesFormat: mediaImagesFormat,
                    notMediaImagesFormat: notMediaImagesFormat,
                    mediaVideosCountMin: mediaVideosCountMin,
                    mediaVideosCountMax: mediaVideosCountMax,
                    authorId: authorId,
                    notAuthorId: notAuthorId,
                    authorName: authorName,
                    notAuthorName: notAuthorName,
                    sourceId: sourceId,
                    notSourceId: notSourceId,
                    sourceName: sourceName,
                    notSourceName: notSourceName,
                    sourceDomain: sourceDomain,
                    notSourceDomain: notSourceDomain,
                    sourceLocationsCountry: sourceLocationsCountry,
                    notSourceLocationsCountry: notSourceLocationsCountry,
                    sourceLocationsState: sourceLocationsState,
                    notSourceLocationsState: notSourceLocationsState,
                    sourceLocationsCity: sourceLocationsCity,
                    notSourceLocationsCity: notSourceLocationsCity,
                    sourceScopesCountry: sourceScopesCountry,
                    notSourceScopesCountry: notSourceScopesCountry,
                    sourceScopesState: sourceScopesState,
                    notSourceScopesState: notSourceScopesState,
                    sourceScopesCity: sourceScopesCity,
                    notSourceScopesCity: notSourceScopesCity,
                    sourceScopesLevel: sourceScopesLevel,
                    notSourceScopesLevel: notSourceScopesLevel,
                    sourceLinksInCountMin: sourceLinksInCountMin,
                    sourceLinksInCountMax: sourceLinksInCountMax,
                    sourceRankingsAlexaRankMin: sourceRankingsAlexaRankMin,
                    sourceRankingsAlexaRankMax: sourceRankingsAlexaRankMax,
                    sourceRankingsAlexaCountry: sourceRankingsAlexaCountry,
                    socialSharesCountFacebookMin: socialSharesCountFacebookMin,
                    socialSharesCountFacebookMax: socialSharesCountFacebookMax,
                    socialSharesCountGooglePlusMin: socialSharesCountGooglePlusMin,
                    socialSharesCountGooglePlusMax: socialSharesCountGooglePlusMax,
                    socialSharesCountLinkedinMin: socialSharesCountLinkedinMin,
                    socialSharesCountLinkedinMax: socialSharesCountLinkedinMax,
                    socialSharesCountRedditMin: socialSharesCountRedditMin,
                    socialSharesCountRedditMax: socialSharesCountRedditMax,
                    cluster: cluster,
                    clusterAlgorithm: clusterAlgorithm,
                    _return: _return,
                    storyId: storyId,
                    storyUrl: storyUrl,
                    storyTitle: storyTitle,
                    storyBody: storyBody,
                    boostBy: boostBy,
                    storyLanguage: storyLanguage,
                    perPage: perPage
                );
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
 **id** | **List&lt;long?&gt;**| This parameter is used for finding stories by story id. | [optional] 
 **notId** | **List&lt;long?&gt;**| This parameter is used for excluding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional]  [enum: iab-qag, iptc-subjectcode]
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | **List&lt;string&gt;**| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesId** | **List&lt;string&gt;**| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | **List&lt;int?&gt;**| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesLevel** | **List&lt;int?&gt;**| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **notAuthorId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **notSourceId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose source id is the specified value. | [optional] 
 **sourceName** | **List&lt;string&gt;**| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **notSourceName** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | **List&lt;string&gt;**| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **notSourceDomain** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes  is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes  is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | **List&lt;string&gt;**| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to lingo] [enum: stc, lingo, kmeans]
 **_return** | **List&lt;string&gt;**| This parameter is used for specifying return fields. | [optional]  [enum: id, title, body, summary, source, author, entities, keywords, hashtags, characters_count, words_count, sentences_count, paragraphs_count, categories, social_shares_count, media, sentiment, language, published_at, links]
 **storyId** | **long?**| A story id | [optional] 
 **storyUrl** | **string**| An article or webpage | [optional] 
 **storyTitle** | **string**| Title of the article | [optional] 
 **storyBody** | **string**| Body of the article | [optional] 
 **boostBy** | **string**| This parameter is used for boosting the result by the specified value. | [optional]  [enum: recency, popularity]
 **storyLanguage** | **string**| This parameter is used for setting the language of the story. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional] [default to auto] [enum: auto, en, de, fr, it, es, pt]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page. | [optional] [default to 3]

### Return type

[**RelatedStories**](RelatedStories.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststories"></a>
# **ListStories**
> Stories ListStories (List<long?> id = null, List<long?> notId = null, string title = null, string body = null, string text = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int?> categoriesLevel = null, List<int?> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, List<int?> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int?> sourceId = null, List<int?> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, bool? cluster = null, string clusterAlgorithm = null, List<string> _return = null, string sortBy = null, string sortDirection = null, string cursor = null, int? perPage = null)

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
        static void Main(string[] args)
        {
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();

            var id = new List<long?>();
            var notId = new List<long?>();
            var title = title_example;
            var body = body_example;
            var text = text_example;
            var language = new List<string>();
            var notLanguage = new List<string>();
            var publishedAtStart = publishedAtStart_example;
            var publishedAtEnd = publishedAtEnd_example;
            var categoriesTaxonomy = categoriesTaxonomy_example;
            var categoriesConfident = true;
            var categoriesId = new List<string>();
            var notCategoriesId = new List<string>();
            var categoriesLevel = new List<int?>();
            var notCategoriesLevel = new List<int?>();
            var entitiesTitleText = new List<string>();
            var notEntitiesTitleText = new List<string>();
            var entitiesTitleType = new List<string>();
            var notEntitiesTitleType = new List<string>();
            var entitiesTitleLinksDbpedia = new List<string>();
            var notEntitiesTitleLinksDbpedia = new List<string>();
            var entitiesBodyText = new List<string>();
            var notEntitiesBodyText = new List<string>();
            var entitiesBodyType = new List<string>();
            var notEntitiesBodyType = new List<string>();
            var entitiesBodyLinksDbpedia = new List<string>();
            var notEntitiesBodyLinksDbpedia = new List<string>();
            var sentimentTitlePolarity = sentimentTitlePolarity_example;
            var notSentimentTitlePolarity = notSentimentTitlePolarity_example;
            var sentimentBodyPolarity = sentimentBodyPolarity_example;
            var notSentimentBodyPolarity = notSentimentBodyPolarity_example;
            var mediaImagesCountMin = 56;
            var mediaImagesCountMax = 56;
            var mediaImagesWidthMin = 56;
            var mediaImagesWidthMax = 56;
            var mediaImagesHeightMin = 56;
            var mediaImagesHeightMax = 56;
            var mediaImagesContentLengthMin = 56;
            var mediaImagesContentLengthMax = 56;
            var mediaImagesFormat = new List<string>();
            var notMediaImagesFormat = new List<string>();
            var mediaVideosCountMin = 56;
            var mediaVideosCountMax = 56;
            var authorId = new List<int?>();
            var notAuthorId = new List<int?>();
            var authorName = authorName_example;
            var notAuthorName = notAuthorName_example;
            var sourceId = new List<int?>();
            var notSourceId = new List<int?>();
            var sourceName = new List<string>();
            var notSourceName = new List<string>();
            var sourceDomain = new List<string>();
            var notSourceDomain = new List<string>();
            var sourceLocationsCountry = new List<string>();
            var notSourceLocationsCountry = new List<string>();
            var sourceLocationsState = new List<string>();
            var notSourceLocationsState = new List<string>();
            var sourceLocationsCity = new List<string>();
            var notSourceLocationsCity = new List<string>();
            var sourceScopesCountry = new List<string>();
            var notSourceScopesCountry = new List<string>();
            var sourceScopesState = new List<string>();
            var notSourceScopesState = new List<string>();
            var sourceScopesCity = new List<string>();
            var notSourceScopesCity = new List<string>();
            var sourceScopesLevel = new List<string>();
            var notSourceScopesLevel = new List<string>();
            var sourceLinksInCountMin = 56;
            var sourceLinksInCountMax = 56;
            var sourceRankingsAlexaRankMin = 56;
            var sourceRankingsAlexaRankMax = 56;
            var sourceRankingsAlexaCountry = new List<string>();
            var socialSharesCountFacebookMin = 56;
            var socialSharesCountFacebookMax = 56;
            var socialSharesCountGooglePlusMin = 56;
            var socialSharesCountGooglePlusMax = 56;
            var socialSharesCountLinkedinMin = 56;
            var socialSharesCountLinkedinMax = 56;
            var socialSharesCountRedditMin = 56;
            var socialSharesCountRedditMax = 56;
            var cluster = true;
            var clusterAlgorithm = clusterAlgorithm_example;
            var _return = new List<string>();
            var sortBy = sortBy_example;
            var sortDirection = sortDirection_example;
            var cursor = cursor_example;
            var perPage = 56;

            try
            {
                // List Stories
                Stories result = apiInstance.ListStories(
                    id: id,
                    notId: notId,
                    title: title,
                    body: body,
                    text: text,
                    language: language,
                    notLanguage: notLanguage,
                    publishedAtStart: publishedAtStart,
                    publishedAtEnd: publishedAtEnd,
                    categoriesTaxonomy: categoriesTaxonomy,
                    categoriesConfident: categoriesConfident,
                    categoriesId: categoriesId,
                    notCategoriesId: notCategoriesId,
                    categoriesLevel: categoriesLevel,
                    notCategoriesLevel: notCategoriesLevel,
                    entitiesTitleText: entitiesTitleText,
                    notEntitiesTitleText: notEntitiesTitleText,
                    entitiesTitleType: entitiesTitleType,
                    notEntitiesTitleType: notEntitiesTitleType,
                    entitiesTitleLinksDbpedia: entitiesTitleLinksDbpedia,
                    notEntitiesTitleLinksDbpedia: notEntitiesTitleLinksDbpedia,
                    entitiesBodyText: entitiesBodyText,
                    notEntitiesBodyText: notEntitiesBodyText,
                    entitiesBodyType: entitiesBodyType,
                    notEntitiesBodyType: notEntitiesBodyType,
                    entitiesBodyLinksDbpedia: entitiesBodyLinksDbpedia,
                    notEntitiesBodyLinksDbpedia: notEntitiesBodyLinksDbpedia,
                    sentimentTitlePolarity: sentimentTitlePolarity,
                    notSentimentTitlePolarity: notSentimentTitlePolarity,
                    sentimentBodyPolarity: sentimentBodyPolarity,
                    notSentimentBodyPolarity: notSentimentBodyPolarity,
                    mediaImagesCountMin: mediaImagesCountMin,
                    mediaImagesCountMax: mediaImagesCountMax,
                    mediaImagesWidthMin: mediaImagesWidthMin,
                    mediaImagesWidthMax: mediaImagesWidthMax,
                    mediaImagesHeightMin: mediaImagesHeightMin,
                    mediaImagesHeightMax: mediaImagesHeightMax,
                    mediaImagesContentLengthMin: mediaImagesContentLengthMin,
                    mediaImagesContentLengthMax: mediaImagesContentLengthMax,
                    mediaImagesFormat: mediaImagesFormat,
                    notMediaImagesFormat: notMediaImagesFormat,
                    mediaVideosCountMin: mediaVideosCountMin,
                    mediaVideosCountMax: mediaVideosCountMax,
                    authorId: authorId,
                    notAuthorId: notAuthorId,
                    authorName: authorName,
                    notAuthorName: notAuthorName,
                    sourceId: sourceId,
                    notSourceId: notSourceId,
                    sourceName: sourceName,
                    notSourceName: notSourceName,
                    sourceDomain: sourceDomain,
                    notSourceDomain: notSourceDomain,
                    sourceLocationsCountry: sourceLocationsCountry,
                    notSourceLocationsCountry: notSourceLocationsCountry,
                    sourceLocationsState: sourceLocationsState,
                    notSourceLocationsState: notSourceLocationsState,
                    sourceLocationsCity: sourceLocationsCity,
                    notSourceLocationsCity: notSourceLocationsCity,
                    sourceScopesCountry: sourceScopesCountry,
                    notSourceScopesCountry: notSourceScopesCountry,
                    sourceScopesState: sourceScopesState,
                    notSourceScopesState: notSourceScopesState,
                    sourceScopesCity: sourceScopesCity,
                    notSourceScopesCity: notSourceScopesCity,
                    sourceScopesLevel: sourceScopesLevel,
                    notSourceScopesLevel: notSourceScopesLevel,
                    sourceLinksInCountMin: sourceLinksInCountMin,
                    sourceLinksInCountMax: sourceLinksInCountMax,
                    sourceRankingsAlexaRankMin: sourceRankingsAlexaRankMin,
                    sourceRankingsAlexaRankMax: sourceRankingsAlexaRankMax,
                    sourceRankingsAlexaCountry: sourceRankingsAlexaCountry,
                    socialSharesCountFacebookMin: socialSharesCountFacebookMin,
                    socialSharesCountFacebookMax: socialSharesCountFacebookMax,
                    socialSharesCountGooglePlusMin: socialSharesCountGooglePlusMin,
                    socialSharesCountGooglePlusMax: socialSharesCountGooglePlusMax,
                    socialSharesCountLinkedinMin: socialSharesCountLinkedinMin,
                    socialSharesCountLinkedinMax: socialSharesCountLinkedinMax,
                    socialSharesCountRedditMin: socialSharesCountRedditMin,
                    socialSharesCountRedditMax: socialSharesCountRedditMax,
                    cluster: cluster,
                    clusterAlgorithm: clusterAlgorithm,
                    _return: _return,
                    sortBy: sortBy,
                    sortDirection: sortDirection,
                    cursor: cursor,
                    perPage: perPage
                );
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
 **id** | **List&lt;long?&gt;**| This parameter is used for finding stories by story id. | [optional] 
 **notId** | **List&lt;long?&gt;**| This parameter is used for excluding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional]  [enum: iab-qag, iptc-subjectcode]
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | **List&lt;string&gt;**| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesId** | **List&lt;string&gt;**| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | **List&lt;int?&gt;**| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesLevel** | **List&lt;int?&gt;**| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **notAuthorId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **notSourceId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose source id is the specified value. | [optional] 
 **sourceName** | **List&lt;string&gt;**| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **notSourceName** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | **List&lt;string&gt;**| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **notSourceDomain** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | **List&lt;string&gt;**| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 
 **cluster** | **bool?**| This parameter enables clustering for the returned stories. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to false]
 **clusterAlgorithm** | **string**| This parameter is used for specifying the clustering algorithm you wish to use. It supprts STC, Lingo and [k-means](https://en.wikipedia.org/wiki/K-means_clustering) algorithms. You can read more about working with clustering [here](https://newsapi.aylien.com/docs/working-with-clustering). | [optional] [default to lingo] [enum: stc, lingo, kmeans]
 **_return** | **List&lt;string&gt;**| This parameter is used for specifying return fields. | [optional]  [enum: id, title, body, summary, source, author, entities, keywords, hashtags, characters_count, words_count, sentences_count, paragraphs_count, categories, social_shares_count, media, sentiment, language, published_at, links]
 **sortBy** | **string**| This parameter is used for changing the order column of the results. | [optional] [default to published_at] [enum: relevance, recency, hotness, published_at, social_shares_count, social_shares_count.facebook, social_shares_count.linkedin, social_shares_count.google_plus, social_shares_count.reddit, media.images.count, media.videos.count, source.links_in_count, source.rankings.alexa.rank, source.rankings.alexa.rank.AF, source.rankings.alexa.rank.AX, source.rankings.alexa.rank.AL, source.rankings.alexa.rank.DZ, source.rankings.alexa.rank.AS, source.rankings.alexa.rank.AD, source.rankings.alexa.rank.AO, source.rankings.alexa.rank.AI, source.rankings.alexa.rank.AQ, source.rankings.alexa.rank.AG, source.rankings.alexa.rank.AR, source.rankings.alexa.rank.AM, source.rankings.alexa.rank.AW, source.rankings.alexa.rank.AU, source.rankings.alexa.rank.AT, source.rankings.alexa.rank.AZ, source.rankings.alexa.rank.BS, source.rankings.alexa.rank.BH, source.rankings.alexa.rank.BD, source.rankings.alexa.rank.BB, source.rankings.alexa.rank.BY, source.rankings.alexa.rank.BE, source.rankings.alexa.rank.BZ, source.rankings.alexa.rank.BJ, source.rankings.alexa.rank.BM, source.rankings.alexa.rank.BT, source.rankings.alexa.rank.BO, source.rankings.alexa.rank.BQ, source.rankings.alexa.rank.BA, source.rankings.alexa.rank.BW, source.rankings.alexa.rank.BV, source.rankings.alexa.rank.BR, source.rankings.alexa.rank.IO, source.rankings.alexa.rank.BN, source.rankings.alexa.rank.BG, source.rankings.alexa.rank.BF, source.rankings.alexa.rank.BI, source.rankings.alexa.rank.KH, source.rankings.alexa.rank.CM, source.rankings.alexa.rank.CA, source.rankings.alexa.rank.CV, source.rankings.alexa.rank.KY, source.rankings.alexa.rank.CF, source.rankings.alexa.rank.TD, source.rankings.alexa.rank.CL, source.rankings.alexa.rank.CN, source.rankings.alexa.rank.CX, source.rankings.alexa.rank.CC, source.rankings.alexa.rank.CO, source.rankings.alexa.rank.KM, source.rankings.alexa.rank.CG, source.rankings.alexa.rank.CD, source.rankings.alexa.rank.CK, source.rankings.alexa.rank.CR, source.rankings.alexa.rank.CI, source.rankings.alexa.rank.HR, source.rankings.alexa.rank.CU, source.rankings.alexa.rank.CW, source.rankings.alexa.rank.CY, source.rankings.alexa.rank.CZ, source.rankings.alexa.rank.DK, source.rankings.alexa.rank.DJ, source.rankings.alexa.rank.DM, source.rankings.alexa.rank.DO, source.rankings.alexa.rank.EC, source.rankings.alexa.rank.EG, source.rankings.alexa.rank.SV, source.rankings.alexa.rank.GQ, source.rankings.alexa.rank.ER, source.rankings.alexa.rank.EE, source.rankings.alexa.rank.ET, source.rankings.alexa.rank.FK, source.rankings.alexa.rank.FO, source.rankings.alexa.rank.FJ, source.rankings.alexa.rank.FI, source.rankings.alexa.rank.FR, source.rankings.alexa.rank.GF, source.rankings.alexa.rank.PF, source.rankings.alexa.rank.TF, source.rankings.alexa.rank.GA, source.rankings.alexa.rank.GM, source.rankings.alexa.rank.GE, source.rankings.alexa.rank.DE, source.rankings.alexa.rank.GH, source.rankings.alexa.rank.GI, source.rankings.alexa.rank.GR, source.rankings.alexa.rank.GL, source.rankings.alexa.rank.GD, source.rankings.alexa.rank.GP, source.rankings.alexa.rank.GU, source.rankings.alexa.rank.GT, source.rankings.alexa.rank.GG, source.rankings.alexa.rank.GN, source.rankings.alexa.rank.GW, source.rankings.alexa.rank.GY, source.rankings.alexa.rank.HT, source.rankings.alexa.rank.HM, source.rankings.alexa.rank.VA, source.rankings.alexa.rank.HN, source.rankings.alexa.rank.HK, source.rankings.alexa.rank.HU, source.rankings.alexa.rank.IS, source.rankings.alexa.rank.IN, source.rankings.alexa.rank.ID, source.rankings.alexa.rank.IR, source.rankings.alexa.rank.IQ, source.rankings.alexa.rank.IE, source.rankings.alexa.rank.IM, source.rankings.alexa.rank.IL, source.rankings.alexa.rank.IT, source.rankings.alexa.rank.JM, source.rankings.alexa.rank.JP, source.rankings.alexa.rank.JE, source.rankings.alexa.rank.JO, source.rankings.alexa.rank.KZ, source.rankings.alexa.rank.KE, source.rankings.alexa.rank.KI, source.rankings.alexa.rank.KP, source.rankings.alexa.rank.KR, source.rankings.alexa.rank.KW, source.rankings.alexa.rank.KG, source.rankings.alexa.rank.LA, source.rankings.alexa.rank.LV, source.rankings.alexa.rank.LB, source.rankings.alexa.rank.LS, source.rankings.alexa.rank.LR, source.rankings.alexa.rank.LY, source.rankings.alexa.rank.LI, source.rankings.alexa.rank.LT, source.rankings.alexa.rank.LU, source.rankings.alexa.rank.MO, source.rankings.alexa.rank.MK, source.rankings.alexa.rank.MG, source.rankings.alexa.rank.MW, source.rankings.alexa.rank.MY, source.rankings.alexa.rank.MV, source.rankings.alexa.rank.ML, source.rankings.alexa.rank.MT, source.rankings.alexa.rank.MH, source.rankings.alexa.rank.MQ, source.rankings.alexa.rank.MR, source.rankings.alexa.rank.MU, source.rankings.alexa.rank.YT, source.rankings.alexa.rank.MX, source.rankings.alexa.rank.FM, source.rankings.alexa.rank.MD, source.rankings.alexa.rank.MC, source.rankings.alexa.rank.MN, source.rankings.alexa.rank.ME, source.rankings.alexa.rank.MS, source.rankings.alexa.rank.MA, source.rankings.alexa.rank.MZ, source.rankings.alexa.rank.MM, source.rankings.alexa.rank.NA, source.rankings.alexa.rank.NR, source.rankings.alexa.rank.NP, source.rankings.alexa.rank.NL, source.rankings.alexa.rank.NC, source.rankings.alexa.rank.NZ, source.rankings.alexa.rank.NI, source.rankings.alexa.rank.NE, source.rankings.alexa.rank.NG, source.rankings.alexa.rank.NU, source.rankings.alexa.rank.NF, source.rankings.alexa.rank.MP, source.rankings.alexa.rank.NO, source.rankings.alexa.rank.OM, source.rankings.alexa.rank.PK, source.rankings.alexa.rank.PW, source.rankings.alexa.rank.PS, source.rankings.alexa.rank.PA, source.rankings.alexa.rank.PG, source.rankings.alexa.rank.PY, source.rankings.alexa.rank.PE, source.rankings.alexa.rank.PH, source.rankings.alexa.rank.PN, source.rankings.alexa.rank.PL, source.rankings.alexa.rank.PT, source.rankings.alexa.rank.PR, source.rankings.alexa.rank.QA, source.rankings.alexa.rank.RE, source.rankings.alexa.rank.RO, source.rankings.alexa.rank.RU, source.rankings.alexa.rank.RW, source.rankings.alexa.rank.BL, source.rankings.alexa.rank.SH, source.rankings.alexa.rank.KN, source.rankings.alexa.rank.LC, source.rankings.alexa.rank.MF, source.rankings.alexa.rank.PM, source.rankings.alexa.rank.VC, source.rankings.alexa.rank.WS, source.rankings.alexa.rank.SM, source.rankings.alexa.rank.ST, source.rankings.alexa.rank.SA, source.rankings.alexa.rank.SN, source.rankings.alexa.rank.RS, source.rankings.alexa.rank.SC, source.rankings.alexa.rank.SL, source.rankings.alexa.rank.SG, source.rankings.alexa.rank.SX, source.rankings.alexa.rank.SK, source.rankings.alexa.rank.SI, source.rankings.alexa.rank.SB, source.rankings.alexa.rank.SO, source.rankings.alexa.rank.ZA, source.rankings.alexa.rank.GS, source.rankings.alexa.rank.SS, source.rankings.alexa.rank.ES, source.rankings.alexa.rank.LK, source.rankings.alexa.rank.SD, source.rankings.alexa.rank.SR, source.rankings.alexa.rank.SJ, source.rankings.alexa.rank.SZ, source.rankings.alexa.rank.SE, source.rankings.alexa.rank.CH, source.rankings.alexa.rank.SY, source.rankings.alexa.rank.TW, source.rankings.alexa.rank.TJ, source.rankings.alexa.rank.TZ, source.rankings.alexa.rank.TH, source.rankings.alexa.rank.TL, source.rankings.alexa.rank.TG, source.rankings.alexa.rank.TK, source.rankings.alexa.rank.TO, source.rankings.alexa.rank.TT, source.rankings.alexa.rank.TN, source.rankings.alexa.rank.TR, source.rankings.alexa.rank.TM, source.rankings.alexa.rank.TC, source.rankings.alexa.rank.TV, source.rankings.alexa.rank.UG, source.rankings.alexa.rank.UA, source.rankings.alexa.rank.AE, source.rankings.alexa.rank.GB, source.rankings.alexa.rank.US, source.rankings.alexa.rank.UM, source.rankings.alexa.rank.UY, source.rankings.alexa.rank.UZ, source.rankings.alexa.rank.VU, source.rankings.alexa.rank.VE, source.rankings.alexa.rank.VN, source.rankings.alexa.rank.VG, source.rankings.alexa.rank.VI, source.rankings.alexa.rank.WF, source.rankings.alexa.rank.EH, source.rankings.alexa.rank.YE, source.rankings.alexa.rank.ZM, source.rankings.alexa.rank.ZW]
 **sortDirection** | **string**| This parameter is used for changing the order direction of the result. | [optional] [default to desc] [enum: asc, desc]
 **cursor** | **string**| This parameter is used for finding a specific page. You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results). | [optional] [default to *]
 **perPage** | **int?**| This parameter is used for specifying number of items in each page You can read more about pagination of results [here](https://newsapi.aylien.com/docs/pagination-of-results) | [optional] [default to 10]

### Return type

[**Stories**](Stories.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtimeseries"></a>
# **ListTimeSeries**
> TimeSeriesList ListTimeSeries (List<long?> id = null, List<long?> notId = null, string title = null, string body = null, string text = null, List<string> language = null, List<string> notLanguage = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int?> categoriesLevel = null, List<int?> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, List<int?> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int?> sourceId = null, List<int?> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null, string publishedAtStart = null, string publishedAtEnd = null, string period = null)

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
        static void Main(string[] args)
        {
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();

            var id = new List<long?>();
            var notId = new List<long?>();
            var title = title_example;
            var body = body_example;
            var text = text_example;
            var language = new List<string>();
            var notLanguage = new List<string>();
            var categoriesTaxonomy = categoriesTaxonomy_example;
            var categoriesConfident = true;
            var categoriesId = new List<string>();
            var notCategoriesId = new List<string>();
            var categoriesLevel = new List<int?>();
            var notCategoriesLevel = new List<int?>();
            var entitiesTitleText = new List<string>();
            var notEntitiesTitleText = new List<string>();
            var entitiesTitleType = new List<string>();
            var notEntitiesTitleType = new List<string>();
            var entitiesTitleLinksDbpedia = new List<string>();
            var notEntitiesTitleLinksDbpedia = new List<string>();
            var entitiesBodyText = new List<string>();
            var notEntitiesBodyText = new List<string>();
            var entitiesBodyType = new List<string>();
            var notEntitiesBodyType = new List<string>();
            var entitiesBodyLinksDbpedia = new List<string>();
            var notEntitiesBodyLinksDbpedia = new List<string>();
            var sentimentTitlePolarity = sentimentTitlePolarity_example;
            var notSentimentTitlePolarity = notSentimentTitlePolarity_example;
            var sentimentBodyPolarity = sentimentBodyPolarity_example;
            var notSentimentBodyPolarity = notSentimentBodyPolarity_example;
            var mediaImagesCountMin = 56;
            var mediaImagesCountMax = 56;
            var mediaImagesWidthMin = 56;
            var mediaImagesWidthMax = 56;
            var mediaImagesHeightMin = 56;
            var mediaImagesHeightMax = 56;
            var mediaImagesContentLengthMin = 56;
            var mediaImagesContentLengthMax = 56;
            var mediaImagesFormat = new List<string>();
            var notMediaImagesFormat = new List<string>();
            var mediaVideosCountMin = 56;
            var mediaVideosCountMax = 56;
            var authorId = new List<int?>();
            var notAuthorId = new List<int?>();
            var authorName = authorName_example;
            var notAuthorName = notAuthorName_example;
            var sourceId = new List<int?>();
            var notSourceId = new List<int?>();
            var sourceName = new List<string>();
            var notSourceName = new List<string>();
            var sourceDomain = new List<string>();
            var notSourceDomain = new List<string>();
            var sourceLocationsCountry = new List<string>();
            var notSourceLocationsCountry = new List<string>();
            var sourceLocationsState = new List<string>();
            var notSourceLocationsState = new List<string>();
            var sourceLocationsCity = new List<string>();
            var notSourceLocationsCity = new List<string>();
            var sourceScopesCountry = new List<string>();
            var notSourceScopesCountry = new List<string>();
            var sourceScopesState = new List<string>();
            var notSourceScopesState = new List<string>();
            var sourceScopesCity = new List<string>();
            var notSourceScopesCity = new List<string>();
            var sourceScopesLevel = new List<string>();
            var notSourceScopesLevel = new List<string>();
            var sourceLinksInCountMin = 56;
            var sourceLinksInCountMax = 56;
            var sourceRankingsAlexaRankMin = 56;
            var sourceRankingsAlexaRankMax = 56;
            var sourceRankingsAlexaCountry = new List<string>();
            var socialSharesCountFacebookMin = 56;
            var socialSharesCountFacebookMax = 56;
            var socialSharesCountGooglePlusMin = 56;
            var socialSharesCountGooglePlusMax = 56;
            var socialSharesCountLinkedinMin = 56;
            var socialSharesCountLinkedinMax = 56;
            var socialSharesCountRedditMin = 56;
            var socialSharesCountRedditMax = 56;
            var publishedAtStart = publishedAtStart_example;
            var publishedAtEnd = publishedAtEnd_example;
            var period = period_example;

            try
            {
                // List time series
                TimeSeriesList result = apiInstance.ListTimeSeries(
                    id: id,
                    notId: notId,
                    title: title,
                    body: body,
                    text: text,
                    language: language,
                    notLanguage: notLanguage,
                    categoriesTaxonomy: categoriesTaxonomy,
                    categoriesConfident: categoriesConfident,
                    categoriesId: categoriesId,
                    notCategoriesId: notCategoriesId,
                    categoriesLevel: categoriesLevel,
                    notCategoriesLevel: notCategoriesLevel,
                    entitiesTitleText: entitiesTitleText,
                    notEntitiesTitleText: notEntitiesTitleText,
                    entitiesTitleType: entitiesTitleType,
                    notEntitiesTitleType: notEntitiesTitleType,
                    entitiesTitleLinksDbpedia: entitiesTitleLinksDbpedia,
                    notEntitiesTitleLinksDbpedia: notEntitiesTitleLinksDbpedia,
                    entitiesBodyText: entitiesBodyText,
                    notEntitiesBodyText: notEntitiesBodyText,
                    entitiesBodyType: entitiesBodyType,
                    notEntitiesBodyType: notEntitiesBodyType,
                    entitiesBodyLinksDbpedia: entitiesBodyLinksDbpedia,
                    notEntitiesBodyLinksDbpedia: notEntitiesBodyLinksDbpedia,
                    sentimentTitlePolarity: sentimentTitlePolarity,
                    notSentimentTitlePolarity: notSentimentTitlePolarity,
                    sentimentBodyPolarity: sentimentBodyPolarity,
                    notSentimentBodyPolarity: notSentimentBodyPolarity,
                    mediaImagesCountMin: mediaImagesCountMin,
                    mediaImagesCountMax: mediaImagesCountMax,
                    mediaImagesWidthMin: mediaImagesWidthMin,
                    mediaImagesWidthMax: mediaImagesWidthMax,
                    mediaImagesHeightMin: mediaImagesHeightMin,
                    mediaImagesHeightMax: mediaImagesHeightMax,
                    mediaImagesContentLengthMin: mediaImagesContentLengthMin,
                    mediaImagesContentLengthMax: mediaImagesContentLengthMax,
                    mediaImagesFormat: mediaImagesFormat,
                    notMediaImagesFormat: notMediaImagesFormat,
                    mediaVideosCountMin: mediaVideosCountMin,
                    mediaVideosCountMax: mediaVideosCountMax,
                    authorId: authorId,
                    notAuthorId: notAuthorId,
                    authorName: authorName,
                    notAuthorName: notAuthorName,
                    sourceId: sourceId,
                    notSourceId: notSourceId,
                    sourceName: sourceName,
                    notSourceName: notSourceName,
                    sourceDomain: sourceDomain,
                    notSourceDomain: notSourceDomain,
                    sourceLocationsCountry: sourceLocationsCountry,
                    notSourceLocationsCountry: notSourceLocationsCountry,
                    sourceLocationsState: sourceLocationsState,
                    notSourceLocationsState: notSourceLocationsState,
                    sourceLocationsCity: sourceLocationsCity,
                    notSourceLocationsCity: notSourceLocationsCity,
                    sourceScopesCountry: sourceScopesCountry,
                    notSourceScopesCountry: notSourceScopesCountry,
                    sourceScopesState: sourceScopesState,
                    notSourceScopesState: notSourceScopesState,
                    sourceScopesCity: sourceScopesCity,
                    notSourceScopesCity: notSourceScopesCity,
                    sourceScopesLevel: sourceScopesLevel,
                    notSourceScopesLevel: notSourceScopesLevel,
                    sourceLinksInCountMin: sourceLinksInCountMin,
                    sourceLinksInCountMax: sourceLinksInCountMax,
                    sourceRankingsAlexaRankMin: sourceRankingsAlexaRankMin,
                    sourceRankingsAlexaRankMax: sourceRankingsAlexaRankMax,
                    sourceRankingsAlexaCountry: sourceRankingsAlexaCountry,
                    socialSharesCountFacebookMin: socialSharesCountFacebookMin,
                    socialSharesCountFacebookMax: socialSharesCountFacebookMax,
                    socialSharesCountGooglePlusMin: socialSharesCountGooglePlusMin,
                    socialSharesCountGooglePlusMax: socialSharesCountGooglePlusMax,
                    socialSharesCountLinkedinMin: socialSharesCountLinkedinMin,
                    socialSharesCountLinkedinMax: socialSharesCountLinkedinMax,
                    socialSharesCountRedditMin: socialSharesCountRedditMin,
                    socialSharesCountRedditMax: socialSharesCountRedditMax,
                    publishedAtStart: publishedAtStart,
                    publishedAtEnd: publishedAtEnd,
                    period: period
                );
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
 **id** | **List&lt;long?&gt;**| This parameter is used for finding stories by story id. | [optional] 
 **notId** | **List&lt;long?&gt;**| This parameter is used for excluding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional]  [enum: iab-qag, iptc-subjectcode]
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | **List&lt;string&gt;**| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesId** | **List&lt;string&gt;**| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | **List&lt;int?&gt;**| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesLevel** | **List&lt;int?&gt;**| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **notAuthorId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **notSourceId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose source id is the specified value. | [optional] 
 **sourceName** | **List&lt;string&gt;**| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **notSourceName** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | **List&lt;string&gt;**| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **notSourceDomain** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | **List&lt;string&gt;**| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
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
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtrends"></a>
# **ListTrends**
> Trends ListTrends (string field, List<long?> id = null, List<long?> notId = null, string title = null, string body = null, string text = null, List<string> language = null, List<string> notLanguage = null, string publishedAtStart = null, string publishedAtEnd = null, string categoriesTaxonomy = null, bool? categoriesConfident = null, List<string> categoriesId = null, List<string> notCategoriesId = null, List<int?> categoriesLevel = null, List<int?> notCategoriesLevel = null, List<string> entitiesTitleText = null, List<string> notEntitiesTitleText = null, List<string> entitiesTitleType = null, List<string> notEntitiesTitleType = null, List<string> entitiesTitleLinksDbpedia = null, List<string> notEntitiesTitleLinksDbpedia = null, List<string> entitiesBodyText = null, List<string> notEntitiesBodyText = null, List<string> entitiesBodyType = null, List<string> notEntitiesBodyType = null, List<string> entitiesBodyLinksDbpedia = null, List<string> notEntitiesBodyLinksDbpedia = null, string sentimentTitlePolarity = null, string notSentimentTitlePolarity = null, string sentimentBodyPolarity = null, string notSentimentBodyPolarity = null, int? mediaImagesCountMin = null, int? mediaImagesCountMax = null, int? mediaImagesWidthMin = null, int? mediaImagesWidthMax = null, int? mediaImagesHeightMin = null, int? mediaImagesHeightMax = null, int? mediaImagesContentLengthMin = null, int? mediaImagesContentLengthMax = null, List<string> mediaImagesFormat = null, List<string> notMediaImagesFormat = null, int? mediaVideosCountMin = null, int? mediaVideosCountMax = null, List<int?> authorId = null, List<int?> notAuthorId = null, string authorName = null, string notAuthorName = null, List<int?> sourceId = null, List<int?> notSourceId = null, List<string> sourceName = null, List<string> notSourceName = null, List<string> sourceDomain = null, List<string> notSourceDomain = null, List<string> sourceLocationsCountry = null, List<string> notSourceLocationsCountry = null, List<string> sourceLocationsState = null, List<string> notSourceLocationsState = null, List<string> sourceLocationsCity = null, List<string> notSourceLocationsCity = null, List<string> sourceScopesCountry = null, List<string> notSourceScopesCountry = null, List<string> sourceScopesState = null, List<string> notSourceScopesState = null, List<string> sourceScopesCity = null, List<string> notSourceScopesCity = null, List<string> sourceScopesLevel = null, List<string> notSourceScopesLevel = null, int? sourceLinksInCountMin = null, int? sourceLinksInCountMax = null, int? sourceRankingsAlexaRankMin = null, int? sourceRankingsAlexaRankMax = null, List<string> sourceRankingsAlexaCountry = null, int? socialSharesCountFacebookMin = null, int? socialSharesCountFacebookMax = null, int? socialSharesCountGooglePlusMin = null, int? socialSharesCountGooglePlusMax = null, int? socialSharesCountLinkedinMin = null, int? socialSharesCountLinkedinMax = null, int? socialSharesCountRedditMin = null, int? socialSharesCountRedditMax = null)

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
        static void Main(string[] args)
        {
            // Configure API key authorization: app_id
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

            // Configure API key authorization: app_key
            Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();

            var field = field_example;
            var id = new List<long?>();
            var notId = new List<long?>();
            var title = title_example;
            var body = body_example;
            var text = text_example;
            var language = new List<string>();
            var notLanguage = new List<string>();
            var publishedAtStart = publishedAtStart_example;
            var publishedAtEnd = publishedAtEnd_example;
            var categoriesTaxonomy = categoriesTaxonomy_example;
            var categoriesConfident = true;
            var categoriesId = new List<string>();
            var notCategoriesId = new List<string>();
            var categoriesLevel = new List<int?>();
            var notCategoriesLevel = new List<int?>();
            var entitiesTitleText = new List<string>();
            var notEntitiesTitleText = new List<string>();
            var entitiesTitleType = new List<string>();
            var notEntitiesTitleType = new List<string>();
            var entitiesTitleLinksDbpedia = new List<string>();
            var notEntitiesTitleLinksDbpedia = new List<string>();
            var entitiesBodyText = new List<string>();
            var notEntitiesBodyText = new List<string>();
            var entitiesBodyType = new List<string>();
            var notEntitiesBodyType = new List<string>();
            var entitiesBodyLinksDbpedia = new List<string>();
            var notEntitiesBodyLinksDbpedia = new List<string>();
            var sentimentTitlePolarity = sentimentTitlePolarity_example;
            var notSentimentTitlePolarity = notSentimentTitlePolarity_example;
            var sentimentBodyPolarity = sentimentBodyPolarity_example;
            var notSentimentBodyPolarity = notSentimentBodyPolarity_example;
            var mediaImagesCountMin = 56;
            var mediaImagesCountMax = 56;
            var mediaImagesWidthMin = 56;
            var mediaImagesWidthMax = 56;
            var mediaImagesHeightMin = 56;
            var mediaImagesHeightMax = 56;
            var mediaImagesContentLengthMin = 56;
            var mediaImagesContentLengthMax = 56;
            var mediaImagesFormat = new List<string>();
            var notMediaImagesFormat = new List<string>();
            var mediaVideosCountMin = 56;
            var mediaVideosCountMax = 56;
            var authorId = new List<int?>();
            var notAuthorId = new List<int?>();
            var authorName = authorName_example;
            var notAuthorName = notAuthorName_example;
            var sourceId = new List<int?>();
            var notSourceId = new List<int?>();
            var sourceName = new List<string>();
            var notSourceName = new List<string>();
            var sourceDomain = new List<string>();
            var notSourceDomain = new List<string>();
            var sourceLocationsCountry = new List<string>();
            var notSourceLocationsCountry = new List<string>();
            var sourceLocationsState = new List<string>();
            var notSourceLocationsState = new List<string>();
            var sourceLocationsCity = new List<string>();
            var notSourceLocationsCity = new List<string>();
            var sourceScopesCountry = new List<string>();
            var notSourceScopesCountry = new List<string>();
            var sourceScopesState = new List<string>();
            var notSourceScopesState = new List<string>();
            var sourceScopesCity = new List<string>();
            var notSourceScopesCity = new List<string>();
            var sourceScopesLevel = new List<string>();
            var notSourceScopesLevel = new List<string>();
            var sourceLinksInCountMin = 56;
            var sourceLinksInCountMax = 56;
            var sourceRankingsAlexaRankMin = 56;
            var sourceRankingsAlexaRankMax = 56;
            var sourceRankingsAlexaCountry = new List<string>();
            var socialSharesCountFacebookMin = 56;
            var socialSharesCountFacebookMax = 56;
            var socialSharesCountGooglePlusMin = 56;
            var socialSharesCountGooglePlusMax = 56;
            var socialSharesCountLinkedinMin = 56;
            var socialSharesCountLinkedinMax = 56;
            var socialSharesCountRedditMin = 56;
            var socialSharesCountRedditMax = 56;

            try
            {
                // List trends
                Trends result = apiInstance.ListTrends(
                    field: field,
                    id: id,
                    notId: notId,
                    title: title,
                    body: body,
                    text: text,
                    language: language,
                    notLanguage: notLanguage,
                    publishedAtStart: publishedAtStart,
                    publishedAtEnd: publishedAtEnd,
                    categoriesTaxonomy: categoriesTaxonomy,
                    categoriesConfident: categoriesConfident,
                    categoriesId: categoriesId,
                    notCategoriesId: notCategoriesId,
                    categoriesLevel: categoriesLevel,
                    notCategoriesLevel: notCategoriesLevel,
                    entitiesTitleText: entitiesTitleText,
                    notEntitiesTitleText: notEntitiesTitleText,
                    entitiesTitleType: entitiesTitleType,
                    notEntitiesTitleType: notEntitiesTitleType,
                    entitiesTitleLinksDbpedia: entitiesTitleLinksDbpedia,
                    notEntitiesTitleLinksDbpedia: notEntitiesTitleLinksDbpedia,
                    entitiesBodyText: entitiesBodyText,
                    notEntitiesBodyText: notEntitiesBodyText,
                    entitiesBodyType: entitiesBodyType,
                    notEntitiesBodyType: notEntitiesBodyType,
                    entitiesBodyLinksDbpedia: entitiesBodyLinksDbpedia,
                    notEntitiesBodyLinksDbpedia: notEntitiesBodyLinksDbpedia,
                    sentimentTitlePolarity: sentimentTitlePolarity,
                    notSentimentTitlePolarity: notSentimentTitlePolarity,
                    sentimentBodyPolarity: sentimentBodyPolarity,
                    notSentimentBodyPolarity: notSentimentBodyPolarity,
                    mediaImagesCountMin: mediaImagesCountMin,
                    mediaImagesCountMax: mediaImagesCountMax,
                    mediaImagesWidthMin: mediaImagesWidthMin,
                    mediaImagesWidthMax: mediaImagesWidthMax,
                    mediaImagesHeightMin: mediaImagesHeightMin,
                    mediaImagesHeightMax: mediaImagesHeightMax,
                    mediaImagesContentLengthMin: mediaImagesContentLengthMin,
                    mediaImagesContentLengthMax: mediaImagesContentLengthMax,
                    mediaImagesFormat: mediaImagesFormat,
                    notMediaImagesFormat: notMediaImagesFormat,
                    mediaVideosCountMin: mediaVideosCountMin,
                    mediaVideosCountMax: mediaVideosCountMax,
                    authorId: authorId,
                    notAuthorId: notAuthorId,
                    authorName: authorName,
                    notAuthorName: notAuthorName,
                    sourceId: sourceId,
                    notSourceId: notSourceId,
                    sourceName: sourceName,
                    notSourceName: notSourceName,
                    sourceDomain: sourceDomain,
                    notSourceDomain: notSourceDomain,
                    sourceLocationsCountry: sourceLocationsCountry,
                    notSourceLocationsCountry: notSourceLocationsCountry,
                    sourceLocationsState: sourceLocationsState,
                    notSourceLocationsState: notSourceLocationsState,
                    sourceLocationsCity: sourceLocationsCity,
                    notSourceLocationsCity: notSourceLocationsCity,
                    sourceScopesCountry: sourceScopesCountry,
                    notSourceScopesCountry: notSourceScopesCountry,
                    sourceScopesState: sourceScopesState,
                    notSourceScopesState: notSourceScopesState,
                    sourceScopesCity: sourceScopesCity,
                    notSourceScopesCity: notSourceScopesCity,
                    sourceScopesLevel: sourceScopesLevel,
                    notSourceScopesLevel: notSourceScopesLevel,
                    sourceLinksInCountMin: sourceLinksInCountMin,
                    sourceLinksInCountMax: sourceLinksInCountMax,
                    sourceRankingsAlexaRankMin: sourceRankingsAlexaRankMin,
                    sourceRankingsAlexaRankMax: sourceRankingsAlexaRankMax,
                    sourceRankingsAlexaCountry: sourceRankingsAlexaCountry,
                    socialSharesCountFacebookMin: socialSharesCountFacebookMin,
                    socialSharesCountFacebookMax: socialSharesCountFacebookMax,
                    socialSharesCountGooglePlusMin: socialSharesCountGooglePlusMin,
                    socialSharesCountGooglePlusMax: socialSharesCountGooglePlusMax,
                    socialSharesCountLinkedinMin: socialSharesCountLinkedinMin,
                    socialSharesCountLinkedinMax: socialSharesCountLinkedinMax,
                    socialSharesCountRedditMin: socialSharesCountRedditMin,
                    socialSharesCountRedditMax: socialSharesCountRedditMax
                );
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
 **field** | **string**| This parameter is used to specify the trend field. |  [enum: author.name, source.name, source.domain, keywords, entities.title.text, entities.title.type, entities.title.links.dbpedia, entities.body.text, entities.body.type, entities.body.links.dbpedia, hashtags, categories.id, sentiment.title.polarity, sentiment.body.polarity]
 **id** | **List&lt;long?&gt;**| This parameter is used for finding stories by story id. | [optional] 
 **notId** | **List&lt;long?&gt;**| This parameter is used for excluding stories by story id. | [optional] 
 **title** | **string**| This parameter is used for finding stories whose title contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **body** | **string**| This parameter is used for finding stories whose body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **text** | **string**| This parameter is used for finding stories whose title or body contains a specfic keyword. It supports [boolean operators](https://newsapi.aylien.com/docs/boolean-operators). | [optional] 
 **language** | **List&lt;string&gt;**| This parameter is used for finding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **notLanguage** | **List&lt;string&gt;**| This parameter is used for excluding stories whose language is the specified value. It supports [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language codes. | [optional]  [enum: en, de, fr, it, es, pt]
 **publishedAtStart** | **string**| This parameter is used for finding stories whose published at time is greater than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **publishedAtEnd** | **string**| This parameter is used for finding stories whose published at time is less than the specified value. [Here](https://newsapi.aylien.com/docs/working-with-dates) you can find more information about how [to work with dates](https://newsapi.aylien.com/docs/working-with-dates). | [optional] 
 **categoriesTaxonomy** | **string**| This parameter is used for defining the type of the taxonomy for the rest of the categories queries. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional]  [enum: iab-qag, iptc-subjectcode]
 **categoriesConfident** | **bool?**| This parameter is used for finding stories whose categories are confident. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] [default to true]
 **categoriesId** | **List&lt;string&gt;**| This parameter is used for finding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesId** | **List&lt;string&gt;**| This parameter is used for excluding stories by categories id. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **categoriesLevel** | **List&lt;int?&gt;**| This parameter is used for finding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **notCategoriesLevel** | **List&lt;int?&gt;**| This parameter is used for excluding stories by categories level. You can read more about working with categories [here](https://newsapi.aylien.com/docs/working-with-categories). | [optional] 
 **entitiesTitleText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesTitleLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in story titles. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyText** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyText** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;text&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyType** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyType** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities &#x60;type&#x60; in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **entitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to find stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **notEntitiesBodyLinksDbpedia** | **List&lt;string&gt;**| This parameter is used to exclude stories based on the specified entities dbpedia URL in the body of stories. You can read more about working with entities [here](https://newsapi.aylien.com/docs/working-with-entities). | [optional] 
 **sentimentTitlePolarity** | **string**| This parameter is used for finding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentTitlePolarity** | **string**| This parameter is used for excluding stories whose title sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **sentimentBodyPolarity** | **string**| This parameter is used for finding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **notSentimentBodyPolarity** | **string**| This parameter is used for excluding stories whose body sentiment is the specified value. | [optional]  [enum: positive, neutral, negative]
 **mediaImagesCountMin** | **int?**| This parameter is used for finding stories whose number of images is greater than or equal to the specified value. | [optional] 
 **mediaImagesCountMax** | **int?**| This parameter is used for finding stories whose number of images is less than or equal to the specified value. | [optional] 
 **mediaImagesWidthMin** | **int?**| This parameter is used for finding stories whose width of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesWidthMax** | **int?**| This parameter is used for finding stories whose width of images are less than or equal to the specified value. | [optional] 
 **mediaImagesHeightMin** | **int?**| This parameter is used for finding stories whose height of images are greater than or equal to the specified value. | [optional] 
 **mediaImagesHeightMax** | **int?**| This parameter is used for finding stories whose height of images are less than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMin** | **int?**| This parameter is used for finding stories whose images content length are greater than or equal to the specified value. | [optional] 
 **mediaImagesContentLengthMax** | **int?**| This parameter is used for finding stories whose images content length are less than or equal to the specified value. | [optional] 
 **mediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for finding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **notMediaImagesFormat** | **List&lt;string&gt;**| This parameter is used for excluding stories whose images format are the specified value. | [optional]  [enum: BMP, GIF, JPEG, PNG, TIFF, PSD, ICO, CUR, WEBP, SVG]
 **mediaVideosCountMin** | **int?**| This parameter is used for finding stories whose number of videos is greater than or equal to the specified value. | [optional] 
 **mediaVideosCountMax** | **int?**| This parameter is used for finding stories whose number of videos is less than or equal to the specified value. | [optional] 
 **authorId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose author id is the specified value. | [optional] 
 **notAuthorId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose author id is the specified value. | [optional] 
 **authorName** | **string**| This parameter is used for finding stories whose author full name contains the specified value. | [optional] 
 **notAuthorName** | **string**| This parameter is used for excluding stories whose author full name contains the specified value. | [optional] 
 **sourceId** | **List&lt;int?&gt;**| This parameter is used for finding stories whose source id is the specified value. | [optional] 
 **notSourceId** | **List&lt;int?&gt;**| This parameter is used for excluding stories whose source id is the specified value. | [optional] 
 **sourceName** | **List&lt;string&gt;**| This parameter is used for finding stories whose source name contains the specified value. | [optional] 
 **notSourceName** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source name contains the specified value. | [optional] 
 **sourceDomain** | **List&lt;string&gt;**| This parameter is used for finding stories whose source domain is the specified value. | [optional] 
 **notSourceDomain** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source domain is the specified value. | [optional] 
 **sourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source country is the specified value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source state/province is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceLocationsCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source city is the specified value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCountry** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesState** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesState** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified state/province value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesCity** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **notSourceScopesCity** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified city value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional] 
 **sourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for finding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **notSourceScopesLevel** | **List&lt;string&gt;**| This parameter is used for excluding stories whose source scopes is the specified level value. [Here](https://newsapi.aylien.com/docs/working-with-locations) you can find more information about how [to work with locations](https://newsapi.aylien.com/docs/working-with-locations). | [optional]  [enum: international, national, local]
 **sourceLinksInCountMin** | **int?**| This parameter is used for finding stories from sources whose Links in count is greater than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceLinksInCountMax** | **int?**| This parameter is used for finding stories from sources whose Links in count is less than or equal to the specified value. You can read more about working with Links in count [here](https://newsapi.aylien.com/docs/working-with-links-in-count). | [optional] 
 **sourceRankingsAlexaRankMin** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is greater than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaRankMax** | **int?**| This parameter is used for finding stories from sources whose Alexa rank is less than or equal to the specified value. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **sourceRankingsAlexaCountry** | **List&lt;string&gt;**| This parameter is used for finding stories from sources whose Alexa rank is in the specified country value. It supports [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. You can read more about working with Alexa ranks [here](https://newsapi.aylien.com/docs/working-with-alexa-ranks). | [optional] 
 **socialSharesCountFacebookMin** | **int?**| This parameter is used for finding stories whose Facebook social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountFacebookMax** | **int?**| This parameter is used for finding stories whose Facebook social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMin** | **int?**| This parameter is used for finding stories whose Google+ social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountGooglePlusMax** | **int?**| This parameter is used for finding stories whose Google+ social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMin** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountLinkedinMax** | **int?**| This parameter is used for finding stories whose LinkedIn social shares count is less than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMin** | **int?**| This parameter is used for finding stories whose Reddit social shares count is greater than or equal to the specified value. | [optional] 
 **socialSharesCountRedditMax** | **int?**| This parameter is used for finding stories whose Reddit social shares count is less than or equal to the specified value. | [optional] 

### Return type

[**Trends**](Trends.md)

### Authorization

[app_key](../README.md#app_key), [app_id](../README.md#app_id)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

