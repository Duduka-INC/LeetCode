using LeetCode.Pointers;


// var foo = new PrintInOrder();
// var threadA = new Thread(() =>
// {
//     foo.Second(() => Console.Write("second"));
// });
//
// var threadB = new Thread(() =>
// {
//     foo.First(() => Console.Write("first"));
// });
//
// var threadC = new Thread(() =>
// {
//     foo.Third(() => Console.Write("third"));
// });
//
// threadA.Start();
// threadB.Start();
// threadC.Start();

// var fooBar = new FooBar(3);
//
// new Thread(() => fooBar.Foo(() => Console.Write("foo"))).Start();
// new Thread(() => fooBar.Bar(() => Console.Write("bar"))).Start();


// var zeroEvenOdd = new ZeroEvenOdd(16);
//
// new Thread(() => zeroEvenOdd.Zero((n) => Console.Write(n))).Start();
// new Thread(() => zeroEvenOdd.Even((n) => Console.Write(n))).Start();
// new Thread(() => zeroEvenOdd.Odd((n) => Console.Write(n))).Start();


// var buildingH2O = new H2O();
//
// var water = "HHHHHHHHHHOHHOHHHHOOHHHOOOOHHOOHOHHHHHOOHOHHHOOOOOOHHHHHHHHH";
// var result = new StringBuilder();
// var threads = new List<Thread>();
//
// void DoAction(char c)
// {
//     result.Append(c);
// }
//
// foreach (char c in water)
// {
//     if (c is 'H')
//     {
//         var t = new Thread(() => buildingH2O.Hydrogen(() => DoAction(c)));
//         threads.Add(t);
//         t.Start();
//     }
//     else
//     {
//         var t = new Thread(() => buildingH2O.Oxygen(() => DoAction(c)));
//         threads.Add(t);
//         t.Start();
//     }
// }
//
// foreach (var thread in threads)
// {
//     thread.Join();
// }
//
// if (result.Length != water.Length)
// {
//     Console.WriteLine($"Wrong: \n{water}\n{result}");
// }
// else
// {
//     Console.WriteLine($"Correct: \n{water}\n{result}");
// }

var arr1 = new int[] {0, 2, 3, 3, 3, 3, 3, 4, 4, 55};
var arr2 = new int[] {1, 1, 3, 3, 3, 4};
var arr3 = new int[] {0, 2, 2, 2, 4};

var test = new SameNumber();

int res = test.Solve(arr1, arr2, arr3);

Console.WriteLine(res);