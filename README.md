# Kutuphane Otomasyonu

Bu proje, bir **Kitap Otomasyonu** sistemini yönetmek için geliştirilmiş bir Windows Form uygulamasıdır. Proje, **Katmanlı Mimari** kullanılarak geliştirilmiş olup, **Code First** yaklaşımı ile **Entity Framework** ile veritabanı yönetimi sağlanmıştır. Uygulama, kitapların takibini, kullanıcıların eklenmesini ve yönetilmesini sağlar.

## Özellikler

- **Kitap Yönetimi**: Kitap ekleme, güncelleme, silme ve listeleme işlemleri yapılabilir.
- **Kullanıcı Yönetimi**: Kullanıcı ekleme, güncelleme, silme ve kullanıcıların kitaplarla ilişkili işlemleri yönetme imkanı.
- **Katmanlı Mimari**: Proje, iş mantığını (Business Layer), veri erişimini (Data Access Layer) ve kullanıcı arayüzünü (UI Layer) birbirinden ayırarak düzenli bir yapı sunar.
- **Code First Yaklaşımı**: Veritabanı oluşturulurken **Entity Framework** kullanılarak veritabanı modelleri doğrudan C# sınıflarıyla oluşturulmuştur.
- **Windows Form UI**: Kullanıcı dostu bir arayüz ile kitap ve kullanıcı yönetimi işlemleri yapılır.

## Kullanılan Teknolojiler

- **C#**: Proje geliştirme dili.
- **Entity Framework**: Veritabanı yönetimi için Code First yaklaşımı ile kullanılmıştır.
- **Windows Forms**: UI kısmı Windows Form teknolojisi ile geliştirilmiştir.
- **SQL Server**: Veritabanı yönetimi için kullanılmaktadır.

## Kurulum

1. Projeyi GitHub üzerinden ya da ZIP dosyası olarak indirip, Visual Studio'ya aktarın.
2. **NuGet** paket yöneticisini kullanarak gerekli Entity Framework paketlerini yükleyin:
   - `Install-Package EntityFramework`
3. Veritabanı için gerekli bağlantı string'ini **App.config** dosyasına ekleyin.
4. Veritabanını oluşturmak için Entity Framework Code First yaklaşımını kullanarak **migrasyonlar** yapın:
   - `Enable-Migrations`
   - `Add-Migration InitialCreate`
   - `Update-Database`
   
   Bu adımlar, veritabanını oluşturacak ve tabloları uygulamanızla uyumlu hale getirecektir.

## Kullanım

1. **Uygulamayı Başlatın**: Visual Studio'da projeyi çalıştırarak uygulamayı başlatın.
2. **Kitap Eklemek**: Kitap eklemek için "Kitaplar" menüsüne gidin ve gerekli kitap bilgilerini girerek ekleme işlemini gerçekleştirin.
3. **Kullanıcı Ekleme**: Kullanıcı eklemek için "Kullanıcılar" menüsüne gidin ve gerekli bilgileri girerek yeni kullanıcı ekleyin.
4. **Kitapları Listeleme**: Sistemdeki kitapları görüntülemek için ana ekran üzerinden kitap listesini görebilirsiniz.

## Katmanlı Mimari Yapısı

Proje, üç ana katmandan oluşmaktadır:

1. **UI Layer (Windows Forms)**: Kullanıcı arayüzü burada bulunur ve kullanıcının etkileşimde bulunduğu tüm öğeler bu katmanda yer alır.
2. **Business Layer**: İş mantığını barındıran katmandır. Kitap ekleme, güncelleme ve silme işlemleri burada yapılır.
3. **Data Access Layer**: Entity Framework ile veritabanı işlemleri burada yapılır. Veritabanı bağlantıları ve sorgular bu katmanda yönetilir.

## Kod Yapısı

- **Entities**: Veritabanındaki tablolara karşılık gelen sınıflar.
- **Data Access Layer**: Veritabanı işlemleri için kullanılan sınıflar ve Entity Framework DbContext sınıfı.
- **Business Layer**: İş mantığının yer aldığı sınıflar.
- **UI Layer**: Windows Forms'tan oluşan kullanıcı arayüzü.

## Katmanlı Mimari İle İlgili Detaylar

- **Code First Yaklaşımı**: Entity Framework'ün Code First yaklaşımı kullanılarak veritabanı tasarımı yapılmıştır. Bu, veri tabanı şemasını doğrudan C# sınıflarından türetmeyi sağlar.
- **Veritabanı Modelleme**: `DbContext` sınıfı kullanılarak veritabanı ve tablolar yönetilmektedir. Bu sınıflar, kitaplar ve kullanıcılar gibi ana varlıkları temsil etmektedir.
  


