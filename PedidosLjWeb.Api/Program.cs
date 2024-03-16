using Microsoft.EntityFrameworkCore;
using PedidosLjWeb.Application.Profile;
using PedidosLjWeb.Application.Servicos;
using PedidosLjWeb.Repository;
using PedidosLjWeb.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PedidosLjWebContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("PedidosLjConnection"));
});

builder.Services.AddAutoMapper(typeof(ProdutoProfile).Assembly);

//Repositories
builder.Services.AddScoped<ProdutoRepository>();
builder.Services.AddScoped<LojaRepository>();
builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<PedidoRepository>();
builder.Services.AddScoped<ItemPedidoRepository>();

//Services
builder.Services.AddScoped<ProdutoService>();
builder.Services.AddScoped<LojaService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<PedidoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
