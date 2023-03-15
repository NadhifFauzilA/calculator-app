class Calculator
{
	static void Main(string[] args)
	{
		int a =10;
		int b=6;
		console.Writeline("Hasil Penambahan :{0} + {1} = {2} ",a,b, Penambahan (a,b));
	}
	static int Penambahan (int a, int b)
	{
		return a+b;
		
	}
	static int Pengurangan (int a, int b )
	{
		return a-b;
		
	}
}