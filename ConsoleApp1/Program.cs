using ConsoleApp1;

//Cordinate
Cordinate c = new(4, 2);
c.ShowData();
    



//Counter
 Counter a=new Counter(1, 100);
a.increment();
a.decrement();
Console.WriteLine(a);





//TAsk Fraction
Fraction f1 = new Fraction(1, 2);
Fraction f2 = new Fraction(3, 4);

Fraction sum = Fraction.Add(f1, f2);
Console.WriteLine($"Sum: {sum.ToDecimal()}");
Fraction product = f1.Multiply(f2);
Fraction difference = f1.Subtract(f2);

Console.WriteLine($"Product: {product}");
Console.WriteLine($"Difference: {difference}");
