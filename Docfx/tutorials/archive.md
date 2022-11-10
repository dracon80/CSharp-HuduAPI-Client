# Archive Asset
Not all endpoints provide an Archive Method, but those that do follow the same usage pattern as this tutorial.


    using HuduAPI.Records;
    using HuduAPI.Endpoints.Parameters;
    using HuduAPI.Endpoints.Exceptions;
    using HuduAPI.Endpoints;

    AssetsEndpoint endpoint = new AssetsEndpoint("HuduAPIKey", "https://docs.huduexample.com/");

    int companyID = 1;
    int id = 100;

    AssetById item = new(id,companyID);

    try {
        //Archvie Asset
        var result = _endpoint.Archive(item, true);

        //Un-Archive the Asset
        var result = _endpoint.Archive(item, false);

    }catch(RecordNotFoundException){
        //This was an invalid combination of companyID and AssetID
    }