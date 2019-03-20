public sealed class GameSystems : Feature
{
	public GameSystems(Contexts contexts)
	{
		Add(new CreateGangSystem(contexts));

		Add(new AddViewSystem(contexts));

		Add(new SetParentSystem(contexts));

		Add(new GameEventSystems(contexts));

		Add(new GameCleanupSystems(contexts));
	}
}