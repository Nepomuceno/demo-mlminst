using api;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Linq;
using System.Threading.Tasks;


public class SampleHub : Hub
{
    private readonly MLModel ml;

    public SampleHub(MLModel ml)
    {
        Console.WriteLine("Hello");
        this.ml = ml;
    }
    public async Task GetPrediction(float[] image)
    {
        var digit = MinstDigit.FromList(image, false);
        var prediction = ml.Predict(digit);
        prediction.Label = prediction.Score.Select((value, index) => new { Value = value, Index = index }).Aggregate((a, b) => (a.Value > b.Value) ? a : b).Index;
        await Clients.Caller.SendAsync("receivePrediction", image, prediction);
        await Clients.All.SendAsync("receiveBackground", image, prediction);

    }
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

}