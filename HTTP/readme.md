﻿# HTTP
Provide HTTPClient
# Class and Interfaces
1. ```GenericHttpClient``` : implement ```IGenericHttpClient``` and offer the following method
      - ```SetBaseUrl(string baseUrl)```: Set the base url used in the http client


      - ```SetHeader(string Key, string Value)```: Set http header


      - ```SetAuthStrategy(IAuthStrategy authStrategy)```: Set How To Apply Authentication to the HttpClient Which you can do it through implementing the IAuthStrategy Interface. the already Provided Strategy are:
          - ```JwtAuthStrategy```


      - ```PostAsync<ReturnType, RequestContent>(Request<ReturnType,RequestContent> request)```: Preform HTTP Request Of Type POST and it take the following parameter 
          - ```request```: request details


      - ```PutAsync<ReturnType, RequestContent>(Request<ReturnType,RequestContent> request)``` : Preform HTTP Request Of Type POST and it take the following parameter
          - ```request```: request details


      - ```GetAsync<ReturnType, RequestContent>(Request<ReturnType,RequestContent> request)``` : Preform HTTP Request Of Type POST and it take the following parameter
          - ```request```: request detail      


      - ```DeleteAsync<ReturnType, RequestContent>(Request<ReturnType,RequestContent> request)``` : Preform HTTP Request Of Type POST and it take the following parameter
          - ```request```: request details

     
     
     - ```Request<ReturnType,RequestContent> ``` : Contain the field necessary to send HTTP Request
          - ```endPoint```: the end point you want to call 
          - ```IResponseDeserializer<ReturnType>```: Interface that specify how to deserialize the recieved http response. you can Implement your Custom ResponseDeserializer by inherting it. the already Provided Deserializer are
              - ```JsonResponseDeserializer```
          - ```RequestContent```: The Data you want to send and its of generic type RequestContent that specified in the Method
          - ```IRequestContentBuilder<RequestContent>``` Interface that specify how to serialize the RequestContent and conver it to HttpContent Before Sending it to the specifed endpoint