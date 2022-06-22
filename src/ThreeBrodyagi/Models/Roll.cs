namespace ThreeBrodyagi.Models;

public class Roll
{
	private Random _random = new Random();

	public int Next()
	{
		var value = _random.Next(0, 20);
		return value;
	}
}