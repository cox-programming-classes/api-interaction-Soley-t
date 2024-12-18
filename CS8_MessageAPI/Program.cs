global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Services;
// this is my PostMan Analog
var apiService = new ApiService();

var loginSuccess = true;

await apiService.Login("soley.toussaint@winsor.edu", "*&#864XCBwyc",
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    });
    
if(!loginSuccess)
    return;

    var myFreeBlocks = await apiService.SendAsync<FreeBlockCollection>(
        HttpMethod.Get, "api/schedule/free-blocks/for/gjQ9ZmbMX5a2",
        err =>
        {
            Console.WriteLine(err);
        });