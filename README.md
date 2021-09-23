<h3>Uygulama İçeriği</h3></br>

<li>Kişiler üye olabilir </li>
<li>Kullanıcılar giriş yapabilir </li>
<li>Üyelerin progil sayfası olacak </li>
<li>Not yönetim sayfayı olacak </li>
<li>Notlara like ve unlike </li>
<li>Notlara yorum yapılabilecek</li>
<li>Notlar içinde arama yapilinir </li>
<li>Notları listeleme türlerini seçebilir </li>
<li>Nota yazılan yorumlar sayfada pop-up olarak açılacak </li>
<li>Üye giriş yapmış ise yorum yapabilir.</li>
<li>Kişiler eBülten üyeliği yapabilir </li>
<li> Toplu duyuru e-postası atılabilinir</li>
<li>Üye olunduğunda bir aktivasyon e-maili alacak </li></br>
<h4>Admin Paneli </h4>
<li>Kategori ekleyebilir, değiştirebilir ve silebilirler </li>
<li>Üyeleri listeleyebilirler ve admin olarak atama yapabilirler </li>
<li>Notlar üzerinde işlem yapabilirler</li>
<li>Profili olacak </li>
<h4>Data Access Layer</h4>
İçerisinde;</br>
<li>Entity framework'ün context'i yer alacak</li>
<li>Tabloları temsil eden diğer nesneler yer alacak (Note class, category class, user class)(Bunlar UI ve Business'ta da kullanılacak.). </li>
DataAccessLayer, Entities.dll içerisine aldığımızda UI, DataAccess, Business refere edebiliriz. Bu üçüyle de çalışabilir. Bu üç katman da entitiesi tanıyıp birlikte çalışabilecek. </br></br>
 Not : Başka class'larla ilgili olan classlarda tanımlara virtual etiketini de koyuyoruz. 1'e *, *'a 1 ya da *'a * ilişkilerde bu ilişkiyi alttaki satırla tanımlayabiliriz.</br>
 <strong>public virtual List<EvernoteNote> Notes { get; set; } </strong> </br></br>
 
