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

//Services
builder.Services.AddScoped<ProdutoService>();


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
