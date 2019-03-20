using Entitas;

public class SetupGameStateSystem : IInitializeSystem
{
	private readonly Contexts _contexts;

	public SetupGameStateSystem(Contexts contexts)
	{
		_contexts = contexts;
	}

	public void Initialize()
	{
		_contexts.game.SetVariables(0, 1);
	}
}