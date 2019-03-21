using System;
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
			var dudeHolder = Random.Range(0, 3) == 0;
			_contexts.game.CreateShadowAndGlass(tempPosition, dudeHolder);
		}

		var trueDudes = _contexts.game.GetEntitiesWithDudeHolder(true);
		foreach (var trueDude in trueDudes)
			trueDude.ReplacePosition(trueDude.position.value + new Vector2(0, 10));

		var falseDudes = _contexts.game.GetEntitiesWithDudeHolder(false);
		foreach (var falseDude in falseDudes)
			falseDude.ReplacePosition(falseDude.position.value + new Vector2(0, -10));
	}
}