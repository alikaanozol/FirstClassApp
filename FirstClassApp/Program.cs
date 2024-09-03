using FirstClassApp;

Person person = new Person();
person.Name = "Ajda";
person.Surname = "Pekkan";
person.DateofBirth = 1946;

Console.WriteLine("İlk kayıt olan öğrencimizin Adı ve Soyadı " +person.Name+" "+person.Surname);

Console.WriteLine("------------------------------");
Console.WriteLine("Sınıfımızda iki adet öğretmenimiz var.");

Person teacher = new Person()
{
    Name = "Adile",
    Surname = "Naşit",
    DateofBirth = 1930,

};
Console.WriteLine($"MEB'den atanan öğretmenimiz {teacher.Name} {teacher.Surname}");

Console.WriteLine("Diğer öğretmenimizin bilgilerini sizin girmeniz isteniyor.");
Person teacher2 = new Person();
Console.Write("Öğretmenin adını giriniz: ");
teacher2.Name = Console.ReadLine();
Console.Write("Öğretmenin soyadını giriniz: ");
teacher2.Surname = Console.ReadLine();
Console.Write("Öğretmenin doğum tarihini yıl olarak giriniz: ");
teacher2.DateofBirth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Oluşturulan öğretmenin adı ve soyadı {teacher2.Name} {teacher2.Surname}");


