
string helloValue = Environment.GetEnvironmentVariable("HELLO");

if (string.IsNullOrEmpty(helloValue))
{
  Console.WriteLine("none");
}
else
{
   Console.WriteLine(helloValue);
}
