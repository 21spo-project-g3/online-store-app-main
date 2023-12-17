using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using online_store_app.Data;
using online_store_app.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure the connection string
var connectionString = builder.Configuration.GetConnectionString("production")
                       ?? throw new InvalidOperationException("Connection string not found.");

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;

    // Remove email and password requirements
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 1; // Set to your desired minimum length
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.User.RequireUniqueEmail = false; // Remove email uniqueness requirement
})
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<ReviewService>(); // Add this line to register ReviewService

// Add Authorization policies
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireUserName("admin@admin"));
});

builder.Services.AddControllersWithViews();

// Add session services
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

// Use session middleware
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "checkout",
    pattern: "checkout/{action=Index}",
    defaults: new { controller = "Checkout" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{ean?}");

app.MapRazorPages();

app.Run();
