using System;
using System.Threading.Tasks;
using LeetCode.Problems;


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


var zeroEvenOdd = new ZeroEvenOdd(16);

new Thread(() => zeroEvenOdd.Zero((n) => Console.Write(n))).Start();
new Thread(() => zeroEvenOdd.Even((n) => Console.Write(n))).Start();
new Thread(() => zeroEvenOdd.Odd((n) => Console.Write(n))).Start();
