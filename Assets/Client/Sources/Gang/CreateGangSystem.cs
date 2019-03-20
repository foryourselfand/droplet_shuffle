using System;
using Entitas;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using Object = UnityEngine.Object;

public class CreateGangSystem : IInitializeSystem
{
	private readonly Contexts _contexts;

	public CreateGangSystem(Contexts contexts)
	{
		_contexts = contexts;
	}

	public void Initialize()
	{
		for (var i = -45; i <= 45; i += 30)
		{
			_contexts.game.CreateShadowAndGlass(i);
		}
	}
}