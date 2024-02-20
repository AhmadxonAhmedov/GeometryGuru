



 string menu = @"Geometrik guru loyixasi
 Agar 1 raqamini kiritsangiz aylana yuzasini aniqlab beriladi
 Agar 2 raqamini kiritsangiz uchburchak yuzasini aniqlab beriladi
 Agar 3 raqamini kiritsangiz tortburchak yuzasini aniqlab beriladi";

Console.WriteLine(menu);



double S;
string userInput = Console.ReadLine();




  switch(userInput)
{
    case "1":
    Console.WriteLine("Radius:  ");
    userInput = Console.ReadLine();
    double radius = Convert.ToDouble(userInput);
    
    S = Math.PI * (radius * radius);
    Console.WriteLine("Aylana yuzasi " + S);
    break;

    case "2":
    Console.WriteLine("Uzunlikni kiriting:  ");
    userInput = Console.ReadLine();
    double b = Convert.ToDouble(userInput);
    Console.WriteLine("Balandlikni kriting:  ");
    userInput = Console.ReadLine();
    double p = Convert.ToDouble(userInput);

    S = 0.5 * b * p;
    Console.WriteLine("Uchburchakning yuzi "+S);
    break;
   
   case "3":
   Console.WriteLine("Uzunlikni kiriting:  ");
   userInput = Console.ReadLine();
   double m = Convert.ToDouble(userInput);
   Console.WriteLine("Balandlikni kiriting: ");
   userInput = Console.ReadLine();
   double u = Convert.ToDouble(userInput);

   S = m * u;
   Console.WriteLine("To`rtburchakning yuzi: " +S);
   break;

   
     default:
   Console.WriteLine("Nono`g`ri raqam kiritdingiz:"); 
   break; 

}  