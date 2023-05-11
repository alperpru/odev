Bu proje , basit bir sinema rezarvasyon uygulamasıdır. Aşağıdaki kısımda kodun işleyişi ve her bir kodun ne işe yaradığını detaylı olarak açıklamaya çalıştım ; 

ilk olarak Film sınıfı :
Ad adında bir özellik içeriyor ,film adını temsil eder.
SeansSaatleri adında bir DateTime listesi özelliği vardır, bu da filmin seans saatlerini temsil eder.
Film sınıfının yapıcı (constructor) metodu, film adını alır ve SeansSaatleri listesini oluşturur.

ikinci olarak salon sınıfı:
Ad adında bir özellik içeriyor, bu salonun adını temsil eder.
KoltukKapasitesi adında bir tamsayı özelliği vardır, bu da salonun koltuk kapasitesini temsil eder.
Salon sınıfının yapıcı metodu, salon adını ve koltuk kapasitesini alır.

Üçüncü olarak seans sınıfı:
Film adında bir Film nesnesi özelliği içerir, bu seansın hangi filmi temsil ettiğini gösterir.
Salon adında bir Salon nesnesi özelliği içerir, bu seansın hangi salonda yapıldığını gösterir.
Tarih adında bir DateTime özelliği vardır, bu da seansın tarih ve saatini temsil eder.
Seans sınıfının yapıcı metodu, film, salon ve tarih bilgilerini alır.

Dördüncü olarak rezarvasyon sınıfı:
Seans adında bir Seans nesnesi özelliği içerir, bu rezervasyonun hangi seansa ait olduğunu gösterir.
MusteriAdSoyad adında bir dize (string) özelliği vardır, bu da rezervasyon yapan müşterinin adını temsil eder.
BiletAdedi adında bir tamsayı özelliği vardır, bu da rezervasyonun bilet adedini temsil eder.
KoltukNo adında bir tamsayı özelliği vardır, bu da rezervasyonun koltuk numarasını temsil eder.
Rezervasyon sınıfının yapıcı metodu, seans, müşteri adı, bilet adedi ve koltuk numarasını alır.
Son olarak program sınıfı:

Main metodunda programın ana mantığı yer alır.
İlk olarak, Film ve Seans nesneleri oluşturulur ve seans saatleri eklenir.
Ardından, Salon nesnesi oluşturulur.
Seanslar oluşturulur ve belirli bir listeye eklenir.



