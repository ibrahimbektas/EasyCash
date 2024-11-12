1- Kullanıcı kayıt sayfası oluşturuldu.(Kayıt için confirm ma,il eklendi.)
2- Login sayfası oluşturuldu.
3- Layout sayfası oluşturuldu ve düzenlendi.
4- Giriş yapan kullanıcının kullanıcı bilgilerini düzenleyebilmesi için MyAccounts sayfası oluşturuldu.
5- Para transfer işlemi için SendMoney sayfası oluşturuldu.
6- Döviz kurları için Exchange sayfası oluşturuldu.(API ile döviz kurları çekildi.)
7- Kullanıcın yaptığı son işlemlerin görüntülenebilmesi için MyLastProcess sayfası oluşturuldu.
8- Kullanıcın Hesap bilgilerinin listelenebildiği AccountListForCopy sayfası oluşturuldu.
9- Elektrik faturalarının ödenebiildiği ElectricBill sayfası oluşturuldu.


--HATIRLATMA--
Email confirmed çalışması için RegisterConroller.cs dosyası 51. satır admin email yazmayı unutma.
                    MailboxAddress mailBoxAdressFrom = new MailboxAddress("Easy Cash Admin", " //Admin email ");

Aynı şekilde 66. satırda admin email için Uygulama Kimliği Anahtarı yazmayı unutma
                    client.Authenticate(" //Admin Email ", " //Uygulama Kimliği Anahtarı ");
