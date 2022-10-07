# IO.Swagger.Api.DevelopersApi

All URIs are relative to *https://virtserver.swaggerhub.com/SSDMUKK/Swagger_PED/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchInventory**](DevelopersApi.md#searchinventory) | **GET** /inventory | searches inventory

<a name="searchinventory"></a>
# **SearchInventory**
> List<InventoryItem> SearchInventory (string searchString = null, int? skip = null, int? limit = null)

searches inventory

By passing in the appropriate options, you can search for available inventory in the system 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchInventoryExample
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var searchString = searchString_example;  // string | pass an optional search string for looking up inventory (optional) 
            var skip = 56;  // int? | number of records to skip for pagination (optional) 
            var limit = 56;  // int? | maximum number of records to return (optional) 

            try
            {
                // searches inventory
                List&lt;InventoryItem&gt; result = apiInstance.SearchInventory(searchString, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.SearchInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchString** | **string**| pass an optional search string for looking up inventory | [optional] 
 **skip** | **int?**| number of records to skip for pagination | [optional] 
 **limit** | **int?**| maximum number of records to return | [optional] 

### Return type

[**List<InventoryItem>**](InventoryItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
