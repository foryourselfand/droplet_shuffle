using Entitas;
using UnityEngine;

public class CreateFingerSystem : IInitializeSystem
{
	private readonly Contexts _contexts;

	public CreateFingerSystem(Contexts contexts)
	{
		_contexts = contexts;
	}

	public void Initialize()
	{
		var entity = _contexts.game.CreateEntity();
		entity.AddAsset("finger");
		entity.AddPosition(new Vector2Int(-20, -20));
	}
}