Döviz Çeviri Uygulaması


Bu uygulama, C# programlama dili kullanılarak geliştirilmiş bir döviz çeviri uygulamasıdır. Uygulama, kullanıcıların dört farklı para birimi arasında dönüşüm yapmasına olanak tanır: Amerikan Doları (USD), Euro (EUR), İngiliz Sterlini (GBP) ve Türk Lirası (TRY).

Özellikler ;

Kullanıcılar dört farklı para birimi arasında dönüşüm yapabilir: USD, EUR, GBP ve TRY.
Güncel döviz kurları sabit olarak tutulur ve uygulama başlatıldığında otomatik olarak yüklenir.
Kullanıcılar, girdikleri tutarın dönüştürülmüş değerini görebilirler.
Uygulama, kullanıcıların hatalı girişler yapmasını önlemek için doğrulama yapar.
Kullanılan Teknolojiler
C# programlama dili
Visual Studio IDE
.NET Framework

Kurulum ;

Bu uygulama, .NET Framework kullanılarak geliştirilmiştir. Uygulamayı çalıştırmak için bilgisayarınızda .NET Framework yüklü olmalıdır.

Bu GitHub deposunu kopyalayın veya indirin.
Visual Studio IDE veya bir benzeri programı açın.
ExchangeRates.cs dosyasını açın ve döviz kurlarını düzenleyin, gerektiği gibi değiştirin.
Uygulamayı derleyin ve çalıştırın.

Kullanım ;

Uygulama, bir konsol uygulamasıdır. Başlatıldığında, kullanıcılar bir para birimi seçmeleri istenir. Kullanıcı, dönüştürmek istediği para birimini seçtikten sonra, dönüştürülecek tutarı girmeleri istenir. Uygulama, kullanıcının girdiği tutarı, seçilen para birimine göre dönüştürür ve sonucu konsolda gösterir.

// Örnek kullanım
CurrencyConverter converter = new CurrencyConverter();
string fromCurrency = "USD";
string toCurrency = "EUR";
decimal amount = 100.00M;

decimal result = converter.ConvertCurrency(fromCurrency, toCurrency, amount);
Console.WriteLine($"{amount} {fromCurrency} = {result} {toCurrency}");
