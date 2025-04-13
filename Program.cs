using GenericsExample;
using System.Collections;

//FloatPrinter printer = new FloatPrinter(2.35f);


//var result = printer.PrintData();

//Console.WriteLine(result);

//IntPrinter printer1 = new IntPrinter(34);

//var result1 = printer1.PrintData();

//Console.WriteLine(result1);

//StringPrinter printer2 = new StringPrinter("Traffic");

//var result2 = printer2.PrintData();

//Console.WriteLine(result2);

AllPurposePrinter<float> floatPrinter = new AllPurposePrinter<float>(13.4565f);

var result = floatPrinter.PrintData();

Console.WriteLine(result);

Console.WriteLine();

AllPurposePrinter<string> stringPrinter = new AllPurposePrinter<string>("traffic");

var result1 = stringPrinter.PrintData();

Console.WriteLine(result1);

Console.WriteLine();

AllPurposePrinter<bool> boolPrinter = new AllPurposePrinter<bool>(false);

var result2 = boolPrinter.PrintData();

Console.WriteLine(result2);

CustomClass customClass = new CustomClass();

AllPurposePrinter<CustomClass> customPrinter = new AllPurposePrinter<CustomClass>(customClass);


//Using Array List to do the above
//ArrayList types = new ArrayList
//{
//    "traffic", 3.142f, false, 3000
//};

//foreach (var type in types)
//{
//    AllPurposePrinter<dynamic> typePrinter = new AllPurposePrinter<dynamic>(type);

//    var result5 = typePrinter.PrintData();

//    Console.WriteLine(result5);
//}
Console.ReadKey();
