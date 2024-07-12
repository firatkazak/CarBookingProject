using Microsoft.AspNetCore.Authentication.JwtBearer;//JwtBearer s�n�f�n� kullanabilmek i�in gerekli using direktifini ekler.

var builder = WebApplication.CreateBuilder(args);//ASP.NET Core uygulamas�n� ba�latmak i�in bir WebApplicationBuilder �rne�i olu�turur.

builder.Services.AddControllersWithViews();//MVC (Model-View-Controller) mimarisi i�in gerekli olan kontroller ve g�r�n�mleri ekler.
builder.Services.AddHttpClient();//HTTP istemcisi ekler. Bu, HTTP istekleri yapmak i�in kullan�labilir.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddCookie(JwtBearerDefaults.AuthenticationScheme, opt =>
{//Kimlik do�rulama i�in gerekli servisleri ekler. Bu �rnekte, JWT ile kimlik do�rulama ve Cookie tabanl� oturum y�netimi konfig�re edilir.
    opt.LoginPath = "/Login/Index/";//Kullan�c�n�n giri� yapmas� gerekti�inde y�nlendirilecek olan sayfan�n yolu.
    opt.LogoutPath = "/Login/LogOut/";//Kullan�c�n�n ��k�� yapmas� gerekti�inde y�nlendirilecek olan sayfan�n yolu.
    opt.AccessDeniedPath = "/Pages/AccessDenied/";//Kullan�c�n�n eri�im izinlerinin olmamas� durumunda y�nlendirilecek olan sayfan�n yolu.
    opt.Cookie.SameSite = SameSiteMode.Strict;// Taray�c�n�n �erezin yaln�zca ayn� siteye g�nderilmesine izin vermesini sa�lar.
    opt.Cookie.HttpOnly = true;//Bu sat�r, �erezin sadece HTTP istekleri arac�l���yla eri�ilebilir olmas�n� sa�lar.
    opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;//Bu sat�r, �erezin g�venli ba�lant�lar �zerinden sadece HTTPS arac�l���yla iletilmesini sa�lar.
    opt.Cookie.Name = "CarBookJwt";//Bu sat�r, olu�turulan �erezin ad�n� belirtir. 
});

var app = builder.Build();//Uygulamay� olu�turur.

if (!app.Environment.IsDevelopment())//E�er uygulama geli�tirme ortam�nda de�ilse(production ortam�nda)
{
    app.UseHsts();//HTTP Strict Transport Security (HSTS) kullanarak g�venli ileti�imi etkinle�tirir.
}

app.UseHttpsRedirection();//HTTPS'e y�nlendirme i�levini etkinle�tirir. HTTP istekleri otomatik olarak HTTPS'e y�nlendirilir.
app.UseStaticFiles();//Statik dosyalar�n (�rne�in, resimler, stil dosyalar�) servis edilmesini sa�lar.
app.UseRouting();//Y�nlendirme hizmetini etkinle�tirir. Bu, gelen isteklerin do�ru kontrolere y�nlendirilmesini sa�lar.
app.UseAuthentication();//Kimlik do�rulama i�lemlerini etkinle�tirir. Bu, kullan�c� kimlik do�rulama s�re�lerini ba�lat�r.
app.UseAuthorization();//Yetkilendirme i�lemlerini etkinle�tirir. Bu, kimlik do�rulama s�recinden sonra kullan�c� yetkilerini kontrol eder.
app.MapControllerRoute(name: "default", pattern: "{controller=Default}/{action=Index}/{id?}");
//Varsay�lan bir controller ve action belirler. Bu, uygulama ba�lad���nda y�nlendirilecek varsay�lan rotay� belirtir.
app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
//Area (Alan) tabanl� bir controller rotas� belirler. E�er alan varsa, belirtilen controller ve action'a y�nlendirilir.
app.Run();//Uygulamay� �al��t�r�r. Bu, uygulaman�n i�leme ge�mesini sa�lar ve HTTP isteklerini dinlemeye ba�lar.