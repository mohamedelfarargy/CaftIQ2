
using CraftIQ2.infastrcure;
using CraftIQ2.service;
using huzcodes.Extensions.Exceptions;


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
var DBconectionString = builder.Configuration.GetSection("ConnectionStrings:SqlServerConnectionString");
builder.Services.AddInventoryDbContext(DBconectionString.Value!);
builder.Services.AddInfrastructureRegistrations();
builder.Services.AddServicesRegistrations();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
              app.AddExceptionHandlerExtension();
                app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
       
    

