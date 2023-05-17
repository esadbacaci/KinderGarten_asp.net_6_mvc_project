using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(options =>
{
	options.LoginPath = "/Admin/Login";
	options.ExpireTimeSpan = TimeSpan.FromMinutes(120);
	options.SlidingExpiration = true;
	options.Cookie.HttpOnly = true;
	options.Cookie.SameSite = SameSiteMode.Strict;
	options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Anasayfa}/{action=Index}/{id?}");

app.Run();
