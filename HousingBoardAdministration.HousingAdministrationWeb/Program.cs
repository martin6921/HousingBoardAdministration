using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppUserDbContext;


var builder = WebApplication.CreateBuilder(args);

// Add-Migration init -Context WebAppUserDbContext.WebAppUserDbContext -Project WebAppUserDbContextMigrations
// Update-Database -Context WebAppUserDbContext.WebAppUserDbContext
var connectionString = builder.Configuration.GetConnectionString("WebAppUserDbContextConnection");
builder.Services.AddDbContext<WebAppUserDbContext.WebAppUserDbContext>(options =>
    options.UseSqlServer(connectionString,
        x => x.MigrationsAssembly("WebAppUserDbContextMigrations")));


builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Lockout.AllowedForNewUsers = true;
    options.Password.RequiredLength = 3;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<WebAppUserDbContext.WebAppUserDbContext>();
builder.Services.AddScoped<RoleManager<IdentityRole>>();
builder.Services.AddRazorPages();

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
