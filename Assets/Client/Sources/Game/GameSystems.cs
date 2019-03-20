public sealed class GameSystems : Feature
{
	public GameSystems(Contexts contexts)
	{
		Add(new CreateShadowSystem(contexts));

		Add(new AddViewSystem(contexts));

		Add(new CreateGlassSystem(contexts));

		Add(new GameEventSystems(contexts));

		Add(new GameCleanupSystems(contexts));
	}
}