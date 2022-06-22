using System.ComponentModel;

namespace ThreeBrodyagi.Models;

public enum AbilityTypes
{
	Unlock,
	СatVision,
	Invisibility,
	Fireball,
	Firefly,
	Alhamore,
	[Description("Факел")]
	Torch,
	[Description("Бросить оружие в цель")]
	WeaponThrow,
	[Description("Сломать замок")]
	BreakTheLock,
	[Description("Смертельный удар")]
	DeathBlow
}