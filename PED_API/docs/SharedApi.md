# IO.Swagger.Api.SharedApi

All URIs are relative to *https://virtserver.swaggerhub.com/SSDMUKK/Swagger_PED/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReasonCodes**](SharedApi.md#reasoncodes) | **GET** /reasoncodes | Get all Reason Codes
[**States**](SharedApi.md#states) | **GET** /states | Get all States

<a name="reasoncodes"></a>
# **ReasonCodes**
> List<ReasonCode> ReasonCodes ()

Get all Reason Codes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReasonCodesExample
    {
        public void main()
        {
            var apiInstance = new SharedApi();

            try
            {
                // Get all Reason Codes
                List&lt;ReasonCode&gt; result = apiInstance.ReasonCodes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharedApi.ReasonCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ReasonCode>**](ReasonCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="states"></a>
# **States**
> List<State> States ()

Get all States

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StatesExample
    {
        public void main()
        {
            var apiInstance = new SharedApi();

            try
            {
                // Get all States
                List&lt;State&gt; result = apiInstance.States();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharedApi.States: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<State>**](State.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
