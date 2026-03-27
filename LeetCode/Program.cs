using LeetCode.Problems;

TwoSum twoSum = new TwoSum();
var res = twoSum.Solve(new int[] {0, 1, 2, 3, 4}, 6);

Console.WriteLine($"{res[0]}, {res[1]}");


AddTwoNumbers addTwoNumbers = new AddTwoNumbers();

var l1 = addTwoNumbers.ReverseListNode(addTwoNumbers.MakeListNode(9999999991));
var l2 = addTwoNumbers.ReverseListNode(addTwoNumbers.MakeListNode(9));

var res1 = addTwoNumbers.Solve(l1,  l2);

l1 = addTwoNumbers.ReverseListNode(addTwoNumbers.MakeListNode(2));
l2 = addTwoNumbers.ReverseListNode(addTwoNumbers.MakeListNode(9));

var res2 = addTwoNumbers.Solve(l1,  l2);


var list = new ListNode(2, new ListNode(1, new ListNode(3, new ListNode(4))));

var  traverseTest = new List<int>();
Traverse(list,  traverseTest);

var reverseTraverseTest = new List<int>();
TraverseReverse(list, reverseTraverseTest);

var getValuesTest = GetValues(list, new List<int>());

var reverseTraversePureTest = TraverseReversePure(list);

Console.ReadLine();


List<int> GetValues(ListNode node, List<int> values)
{
    var iterator = list;
    while (iterator != null)
    {
        values.Add(iterator.val);
        iterator = iterator.next;   
    }
    
    return values;
}

void Traverse(ListNode node, List<int> acc)
{
    if (node == null)
    {
        return;
    }
    acc.Add(node.val);
    Traverse(node.next, acc);
} 

void TraverseReverse(ListNode node, List<int> acc)
{
    if (node == null)
    {
        return;
    }
    
    TraverseReverse(node.next, acc);
    acc.Add(node.val);
} 

List<int> TraverseReversePure(ListNode node)
{
    if (node == null)
    {
        return new List<int>();
    }
    
    var result = TraverseReversePure(node.next);
    result.Add(node.val);
    
    return result;
} 


