# IO.Swagger.Api.AdminApi

All URIs are relative to *https://virtserver.swaggerhub.com/SSDMUKK/Swagger_PED/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventory**](AdminApi.md#addinventory) | **POST** /inventory | adds an inventory item
[**SearchInventory**](AdminApi.md#searchinventory) | **GET** /inventory | searches inventory

<a name="addinventory"></a>
# **AddInventory**
> void AddInventory (InventoryItem body = null)

adds an inventory item

Adds an item to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddInventoryExample
    {
        public void main()
        {
            var apiInstance = new AdminApi();
            var body = new InventoryItem(); // InventoryItem | Inventory item to add (optional) 

            try
            {
                // adds an inventory item
                apiInstance.AddInventory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AddInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryItem**](InventoryItem.md)| Inventory item to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
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
            var apiInstance = new AdminApi();
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
                Debug.Print("Exception when calling AdminApi.SearchInventory: " + e.Message );
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
