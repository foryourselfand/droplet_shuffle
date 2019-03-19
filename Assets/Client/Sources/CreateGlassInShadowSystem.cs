using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CreateGlassInShadowSystem : ReactiveSystem<GameEntity>
{
	private readonly Contexts _contexts;

	public CreateGlassInShadowSystem(Contexts contexts) : base(contexts.game)
	{
		_contexts = contexts;
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.NeedToCreateGlass);

	protected override bool Filter(GameEntity entity)
		=> entity.isNeedToCreateGlass;

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var entity in entities)
		{
			var glass = _contexts.game.CreateEntity();
			glass.AddParentTransform(entity.transform.value);
			glass.AddAsset("glass");
			glass.AddPosition(new Vector2(0, -10));
		}
	}
}