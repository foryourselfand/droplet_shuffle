public sealed class GameSystems : Feature
{
	public GameSystems(Contexts contexts)
	{
		Add(new CreateFingerSystem(contexts));

		Add(new AddViewSystem(contexts));

		//Events(Generated)
		Add(new GameEventSystems(contexts));

		//Cleanup(Generated)
		Add(new GameCleanupSystems(contexts));
	}
}