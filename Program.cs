/*******************************************************************************
            **                         SAKARYA ÜNİVERSİTESİ                               **
            **                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                   **
            **                 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                     **
            **                 NESNEYE DAYALI PROGRAMLAMA DERSİ                           **
            **                         2019-2020 BAHAR DÖNEMİ                             **
            **                                                                            **
            **                        ÖDEV NUMARASI:[1]                                   **
            **                          ÖĞRENCİ ADI: [ESSRAA BAKR].                       **
            **                           DERSİN ALINDIĞI GRUP:[A]                         **
            **                                                                            **
            ** *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int main_menu;
            bool dongu = true;
            while (dongu)
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = "MAGIC TRAVEL IN TURKEY";
                Console.WriteLine("*****Attractions and Historic Attractions in Turkey*****");
                Console.WriteLine("let’s go together to a short cultural trip in Turkey");
                Console.WriteLine("Please choose a number from one to seven to have information about the area");
                Console.WriteLine("1.Marmara");
                Console.WriteLine("2.Black sea");
                Console.WriteLine("3.Aegean");
                Console.WriteLine("4.Central Anatolia");
                Console.WriteLine("5.Eastern Anatolia");
                Console.WriteLine("6.Mediterranean");
                Console.WriteLine("7.southeat Anatolia");
                int i;
                i = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    dongu = false;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("34.İSTANBUL");
                    Console.WriteLine("54.SAKARYA");
                    Console.WriteLine("10.BAKLİKESİR");
                    Console.WriteLine("17.ÇANAKKALE");
                    Console.WriteLine("41.KOCAELİ");
                    Console.WriteLine("56.TEKİRDAGİ");
                    Console.WriteLine("77.YOLOVA");
                    Console.WriteLine("22.EDİRNE");
                    Console.WriteLine("11.BİLECİK");
                    Console.WriteLine("16.BURSA");
                    Console.WriteLine("please select from the numbers we knew");

                    int city_​​code;
                    city_​​code = Convert.ToUInt16(Console.ReadLine());
                    Console.Clear();
                    switch (city_​​code)
                    {
                        case 34:
                            Console.WriteLine("****WELCOME TO ISTANBUL****");
                            Console.WriteLine("1.Topkapı Sarayı Müzesi:Topkapi Palace Museum");
                            Console.WriteLine("2.Sultan Ahmet Camii");
                            Console.WriteLine("3.Yerebatan Sarnıcı:Basilica Cistern");
                            Console.WriteLine("4.BELTUR Galata Kulesi:BELTUR Galata Tower");
                            Console.WriteLine("5.Dolmabahçe Sarayı:Dolmabahçe Palace");
                            Console.WriteLine("6.rumeli hisar:rumeli hisar castle");
                            Console.WriteLine("7.Anadolu hisar:castle");
                            Console.WriteLine("8.eyyup sultan");
                            Console.WriteLine("9.beşiktaş sahili:besiktas beach");
                            Console.WriteLine("10.beylerbeyi sahili:beylerbeyi beach:");
                            Console.WriteLine("11.çamlıca tepesi:camlica hill");
                            Console.WriteLine("12.emirgan korusu:emirgan grove");
                            Console.WriteLine("13.istiklal caddesi:istiklal Street");
                            Console.WriteLine("14.fatih korusu:fatih grove");
                            Console.WriteLine("15.İstiklal Avenue");
                            Console.WriteLine("16.Bebek Sahili:Baby Beach");
                            Console.WriteLine("17.Kapalıçarşı:Grand Bazaar");
                            Console.WriteLine("18.Bağdat Caddesi:bagdat Street");
                            Console.WriteLine("19.Eminönü");
                            Console.WriteLine("20.Galata");
                            Console.WriteLine("21.Pera Müzesi:Pera Museum");
                            Console.WriteLine("22.Etiler");
                            Console.WriteLine("23.Şile sahili:Şile coast");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 54:
                            Console.WriteLine("****WELCOME TO SAKARYA ****\n");
                            Console.WriteLine("TRADITIONAL FOOD:");
                            Console.WriteLine("Places to visit in Sakarya");
                            Console.WriteLine("1.kent park:city ​​park");
                            Console.WriteLine("2.sapanca:Lake");
                            Console.WriteLine("3.uzun çarşi:traditional bazaar");
                            Console.WriteLine("4.kartepe:snow hill");
                            Console.WriteLine("5.Sakarya Aqua Park Tatil Köyü:Sakarya Aqua Park Holiday Village");
                            Console.WriteLine("6.Serdivan Gölpark:Serdivan Lake park");
                            Console.WriteLine("7.Sakarya Sanat Galerisi:Sakarya Art Gallery");
                            Console.WriteLine("8.Deprem Kültür Müzesi:Earthquake Culture Museum");
                            Console.WriteLine("9.CARK Avenue");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 10:
                            Console.WriteLine("****WELCOME TO balikesir****\n");
                            Console.WriteLine("TRADITIONAL FOOD:PUMPKIN DESSERT");
                            Console.WriteLine("Places to visit in Balikesir");
                            Console.WriteLine("1.kaz dağı:(Mountain)");
                            Console.WriteLine("2.Avşa Adası:(Avsa Island)");
                            Console.WriteLine("3.Sütüven Şelalesi:(Sutuven Waterfall)");
                            Console.WriteLine("4.Kuş Gölü:(lake)");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 17:
                            Console.WriteLine("****WELCOME TO CANAKKALE****\n");
                            Console.WriteLine("Places to visit in canakkale");
                            Console.WriteLine("1.7. Truva Antik Kenti:(7. Troy Ancient City)");
                            Console.WriteLine("2.Çanakkale Şehitleri Müzesi(Çanakkale Martyrs Museum)");
                            Console.WriteLine("Çanakkale Deniz Müzesi:çanakkale maritime Museum");
                            Console.WriteLine("Çimenlik Kalesi:Cimenlik Castle");
                            Console.WriteLine("Namazgah Tabyası:Namazgah Bastion");
                            Console.WriteLine("ana nenüye dönmek icin 0 basınız");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 41:
                            Console.WriteLine("****WELCOME TO KOCAELI****\n");
                            Console.WriteLine("TRADITIONAL FOOD:pishmaniye");
                            Console.WriteLine("Places to visit in kocaeli");
                            Console.WriteLine("1.Kasr - ı Hümayun Saray Müzesi:(Kasr - ı Hümayun Palace Museum)");
                            Console.WriteLine("2.Selim Sırrı Paşa Konağı:(Selim Sırrı Pasha Mansion)");
                            Console.WriteLine("Yuvacık Başiskele Cami");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 56:
                            Console.WriteLine("****WELCOME TO TEKİRDAGİ****\n");
                            Console.WriteLine("TRADITIONAL FOOD: tekirdagi's meatballs");
                            Console.WriteLine("Places to visit in tekirdaği");
                            Console.WriteLine("1.Rakoczi Müzesi:(  Rakoczi Museum)");
                            Console.WriteLine("2.Tekirdağ Arkeoloji ve Etnografya Müzesi:(Tekirdağ Archeology and Ethnography Museum)");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 77:
                            Console.WriteLine("****WELCOME TO YOLOVA****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Yalova Kebab");
                            Console.WriteLine("Places to visit in yolova");
                            Console.WriteLine("1.Kapılıçınar Piknik Alani:(Kapılıçınar Picnic Area)");
                            Console.WriteLine("2.Yalova Kent Müzesi(Kapılıçınar Picnic Area)");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 22:
                            Console.WriteLine("****WELCOME TO EDİRNE****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Almond butter.");
                            Console.WriteLine("Places to visit in edirne");
                            Console.WriteLine("1.Selimiye Camii:(Selimiye Mosque)");
                            Console.WriteLine("2.Edirne Sarayı(Edirne Palace)");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 11:
                            Console.WriteLine("****WELCOME TO BİLECİK****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Stuffed peppers");
                            Console.WriteLine("Places to visit in bilecik");
                            Console.WriteLine("1.Şeyh Edebali Türbesi:(Şeyh Edebali Tomb)");
                            Console.WriteLine("2.Bilecik Saat Kulesi:(Bilecik Clock Tower)");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 16:
                            Console.WriteLine("****WELCOME TO BURSA****\n");
                            Console.WriteLine("TRADITIONAL FOOD:İskender");
                            Console.WriteLine("Places to visit in bursa");
                            Console.WriteLine("1.Ulu Cami:(.Grand Mosque)");
                            Console.WriteLine("2.İnkaya Tarihi Çınar ağacı(İnkaya Historical Plane Tree)");
                            Console.WriteLine("3. Bursa Teleferik(Bursa Cable Car)");
                            Console.WriteLine("Yeşil Türbe:Green shrine");
                            Console.WriteLine("Bursa Hayvanat Bahçesi:Bursa Zoo");
                            Console.WriteLine("Muradiye Külliyesi:Muradiye Complex");
                            Console.WriteLine(" Emir Sultan Cami ve Külliyesi");
                            Console.WriteLine("Uludağ Kayak Merkezi:Uludag Ski Center");
                            Console.WriteLine("Uluumay Osmanlı Halk Kıyafetleri ve Takıları Müzesi:Uluumay Ottoman Folk Clothing and Jewelry Museum");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                    }

                }

                else if (i == 2)

                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("05.Amasya");
                    Console.WriteLine("08 Artvin");
                    Console.WriteLine("14 Bolu");
                    Console.WriteLine("19 Çorum");
                    Console.WriteLine("28 Giresun");
                    Console.WriteLine("29 Gümüşhane");
                    Console.WriteLine("52 Ordu");
                    Console.WriteLine("53 Rize");
                    Console.WriteLine("55 Samsun");
                    Console.WriteLine("57 Sinop");
                    Console.WriteLine("60 Tokat");
                    Console.WriteLine("61 Trabzon");
                    Console.WriteLine("67 Zonguldak");
                    Console.WriteLine("69 Bayburt");
                    Console.WriteLine("55 Samsun");
                    Console.WriteLine("74 Bartın");
                    Console.WriteLine("78 Karabük");
                    Console.WriteLine("81 Düzce");
                    Console.Write("please enter the province code");
                    int city_​​code1;
                    city_​​code1 = Convert.ToUInt16(Console.ReadLine());
                    Console.Clear();
                    switch (city_​​code1)
                    {
                        case 05:
                            Console.WriteLine("****WELCOME TO AMASYA****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Helle soup");
                            Console.WriteLine("Places to visit in Amasya");
                            Console.WriteLine("1.Amasra Kalesi:Amasra Castle");
                            Console.WriteLine("2.Kral Kaya Mezarları:King Rock Tombs");
                            Console.WriteLine("3.Amasya yalıboyu evleri:Amasya insulation homes");
                            Console.WriteLine("4.Ferhat Su Kanalı:Ferhat Water Channel");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 08:
                            Console.WriteLine("****WELCOME TO ARTVİN****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Pushal   Ovmaç çorbası");
                            Console.WriteLine("Places to visit in Artvin");
                            Console.WriteLine("1.Maral Şelalesi:(Maral Waterfall)");
                            Console.WriteLine("2.Hatila Vadisi Millî Parkı:(Hatila Valley National Park)");
                            Console.WriteLine("3.Borçka Karagöl Tabiat Parkı:(Borcka Karagol Nature Park)");
                            Console.WriteLine("4.kartepe:snow hill");
                            break;
                        case 14:
                            Console.WriteLine("****WELCOME TO BOLU****\n");
                            Console.WriteLine(" TRADITIONAL FOOD:Ovmac soup");
                            Console.WriteLine("Places to visit in Bolu");
                            Console.WriteLine("1.Gölcük Tabiat Parkı:Gölcük Nature Park");
                            Console.WriteLine("2.Abant Gölü:Lake Abant");
                            Console.WriteLine("3.Sülüklü Göl Tabiat Parkı:Sülüklü Lake Nature Park");
                            Console.WriteLine("4.Cubuk Gölü:Lake Cubuk");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 19:
                            Console.WriteLine("****WELCOME TO ÇORUM****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Kuzu Tandır,Sobelek stuffed");
                            Console.WriteLine("Places to visit in Çorum");
                            Console.WriteLine("1.Çorum Müzesi:CHorum Museum");
                            Console.WriteLine("2.Çorum Kalesi:CHorum Castle");
                            Console.WriteLine("3.Ayakkabıcılar Arastası:Shoemakers' Break");
                            Console.WriteLine("4.Troya Tarihi Milli Parkı:Troy Historical National Park");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 28:
                            Console.WriteLine("****WELCOME TO GİRASUN****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Corn bread");
                            Console.WriteLine("Places to visit in Girasun");
                            Console.WriteLine("1.Giresun Adası:Giresun Island");
                            Console.WriteLine("2.Giresun Müzesi:Giresun Museum");
                            Console.WriteLine("3.Giresun Kalesi:Giresun Castle");
                            Console.WriteLine("4.Seyyid Vakkas Türbesi:Seyyid Vakkas Tomb");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 29:
                            Console.WriteLine("****WELCOME TO GÜMÜŞHANE****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Pestil ve Kome");
                            Console.WriteLine("Places to visit in Gümüşhane");
                            Console.WriteLine("1.Tomara Şelalesi:Tomara Waterfall");
                            Console.WriteLine("2.Örümcek Ormanı Tabiatı Koruma Alanı:Spider Forest Nature Reserve");
                            Console.WriteLine("4.Torul Kalesi:Torul Castle");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 52:
                            Console.WriteLine("****WELCOME TO ORDU****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Pancar karalahana diblesi");
                            Console.WriteLine("Places to visit in Ordu");
                            Console.WriteLine("1.Çambaşı Yaylası:chambashı Plateau");
                            Console.WriteLine("2.Etnografya Müzesi:ethnography Museum");
                            Console.WriteLine("3.Perşembe Yaylası:Thursday Plateau");
                            Console.WriteLine("4.Ohtamış Şelalesi:Ohtamısh Waterfall");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 53:
                            Console.WriteLine("****WELCOME TO RİZA****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Rize Pidesi,Rice pudding");
                            Console.WriteLine("Places to visit in Rize");
                            Console.WriteLine("1.Palovit Şelalesi:Palovit Waterfall");
                            Console.WriteLine("2.Zil Kalesi:Bell Castle");
                            Console.WriteLine("3.Senyuva koprusu:senyuva bridge");
                            Console.WriteLine("4.Ovit Yaylası:Ovit Plateau");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 55:
                            Console.WriteLine("****WELCOME TO SAMSUN****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Baklalı Sarma,Büryan");
                            Console.WriteLine("Places to visit in Samsun");
                            Console.WriteLine("1.şahinkaya kanyonu:sahinkaya canyon");
                            Console.WriteLine("2.Gazi Müzesi:Gazi Museum");
                            Console.WriteLine("3.Samsun Amazon Heykeli:Samsun Amazon Statue");
                            Console.WriteLine("4.Samsun Kent Muzesi:Samsun City Museum");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 57:
                            Console.WriteLine("****WELCOME TO SİNOP***\n");
                            Console.WriteLine("TRADITIONAL FOOD:Mısır soup");
                            Console.WriteLine("Places to visit in Sinop");
                            Console.WriteLine("1.Balatlar Kilisesi:Balatlar Church");
                            Console.WriteLine("2.Sinop Tarihi Paşa Tabyaları:Sinop Historical Pasha Bases");
                            Console.WriteLine("3.Sinop Arkeoloji Müzesi:Sinop Archeology Museum");
                            Console.WriteLine("4.Diyojen Heykeli:Diogenes Sculpture");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 60:
                            Console.WriteLine("****WELCOME TO TOKAT****\n");
                            Console.WriteLine("TRADITIONAL FOOD");
                            Console.WriteLine("Places to visit in Tokat");
                            Console.WriteLine("1.Akbelen Yaylası:Akbelen Plateau");
                            Console.WriteLine("2.Niksar Kalesi:Niksar Castle");
                            Console.WriteLine("3.Kaz Gölü:Lake's kaz");
                            Console.WriteLine("4.Ballıca Mağarası:Cave Ballica");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 61:
                            Console.WriteLine("****WELCOME TO TRABZON****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Kuşburnu");
                            Console.WriteLine("Places to visit in trabzon");
                            Console.WriteLine("1.Uzungöl ve Karester Yaylası:Uzungöl and Karester Plateau");
                            Console.WriteLine("2.Haldizen Yaylası:Haldizen Plateau");
                            Console.WriteLine("3.Şekersu yaylası:Şekersu plateau");
                            Console.WriteLine("4. Lapazan Yaylası:Lapazan Plateau");
                            Console.WriteLine("5.Sis Dağı Yaylası:Fog mountain plateau");
                            Console.WriteLine("3.Sera Gölü Tabiat Parkı:Sera Lake Natural Park");
                            Console.WriteLine("4. Karadağ Yaylası: Karadağ Plateau");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 67:
                            Console.WriteLine("****WELCOME TO zonguldak****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Bayram Tiridi");
                            Console.WriteLine("Places to visit in zonguldak");
                            Console.WriteLine("1.harmankaya şelalesi:harmankaya waterfall");
                            Console.WriteLine("2.Zonguldak Maden Müzesi:Zonguldak Mine Museum");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 69:
                            Console.WriteLine("****WELCOME TO BAYBURT****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Sweet Soup");
                            Console.WriteLine("Places to visit in bayburt");
                            Console.WriteLine("1.Bayburt Kalesi:bayburt castle");
                            Console.WriteLine("2.Aydıntepe Yeraltı Şehri:Aydıntepe Underground City");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;

                        case 74:
                            Console.WriteLine("****WELCOME TO BARTIN****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Amasra Salad");
                            Console.WriteLine("Places to visit in bartın");
                            Console.WriteLine("1.GERGECE ŞELALESİ:GERGECE WATERFALL");
                            Console.WriteLine("2.Bartın Kent Müzesi:Bartın City Museum");
                            Console.WriteLine("3.Amasra Müzesi:Amasra Museum");
                            Console.WriteLine("4.Kapisuyu Plaji:Kapisuyu Beach");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 78:
                            Console.WriteLine("****WELCOME TO KARABÜK****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Milky Keshkek");
                            Console.WriteLine("Places to visit in karabük");
                            Console.WriteLine("1.Bulak Mağarası:Bulak Cave");
                            Console.WriteLine("2.Yörük Köyü:Yoruk Village");
                            Console.WriteLine("3.Kristal Teras:Crystal Terrace");
                            Console.WriteLine("4.Hıdırlık Tepesi Safranbolu:Hıdırlık Hill Safranbolu");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 81:
                            Console.WriteLine("****WELCOME TO DÜZCE*****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Mamursa");
                            Console.WriteLine("Places to visit in düzce");
                            Console.WriteLine("1.Yedigöller:Seven Lakes");
                            Console.WriteLine("2.Aydınpınar Şelalesi Tabiat Parkı:Aydınpınar Waterfall Natural Park");
                            Console.WriteLine("3.Güzeldere Şelalesi Tabiat Parkı:Güzeldere Waterfall Natural Park");
                            Console.WriteLine("4.Düş Yolcusu Çiftliği:Dream Traveler Farm");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                    }


                }

                else if (i == 3)

                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("*****welcome to Aegean******");
                    Console.WriteLine("35.izmir ");
                    Console.WriteLine("45.manisa");
                    Console.WriteLine("09.Aydin");
                    Console.WriteLine("20.Denizli");
                    Console.WriteLine("43.kütahiya");
                    Console.WriteLine("6.Afyonkarahisar");
                    Console.WriteLine("48.Muğla.");
                    Console.WriteLine("64.Uşak");
                    int city_​​code2;
                    city_​​code2 = Convert.ToUInt16(Console.ReadLine());
                    Console.Clear();
                    switch (city_​​code2)
                    {
                        case 35:
                            Console.WriteLine("****WELCOME TO İZMİR****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Izmir meatballs");
                            Console.WriteLine("Places to visit in İzmir");
                            Console.WriteLine("Kemeraltı Çarşısı:(Kemeraltı Bazaar)");
                            Console.WriteLine("KEY MUSEUM Torbalı:KEY MUSEUM Torbali");
                            Console.WriteLine("Kadifekale Dağı:Kadifekale Mountain"); Console.WriteLine("Spil Dağı:Spil Mountain");
                            Console.WriteLine("İzmir Doğal Yaşam Parkı");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 45:
                            Console.WriteLine("****WELCOME TO MANİSA****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Sultaniye Grape");
                            Console.WriteLine("Places to visit in maisa");
                            Console.WriteLine("Kuladokya Peri Bacalari:Kuladokya Fairy Chimneys");
                            Console.WriteLine("Marmara Gölü:Marmara Lake");
                            Console.WriteLine("Kurşunlu kaplıcaları:Kursunlu hot springs");
                            Console.WriteLine("Kula Volkanik Jeoparkı:Kula Volcanic Geopark");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 09:
                            Console.WriteLine("****WELCOME TO AYDİN****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Keshkek");
                            Console.WriteLine("Places to visit in Aydin");
                            Console.WriteLine("Aydın Müzesi:Aydın Museum");
                            Console.WriteLine("Pınarbaşı Mesire Alanı:Pınarbaşı Recreation Area");
                            Console.WriteLine("Tralleis Antik Kenti Kazı Alanı:Tralleis Ancient City Excavation Site");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 20:
                            Console.WriteLine("****WELCOME TO DENİZLİ****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Pepper Tatar");
                            Console.WriteLine("Places to visit in Denizli");
                            Console.WriteLine("1.Pamukkale:(Pamukkale)");
                            Console.WriteLine("2.Denizli teleferik:(Denizli cable car)");
                            Console.WriteLine("3.Karahayit:(KARAHAYIT)");
                            Console.WriteLine("4.Çamlık Parkı:(Çamlık Parkı)");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 43:
                            Console.WriteLine("****WELCOME TO  KUTAHİYA****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Cimcik");
                            Console.WriteLine("Places to visit in Kütahiya");
                            Console.WriteLine("Enne Barajı Tabiat Parkı:(Enne Dam Nature Park)");
                            Console.WriteLine("Vacidiye Medresesi:(Vacidiye Madrasa)");
                            Console.WriteLine("Kütahya Kalesi:(kutahya castle)");
                            Console.WriteLine("Kossuth Müzesi(Macar Evi) :(Kossuth Museum (Macar Evi))");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 03:
                            Console.WriteLine("****WELCOME TO AFYONKARAHİSAR ****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Emirdag Guveci");
                            Console.WriteLine("Places to visit in Afyonkarahisar");
                            Console.WriteLine("Afyonkarahisar Müzesi:");
                            Console.WriteLine("Kocatepe ANITI:Kocatepe MONUMENT");
                            Console.WriteLine("Afyonkarahisar Kalesi:Afyonkarahisar Castle");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 1:
                            Console.WriteLine("****WELCOME TO MUGLA****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Chokertme Kebab");
                            Console.WriteLine("Places to visit in Muğla");
                            Console.WriteLine("Kelebekler Vadisi:(butterfly Valley)");
                            Console.WriteLine("Tlos Ören Yeri:Tlos Ruins");
                            Console.WriteLine("Babadağ palajı:Babadağ beach");
                            Console.WriteLine("Bodrum Kalesi");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 64:
                            Console.WriteLine("****WELCOME TO USAK ****\n");
                            Console.WriteLine("TRADITIONAL FOOD:Rice Meatballs");
                            Console.WriteLine("Places to visit in Uşak");
                            Console.WriteLine("Uşak Kent Tarihi Müzesi:Uşak City History Museum");
                            Console.WriteLine("Çakaloz Camii: cakalgoz mosque");
                            Console.WriteLine("Uşak Halı Kilim Müzesi:Usak Carpet Kilim Museum");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                    }
                }
                else if (i == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("06.ANKARA");
                    Console.WriteLine("42.KONYA");
                    Console.WriteLine("38.KAYSERİ");
                    Console.WriteLine("26.ESKİŞEHİR");
                    Console.WriteLine("58.SİVAS");
                    Console.WriteLine("71.KIRIKKALE");
                    Console.WriteLine("68.AKSARAY");
                    Console.WriteLine("70.KARAMAN");
                    Console.WriteLine("KIRŞEHİR");
                    Console.WriteLine("51.NİĞDE");
                    Console.WriteLine("50.NEVŞEHİR");
                    Console.WriteLine("66.YOZGAT");
                    Console.WriteLine("18.ÇANKIRI");
                    Console.WriteLine("please select from the numbers we knew");

                    int city_​​code3;
                    city_​​code3 = Convert.ToUInt16(Console.ReadLine());
                    Console.Clear();

                    switch (city_​​code3)
                    {
                        case 06:
                            Console.WriteLine("****WELCOME TO ANKARA****\n");
                            Console.WriteLine("Places to visit in Ankara");
                            Console.WriteLine("Altınköy Açık Hava Müzesi:Altınköy Open Air Museum");
                            Console.WriteLine("Atakule: Atakule");
                            Console.WriteLine("Anıtkabir: Mausoleum");
                            Console.WriteLine("Etnoğrafya Müzesi:Ethnography Museum");
                            Console.WriteLine("Anadolu Medeniyetleri Müzesi:3. Anatolian Civilizations Museum");
                            Console.WriteLine("Ankara Kalesi: Ankara Castle");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 42:
                            Console.WriteLine("****WELCOME TO KONYA****\n");
                            Console.WriteLine("Places to visit in konya");
                            Console.WriteLine("Konya Tropikal Kelebek Bahçesi:Konya Tropical Butterfly Garden");
                            Console.WriteLine("Binde Devr-i Alem Parkı:Millennium World Park");
                            Console.WriteLine("Japon Kyoto Parkı:Japanese Kyoto Park");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 38:
                            Console.WriteLine("****WELCOME TO KAYSERİ****\n");
                            Console.WriteLine("Places to visit in kayseri");
                            Console.WriteLine("Kayseri Kalesi:Kayseri Castle");
                            Console.WriteLine("Mazakaland Eğlence Merkezi:Mazakaland Entertainment Center");
                            Console.WriteLine("Hunat Hatun Camii ve Külliyesİ:Hunat Hatun Mosque and Kulliyes");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 26:
                            Console.WriteLine("****WELCOME TO ESKİŞEHİR****\n");
                            Console.WriteLine("Places to visit in Eskişehie");
                            Console.WriteLine("Eskişehir Büyükşehir Belediyesi Yılmaz Büyükerşen :Eskişehir Metropolitan Municipality Yılmaz Büyükerşen");
                            Console.WriteLine("Odunpazarı Modern Müze: Odunpazarı Modern Museum");
                            Console.WriteLine("Eskişehir Büyükşehir Belediyesi Masal Şatosu :Eskişehir Metropolitan Municipality Fairy Tale Castle");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 71:
                            Console.WriteLine("****WELCOME TO KIRIKKALE****\n");
                            Console.WriteLine("Places to visit in Kırıkkale");
                            Console.WriteLine("Celal Bayar Parkı:Celal Bayar Park");
                            Console.WriteLine("kırıkkale Büyük Şehir Parjı:kırkale Big City Parj");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }


                            break;
                        case 58:
                            Console.WriteLine("****WELCOME TO SİVAS****\n");
                            Console.WriteLine("Places to visit in Sİvas");
                            Console.WriteLine("Kale Cami: CASTLE MOSQE");
                            Console.WriteLine("Sivas Ulu Camii: SİVAS MOSQE");
                            Console.WriteLine("Sivas Atatürk ve Kongre Müzesi:Sivas Atatürk and Congress Museum");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 68:
                            Console.WriteLine("****WELCOME TO AKSARAY****\n");
                            Console.WriteLine("Places to visit in Aksaray");
                            Console.WriteLine("Aksaray Müzesi:Aksaray Museum");
                            Console.WriteLine("Saratli Kirkgöz:Saratli Kirkgöz");
                            Console.WriteLine("Zinciriye Medresesi:Zinciriye Madrasa");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 70:
                            Console.WriteLine("****WELCOME TO KARAMAN****\n");
                            Console.WriteLine("Places to visit in kARAMAN");
                            Console.WriteLine("Ermenek Barajı:Ermenek Dam");
                            Console.WriteLine("incesu Magarasi:incesu Cave");
                            Console.WriteLine("Manazan Caves:Manazan Caves");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 51:
                            Console.WriteLine("****WELCOME TO NİGDE****\n");
                            Console.WriteLine("Places to visit in Niğde");
                            Console.WriteLine("Niğde Müzesi:nigde museum");
                            Console.WriteLine("Saat Kulesi:clock tower");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;

                        case 50:
                            Console.WriteLine("****WELCOME TO NRVŞEHİR****\n");
                            Console.WriteLine("Places to visit in Nevşehir");
                            Console.WriteLine("Nevşehir Müzesi:nevsehir museum");
                            Console.WriteLine("Kapadokya:kapadokya Airship");
                            Console.WriteLine("Kapadokya Mağaraları: kapadokya cave");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 66:
                            Console.WriteLine("****WELCOME TO YOZGAT****\n");
                            Console.WriteLine("Places to visit in Yozgat");
                            Console.WriteLine("Yozgat Çamlığı Millî Parkı:Yozgat Çamlığı National Park");
                            Console.WriteLine("Çeşka Kalesi:ceka castle");
                            Console.WriteLine("Yozgat Saat Kulesi:Yozgat Clock Tower");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 40:
                            Console.WriteLine("****WELCOME TO KIRŞEHİR ****\n");
                            Console.WriteLine("Places to visit in Kırşehir");
                            Console.WriteLine("Yıldıztepe Doga ve Kış Sporları Merkezi:Yıldıztepe Nature and Winter Sports Center");
                            Console.WriteLine("Tuz Magarasi:Salt Cave");
                            Console.WriteLine("Ilgaz Dağı Kayak Merkezi:Ilgaz Mountain Ski Center");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 18:
                            Console.WriteLine("****WELCOME TO ÇANKIRI****\n");
                            Console.WriteLine("Places to visit in ÇANKIRI");
                            Console.WriteLine("Çankırı Cam Seyir Teras:Çankırı Glass Observation Terrace");
                            Console.WriteLine("Çankırı Müzesi:Çankırı Museum");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }


                            break;
                    }
                }
                else if (i == 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("04.AĞRI");
                    Console.WriteLine("75.ARDAHAN");
                    Console.WriteLine("10.BİTLİS");
                    Console.WriteLine("17.BİNGÖL");
                    Console.WriteLine("23.ELAZIĞİ");
                    Console.WriteLine("24.ERZİNCAN");
                    Console.WriteLine("25.ERZURUM");
                    Console.WriteLine("30.HAKKARİ");
                    Console.WriteLine("76.IĞDIR");
                    Console.WriteLine("36.KARS");
                    Console.WriteLine("44.MALATYA");
                    Console.WriteLine("49.MUŞ");
                    Console.WriteLine("62.TUNCELİ");
                    Console.WriteLine("65.VAN\n");
                    Console.WriteLine("please select from the numbers we knew");

                    int city_​​code4;
                    city_​​code4 = Convert.ToUInt16(Console.ReadLine());
                    Console.Clear();

                    switch (city_​​code4)
                    {
                        case 04:
                            Console.WriteLine("****WELCOME TO AGRİ ****\n");
                            Console.WriteLine("Places to visit in AĞRI");
                            Console.WriteLine("1.Sabancı Merkez Camii:");
                            Console.WriteLine("2.Seyhan Barajı ve Hidroelektrik Santrali: Seyhan Dam and Hydroelectric Power Plant");
                            Console.WriteLine("3.Tarihi Büyüksaat Kulesi:Historic Grand Clock Tower");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 75:
                            Console.WriteLine("****WELCOME TO ARDİHAN****\n");
                            Console.WriteLine("Places to visit in ARDAHAN");
                            Console.WriteLine("1.Yalnızçam Kayak Merkezi:Solocam Ski Center");
                            Console.WriteLine("2.Arsiyan Yaylası:Arsiyan Plateau");
                            Console.WriteLine("3.Goze Dağı:Goze Mountain");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 12:
                            Console.WriteLine("****WELCOME TO BİNGOL****\n");
                            Console.WriteLine("Places to visit in BİNGÖL");
                            Console.WriteLine("1.Bal Kaymak Evleri:Honey Cream Houses");
                            Console.WriteLine("2.Yolçatı Kayak Merkezi:Yolçatı Ski Center");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 13:
                            Console.WriteLine("****WELCOME TO BİTLİS****\n");
                            Console.WriteLine("Places to visit in BİTLİS");
                            Console.WriteLine("1.Nemrut Gölü:Nemrut lake");
                            Console.WriteLine("2.Nemrut Dağı:Nemrut Mountain");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 23:
                            Console.WriteLine("****WELCOME TO ELAZGİ****\n");
                            Console.WriteLine("Places to visit in ELAZĞI");
                            Console.WriteLine("1.Elâzığ Buzluk Mağarası:Elâzığ Buzluk Cave");
                            Console.WriteLine("2.İzzetpaşa Cami:İzzetpaşa Mosque");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 24:
                            Console.WriteLine("****WELCOME TO ERZİNCAN****\n");
                            Console.WriteLine("Places to visit in ERZİNCAN");
                            Console.WriteLine("1.Erzincan müzesi:Erzincan museum");
                            Console.WriteLine("2.Ergan Dağı Kayak Merkezi İşletmesi:Ergan Mountain Ski Resort Management");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 25:
                            Console.WriteLine("****WELCOME TO ERZURUM****\n");
                            Console.WriteLine("Places to visit in ERZURUM");
                            Console.WriteLine("1.Palandöken Dağı:");
                            Console.WriteLine("2.Narman Peribacaları");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 30:
                            Console.WriteLine("****WELCOME TO HAKKARİ****\n");
                            Console.WriteLine("Places to visit in HAKKARİ");
                            Console.WriteLine("1.Uludoruk:");
                            Console.WriteLine("2.Cilo Dağı");
                            Console.WriteLine("3.Sumbul Dağı");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 76:
                            Console.WriteLine("****WELCOME TO İGDR****\n");
                            Console.WriteLine("Places to visit in İĞDR");
                            Console.WriteLine("1.GÖKKUŞAĞI TEPELERİ TUZLUCA:RAINBOW HILLS TUZLUCA");
                            Console.WriteLine("2.Balık Gölü: fish lake");
                            Console.WriteLine("3.Pamukdagi Tepe:Pamukdagi Tepe");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 36:
                            Console.WriteLine("****WELCOME TO KARS****\n");
                            Console.WriteLine("Places to visit in KARS");
                            Console.WriteLine("1.Kars Kalesi:kars castle");
                            Console.WriteLine("2.Kümbet Camii:mosqe");
                            Console.WriteLine("3.Taş Köprü:tas bridge");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 44:
                            Console.WriteLine("****WELCOME TO  MALATYA****\n");
                            Console.WriteLine("Places to visit in MALATYA");
                            Console.WriteLine("1.Aslantepe Ören Yeri:Aslantepe Ruins");
                            Console.WriteLine("2.Turgut Özal Tabiat Parkı:Turgut Özal Nature Park");
                            Console.WriteLine("3.Kernek Şelalesi:Kernek Waterfall");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 49:
                            Console.WriteLine("****WELCOME TO MUS ****\n");
                            Console.WriteLine("Places to visit in MUŞ");
                            Console.WriteLine("1.Kutsal Havariler Manastırı:Holy Apostles Monastery");
                            Console.WriteLine("2.Kale Parkı:Castle Park)");
                            Console.WriteLine("3.Haspet kalesi:haspet castle");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 62:
                            Console.WriteLine("****WELCOME TO TUNCELİ****\n");
                            Console.WriteLine("Places to visit in TUNCELİ");
                            Console.WriteLine("1.Ovacık Kayak Merkezi:Ovacik Ski Center");
                            Console.WriteLine("2.Bağin kaplıcası:");
                            Console.WriteLine("3.Munzur Vadisi Millî Parkı");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 65:
                            Console.WriteLine("****WELCOME TO VAN****\n");
                            Console.WriteLine("Places to visit in VAN");
                            Console.WriteLine("1.Van kalesi:Van Castle)");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                    }
                }

                else if (i == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("01.ADANA");
                    Console.WriteLine("07.ANTALYA");
                    Console.WriteLine("15.BURDUR");
                    Console.WriteLine("31.HATAY");
                    Console.WriteLine("32.ISPARTA");
                    Console.WriteLine("33.MERSİM");
                    Console.WriteLine("80.OSMANİYE\n");
                    Console.WriteLine("please select from the numbers we knew");

                    int city_​​code5;
                    city_​​code5 = Convert.ToUInt16(Console.ReadLine());
                    Console.Clear();

                    switch (city_​​code5)
                    {

                        case 01:
                            Console.WriteLine("****WELCOME TO ADANA ****\n");
                            Console.WriteLine("Places to visit in Adana");
                            Console.WriteLine("1.Ulu Cami");
                            Console.WriteLine("2.Seyhan Barajı ve Hidroelektrik Santrali");
                            Console.WriteLine("3.Merkez Park");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 07:
                            Console.WriteLine("****WELCOME TO ANTALYA****\n");
                            Console.WriteLine("Places to visit in Antalya");
                            Console.WriteLine("1.Düden Şelalesi");
                            Console.WriteLine("2.Konyaaltı Plajı:Konyaaltı Beach");
                            Console.WriteLine("3.Kurşunlu Şelalesi Tabiat Parkı:Kursunlu Waterfall Nature Park");
                            Console.WriteLine("4.Antalya Aquarium: Antalya Aquarium");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 15:
                            Console.WriteLine("****WELCOME TO BURDUR ****\n");
                            Console.WriteLine("Places to visit in Burdur");
                            Console.WriteLine("1.Salda Gölü:salde lake");
                            Console.WriteLine("2.Salda Gölü Tabiat Parkı:Salda Lake Natural Park");
                            Console.WriteLine("3.Salda Gölü Yeşilova Burdur");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 31:
                            Console.WriteLine("****WELCOME TO HATAY ****\n");
                            Console.WriteLine("Places to visit in Hatay");
                            Console.WriteLine("1.Hatay Arkeoloji Müzesi:Hatay Archeology Museum");
                            Console.WriteLine("2.Beşikli Mağara:");
                            Console.WriteLine("3.Nur Dağları");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 32:
                            Console.WriteLine("****WELCOME TO İSPARTA****\n");
                            Console.WriteLine("Places to visit in Isparta");
                            Console.WriteLine("1.Gölcük Tabiat Parkı:Gölcük Nature Park");
                            Console.WriteLine("2.Aya Baniya (Aya Payana) Kilisesi:Aya Baniya (Aya Payana) Church");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                        case 33:
                            Console.WriteLine("****WELCOME TO MERSİN****\n");
                            Console.WriteLine("Places to visit in mersin");
                            Console.WriteLine("1.Mersin Limanı:Mersin Port");
                            Console.WriteLine("2.Mersin Kent Tarihi Müzesi:Mersin City History Museum");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 80:
                            Console.WriteLine("****WELCOME TO OSMANİYE****\n");
                            Console.WriteLine("Places to visit in OSmaniye");
                            Console.WriteLine("1.Toprakkale Kalesi:Toprakkale Castle");
                            Console.WriteLine("2.Çardak Kalesi: Çardak Castle");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                    }
                }

                else if (i == 7)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("27.GAZİANTEP");
                    Console.WriteLine("21.DİYARBAKIR");
                    Console.WriteLine("15.batman");
                    Console.WriteLine("63.ŞANLIURFA");
                    Console.WriteLine("72.BATMAN");
                    Console.WriteLine("02.ADIYAMAN");
                    Console.WriteLine("56.SİİRT");
                    Console.WriteLine("47.MARDİN");
                    Console.WriteLine("79.KİLLİS");
                    Console.WriteLine("73.ŞIRNAK \n");
                    Console.WriteLine("please select from the numbers we knew");

                    int city_​​code6;
                    city_​​code6 = Convert.ToUInt16(Console.ReadLine());
                    Console.Clear();

                    switch (city_​​code6)

                    {
                        case 27:
                            Console.WriteLine("****WELCOME TO GAZİANTEP ****\n");
                            Console.WriteLine("Places to visit in Gaziantep");
                            Console.WriteLine("1.Dülükbaba Mesire Alanı:Dülükbaba Recreation Area");
                            Console.WriteLine("2.Gaziantep Hamam Müzesi:Gaziantep Hamam Museum");
                            Console.WriteLine("3.Zincirli Bedesten:Zincirli Bedesten");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }

                            break;
                        case 21:
                            Console.WriteLine("****WELCOME TO DİYARBAKIR****\n");
                            Console.WriteLine("Places to visit in diyarbakır");
                            Console.WriteLine("1.Hevsel Bahçeleri:Hevsel Gardens");
                            Console.WriteLine("2.Ziya Gökalp Müzesi:Ziya Gokalp Museum");
                            Console.WriteLine("3.Ongözlü Köprüsü:Ongözlü Bridge");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 63:
                            Console.WriteLine("****WELCOME TO SANLIURFA****\n");
                            Console.WriteLine("Places to visit in şanlıurfaL");
                            Console.WriteLine("1.Şanlıurfa Arkeoloji ve Mozaik Müzesi:Şanlıurfa Archeology and Mosaic Museum");
                            Console.WriteLine("2.Halilurrahman Cami: Halilurrahman Mosque");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 72:
                            Console.WriteLine("****WELCOME TO BATMAN ****\n");
                            Console.WriteLine("Places to visit in Batman");
                            Console.WriteLine("1.Hasankeyf Mağaraları: Hasankeyf Caves");
                            Console.WriteLine("2.Memikan Köprüsü: Memikan Bridge");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 02:
                            Console.WriteLine("****WELCOME TO ADİYAMAN****\n");
                            Console.WriteLine("Places to visit in Adıyaman");
                            Console.WriteLine("1.Perre Antik Kent");
                            Console.WriteLine("2.Nemrut Dağı");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 56:
                            Console.WriteLine("****WELCOME TO SİİRT****\n");
                            Console.WriteLine("Places to visit in siirt");
                            Console.WriteLine("1.Hz.Veysel Karani Tabiat Parkı:Hazrat Veysel Karani Nature Park");
                            Console.WriteLine("2.Tillo Kale: Tillo Castle");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 74:
                            Console.WriteLine("****WELCOME TO MARDİN****\n");
                            Console.WriteLine("Places to visit in Mardin");
                            Console.WriteLine("1.Mor Gabriel Manastırı:Mor Gabriel Monastery");
                            Console.WriteLine("2.Dara Mezopotamya Harabeleri:Dara Mesopotamia Ruins");
                            Console.WriteLine("3.Mardin Evleri:Mardin Houses");
                            Console.WriteLine("4.Kasımiye Medresesi:Kasımiye Madrasa");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 79:
                            Console.WriteLine("****WELCOME TO KİLLİS****\n");
                            Console.WriteLine("Places to visit in killis ");
                            Console.WriteLine("1.Salih Ağa Kasteli:");
                            Console.WriteLine("2.Fellah Kasteli");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;

                        case 73:
                            Console.WriteLine("****WELCOME TO SİRNAK****\n");
                            Console.WriteLine("Places to visit in Şırnak");
                            Console.WriteLine("1.Urochishche Kasrik");
                            Console.WriteLine("2.Cudi Dağı");
                            Console.WriteLine("please press 0 to return to the regions screen");
                            main_menu = Convert.ToUInt16(Console.ReadLine());
                            if (main_menu == 0)
                            {
                                dongu = true;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("wrong choice");
                }
                dongu = true;
            }
            Console.ReadKey();
        }
    }
}

