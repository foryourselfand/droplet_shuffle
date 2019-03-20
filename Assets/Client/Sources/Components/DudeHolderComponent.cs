using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game]
public class DudeHolderComponent : IComponent
{
	[EntityIndex] public bool value;
}