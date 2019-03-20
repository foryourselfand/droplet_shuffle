using System;
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
		var shadowEntity = _contexts.game.CreateEntity();
		shadowEntity.AddAsset("shadow");
		shadowEntity.AddPosition(new Vector2(-20, -20));
		shadowEntity.isNeedToCreateGlass = true;
	}
}