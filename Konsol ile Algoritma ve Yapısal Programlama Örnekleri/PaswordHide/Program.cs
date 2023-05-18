/*kullanıcı giriş ekranında yazılan şifreler, klavyeden her bir karaktere basıldığında
ekrana o karakter yerine * karakteri yazılarak gizli hale getirilecektir.
Girilen şifre sadece ekranda * karakterleri ile değiştirilmemeli, aynı zamanda arka planda enter tuşuna
basılana kadar bekletilmelidir. Yazılımı test etmek için girilen şifreyi enter tuşundan sonra ekrana
yansıtılacaktır*/


Console.WriteLine(@"//////////////\\\\\\\\\\\\\\
|| Lorem Ipsum CRM System ||
\\\\\\\\\\\\\\//////////////
Lütfen kullanıcı adınızı ve parolanızı giriniz.");
Console.Write("Kullanıcı Adı: ");
Console.ReadLine();
Console.Write("Parola: ");

string password = string.Empty;
while(true)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (keyInfo.Key == ConsoleKey.Enter)
    {
        break;
    }
    Console.Write("*");
    password += keyInfo.KeyChar;
}
