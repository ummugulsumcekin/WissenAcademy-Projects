***Rock Paper Scissors Game***


Bu, klasik taş-kağıt-makas oyununun bir bilgisayar versiyonudur. Oyun, kullanıcının seçtiği taş, kağıt veya makasa karşı bilgisayarın seçimi ile eşleştirilir. Sonuç, seçilen öğelerin kombinasyonuna göre belirlenir. Kullanıcı ve bilgisayarın skoru kaydedilir ve oyun sonlandırıldığında kazanan bildirilir.

*Başlangıç;
Bu oyunu kendi bilgisayarınızda oynamak için aşağıdaki adımları takip edebilirsiniz:

*Gereksinimler;

Bu projeyi çalıştırmak için aşağıdaki yazılımların yüklü olması gerekmektedir:

Visual Studio 2019
.NET Framework 4.7.2

*Kurulum;
Bu projenin Github sayfasına gidin ve projeyi indirin veya kopyalayın.
Visual Studio 2019'u açın.
"File" -> "Open" -> "Project/Solution" seçeneklerini kullanarak projeyi açın.
Projeyi çalıştırın.

*Kullanım;
Oyun, kullanıcının taş, kağıt veya makas seçimleri için düğmeler içeren bir kullanıcı arayüzüne sahiptir. Kullanıcının seçimiyle birlikte, bilgisayarın rastgele seçtiği öğe de görüntülenir. Sonuç, kullanıcının seçimine ve bilgisayarın seçimine göre belirlenir.

Kullanıcının ve bilgisayarın skoru oyun boyunca kaydedilir ve her oyun sonunda ekranda görüntülenir. Oyunu sonlandırmak için "Exit" düğmesine basabilirsiniz.


![taskagıtmakas](https://user-images.githubusercontent.com/102469765/236487146-75482561-c839-4556-9f34-a6110a7ac018.png)

***Word Guessing Game***


Açıklama; 

Bu program, kelimeleri tahmin etmek üzerine basit bir tahmin oyunudur. Program, belirli bir kelime havuzundan rasgele bir kelime seçer ve kullanıcının kelimenin hangi harflerinin olduğunu tahmin etmesine olanak tanır.

Nasıl Çalışır?;

Program çalıştırıldığında, rastgele bir kelime havuzundan seçilen bir kelime ekrana yazdırılır ve kaç harf içerdiği bildirilir. Kullanıcı, her turda bir harf tahmini yapar. Tahmin kelime içinde varsa, kelimenin hangi pozisyonlarında olduğu gösterilir. Eğer tüm harfler doğru tahmin edilirse oyun kazanılır.

Oyun, 6 tahmin hakkı ile başlar. Kullanıcının tahmini kelime içinde yoksa, kalan tahmin hakkı azalır ve kullanıcıya kaç tahmin hakkının kaldığı bildirilir. Oyun, kullanıcının tüm tahmin haklarını kullanana kadar devam eder.

Kurulum;

Bu projeyi kendi bilgisayarınıza indirin veya kopyalayın.
C# derleyicisi (örn. Visual Studio, .NET Core) kullanarak WordGuessingGame.cs dosyasını derleyin.
Oluşturulan uygulamayı çalıştırın.

Kullanılan Teknolojiler;

C#
