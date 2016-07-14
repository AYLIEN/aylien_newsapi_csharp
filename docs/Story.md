# Aylien.NewsApi.Model.Story
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | ID of the story which is a unique identification | [optional] 
**Title** | **string** | Title of the story | [optional] 
**Body** | **string** | Body of the story | [optional] 
**Summary** | [**Summary**](Summary.md) | The suggested story summary | [optional] 
**Source** | [**Source**](Source.md) | The story source | [optional] 
**Author** | [**Author**](Author.md) | The story author | [optional] 
**Entities** | [**Entities**](Entities.md) | Extracted entities from the story title or body | [optional] 
**Keywords** | **List&lt;string&gt;** | Extracted keywords mentioned in the story title or body | [optional] 
**Hashtags** | **List&lt;string&gt;** | An array of suggested Story hashtags | [optional] 
**CharactersCount** | **int?** | Character count of the story body | [optional] 
**WordsCount** | **int?** | Word count of the story body | [optional] 
**SentencesCount** | **int?** | Sentence count of the story body | [optional] 
**ParagraphsCount** | **int?** | Paragraph count of the story body | [optional] 
**Categories** | [**List&lt;Category&gt;**](Category.md) | Suggested categories for the story | [optional] 
**SocialSharesCount** | [**ShareCounts**](ShareCounts.md) | Social shares count for the story | [optional] 
**Media** | [**List&lt;Media&gt;**](Media.md) | An array of extracted media such as images and videos | [optional] 
**Sentiment** | [**Sentiments**](Sentiments.md) | Suggested sentiments for the story title or body | [optional] 
**Language** | **string** | Language of the story | [optional] 
**PublishedAt** | **DateTime?** | Published date of the story | [optional] 
**Links** | [**StoryLinks**](StoryLinks.md) | Links which is related to the story | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

