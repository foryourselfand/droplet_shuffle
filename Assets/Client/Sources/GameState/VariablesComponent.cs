using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Unique]
public class VariablesComponent : IComponent
{
	public int currentPlaceNumber;
	public int distace;
}