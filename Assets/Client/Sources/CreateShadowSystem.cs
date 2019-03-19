using Entitas;
using UnityEngine;

public class CreateShadowSystem : IInitializeSystem
{
	private readonly Contexts _contexts;

	public CreateShadowSystem(Contexts contexts)
	{
		_contexts = contexts;
	}

	public void Initialize()
	{
		var shadow = _contexts.game.CreateEntity();
		shadow.AddAsset("shadow");
		shadow.AddPosition(new Vector2(-20, -20));
		shadow.isNeedToCreateGlass = true;
	}
}