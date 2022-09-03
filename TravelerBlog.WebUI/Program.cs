
using FluentValidation;
using System.Reflection;
using TravelerBlog.Application.Validations.AdviceValidators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TravelerBlogDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TravelerBlogConnection"));
});

builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<TravelerBlogDbContext>();
builder.Services.AddFluentValidationContainer();
builder.Services.AddIocContainer();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(CreateAdviceValidator));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapAreaControllerRoute(
    name:"Management",
    areaName: "Management",
    pattern:"Management/{controller=AccountManagement}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
