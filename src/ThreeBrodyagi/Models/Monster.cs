namespace ThreeBrodyagi.Models;

public class Monsters
{
	public string Name;
	public int Health;
	public int Strange;
	public int Dextery;
	public int Wisdom;
	public int Armor;
	private string[] AuchReplics = new[] { "Auch!" };
	private string DieReplic = "??????!";
	public void Damage(int damage)
	{
		Health = Health - damage;
		if (Health > 0)
		{
			Console.WriteLine(AuchReplics[0]);
		}
		else
		{
			Console.WriteLine(DieReplic);
		}
	}
}

