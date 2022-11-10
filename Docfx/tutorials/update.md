# Update
Not all Hudu API endpoints have an update method available, but for those that do
all implementations in this library follow the same basic approach. Build the required
parameters and then call the update method on the endopoint object.

The below example updates an existing Asset in hudu.

    using HuduAPI.Endpoints.Parameters;
    using HuduAPI.Endpoints;

    AssetsEndpoint endpoint = new AssetsEndpoint("HuduAPIKey", "https://docs.huduexample.com/");

    layoutID = 1;
    assetID = 10;
    companyID = 2;
    name = "Updated Asset Name";
    serial = "12342342345";
    man = "Updated Manufactor";
    mail = "nada@na.com.au";
    model = "Updated Model";

    UpdateAsset updateparams = new UpdateAssetBuilder(assetID, companyID, layoutID, name)
        .WithPrimarySerial(serial)
        .WithPrimaryManufacturer(man)
        .WithPrimaryMail(mail)
        .WithPrimaryModel(model)
        .WithCustomField("Status", "ACTIVE")
        .WithCustomField("Email Address", mail)
        .WithCustomField("Department", "IT")
        .WithCustomField("Gender", "Male")
        .WithCustomField("Title", "Chaos Management")
        .Build();

    result = endpoint.Update(updateparams);