global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Models;
using CS8_MessageAPI.Services;
// this is my PostMan Analog
var apiService = new ApiService();

var loginSuccess = true;

var advice = await apiService.SendAsync<SlipWrapper>(HttpMethod.Get, "advice", //log into MY API
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    }, authorize:false);

Console.WriteLine(advice.slip.advice);

