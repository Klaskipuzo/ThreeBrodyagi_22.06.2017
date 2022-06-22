namespace ThreeBrodyagi.Models;

public class Hero
{
	private string[] AuchReplics = new[]
	{
		"Больно!", "Кажется это кровь("
	};
	
	private string DieReplic = "Отомсти за меня...";
	public Race Race;
	public int Health;
	public int Strange;
	public int Dextery;
	public int Wisdom;
	public string Waepon;
	public int Armor;
	public AbilityTypes[] Abilities;

	public string Description()
	{
		return $"Здоровье - {Health}\nСила - {Strange}\n" +
			$"Ловкость - {Dextery}\nМудрость - {Wisdom}\n" +
			$"Защита - {Armor}";
	}
}





