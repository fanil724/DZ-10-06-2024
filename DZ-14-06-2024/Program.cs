var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var c = new Car("benzin 2.0","rkpp","black","sedan","12.600.000");
app.Configuration["car"]=CarToString(c);


app.Run(async(context)=>{
    var car = GetCar(app.Configuration["car"]);
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync(
        $"Car:<br> Engine: {car.engine}<br> RPP: {car.KPP}<br> Color: {car.color}<br> Body type: {car.bodyType} <br> Price: {car.price}"
        );
});

app.Run();

string CarToString(Car c)
{
    return $"{c.engine}-{c.KPP}-{c.color}-{c.bodyType}-{c.price}";
}

Car GetCar(string c)
{
    string[] car=c.Split('-');
    return new Car(car[0], car[1], car[2], car[3], car[4]);
}

record Car(string engine, string KPP, string color, string bodyType, string price);

