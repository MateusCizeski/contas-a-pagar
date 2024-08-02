using api_contas_pagar;
using api_contas_pagar.Repositories;
using api_contas_pagar.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ConnectionContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    .EnableSensitiveDataLogging()
    .LogTo(Console.WriteLine, LogLevel.Information));

//FORNECEDOR
builder.Services.AddTransient<IRepFornecedor, RepFornecedor>();
builder.Services.AddScoped<IRepFornecedor, RepFornecedor>();
builder.Services.AddScoped<IServFornecedor, ServFornecedor>();
builder.Services.AddScoped<IAplicFornecedor, AplicFornecedor>();
builder.Services.AddScoped<IMapperFornecedor, MapperFornecedor>();

//Fatura
builder.Services.AddTransient<IRepFatura, RepFatura>();
builder.Services.AddScoped<IRepFatura, RepFatura>();
builder.Services.AddScoped<IServFatura, ServFatura>();
builder.Services.AddScoped<IAplicFatura, AplicFatura>();
builder.Services.AddScoped<IMapperFatura, MapperFatura>();

//Pagamento
builder.Services.AddTransient<IRepPagamento, RepPagamento>();
builder.Services.AddScoped<IRepPagamento, RepPagamento>();
builder.Services.AddScoped<IServPagamento, ServPagamento>();
builder.Services.AddScoped<IAplicPagamento, AplicPagamento>();
builder.Services.AddScoped<IMapperPagamento, MapperPagamento>();

//Metodo de pagamento
builder.Services.AddTransient<IRepMetodoPagamento, RepMetodoPagamento>();
builder.Services.AddScoped<IRepMetodoPagamento, RepMetodoPagamento>();
builder.Services.AddScoped<IServMetodoPagamento, ServMetodoPagamento>();
builder.Services.AddScoped<IAplicMetodoPagamento, AplicMetodoPagamento>();
builder.Services.AddScoped<IMapperMetodoPagamento, MapperMetodoPagamento>();

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
