public sealed class GameSystems : Feature
{
	public GameSystems(Contexts contexts)
	{
		Add(new SetupGameStateSystem(contexts));
		Add(new CreateViewParentSystem(contexts));

		Add(new FirstCreateSystem(contexts));

		Add(new AddViewSystem(contexts));

		Add(new SetParentSystem(contexts));
		Add(new OnAnimationCompletedSystem(contexts));

		Add(new GameEventSystems(contexts));

		Add(new GameCleanupSystems(contexts));
	}
}