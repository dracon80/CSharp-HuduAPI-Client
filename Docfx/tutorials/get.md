# Get AssetLayouts
All Endpoints have at least 1 Get method, many have multiple overloads available.
All Endpoints follow the exact same pattern of usage as outlined in the below examples.


Just want an unfiltered list of all AssetLayouts in hudu?

    using HuduAPI.Endpoints;
    using HuduAPI.Records;

    AssetLayoutsEndpoint endpoint = new AssetLayoutsEndpoint("huduAPIKEY", "https://docs.huduexample.com/");
    Records.AssetLayouts results = endpoint.Get();
    
What about filtering the list of AssetLayouts?

    using HuduAPI.Endpoints;
    using HuduAPI.Records;
    using HuduAPI.Endpoints.Parameters;
    using HuduAPI.Endpoints.Exceptions;

    AssetLayoutsEndpoint endpoint = new AssetLayoutsEndpoint("huduAPIKEY", "https://docs.huduexample.com/");

    GetAssetLayouts myparams = new GetAssetLayoutsBuilder()
        .WithName("Network Device")
        .Build();

    try
    {
        AssetLayout assetlayout = _endpoint.Get(myparams).AssetLayoutList.First<AssetLayout>();
        Assert.IsNotNull(assetlayout);
    }
    catch (RecordNotFoundException)
    {
        //There were now results returned
    }
    

Already know the ID of the assetlayout you want?

    using HuduAPI.Endpoints;
    using HuduAPI.Records;
    using HuduAPI.Endpoints.Parameters;
    using HuduAPI.Endpoints.Exceptions;

    AssetLayoutsEndpoint endpoint = new AssetLayoutsEndpoint("huduAPIKEY", "https://docs.huduexample.com/");

    try{
        Parameters.ItemById parameters = new(1);
        AssetLayout result = _endpoint.Get(parameters);
    }
    catch(RecordNotFoundException){
        //No AssetLayout with ID supplied was found!
    }