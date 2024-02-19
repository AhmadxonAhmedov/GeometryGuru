string menu = @"Geometrik guru loyixasi
Agar 1 raqamini kiritsangiz aylana yuzasini aniqlab beriladi
Agar 2 raqamini kiritsangiz uchburchak yuzasini aniqlab beriladi
Agar 3 raqamini kiritsangiz tortburchak yuzasini aniqlab beriladi";

double S;
Console.WriteLine(menu);
string userInhut = Console.ReadLine();

  switch(userInhut)
{
    case "1":
    Console.WriteLine("Radius:  ");
    userInhut = Console.ReadLine();
    double radius = Convert.ToDouble(userInhut);
    
    S = Math.PI * (radius * radius);
    Console.WriteLine("Aylana yuzasi " + S);
    break;

    case "2":
    Console.WriteLine("Uzunlikni kiriting:  ");
    userInhut = Console.ReadLine();
    double b = Convert.ToDouble(userInhut);
    Console.WriteLine("Balandlikni kriting:  ");
    userInhut = Console.ReadLine();
    double p = Convert.ToDouble(userInhut);

    S = 0.5 * b * p;
    Console.WriteLine("Uchburchakning yuzi "+S);
    break;
   
   case "3":
   Console.WriteLine("Uzunlikni kiriting:  ");
   userInhut = Console.ReadLine();
   double m = Convert.ToDouble(userInhut);
   Console.WriteLine("Balandlikni kiriting: ");
   userInhut = Console.ReadLine();
   double u = Convert.ToDouble(userInhut);

   S = m * u;
   Console.WriteLine("To`rtburchakning yuzi: " +S);
   break;
     default:
   Console.WriteLine("Nono`g`ri raqam kiritdingiz:"); 
   break; 

}  