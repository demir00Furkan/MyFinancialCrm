## FinancalCrm Projesi

Bu Repo, Murat Yücedağ'ın Youtube c# Eğitim Kampi Serisinin Son Case'i dir. Bu Projede MyFinancalCrm Adında, crm (Müşteri ilişkileri yönetimi) Projesini Bitirdim. Projeyi Entitity Framework Kullanarak Oluşturdum.

## **"Login And Register" Fromu**

![LoginFormu](https://github.com/user-attachments/assets/465b8f08-d174-484e-b043-10c071ffa515)

 Bu Form Kullanıcının İlk Karşılaşacağı Form. Kullanıcı Bu Formdan Kayıtlıysa Giriş Yapabilir. 
 Değilsede Üye Ol Diyerek Üyel Olduktan Sonra Giriş Yapabilir. Ayrıca Formun Üye Ol Kısmına Bi Doğrulama TextBox'ı Ekledim. Bu Sayede Kayıt Olunurken Şifrenizi Yanlış Giremeyeceksiniz.
 
 ## **"Banks" Formu**
 
 ![Ekran görüntüsü 2025-02-12 151912](https://github.com/user-attachments/assets/44561a4c-53e5-4304-a033-8a222af7c15a)

 Bu Form Giriş İşlem Yapma Formu Değildir. Bu formda Sadece Veri Tabanından Kullanıcının Son 5 Banka Hareketleri Ve 3 Bankadaki Bakiyeleri Ektede Görüldüğü Gibi Ayrı Ayrı Görünmektedir. Ayrıca Formun Sol Tarafında Yer Alan Buttonlar Formlar Arasında Geçiş Yapmak İçin Tüm Formlara Eklenmiştir.

## **"Categories" Fromu**

![Ekran görüntüsü 2025-02-12 151816](https://github.com/user-attachments/assets/2a644f7a-edcb-4282-a1e7-af60b28d3542)

Bu Formda Ekleme, Silme, Güncelleme Ve Listeleme İşlemleri Yapılabilir. Form Açıldığında Datagrid teki Verilerden İşlem Yapmak İstenilen Veri Satırı Seçilir Ve Yapılmak İstenen Buttonlardan Uygulanır. Eklemek İçin TextBox'a  Veri Yazıp Kategori Ekle Butonuna Basmanız İşlemi Gerçekleştirecektir.

## **"Billing" Fromu**

![Ekran görüntüsü 2025-02-12 151832](https://github.com/user-attachments/assets/8a29bf72-d904-44ad-a5d1-a5fbc6856794)

Bu Form Yapı Bakımından Categories Formu İle Neredeyse Aynı. Ektede Görüldüğü Gibi Listeleme, Ekleme, Silme,   Ve Güncelleme Bu Formdada Mevcut.

## **"Spendings" Formu**

![Spendings](https://github.com/user-attachments/assets/849462f9-81bc-4db8-8c59-fad6ed81166b)

Bu Formda Yapı Bakımından Categories Ve Billing Formu İle Aynı.

## **"Bank Processes" Formu**

![Ekran görüntüsü 2025-02-12 151936](https://github.com/user-attachments/assets/91d6198e-6451-4cc8-905e-81434183d1ea)

Bu Form Müşterinin Tüm Bankalardaki Tüm Geçmiş İşlemlerini Datagride Aktaran Yapıdır.

## **"Dashboard" Formu**

![Ekran görüntüsü 2025-02-12 151800](https://github.com/user-attachments/assets/2da5719a-a717-4a7d-91aa-56ddef57ee17)

Bu Form Kullanıcının Toplam Bakiyesini, Ödeme Günü Gelmiş Faturasını Ve Gelen Son Para Trasnferini Listeler.
Ayrıca Ektede Görüldüğü Gibi İki Tane Chart Eklenmiştir. Bu Chartların İlki Banka Hesablarındaki Para Miktarını Banka Adına Göre Göstermektedir. Diğeri İse Ödenmiş Ve Ödenmemiş Tüm Faturaların Tutarlarını Göstermektedir.

## **"Settings" Formu**

![Ekran görüntüsü 2025-02-12 151741](https://github.com/user-attachments/assets/a0e11124-02f2-484f-bfc5-b56928370c09)

Bu Form Kullanıcının Giriş Bilgileri İle İlgili Güncelleme Ve Silme (Hesabını Silme) İşlemi Yapmak İçin Tasarlanmıştır.
Kullanıcı Hesabına Giriş Yaptığı Esnada Kullanıcı Adı Ve Şifresi Bir Sınıfta Tutuluyor Ve Settings Formundaki İşlemler İçin Kullanılıyor. 
Bu Durumda Kullanıcı Hiçbir Veri Girmeden, Sadece Güncellenecek Veriyi Textboxa Girmesi Yeterli Oluyor. Hesabımı Sil İçin İse Kullanıcı Güveliği
İçin Hesabını Doğrulaması İstenmektedir. Hesap Bilgilerini Girdikten Sonra Hesabımı Sil Butonuna Basılır. Daha Sonra Kullanıcının Kararından Emin Olmak 
İçin MessageBox Aracılığıyla Bir Evet Hayır Girdisi Alınır. Evet İse Hesap Databaseden Silinir Hayır İse Bir MessageBox Daha Verilir,  (İşlemden Vazgeçtiniz) Yazar. 


