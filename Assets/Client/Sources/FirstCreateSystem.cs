using System;
using DG.Tweening;
using Entitas;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class FirstCreateSystem : IInitializeSystem
{
	private readonly Contexts _contexts;

	public FirstCreateSystem(Contexts contexts)
	{
		_contexts = contexts;
	}

	public void Initialize()
	{
		for (var i = 0; i < 4; i += 1)
		{
			var tempPosition = i * _contexts.game.variables.positionDistance;
			_contexts.game.CreateShadowAndGlass(tempPosition, i);
		}

		var trueDudes = _contexts.game.GetEntitiesWithDudeHolder(true);
		foreach (var trueDude in trueDudes)
			trueDude.AddGlassAnimation(1, Ease.OutQuart);
	}
}