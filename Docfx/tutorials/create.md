# Create Asset
Not all Hudu API endpoints have a create method available, but for those that do
all implementations in this library follow the same basic approach. Build the required
parameters and then call the create method on the endopoint object.

The below example creates a new Asset in hudu of the AssetLayout type "Person"

    using HuduAPI.Records;
    using HuduAPI.Endpoints.Parameters;
    using HuduAPI.Endpoints.Exceptions;
    using HuduAPI.Endpoints;

    AssetsEndpoint endpoint = new AssetsEndpoint("HuduAPIKey", "https://docs.huduexample.com/");

    int companyID = 1;
    layoutID = 1;
    name = "Dracon80";

    CreateAsset myparams = new CreateAssetBuilder(companyID, layoutID, name)
        .WithCustomField("Status", "ACTIVE")
        .WithCustomField("Email_Address", "na@na.com")
        .WithCustomField("Department", "IT")
        .Build();

    Asset result = _endpoint.Create(myparams);

# Create AssetLayout
This is an example of using the AssetLayout endpoint to create a new assetlayout

    using HuduAPI.Records;
    using HuduAPI.Endpoints.Parameters;
    using HuduAPI.Endpoints.Exceptions;
    using HuduAPI.Endpoints;

    AssetLayoutsEndpoint endpoint = new AssetLayoutsEndpoint("HuduAPIKey", "https://docs.huduexample.com/");

    string name = "Network Device";
    string icon = "fas fa-network-wired";
    System.Drawing.Color color = System.Drawing.Color.Green;
    System.Drawing.Color icon_color = System.Drawing.Color.White;

    List<AssetLayoutField> fields = new List<AssetLayoutField>();

    fields.Add(new AssetLayoutFieldBuilder("IP Address", AssetLayoutFieldType.WEBSITE)
        .WithRequired(true)
        .WithShowInList(true)
        .Build());

    fields.Add(new AssetLayoutFieldBuilder("FQDN", AssetLayoutFieldType.TEXT)
        .WithHint("Fully Qualified Domain Name of the Host")
        .Build());

    fields.Add(new AssetLayoutFieldBuilder("Configuration", AssetLayoutFieldType.RICH_TEXT)
        .WithRequired(true)
        .WithShowInList(false)
        .WithHint("Record device configuration details here")
        .Build());

    CreateAssetLayout myParams = new CreateAssetLayoutBuilder(name: name, icon: icon, color: color, iconColor: icon_color, fields)
        .WithIncludeFiles(false)
        .WithIncludePasswords(true)
        .Build();

    AssetLayout result = _endpoint.Create(myParams);