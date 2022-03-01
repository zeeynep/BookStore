# BookStore
A desktop application where you can buy books, music albums and magazines. Developed with C# and MSSQL.

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
Kullanıcı tüm boşlukları doldurmalıdır ve şifresini doğrulamalıdır. Aksi takdirde bilgileri veri tabanına kaydedilemez. Aynı zamanda uygulamaya kayıt da olamaz. Şekil 4 ve Şekil 5’te bunu görmektesiniz.
