# Kütüphane Yönetim Sistemi - MVC Projesi

Bu proje, **ASP.NET Core MVC** kullanılarak geliştirilmiş bir **Kütüphane Yönetim Sistemi** uygulamasıdır. Proje, kitaplar ve yazarlar arasındaki ilişkileri yönetmek için kapsamlı bir sistem sunmaktadır. **Model-View-Controller (MVC)** mimarisi kullanılarak tasarlanmış ve nesne yönelimli programlama (OOP) prensiplerine sadık kalınmıştır.

## Proje Tanımı

Bu proje, bir kütüphanede kitapların ve yazarların yönetimi için gerekli tüm işlemleri sunan bir sistemdir. Kullanıcılar kitapları ekleyebilir, düzenleyebilir, silebilir ve detaylarını görüntüleyebilirler. Ayrıca, yazarlar hakkında bilgi ekleyebilir ve düzenleyebilirler.

## Kullanılan Teknolojiler

Bu proje, modern web geliştirme araçları ve teknolojileri kullanılarak geliştirilmiştir.

- **ASP.NET Core MVC**: Model-View-Controller mimarisini kullanarak web uygulamalarının geliştirilmesini sağlayan framework.
- **C#**: ASP.NET Core ile uyumlu olan ve nesne yönelimli programlamayı destekleyen güçlü bir programlama dili.
- **Entity Framework Core (EF Core)**: ORM (Object-Relational Mapping) kullanarak veri işlemlerini kolaylaştıran araç. (Bu projede veritabanı bağlantısı yoktur.)
- **Razor Views**: HTML ile C# kodlarının birlikte işlendiği, dinamik içerik oluşturulmasını sağlayan view motoru.
- **HTML5 & CSS3**: Uygulamanın yapılandırılması ve stilini oluşturmak için kullanılan temel web teknolojileri.
- **Bootstrap**: Sayfa tasarımının hızlı ve duyarlı (responsive) olmasını sağlamak için kullanılan açık kaynaklı CSS framework'ü.
- **Git & GitHub**: Proje sürüm kontrolü ve işbirliği için kullanılan araçlar.

## Proje Yapısı

### Modeller

- **Book Modeli**:
  - `Id`: Kitap için benzersiz kimlik (int)
  - `Title`: Kitap başlığı (string)
  - `AuthorId`: Yazar kimliği (int)
  - `Genre`: Kitap türü (string)
  - `PublishDate`: Yayın tarihi (DateTime)
  - `ISBN`: ISBN numarası (string)
  - `CopiesAvailable`: Mevcut kopya sayısı (int)

- **Author Modeli**:
  - `Id`: Yazar için benzersiz kimlik (int)
  - `FirstName`: Yazar adı (string)
  - `LastName`: Yazar soyadı (string)
  - `DateOfBirth`: Yazar doğum tarihi (DateTime)

### ViewModel'ler

- **Book ViewModel**: Kitapların ve detaylarının görüntüleneceği sayfalarda kullanılacak ViewModel.
- **Author ViewModel**: Yazarların ve detaylarının görüntüleneceği sayfalarda kullanılacak ViewModel.

### Controller'lar

- **BookController**: Kitaplarla ilgili işlemleri yönetir.
  - `List`: Kitapların listesini görüntüler.
  - `Details`: Belirli bir kitabın detaylarını gösterir.
  - `Create`: Yeni kitap eklemek için form sağlar.
  - `Edit`: Var olan bir kitabı düzenlemek için form sağlar.
  - `Delete`: Kitap silmek için onay sayfası sağlar.

- **AuthorController**: Yazarlarla ilgili işlemleri yönetir.
  - `List`: Yazarların listesini görüntüler.
  - `Details`: Belirli bir yazarın detaylarını gösterir.
  - `Create`: Yeni yazar eklemek için form sağlar.
  - `Edit`: Var olan bir yazarı düzenlemek için form sağlar.
  - `Delete`: Yazar silmek için onay sayfası sağlar.


