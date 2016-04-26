# AYLIEN News API

AYLIEN News API is the most powerful way of sourcing, searching and syndicating analyzed and enriched news content. If you haven't already done so, you will need to [sign up](https://newsapi.aylien.com/signup).


## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)


## Installation

### NuGet
To install, use nuget package manager:

```PowerShell
PM> Install-Package Aylien.NewsApi
```

### Manual
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] `compile.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using Aylien.NewsApi.Api;
using Aylien.NewsApi.Client;
using Aylien.NewsApi.Model;
using System.Collections.Generic;

namespace Example
{
    public class Example
    {
        static void Main(string[] args)
        {
            
            // Configure API key authorization: app_id
			Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-ID", "YOUR_APP_ID");

			// Configure API key authorization: app_key
			Configuration.Default.ApiKey.Add("X-AYLIEN-NewsAPI-Application-Key", "YOUR_APP_KEY");

            var apiInstance = new DefaultApi();
            
            string title = "trump";
            string since = "NOW-7DAYS";
            string until = "NOW";
            string sortBy = "social_shares_count.facebook";
            List<String> language = new List<String> { "en" };
            List<String> entities = new List<String> {
                "http://dbpedia.org/resource/Donald_Trump",
                "http://dbpedia.org/resource/Hillary_Rodham_Clinton"
            };

            try
            {
                // List stories
                Stories result = apiInstance.ListStories(title: title, publishedAtStart: since, publishedAtEnd: until, language: language, entitiesBodyLinksDbpedia: entities, sortBy: sortBy);
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

## Documentation for API Endpoints

All URIs are relative to *https://api.newsapi.aylien.com/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**ListAutocompletes**](docs/DefaultApi.md#listautocompletes) | **GET** /autocompletes | List autocompletes
*DefaultApi* | [**ListCoverages**](docs/DefaultApi.md#listcoverages) | **POST** /coverages | List coverages
*DefaultApi* | [**ListHistograms**](docs/DefaultApi.md#listhistograms) | **GET** /histograms | List histograms
*DefaultApi* | [**ListRelatedStories**](docs/DefaultApi.md#listrelatedstories) | **POST** /related_stories | List related stories
*DefaultApi* | [**ListStories**](docs/DefaultApi.md#liststories) | **GET** /stories | List Stories
*DefaultApi* | [**ListTimeSeries**](docs/DefaultApi.md#listtimeseries) | **GET** /time_series | List time series
*DefaultApi* | [**ListTrends**](docs/DefaultApi.md#listtrends) | **GET** /trends | List trends


## Documentation for Models

 - [Aylien.NewsApi.Model.Author](docs/Author.md)
 - [Aylien.NewsApi.Model.Autocomplete](docs/Autocomplete.md)
 - [Aylien.NewsApi.Model.Autocompletes](docs/Autocompletes.md)
 - [Aylien.NewsApi.Model.Category](docs/Category.md)
 - [Aylien.NewsApi.Model.CategoryLinks](docs/CategoryLinks.md)
 - [Aylien.NewsApi.Model.Coverages](docs/Coverages.md)
 - [Aylien.NewsApi.Model.Entities](docs/Entities.md)
 - [Aylien.NewsApi.Model.Entity](docs/Entity.md)
 - [Aylien.NewsApi.Model.EntityLinks](docs/EntityLinks.md)
 - [Aylien.NewsApi.Model.Error](docs/Error.md)
 - [Aylien.NewsApi.Model.ErrorLinks](docs/ErrorLinks.md)
 - [Aylien.NewsApi.Model.Errors](docs/Errors.md)
 - [Aylien.NewsApi.Model.HistogramInterval](docs/HistogramInterval.md)
 - [Aylien.NewsApi.Model.Histograms](docs/Histograms.md)
 - [Aylien.NewsApi.Model.Location](docs/Location.md)
 - [Aylien.NewsApi.Model.Media](docs/Media.md)
 - [Aylien.NewsApi.Model.RelatedStories](docs/RelatedStories.md)
 - [Aylien.NewsApi.Model.Scope](docs/Scope.md)
 - [Aylien.NewsApi.Model.Sentiment](docs/Sentiment.md)
 - [Aylien.NewsApi.Model.Sentiments](docs/Sentiments.md)
 - [Aylien.NewsApi.Model.ShareCount](docs/ShareCount.md)
 - [Aylien.NewsApi.Model.ShareCounts](docs/ShareCounts.md)
 - [Aylien.NewsApi.Model.Source](docs/Source.md)
 - [Aylien.NewsApi.Model.Stories](docs/Stories.md)
 - [Aylien.NewsApi.Model.Story](docs/Story.md)
 - [Aylien.NewsApi.Model.StoryCluster](docs/StoryCluster.md)
 - [Aylien.NewsApi.Model.StoryLinks](docs/StoryLinks.md)
 - [Aylien.NewsApi.Model.Summary](docs/Summary.md)
 - [Aylien.NewsApi.Model.TimeSeries](docs/TimeSeries.md)
 - [Aylien.NewsApi.Model.TimeSeriesList](docs/TimeSeriesList.md)
 - [Aylien.NewsApi.Model.Trend](docs/Trend.md)
 - [Aylien.NewsApi.Model.Trends](docs/Trends.md)


## Documentation for Authorization

### app_id

- **Type**: API key
- **API key parameter name**: X-AYLIEN-NewsAPI-Application-ID
- **Location**: HTTP header

### app_key

- **Type**: API key
- **API key parameter name**: X-AYLIEN-NewsAPI-Application-Key
- **Location**: HTTP header
