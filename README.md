# BookStore
Kitap, müzik albümü, dergi satın alabileceğiniz bir masaüstü uygulaması. C# ve MSSQL kullanılarak geliştirildi.
- Sıla Eşme
- Sanem Yıldız Kavukoğlu
- Zeynep Gürlüzer

## Giriş
Bize verilen bu projede, bir “Book Store” masaüstü uygulaması geliştirdik. Oluşturduğumuz “Magic Book Store” menüsünde, profilimizi görüntüleyebileceğimiz ve bilgilerimizi güncelleyebileceğimiz “My Page” butonu, oluşturduğumuz veri tabanında bulunan kitapları, müzik albümlerini ve dergileri görüntüleyebileceğimiz “Books”, “Music CDs” ve “Magazines” butonları, Sepetimize eklediğimiz ürünleri görebileceğimiz “Shopping Cart” butonu, Sipariş verdiğimiz ürünleri takip edebilmemiz için “My Orders” butonu ve çıkış yapabilmemiz için bir “Sign Out” butonu bulunmaktadır. Uygulamanın içeriği detaylı olarak raporun devamında sunulacaktır.
## 1.	Tasarım Hakkında
#### 1.1.	“Login” Ekranı Tasarımı
![Sign-in-screen](https://user-images.githubusercontent.com/56348436/156145233-8af58c4c-3cc1-473c-bd3c-152cfaf4aa89.png)  
"Sign In" ekranı, programı çalıştırdığınızda karşınıza çıkacak olan ilk ekrandır. Kullanıcı daha önce bir hesap oluşturmadıysa altta görünen “Sign Up” label’ine tıklayarak uygulamaya kaydolmalıdır. Aksi takdirde giriş yapamayacaktır.  

![opps](https://user-images.githubusercontent.com/56348436/156146648-8747e52f-4b22-43fc-993c-95a04efc1af0.png)  
Yukarıdaki ekran görüntüsünde programın uyarı verdiğini görmektesiniz.  Kişi bilgilerini yanlış girerse program bu uyarıyı vermektedir.  

#### 1.2.	“Sign Up” Ekranı Tasarımı
![Sign-up-screen](https://user-images.githubusercontent.com/56348436/156147472-c2a50a48-f6b8-4d09-bb4a-61e221206d67.png)  
Yukarıda gördüğünüz ekran, “Login” ekranındaki “Sign Up” label’ine tıklandığında açılır. Burada kullanıcının bilgileri alınır.  

![sign-up-invalid-1](https://user-images.githubusercontent.com/56348436/156147978-79d5f25e-8eed-49d5-8e3a-c35dd969de1f.png)
![sign-up-invalid-2](https://user-images.githubusercontent.com/56348436/156147984-d44d730d-0b05-4f68-92d0-da78de7c1961.png)  
Kullanıcı tüm boşlukları doldurmalıdır ve şifresini doğrulamalıdır. Aksi takdirde bilgileri veri tabanına kaydedilemez. Aynı zamanda uygulamaya kayıt da olamaz. Ekran görüntülerinde de bunu görmektesiniz.  
  
![users-in-database](https://user-images.githubusercontent.com/56348436/156149303-7ad40584-a2ea-4cd5-b5fc-cae4709df989.png)  
Veri tabanı ekran görüntüsünden de görebileceğiniz üzere kullanıcının şifresi Hash Table MD5 kriptolama yöntemi ile kriptolanarak kaydedilmiştir. Aynı zamanda kullanıcıya otomatik olarak “default-picture” atanmaktadır.
#### 1.3.	“Main Page”, “Books”, “Music CDs” ve “Magazines” Ekranları Tasarımı
![main-page](https://user-images.githubusercontent.com/56348436/156150326-2459d5ef-a26c-4c66-b877-8b3f1478272b.png)  
Kullanıcı uygulamaya giriş yaptığında uygulamamızın ana sayfasıyla karşılaşır. İlk açılan yeri “Books” bölümüne ayarladık. Otomatik olarak kitaplar ekrana gelecektir. Kullanıcı dilerse “Read More” butonuna tıklayarak ürünler hakkında daha ayrıntılı bilgilere ulaşabilir. Aşağıda bir kitabın ayrıntılı bilgisinin görüntülendiği ekranı görebilirsiniz.  
  
![book-detail](https://user-images.githubusercontent.com/56348436/156151548-59d4a746-2a75-4e5b-807f-0b3abb20221b.png)  
“₺” sembolünün biraz kayık gözükmesinin sebebini anlayamadık. Form’da düzgün ayarlamamıza rağmen program çalıştığında hafif aşağı doğru kayıyor.
  
![music-cds](https://user-images.githubusercontent.com/56348436/156154916-346b81e4-1bbb-4684-af5d-2ca5de514f6e.png)  
Veri tabanındaki tüm kitapların görüntülenebilmesine benzer şekilde müzik albümlerini de görüntüleyebiliriz.   
  
![music-cds-detail](https://user-images.githubusercontent.com/56348436/156155287-7cfc7d94-2283-460e-b069-7880bb014aed.png)  
Herhangi bir müzik albümünün üzerine tıklandığında o albümün detaylı bilgileri görüntülenir.  
  
![magazines](https://user-images.githubusercontent.com/56348436/156155290-74d639fd-ebec-44d0-8b66-a1b1b0be4608.png)  
Veri tabanındaki tüm dergiler görüntülenir.  
  
![magazines-detail](https://user-images.githubusercontent.com/56348436/156155276-88ce0575-d7cd-4363-885c-8ec7549921f1.png)  
Herhangi bir derginin üzerine tıklandığında o albümün detaylı bilgileri görüntülenir.  
  
#### 1.4. “Shopping Cart” Ekranı Tasarımı
Ürünler ayrıntılı olarak görüntülendiğinde “Add to Cart” butonu belirmekte. Eğer kullanıcı bu butona tıklarsa tıkladığı ürünün bilgileri kullanıcı adı üzerine veri tabanına eklenir ve aynı zamanda sepete eklenen ürünler “Shopping Cart” butonu ile kullanıcı tarafından görüntülenebilir. Aşağıdaki ekran görüntülerinde detaylı olarak görebilirsiniz.  
![shopping-cart](https://user-images.githubusercontent.com/56348436/156156889-532cd80e-d76f-484d-904d-b780dd678fa4.png)  
![shopping-cart-database](https://user-images.githubusercontent.com/56348436/156157090-8d8317d5-fe1e-4601-b756-6304ffd43cf9.png)  
“OrderNo” sütununun NULL olma sebebi siparişin daha verilmemiş olmasından kaynaklıdır.  
  
![shopping-cart-detail](https://user-images.githubusercontent.com/56348436/156159490-09f0b4c0-c928-468b-83b5-fbf2137898e0.png)  
Kullanıcı almak istediği ürünlerin miktarına karar verebilir veya ürünü sepetinden silebilir. Burada yapılan değişikler veri tabanına da doğru bir şekilde etki eder.  
  
![shopping-cart-database-changed](https://user-images.githubusercontent.com/56348436/156159504-52ccbe60-f65a-4c01-a022-9192768ad571.png)  
  
#### 1.5.	“My Page” Ekranı Tasarımı
![my-page](https://user-images.githubusercontent.com/56348436/156160282-651bf5c5-0324-4c71-9e8c-6c8d7c389cae.png)  
Kullanıcı bu sayfada bilgilerini görüntüleyebilir ya da “Update My Informations” ile bilgilerini güncelleyebilir. Burada kullanıcı daha önce bir fotoğraf seçmediği için default olarak eklediğimiz fotoğraf görünür. Bu fotoğraf her yeni kullanıcı için atanan bir fotoğraftır. Kullanıcı dilerse bunu “Update My Informations” butonuna tıklayarak değiştirebilir.  
![set-picture](https://user-images.githubusercontent.com/56348436/156160666-0b9ac778-6940-4d1a-a6f3-da101a3ea07a.png)  
“Update Image” butonuna basıldığında “OpenFileDialog” açılması görüntülenmektedir. Biz projemizin bin/Debug/Profile Images klasörüne birkaç alternatif fotoğraf koyduk. Fakat kullanıcı dilerse kendi bilgisayarından da profil fotoğrafı yükleyebilir. Eğer kendi bilgisayarından seçerse seçtiği fotoğraf bu klasöre kaydolmaktadır. Bunu nasıl yaptığımızı ileride kodları gösterirken anlatacağız.  
Fotoğraf seçildikten sonra “Save” butonuna tıklanması gerekir. Aksi takdirde fotoğraf kaydedilmez. Benzer şekilde değiştirilmek istenen bilgiler de değiştirilip altında bulunan butona basılır.  
![save-image](https://user-images.githubusercontent.com/56348436/156161059-e66252f6-5301-4fe6-b573-b9eeca2bec60.png)  
#### 1.6.	“Order Now” ile Sipariş Oluşturma
![order-now](https://user-images.githubusercontent.com/56348436/156162554-8269d265-fac7-491e-9275-5ea4ebeae49a.png)  
Ürünleri nasıl sipariş verebileceğinizi görebilmeniz için ekran görüntüsünde örnek olarak birkaç ürün sepete eklendi. Bu sayfada 2 buton görüyorsunuz: “Cancel Order” ve “Order Now”. “Cancel Order” ile sepetinizdeki tüm ürünleri silebilirsiniz. “Order Now” butonuna tıklamanız durumunda ödeme ekranına yönlendirilirsiniz.  
  
![payment](https://user-images.githubusercontent.com/56348436/156165604-ba852e03-e910-4b8e-be65-c2a0d587124a.png)  
Yukarıda ödeme ekranını görmektesiniz. Burada kullanıcı “Cash” veya “Credit Card” sekmesinden istediğini seçebilir. Aşağıda taksit seçeneklerini görüntüleyebilir. Sağ tarafta kargo seçeneklerinden birini seçebilir. Kargo fiyatları farklıdır ve “Order Summary” bölümünde buna göre hesaplama yapılır. “Invoice Options” bölümünde ise faturasının gönderileceği yeri belirlemelidir. Kargo ile fatura bölümünü doldurmak zorundadır yoksa sipariş alınamaz.  
  
![successful-payment](https://user-images.githubusercontent.com/56348436/156165898-2b50193b-5f7e-4840-a56c-4e7f605fdae2.png)  
![order-database](https://user-images.githubusercontent.com/56348436/156166394-9b88196c-dd23-4bad-858f-f505a8c87e12.png)  
Görüldüğü üzere ödeme başarıyla gerçekleştiğinde bir messagebox çıkmaktadır. Bu messagebox faturayı nasıl almak istediğimize göre çıkar. Rastgele sayılardan oluşturulan sipariş numarası ise veri tabanına kaydedilir. Sipariş numarasını aynı kullanıcının verdiği farklı siparişlerin karışmaması amacıyla kullandık. Aynı zamanda ShoppingCart ile ilişkilendirmek için kullandık.  
  
![my-orders](https://user-images.githubusercontent.com/56348436/156166713-7a3c2b1f-8ecb-486b-a2ef-c23a1e8544a0.png)  
Kullanıcı dilerse vermiş olduğu siparişleri görebilir, detaylarını görüntüleyebilir veya verilen siparişi iptal edebilir. Burada yapılan değişiklikler, diğer yerlerde de olduğu gibi, veri tabanında ve kodda ilgili yerlerde güncellenir.  
  
## 2.	UML Diyagramı
![uml](https://user-images.githubusercontent.com/56348436/156167193-6667380d-c333-4896-b042-8325fe04be8b.png)  
Aslında projeye ilk olarak UML diyagramı çizerek başladık. Şekil 26’da UML diyagramını görmektesiniz. Bu UML diyagramına sadık kalmaya çalışarak projemizi bitirdik.  

## 3.	Bazı Kodların Anlatımı
![code-profile-image](https://user-images.githubusercontent.com/56348436/156167528-a2de3d33-5db4-48ba-a615-21cead3046d1.png)  
Bu kod parçasında kullanıcı fotoğrafını değiştirdiği zaman “Profile Images” klasörüne kaydedilmesi gösterilmektedir. “System.IO.File.Copy” metoduyla fotoğraf “Profile Images” klasörüne kaydedilir. “Profile Images” dosyası projede bulunur, bu sayede program her seferinde farklı bilgisayarlardan gelen fotoğraflara erişebilir.  
  
![code-user-control](https://user-images.githubusercontent.com/56348436/156167701-0578c9cd-e2b4-4c63-8691-9a22c08ef9da.png)  
Programımızı yazarken user control bileşenlerinden bir hayli yararlandık. User control’ler form mantığında çalışır. Gördüğünüz kod parçası bir user control bileşeninde oluşturuldu. Bu fonksiyon kullanıcının bilgilerini Customer sınıfı nesnesinden çeker ve bilgiler sayfada bu şekilde görüntülenmiş olur. Bu fonksiyonda kullanıcının fotoğrafının ismi veri tabanından çekilir ve “foreach” ile “Profile Images” klasöründe isme göre arama yapılır. En nihayetinde fotoğrafın ismi klasördeki fotoğraflardan biriyle eşleştiğinde bu fotoğraf alınır ve pictureBoxCustomer nesnesine aktarılır.  
  
![code-customer-singleton](https://user-images.githubusercontent.com/56348436/156167927-d3b17db8-143b-4dd0-9b9a-68f6dcd65f8f.png)  
Kullanıcı eğer bilgilerini değiştirip “Update My Informations” butonuna tıklarsa bu fonksiyon çalışır. Bu fonksiyonda hem “Customer” sınıfına ait “customer” nesnesi güncellenir hem de veri tabanındaki “customer” bilgileri güncellenir. Buradaki “customer” nesnesi Singleton ile oluşturulmuştur.  
  
![code-hash](https://user-images.githubusercontent.com/56348436/156168114-cfc68648-5319-4ccc-b949-824c8209070c.png)  
Yukarıda gördüğünüz sınıfın “MD5Sifrele” metodunda kullanıcıdan alınan şifre kriptolandı. Bu metot için “System.Security.Cryptography” kütüphanesi kullanılmıştır. Şifrelenecek olan metin GetBytes yardımıyla byte dizisine dönüştürüp bu diziyi hash’ledik. Sonra bu diziyi 32 karakterlik bir diziye çevirdik. Bu şekilde parolamız şifrelenmiş oldu.  
  
![code-login](https://user-images.githubusercontent.com/56348436/156168363-d23ad125-f44f-4b6f-921f-e76f8c556f81.png)  
Kullanıcı “Login” ekranında “Login” butonuna tıkladığında gerçekleşen işlemleri görmektesiniz. Öncelikle kullanıcıdan alınan parola burada kriptolanır. Daha sonra Database sınıfından bir nesne Singleton design pattern’i yardımıyla oluşturulur ve veri tabanına bağlanılır. Bu aşamada kullanıcının sisteme kaydolup kaydolmadığını kontrol etmek durumundayız. Bu yüzden kullanıcı “Customer.dbo” içerisinde aranır. Buradaki verileri SqlDataReader ile oluşturduğumuz “dr” nesnesi yardımıyla okuruz. Eğer kullanıcının username’i veri tabanındaki username’ler ile eşleşirse bu sefer şifresine bakılır. Şifresinin kriptolanmış hali de veri tabanındaki ile eşleşiyorsa kullanıcı sisteme giriş yapar. Veri tabanındaki bilgiler de Customer sınıfı üyesi “customer” nesnesine aktarılmış olur. Eğer username veya şifre veri tabanındaki bilgilerle eşleşmiyorsa kullanıcı bir uyarı ile karşılaşır.

## 4.	Kullanılan Design Pattern’leri
#### 4.1. Singleton Design Pattern
![code-singleton-usercontrolbooks](https://user-images.githubusercontent.com/56348436/156169411-34eed3fd-29cb-4e80-84d4-c9037f929aa3.png)  
![code-singleton-usercontrolmagazines](https://user-images.githubusercontent.com/56348436/156169657-d4c0ee4c-dd35-411d-84b8-6c782668b879.png)  
![code-singleton-usercontrolmusiccds](https://user-images.githubusercontent.com/56348436/156169658-66353204-29cf-44fe-a59f-05e53b3467c9.png)  
Programımızda “UserControlBooks”, “UserControlMusicCDs”, “UserControlMagazines” gibi tek olması gerektiğini düşündüğümüz formları Singleton yaptık. Tüm kitapların sıralandığı user control’ü düşünürsek, bu user control program boyunca tek bir nesneden oluşmalıydı. Çünkü tüm kitapların oluşması gereken tek bir durum vardır. Bu şekilde oluşması gerektiğini düşündüğümüz yerlere Singleton design pattern’ini uyguladık.  
  
#### 4.2.	Factory Design Pattern
![code-factory](https://user-images.githubusercontent.com/56348436/156169956-a1ba79fa-f96c-4c3a-b72c-4911568dbf53.png)  
String olarak alınan “ProductType” parametresi, if statement’lardaki durumlara göre nesnelere dönüştürülür. Bazı tekrarlanan durumların ufak farklılıklardan ötürü tekrarlanmamasını istediğimizden bu design pattern’inini kullanmamız bize yardımcı oldu. Yazdığımız kod daha düzenli bir hale geldi ve karmaşıklık önlendi.  
