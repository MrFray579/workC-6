int a = 20;
int b = 15;
int c = 30;

bool checkA = a < c + b;
bool checkB = b < c + a;
bool checkC = c < a + b;

if  (checkA && checkB && checkC)
Console.WriteLine("Треугольник со сторонами a b c существует");
else
Console.WriteLine("Треугольник со сторонами a b c не существует");



