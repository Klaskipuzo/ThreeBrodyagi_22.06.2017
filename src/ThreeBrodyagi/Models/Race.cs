using System.ComponentModel;

namespace ThreeBrodyagi.Models;

public enum Race
{
	[Description("могучий орк")]
	OrcWarrior = 1,
	[Description("мудрый волшебник")]
	HumanWizard = 2,
	[Description("ловкий плут")]
	ElfRogue = 3
}