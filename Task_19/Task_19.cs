// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число");
string nums;
nums = Console.ReadLine();
if (nums.Length != 5) {
    Console.WriteLine("неверное число");
    return;
}
if(nums[0]==nums[4] && nums[1]==nums[3]) {
    Console.WriteLine("число полиндром");
} else {
    Console.WriteLine("число не полиндром");
}