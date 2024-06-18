var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("User.json").AddXmlFile("Cars.xml");
var app = builder.Build();

app.MapGet("/", (IConfiguration config) => {
    return $"�������:\n���: {config["User:name"]}\n�������: {config["User:surname"]}" +
    $"\n�������: {config["User:age"]}\n�����: {config["User:email"]}" +
    $"\n������: {config["User:Groups:GrupName"]}\n����: {config["User:Groups:Curs"]} \n������: {config["User:Groups:Grade"]}" +
    $"\n\n��� ������: \n�����: {config["Car:Marka"]} \n���������: {config["Car:Engine"]}  \n���: {config["Car:KPP"]} " +
    $" \n�����: {config["Car:Body"]}  \n����: {config["Car:Price"]} ";
    
});

app.Run();
