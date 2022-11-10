# HuduAPI Client Tutorials
These basic tutorials will run through how to use the library. Another great source of examples is the [test project](https://github.com/dracon80/CSharp-HuduAPI-Client/tree/master/HuduAPITests/Endpoints) included as part of the solution. Obviously your tests will fail until you update many of the tests values to match records in your hudu instance. But its a great way to see how to use the library.

## [Get a AssetLayouts](get.html)
All Endpoints have at least 1 Get method, many have multiple overloads available. All Endpoints follow the exact same pattern of usage as outlined in the [get](get.html) tutorial page.

## [Create Asset](create.html)
Not all Hudu API endpoints have a create method available, but for those that do
all implementations in this library follow the same basic approach. Build the required
parameters and then call the create method on the endopoint object. See the examples
on the [create](create.html) tutorial page.

## [Update Asset](update.html)
Not all Hudu API endpoints have an update method available, but for those that do
all implementations in this library follow the same basic approach. Build the required
parameters and then call the update method on the endopoint object. See the exmaples
on the [update](update.html) tutorial page.

## [Archive Asset](archive.html)
Not all Hudu API endpoints have an Archive method, but those that do are easy to 
call using the tutorial provided on the [Arhive](archive.html) page.

## [Delete Asset](delete.html)
Not all Hudu API endpoints have a delete method, but those that do are easy to 
call using the tutorial provided on the [Delete](delete.html) page.