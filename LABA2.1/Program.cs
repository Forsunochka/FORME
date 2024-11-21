using LABA2._1;
Rational r = new Rational(4, 8);
Rational r2 = new Rational(4, 4);
Rational r3 = new Rational();

Console.WriteLine(r);
Console.WriteLine(r2);
Console.WriteLine(r3);

Rational r4 = r + r2;
Console.WriteLine(r4);

Rational r5 = r2 - r3;
Console.WriteLine(r5);

Rational r6 = r * r;
Console.WriteLine(r6);

Rational r7 = r / r2;
Console.WriteLine(r7);
//
//
Console.WriteLine($"________________________________________________");
//
//
Box box1 = new Box(1, 2, 3);
Box box2= new Box(2, 3, 4);

Console.WriteLine(box1);
Console.WriteLine(box2);

Console.WriteLine(box1 != box2);

Box box3 = box1 + box2;
Console.WriteLine(box3);

Box box4 = box1 - box2;
Console.WriteLine(box4);

Console.WriteLine($"____________________________________________________");

int[] d1 = { 1, 2, 3, 4 }; LinearEquation s1 = new LinearEquation(d1, 1);
int[] d2 = { 1, 2, 3, 7, 7, 8 }; LinearEquation s2 = new LinearEquation(d2, 1);
LinearEquation s3 = s1 + s2; LinearEquation s4 = s1 - s2;
Console.WriteLine(s1);
Console.WriteLine(s2); Console.WriteLine(s3);
Console.WriteLine(s4);