
namespace E_Commerce.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Create Builder
            var builder = WebApplication.CreateBuilder(args);
            #endregion

            #region Add Services to Container
            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services.AddDbContext<StoreDbContext>(options =>
            //{
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //});


            #endregion

            #region Build App
            var app = builder.Build();
            #endregion

            #region Configure HTTP Request Pipeline
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
            #endregion

            #region Run App
            app.Run();
            #endregion
            ////
        }
    }
}
