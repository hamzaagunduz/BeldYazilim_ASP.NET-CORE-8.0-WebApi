# Bilgiyi Gelire Dönüştüren Yenilikçi Blog Platformu

Bu proje, içerik üreticilerinin daha fazla gelir elde etmelerini ve daha geniş bir kitleye ulaşmalarını sağlamak amacıyla geliştirilmiş yeni nesil bir blog platformu sunmaktadır.

## 🎯 Projenin Temel Hedefleri

- **Gelir Modellerini Çeşitlendirmek:** Yazarlara reklam modellerinin ötesinde, içerik satışı, abonelikler ve bağış sistemleri ile gelir elde etme fırsatları sunar.
- **Güçlü Bir Topluluk Oluşturmak:** Yazar ve okuyucular arasında etkileşimi teşvik ederek sadık bir topluluk oluşturur.
- **Kullanıcı Dostu ve Gelişmiş Arayüz:** İçerik üretimini, yönetimini ve gelir takibini kolaylaştıran modern bir kullanıcı arayüzü sunar.
- **Etkili İçerik Tanıtım Araçları:** SEO, sosyal medya entegrasyonu ve e-posta pazarlaması gibi araçlarla içeriklerin daha geniş kitlelere ulaşmasını sağlar.
- **Kolay İçerik Keşfi ve Erişilebilirlik:** Okuyucuların ilgi alanlarına yönelik içeriklere kolayca ulaşmalarını sağlar.

## 🚀 Kullanılan Teknolojiler

- **Backend:** ASP.NET 8.0, RESTful API, SQL Server, ASP.NET Identity, JWT Token
- **Frontend:** HTML, CSS, JavaScript, CKEditor
- **Veritabanı:** SQL Server
- **Sürüm Kontrol:** Git, GitHub
- **API Test Araçları:** Postman, Swagger

## 📐 Mimari

- **Onion Mimari:** Proje esneklik, test edilebilirlik ve sürdürülebilirlik sağlamak amacıyla Onion mimarisi kullanılarak tasarlanmıştır.
- **Mediator Design Pattern:** API isteklerinin işlenmesini düzenli ve esnek hale getirmek için Mediator Design Pattern kullanılmıştır.
- **Repository Design Pattern:** Veritabanına erişimi soyutlamak amacıyla Repository Pattern kullanılmıştır.

## 🛠️ Özellikler

- **Kullanıcı Kaydı ve Girişi:** Güvenli kimlik doğrulama ve yetkilendirme sistemi.
- **Makale Oluşturma ve Düzenleme:** Zengin metin düzenleme özellikleri sunan kullanıcı dostu bir arayüz.
- **Kategori ve Etiket Yönetimi:** İçeriklerin organize edilmesini ve keşfini kolaylaştırmak için araçlar.
- **Gelir Elde Etme:** İçerik satışı, abonelik sistemleri ve bağışlar yoluyla gelir elde etme fırsatları.
- **Topluluk Oluşturma:** Yazarlar ile okuyucular arasında etkileşim sağlama.
- **Dinamik Ana Sayfa:** Öne çıkan, rastgele ve popüler makaleler gibi dinamik içerik alanları.
- **Detaylı Makale Sayfası:** Makale metni, görseller, yazar bilgisi ve ilgili içeriklerin görüntülendiği detaylı sayfa.
- **Kategoriye Özel Arama Sayfası:** Belirli kategorilerde içerik aramayı kolaylaştıran fonksiyon.
- **Hakkımızda Sayfası:** Platform ve ekip hakkında detaylı bilgi.

## 🎥 Demo Video

Projenin nasıl çalıştığını görmek için aşağıdaki demo videosunu izleyebilirsiniz:

[![Demo Video](https://img.youtube.com/vi/KoCqKC_lOBQ/0.jpg)](https://www.youtube.com/watch?v=KoCqKC_lOBQ)

## ⚙️ Geliştirme Notları

- Veritabanı şeması platformun işlevselliğine göre optimize edilmiştir.
- **AppUser** ve **AppRole** tabloları, ASP.NET Identity ile entegre olarak kullanılmıştır.
- **Article** tablosu, makale yönetimi için gerekli tüm bilgileri içermektedir.
- Etiketler, makale kategorizasyonu ve arama işlemleri için kullanışlı bir yapı oluşturmaktadır.

## 💡 Gelecek Geliştirmeler

- Mobil uygulama geliştirme
- Yapay zeka entegrasyonu
- Yeni gelir modelleri ve içerik türlerinin eklenmesi

## 🚀 Kurulum

Projeyi klonlayıp çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

## Nasıl Kullanabilirsin
```bash
1. Repoyu klonlayın
git clone https://github.com/hamzaagunduz/BeldYazilim_ASP.NET-CORE-8.0-WebApi
cd blog-platformu
## 2.Gerekli bağımlılıkları yükleyin
dotnet restore
3. Connection Stringi düzenleyin ardından Veritabanını oluşturun ve migrate edin
dotnet ef database update
4. Uygulamayı başlatın
dotnet run


