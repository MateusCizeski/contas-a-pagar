using api_contas_pagar;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ConnectionContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    .EnableSensitiveDataLogging()
    .LogTo(Console.WriteLine, LogLevel.Information));

builder.Services.AddTransient<IRepFornecedor, RepFornecedor>();

builder.Services.AddScoped<IRepFornecedor, RepFornecedor>();
builder.Services.AddScoped<IServFornecedor, ServFornecedor>();
builder.Services.AddScoped<IAplicFornecedor, AplicFornecedor>();
builder.Services.AddScoped<IMapperFornecedor, MapperFornecedor>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
