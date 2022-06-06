# Spoonacular.Api.IngredientsApi

All URIs are relative to *https://api.spoonacular.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IngredientsByIDImage**](IngredientsApi.md#ingredientsbyidimage) | **GET** /recipes/{id}/ingredientWidget.png | Ingredients by ID Image
[**VisualizeIngredients**](IngredientsApi.md#visualizeingredients) | **POST** /recipes/visualizeIngredients | Ingredients Widget


<a name="ingredientsbyidimage"></a>
# **IngredientsByIDImage**
> Object IngredientsByIDImage (decimal id, string? measure = null)

Ingredients by ID Image

Visualize a recipe's ingredient list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class IngredientsByIDImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spoonacular.com";
            // Configure API key authorization: apiKeyScheme
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new IngredientsApi(config);
            var id = 1082038;  // decimal | The recipe id.
            var measure = metric;  // string? | Whether the the measures should be 'us' or 'metric'. (optional) 

            try
            {
                // Ingredients by ID Image
                Object result = apiInstance.IngredientsByIDImage(id, measure);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngredientsApi.IngredientsByIDImage: " + e.Message );
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
 **id** | **decimal**| The recipe id. | 
 **measure** | **string?**| Whether the the measures should be &#39;us&#39; or &#39;metric&#39;. | [optional] 

### Return type

**Object**

### Authorization

[apiKeyScheme](../README.md#apiKeyScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="visualizeingredients"></a>
# **VisualizeIngredients**
> string VisualizeIngredients (string? contentType = null, string? language = null, string? accept = null)

Ingredients Widget

Visualize ingredients of a recipe. You can play around with that endpoint!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Spoonacular.Api;
using Spoonacular.Client;
using Spoonacular.Model;

namespace Example
{
    public class VisualizeIngredientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spoonacular.com";
            // Configure API key authorization: apiKeyScheme
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new IngredientsApi(config);
            var contentType = application/json;  // string? | The content type. (optional) 
            var language = en;  // string? | The language of the input. Either 'en' or 'de'. (optional) 
            var accept = application/json;  // string? | Accept header. (optional) 

            try
            {
                // Ingredients Widget
                string result = apiInstance.VisualizeIngredients(contentType, language, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngredientsApi.VisualizeIngredients: " + e.Message );
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
 **contentType** | **string?**| The content type. | [optional] 
 **language** | **string?**| The language of the input. Either &#39;en&#39; or &#39;de&#39;. | [optional] 
 **accept** | **string?**| Accept header. | [optional] 

### Return type

**string**

### Authorization

[apiKeyScheme](../README.md#apiKeyScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

