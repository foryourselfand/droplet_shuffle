using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CreateGlassSystem : ReactiveSystem<GameEntity>
{
	private readonly Contexts _contexts;

	public CreateGlassSystem(Contexts contexts) : base(contexts.game)
	{
		_contexts = contexts;
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.NeedToCreateGlass.Added());

	protected override bool Filter(GameEntity entity)
		=> entity.hasTransform;

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var entity in entities)
		{
			var glassEntity = _contexts.game.CreateEntity();
			glassEntity.AddAsset("glass");
			glassEntity.AddPosition(new Vector2(0, 10));
			glassEntity.AddParentTransform(entity.transform.value);
		}
	}
}