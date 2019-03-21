using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class OnAnimationCompletedSystem : ReactiveSystem<GameEntity>
{
	private readonly Contexts _contexts;

	public OnAnimationCompletedSystem(Contexts contexts) : base(contexts.game)
	{
		_contexts = contexts;
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.AnimationCompleted.Added());

	protected override bool Filter(GameEntity entity)
		=> true;

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var entity in entities)
		{
			Debug.Log(entity.ToString());
		}
	}
}