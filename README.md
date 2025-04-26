EducationPortal

EducationPortal, online kurs kayıt ve yönetim sistemi olarak geliştirilmiş kapsamlı bir web uygulamasıdır. Bu sistem, öğrenciler, öğretmenler, yöneticiler ve müşteriler için bir arayüz sağlar. Projenin amacı, eğitim süreçlerini dijitalleştirerek daha etkili bir kullanıcı deneyimi sunmaktır.

✨ Özellikler
Kayıt Olma ve Giriş İşlemleri:

Yeni kullanıcıların kayıt olabilmesi.

Giriş işlemleri ve doğrulama.

Şifre sıfırlama için e-posta desteği.

Öğrenci ve Öğretmen Yönetimi:

Öğrenci ekleme, silme ve güncelleme işlemleri.

Öğretmen ekleme, silme ve güncelleme işlemleri.

Kurs Yönetimi:

Kurslar hakkında detaylı bilgi görüntüleme.

Eğitmen ve sınıf ilişkilendirme.

Proje Yükleme ve Değerlendirme:

Öğrenciler için proje yükleme alanı.

Öğretmenlerin proje puanlaması yapabileceği bir bölüm.

Yönetici ve Admin Paneli:

Kullanıcı ve sistem yönetimi için yetkilendirilmiş alanlar.

🚀 Kullanılan Teknolojiler
Backend:
ASP.NET Core 8.0: Uygulamanın temel altyapısını sağlıyor.

Entity Framework Core: Veritabanı işlemleri ve ORM çözümü.

PostgreSQL: Yüksek performanslı ve güvenilir veritabanı yönetimi.

AutoMapper: Nesne dönüştürme işlemleri.

FluentValidation: Veri doğrulama için etkili bir araç.

Autofac: Dependency injection (bağımlılık enjeksiyonu) sistemi.

Frontend:
HTML5 & CSS3: Modern ve duyarlı kullanıcı arayüzü.

Bootstrap 5: Hızlı ve estetik tasarımlar.

JavaScript & jQuery: Dinamik veri işlemleri ve kullanıcı etkileşimleri.

📂 Proje Yapısı
plaintext
EducationPortal/
├── Controllers/
├── Models/
├── Views/
│   ├── Shared/
│   ├── Home/
│   ├── Account/
├── wwwroot/
│   ├── assets/
│       ├── css/
│       ├── js/
│       ├── img/
├── appsettings.json
├── Program.cs
└── Startup.cs
📜 Kurulum ve Çalıştırma
Kodu Klonla:

bash
git clone https://github.com/[KullanıcıAdın]/EducationPortal.git
Veritabanı Ayarları:

appsettings.json dosyasındaki PostgreSQL bağlantı ayarlarını düzenleyin.

Gereksinimleri Yükle:

Visual Studio 2022 veya Rider ile projeyi açın ve bağımlılıkları yükleyin.

Projeyi Çalıştır:

IIS Express veya Kestrel kullanarak uygulamayı başlatın.

🛠 Geliştirme Süreci
Proje, kullanıcı dostu bir online eğitim yönetim sistemi geliştirmek amacıyla tasarlandı. Şu anda aktif olarak geliştirilmektedir ve katkılara açıktır.

📌 Planlanan Geliştirmeler
Raporlama ve analiz modülleri.

Canlı ders entegrasyonu.

Mobil uyumlu arayüz geliştirme.

🖊 Katkıda Bulunma
Katkıda bulunmak isterseniz, pull request gönderin veya bir issue oluşturun. Her türlü geri bildirime açığız!

📞 İletişim
Herhangi bir sorunuz veya öneriniz varsa, lütfen şu adreslerden benimle iletişime geçin:

E-posta: ahmet@example.com

GitHub: Ahmet Çekiç
İçerik Özeti

Giriş ve Temeller

Entity Sınıfları ve DbContext: Veri modellerinin ve bağlam sınıfının oluşturulması.
Connection Strings ve Migrations: Veritabanı bağlantısı ve veritabanı şemasının yönetimi.
CRUD İşlemleri

Kayıt Ekleme: Yeni kayıtların oluşturulması.
Kayıt Listeleme: Mevcut verilerin okunması ve görüntülenmesi.
Kayıt Güncelleme Formu ve Kayıt Güncelleme: Var olan verilerin güncellenmesi.
Kayıt Silme: Gereksiz verilerin kaldırılması.
Uygulamalar

Kurs Kayıt Sayfası ve Kurs Listesi: Kurs verilerinin yönetimi.
Kurs Güncelleme Sayfası ve Kurs Silme: Kurs bilgilerinin düzenlenmesi ve silinmesi.
İlişkisel Veritabanı İşlemleri

Öğrenci Kurs Kayıt Formu ve Öğrenci Kurs Kaydının Eklenmesi: İlişkili veri kayıtlarının oluşturulması.
Navigation Properties: Veri modelleri arasındaki ilişkileri yönetme.
Öğrenci Kurslarının Listeleme ve Kurs Öğrencilerinin Listeleme: İlişkisel verilerin sorgulanması.
Gelişmiş Özellikler

Veri Tabanı Şemasının Güncellenmesi: Veritabanı yapısında yapılan değişikliklerin yönetimi.
Öğretmen Yönetim Sayfaları: Öğretmen bilgilerini düzenleme ve listeleme.
Öğretmen Kurs İlişkilendirmesi: Kurslar ve öğretmenler arasındaki ilişkilerin yönetimi.
Öğretmen Seçiminin Zorunlu Olması: İlişkilerinize kuralların uygulanması.
