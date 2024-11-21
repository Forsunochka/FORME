using LABA1;

Linear y= new Linear(5,6);
y.Print();
Console.WriteLine(y.Y(4));
//
//
Triangle triangle = new Triangle(3, 4, 90);
triangle.Print();
Console.WriteLine(triangle.S());

Triangle triangle2 = new Triangle(6, 6, 60);
triangle2.Print();
Console.WriteLine(triangle2.S());
//
//
Equation kv=new Equation(1,2,1);
kv.Print();
Console.WriteLine(kv.RootCount());
