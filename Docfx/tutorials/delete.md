# Delete
Not all Hudu API endpoints have a delete method available, but for those that do
all implementations in this library follow the same basic approach.

The below example delete an existing Asset in hudu.

    
    using HuduAPI.Endpoints.Parameters;
    using HuduAPI.Endpoints;

    AssetsEndpoint endpoint = new AssetsEndpoint("HuduAPIKey", "https://docs.huduexample.com/");

    AssetById item = new(10, 2);
    endpoint.Delete(item);