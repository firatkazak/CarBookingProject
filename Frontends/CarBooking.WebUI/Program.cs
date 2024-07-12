using Microsoft.AspNetCore.Authentication.JwtBearer;//JwtBearer sýnýfýný kullanabilmek için gerekli using direktifini ekler.

var builder = WebApplication.CreateBuilder(args);//ASP.NET Core uygulamasýný baþlatmak için bir WebApplicationBuilder örneði oluþturur.

builder.Services.AddControllersWithViews();//MVC (Model-View-Controller) mimarisi için gerekli olan kontroller ve görünümleri ekler.
builder.Services.AddHttpClient();//HTTP istemcisi ekler. Bu, HTTP istekleri yapmak için kullanýlabilir.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddCookie(JwtBearerDefaults.AuthenticationScheme, opt =>
{//Kimlik doðrulama için gerekli servisleri ekler. Bu örnekte, JWT ile kimlik doðrulama ve Cookie tabanlý oturum yönetimi konfigüre edilir.
    opt.LoginPath = "/Login/Index/";//Kullanýcýnýn giriþ yapmasý gerektiðinde yönlendirilecek olan sayfanýn yolu.
    opt.LogoutPath = "/Login/LogOut/";//Kullanýcýnýn çýkýþ yapmasý gerektiðinde yönlendirilecek olan sayfanýn yolu.
    opt.AccessDeniedPath = "/Pages/AccessDenied/";//Kullanýcýnýn eriþim izinlerinin olmamasý durumunda yönlendirilecek olan sayfanýn yolu.
    opt.Cookie.SameSite = SameSiteMode.Strict;// Tarayýcýnýn çerezin yalnýzca ayný siteye gönderilmesine izin vermesini saðlar.
    opt.Cookie.HttpOnly = true;//Bu satýr, çerezin sadece HTTP istekleri aracýlýðýyla eriþilebilir olmasýný saðlar.
    opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;//Bu satýr, çerezin güvenli baðlantýlar üzerinden sadece HTTPS aracýlýðýyla iletilmesini saðlar.
    opt.Cookie.Name = "CarBookJwt";//Bu satýr, oluþturulan çerezin adýný belirtir. 
});

var app = builder.Build();//Uygulamayý oluþturur.

if (!app.Environment.IsDevelopment())//Eðer uygulama geliþtirme ortamýnda deðilse(production ortamýnda)
{
    app.UseHsts();//HTTP Strict Transport Security (HSTS) kullanarak güvenli iletiþimi etkinleþtirir.
}

app.UseHttpsRedirection();//HTTPS'e yönlendirme iþlevini etkinleþtirir. HTTP istekleri otomatik olarak HTTPS'e yönlendirilir.
app.UseStaticFiles();//Statik dosyalarýn (örneðin, resimler, stil dosyalarý) servis edilmesini saðlar.
app.UseRouting();//Yönlendirme hizmetini etkinleþtirir. Bu, gelen isteklerin doðru kontrolere yönlendirilmesini saðlar.
app.UseAuthentication();//Kimlik doðrulama iþlemlerini etkinleþtirir. Bu, kullanýcý kimlik doðrulama süreçlerini baþlatýr.
app.UseAuthorization();//Yetkilendirme iþlemlerini etkinleþtirir. Bu, kimlik doðrulama sürecinden sonra kullanýcý yetkilerini kontrol eder.
app.MapControllerRoute(name: "default", pattern: "{controller=Default}/{action=Index}/{id?}");
//Varsayýlan bir controller ve action belirler. Bu, uygulama baþladýðýnda yönlendirilecek varsayýlan rotayý belirtir.
app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
//Area (Alan) tabanlý bir controller rotasý belirler. Eðer alan varsa, belirtilen controller ve action'a yönlendirilir.
app.Run();//Uygulamayý çalýþtýrýr. Bu, uygulamanýn iþleme geçmesini saðlar ve HTTP isteklerini dinlemeye baþlar.