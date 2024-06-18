var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("User.json").AddXmlFile("Cars.xml");
var app = builder.Build();

app.MapGet("/", (IConfiguration config) => {
    return $"Студент:\nИмя: {config["User:name"]}\nФамилия: {config["User:surname"]}" +
    $"\nВозраст: {config["User:age"]}\nПочта: {config["User:email"]}" +
    $"\nГруппа: {config["User:Groups:GrupName"]}\nКурс: {config["User:Groups:Curs"]} \nОценка: {config["User:Groups:Grade"]}" +
    $"\n\nЕго машина: \nМарка: {config["Car:Marka"]} \nДвигатель: {config["Car:Engine"]}  \nКПП: {config["Car:KPP"]} " +
    $" \nКузов: {config["Car:Body"]}  \nЦена: {config["Car:Price"]} ";
    
});

app.Run();
