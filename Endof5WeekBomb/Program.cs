
using System.Reflection.Emit;

Console.WriteLine("Araba uretmek ister misiniz? Eger cevabiniz evetse e harfine hayirsa h harfine basiniz.");
string answer = Console.ReadLine().ToLower();
while (true)
{
    if (answer == "e")//Cevap evet ise 
    {
        int kapiSayisi = 0;
        Console.WriteLine("Arabaniz uretilmeyen baslandi..");
        Console.WriteLine("Arabanizin seri numarasini giriniz");
        string seriNo = Console.ReadLine();
        Console.WriteLine("Arabanizin markasini giriniz");
        string marka = Console.ReadLine();
        Console.WriteLine("Arabanizin modelini giriniz");
        string model = Console.ReadLine();
        Console.WriteLine("Arabanizin rengini giriniz");
        string renk = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("Arabanizin kapi sayisini giriniz:");
            try//Try catch kullanarak kullanicinin yanlis input girmesi durumunda exception firlatilmasi onlenildi
            {
                kapiSayisi = Convert.ToInt32(Console.ReadLine());
                break; // Exit loop if conversion is successful
            }
            catch (FormatException)
            {
                Console.WriteLine("Hata: Sayı formatı geçersiz. Lütfen bir kapı sayısı giriniz.");
            }
        }
        Araba araba = new Araba(DateTime.Now, seriNo, marka, model, renk, kapiSayisi);

        List<Araba> list = new List<Araba>();// araba listesi olusturma
        list.Add(araba);//listeye araba ekleme
        Console.WriteLine("Baska araba uretmek istiyor musunuz? Eger cevabiniz evetse e harfine hayirsa h harfine basiniz.");
        answer = Console.ReadLine().ToLower();
    }

    else if (answer == "h") //cevap hayir ise
    {
        Console.WriteLine("Araba uretimi yapimiyor..");
        break;
    }
    else//Gecersiz bir cevap verildiyse
    {
        Console.WriteLine("Gecersiz bir cevap verdiniz.Lutfen Tekrar secim yapin!!");

    }
}


Console.ReadKey();
class Araba
{
    //Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı

    public DateTime UretimTarihi { get; }
    public string SeriNumarasi { get; }
    public string Marka { get; }
    public string Model { get; }
    public string Renk { get; }
    public int KapiSayisi { get; }
    public Araba(DateTime uretimTarihi, string seriNumarasi, string marka, string model, string renk, int kapiSayisi)
    {
        UretimTarihi = uretimTarihi;
        SeriNumarasi = seriNumarasi;
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi;

    }

}


