# Cookiezz
Proje .Net Core 2.2 versiyonu ile calismakta eger bilgisayarinizda .Net Core 2.2 surumunden dusuk bir surum varsa calismayacaktir.
Veritabani olarak Postgresql kullanilmistir.
Eger farkli bir veritabani sistemi kullanmak istiyorsaniz Entity Framework Core'un o veritabani icin hazirlanmis paketini projeye dahil etmeniz ve 
Startup.cs dosyasinda degisiklik yapmaniz gerekir.
Bilgisayarinizda Docker kurulu ise projede bir degisiklik yapmadan projenin ana dizininde konsol uygulamasi ile "docker-compose up"
komutunu calistirabilirsiniz.
ConnectionString'i kendi veritabanı bilgilerinize göre güncellemeniz gerekmektedir.

Dosyaya sql dosyasi eklenmemistir bunun sebebi veritabani tablolarini .Net Migrations ile olusturmak daha kolay olacaktir.
Veritabani baglantinizi yaptiktan sonra CookiezzWeb dizininde konsol uygulamasi ile "dotnet ef database update" komutunu 
calistirirsaniz gerekli tablolar veritabanina kaydedilecektir.

Hazırlayanlar:
Yusuf Can Celik 16-701-010
Mehmet Temelatan