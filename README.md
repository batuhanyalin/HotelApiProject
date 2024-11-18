# Asp.Net Core 6 MVC CodeFirst - RapidAPI RESTful API Hotel Rezervasyon Projesi
Murat YÜCEDAĞ' ın udemyde sunduğu 202 Ders 24 saatlik Asp.Net Core Api - Rapid Api ve Api Consume Hotel Rezervasyon Sitesi eğitimi kapsamında geliştirmiş olduğum proje API, Rapid API, RESTful API consume yapısını kavramamı sağladı. Proje bir hotelde kullanıcıların odaları görebildikleri, rezervasyon talebi gönderip sisteme mail aboneliği oluşturup, sistem yöneticileriyle iletişime geçebildikleri, aldıkları hizmet neticesinde yorum yapabildikleri bir ön panele sahiptir. Bununla birlikte bütün bunlar API ile veritabanında kaydedilirken yönetici panelinde de bunların hepsini yönetebilirken ekstra rol-yetkilendirme işlemleri, istatistiki veri alma vb. özellikleri mevcuttur.

## 🪶 Projeye Ait Bazı Özellikler;
* Kullanıcılar aktif odaları görebilmekte, odalar için rezervasyon oluşturabilmekte, isterlerse sistem yöneticileriyle iletişime geçebilmektedirler.
* E-posta bültenine kayıt olunabilmektedir.
* Yönetici paneli aracılığıyla bütün sistem kontrol edilebilmektedir.

## 🛠️ Kullanılan Bazı Teknolojiler
🌟 RapidAPI' den çekilen API' lar consume edildi. Parametreli olarak API' üzerinden consume işlemi yapıldı.
🌟 Bütün Hotelier projesi RESTful API' larla bütün CRUD işlemlerini yapabilir şekilde oluşturuldu.
🌟 JWT Token ile süre bazlı token oluşturup POSTMAN ile testleri yapıldı.
🌟 Proje Admin adlı bir Area vardır ve ana ekrandan ayrılmaktadır. 
🌟 Bütün proje SOLID prensipleriyle ve folder structure yapısıyla oluşturuldu.
* Structural Repository design pattern ile oluşturulmuştur.
* DbCodeFirst ile MSSQL veritabanı oluşturulup yönetimi sağlandı.
* MimeKit ve Smtp ile mail gönderme sistemi oluşturuldu.
* Identity kütüphanesiyle login-logout-role-register sistemi kullanıldı.
* Entity Framework 6.0 Veritabanı etkileşimi ve ORM için kullanıldı.
* Area sistemiyle paneller birbirinden ayrılıp yönetimi kolaylaştırıldı.
* Projede bol bol iç içe layout ve ViewComponent yapısı kullanıldı.
* DTO katmanıyla veri yönetimi kolaylaştırıldı.	
* HTML-CSS Bootstrap ile arayüzler tasarlandı.
* Fluent Validation - kontrol sistemi kullanılarak veirlerin belli kurallara göre alınması sağlandı.
* ViewBaglerle verilerin taşınması.
* 403 - 404 sayfalarının bulunması.
* Proje seviyesinde Authentication - authorize oturum yönetim sistemi oluşturuldu.
* AutoMapper ile Generic yapıyla DTO katmanıyla entitylerin eşleşmesi sağlandı.
* Login sistemi
* Linq sorguları


# Veritabanı
![Veritabanı](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/database.png?raw=true)
### Giriş
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/login.png?raw=true)
### Onay Bekleyen Kullanıcı
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/onay.png?raw=true)
### Yetkisiz Giriş
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/error403forbidden.png?raw=true)
### Sayfa Bulunamadı
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/error404.png?raw=true)
### Yeni Üyelik
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/registerValidation.png?raw=true)
### Parola Sıfırlama
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/forgetPassword.png?raw=true)

####
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/1.png?raw=true)
#### 
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/2.png?raw=true)
#### 
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/3.png?raw=true)
####
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/4.png?raw=true)
####
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/5.png?raw=true)
####
![](https://github.com/batuhanyalin/TraversalCoreProject/blob/master/TraversalCoreProject/wwwroot/images/projectScreenshots/6.png?raw=true)