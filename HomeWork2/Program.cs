namespace HomeWork2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<ICar,Car>();
            var app = builder.Build();

            app.Map("/GetCarName", HandleMapGetCarName);
            app.Map("/GetCarEngine", HandleMapGetCarEngine);
            app.Map("/GetCarAge", HandleMapGetCarAge);


            app.Run(async context =>
            {
                var car = app.Services.GetService<ICar>();
                await context.Response.WriteAsync($"MY CAR : {car?.GetCarName()}  {car?.GetCarEngine()}  {car?.GetCarAge()} years ");
            });


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
          

        }
        private static void HandleMapGetCarName(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var car = app.ApplicationServices.GetService<ICar>();
                await context.Response.WriteAsync($"Car Name : {car?.GetCarName()}");
            });
        }

        private static void HandleMapGetCarEngine(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var car = app.ApplicationServices.GetService<ICar>();
                await context.Response.WriteAsync($"Car Engine : {car?.GetCarEngine()}");
            });
        }

        private static void HandleMapGetCarAge(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var car = app.ApplicationServices.GetService<ICar>();
                await context.Response.WriteAsync($"Car Age : {car?.GetCarAge()}");
            });
        }
    }
    public interface ICar
    {
        string GetCarName();
        int GetCarEngine();
        int GetCarAge();
    }

    public class Car : ICar
    {
        public string GetCarName() => "Nissan XTrail";
        public int GetCarEngine() => 2000;
        public int GetCarAge() => DateTime.Now.Year - 2018;

    }
}