
// 1 - Merhaba Nasılsın ? İyiyim Sen nasılsın ? cıktıyı yazan bir program :

Console.WriteLine("Merhaba \nNasılsın ? \nİyiyim \nSen nasılsın?");
Console.WriteLine("----------------------------------------------------------------");

// 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

string name = "Ahmet";
int number = 61;
Console.WriteLine($"{number} - {name}");
Console.WriteLine("----------------------------------------------------------------");

// 3 - Rastgele bir sayı üretip , ekrana yazdırınız.

Random rnd = new Random();
int randomNumber = rnd.Next();
Console.WriteLine($"Random number: {randomNumber}");
Console.WriteLine("----------------------------------------------------------------");

// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

int randomNumberForMod = rnd.Next();
int remainder = randomNumberForMod % 3;
Console.WriteLine($"Rastgele sayı: {randomNumberForMod}, 3'e bölümünden kalan: {remainder}");
Console.WriteLine("----------------------------------------------------------------");

// 5 -  Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

Console.WriteLine("Yaşınızı giriniz:");
int age = Convert.ToInt32(Console.ReadLine());
if (age > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
Console.WriteLine("----------------------------------------------------------------");

// 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("----------------------------------------------------------------");

// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("Arada virgül kullanarak 2 adet isim giriniz.");
string userInput = Console.ReadLine();
string[] names = userInput.Split(',');
names[0] = "Gülse Birsel";
names[1] = "Demet Evgar";
foreach (string ID in names)
Console.WriteLine(ID);
Console.WriteLine("----------------------------------------------------------------");

// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();
Console.WriteLine("----------------------------------------------------------------");

// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

static int Topla(int num1, int num2)
{
    return num1 + num2;
}
Console.WriteLine(Topla(30, 55));
Console.WriteLine("----------------------------------------------------------------");

// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

Console.WriteLine("Lütfen true ya da false giriniz:");
string choice = Console.ReadLine();


string result = GetStringFromBoolean(choice);
Console.WriteLine("Sonuç: " + result);
    
    static string GetStringFromBoolean(string choice)
{
    if (bool.TryParse(choice, out bool booleanValue))
    {
        return booleanValue ? "Doğru" : "Yanlış";
    }
    else
    {
        return "";
    }
}
Console.WriteLine("----------------------------------------------------------------");

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

Console.Write("Birinci kişinin yaşını girin: ");
int age1 = int.Parse(Console.ReadLine());

Console.Write("İkinci kişinin yaşını girin: ");
int age2 = int.Parse(Console.ReadLine());

Console.Write("Üçüncü kişinin yaşını girin: ");
int age3 = int.Parse(Console.ReadLine());

int oldAge = EnYasliYas(age1, age2, age3);
Console.WriteLine("En yaşlı kişinin yaşı: " + oldAge);

static int EnYasliYas(int age1, int age2, int age3)
{
    return Math.Max(age1, Math.Max(age2, age3));
}
Console.WriteLine("----------------------------------------------------------------");

// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
    
     double largestNumber = FindLargestNumber();
        if (largestNumber != double.MinValue)
        {
            Console.WriteLine($"En büyük sayı: {largestNumber}");
        }
        else
        {
            Console.WriteLine("Hiç sayı girilmedi.");
        }
     static double FindLargestNumber()
     {
        Console.WriteLine("Sayıları girin. Sayı girme işleminizi bitirince lütfen 'w' girin.");
        double largestNumber = double.MinValue;
        bool numberEntered = false;
        while (true)
        {
            string girilen = Console.ReadLine();

            if (girilen.ToLower() == "w")
            {
                break;
            }

            if (double.TryParse(girilen, out double sayi))
            {
                if (sayi > largestNumber)
                {
                    largestNumber = sayi;
                    numberEntered = true;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz sayı. Lütfen tekrar deneyin.");
            }
        }

        return numberEntered ? largestNumber : double.MinValue;
     }


Console.WriteLine("----------------------------------------------------------------");

// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

Console.Write("Birinci ismi girin: ");
string ID1 = Console.ReadLine();
Console.Write("İkinci ismi girin: ");
string ID2 = Console.ReadLine();
Degistir(ref ID1, ref ID2);
Console.WriteLine("İsimlerin yer değiştirdikten sonraki hali:");
Console.WriteLine("Birinci isim: " + ID1);
Console.WriteLine("İkinci isim: " + ID2);
static void Degistir(ref string ID1, ref string ID2)
{
    string temp = ID1;
    ID1 = ID2;
    ID2 = temp;
}
Console.WriteLine("----------------------------------------------------------------");

// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

Console.Write("Bir sayı girin: ");
int numb = Convert.ToInt32(Console.ReadLine());

bool OddN = TekMi(numb);
Console.WriteLine($"Sayı tek mi?: {OddN}");
    static bool TekMi(int numb)
{
    return numb % 2 != 0;
}

Console.WriteLine("----------------------------------------------------------------");

// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.Write("Hızı girin (km/saat): ");
double speed = Convert.ToDouble(Console.ReadLine());
Console.Write("Zamanı girin (saat): ");
double time = Convert.ToDouble(Console.ReadLine());
double road = HesaplaYol(speed, time);
Console.WriteLine($"Gidilen yol: {road} kilometre");
    static double HesaplaYol(double speed, double time)
{
    return speed * time;
}
Console.WriteLine("----------------------------------------------------------------");

// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

double radius = 8.0;
double area = DaireCapıHesapla(radius);
Console.WriteLine("Dairenin Alanı: " + area);
static double DaireCapıHesapla(double radius)
{
    double pi = Math.PI;
    return pi * radius * radius;
}
Console.WriteLine("----------------------------------------------------------------");

// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string message = "Zaman bir GeRi SayIm";
string upperCaseText = message.ToUpper();
string lowerCaseText = message.ToLower();
Console.WriteLine(upperCaseText);
Console.WriteLine(lowerCaseText);
Console.WriteLine("----------------------------------------------------------------");

// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string text = "      Merhaba     ";
string trimmedText = text.Trim();
Console.WriteLine(trimmedText);