using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WissenDandR302BusinessLayer;
using WissenDandR302BusinessLayer.Implementations;
using WissenDandR302DataAccessLayer;
using WissenDandR302DataAccessLayer.ContextInfo;
using WissenDandR302DataAccessLayer.Implementations;
using WissenDandR302EntityLayer.IdentityModels;
using WissenDandR302EntityLayer.Mappings;
using WissenDandR302PresentationLayer.CreateDefaultDatas;

var builder = WebApplication.CreateBuilder(args);

//
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));
});

builder.Services.AddIdentity<AppUser, AppRole>(options=>
{
    options.User.RequireUniqueEmail = true;
    options.Password.RequiredLength = 5;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_@.";
}).AddDefaultTokenProviders().AddEntityFrameworkStores<MyContext>();


//Mapleme ayarlar�
//builder.Services.AddAutoMapper(typeof(Maps));
builder.Services.AddAutoMapper(x =>
{
    x.AddExpressionMapping(); //expressionlar� maplemek i�indir
    x.AddProfile(typeof(Maps));
});

// servislerin DI ya�am d�ng�lerine g�re ayarlar� yap�ld�.
builder.Services.AddScoped<IBookRepo, BookRepo>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<IAuthorRepo, AuthorRepo>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

builder.Services.AddScoped<IBookGenreRepo, BookGenreRepo>();
builder.Services.AddScoped<IBookGenreService, BookGenreService>();

builder.Services.AddScoped<IBookPictureRepo, BookPictureRepo>();
builder.Services.AddScoped<IBookPictureService, BookPictureService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); // wwwroot klas�r�ne eri�im sa�lar.

app.UseRouting(); // /Controller/Action/id?

app.UseAuthentication(); //Login ve logout i�lemlerinde 
app.UseAuthorization(); // [Authorize] attribute kullan�m� i�in


////Area ekledi�imiz i�in program �al��t���nda Url'deki endpoint ayar�n� buraya eklememiz gerekiyor

app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



//TODO: CreateAllRoles metodunu g�nl�m�z buradan �a��rmak ister...
//https://stackoverflow.com/questions/70771874/how-do-i-initialize-database-with-default-values-in-net6 linki incelenecek ve uygulanacak...

app.PrepareData();

app.Run();
