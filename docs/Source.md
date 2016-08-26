# Aylien.NewsApi.Model.Source
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The source id which is a unique value | [optional] 
**Name** | **string** | The source name | [optional] 
**Title** | **string** | The title of the home page URL | [optional] 
**Description** | **string** | A general explanation about the source | [optional] 
**LinksInCount** | **int?** | The number of websites that link to the source | [optional] 
**HomePageUrl** | **string** | The home page URL of the source | [optional] 
**Domain** | **string** | The domain name of the source which is extracted from the source URL | [optional] 
**LogoUrl** | **string** | A URL which points to the source logo | [optional] 
**Locations** | [**List&lt;Location&gt;**](Location.md) | The source locations which are tend to be the physical locations of the source, e.g. BBC headquarter is located in London. | [optional] 
**Scopes** | [**List&lt;Scope&gt;**](Scope.md) | The source scopes which is tend to be scope locations of the source, e.g. BBC scopes is international. | [optional] 
**Rankings** | [**Rankings**](Rankings.md) | The web rankings of the source | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

