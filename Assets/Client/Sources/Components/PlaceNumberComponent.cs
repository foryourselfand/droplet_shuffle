using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game]
public class PlaceNumberComponent : IComponent
{
	[EntityIndex] public int value;
}