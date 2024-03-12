using APBD;

var arr = new []{ 1, 2, 3 };
var arrString = string.Join(",", arr);

Console.WriteLine($"Average of {arrString} is: {MathUtils.GetAverage(arr)}");
Console.WriteLine($"Max value of {arrString} is: {MathUtils.GetMax(arr)}");

Console.ReadKey();