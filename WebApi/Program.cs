var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IPayment, UpiPayment>();


builder.Services.AddScoped<PaymentService>();

// builder.Services.AddTransient<PaymentService>();

// builder.Services.AddSingleton<PaymentService>();

var app = builder.Build();

app.MapControllers();

app.Run();