using System.Collections.Generic;
using Entitas;

public class SetParentSystem : ReactiveSystem<GameEntity>
{
	public SetParentSystem(Contexts contexts) : base(contexts.game)
	{
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.ParentTransform);

	protected override bool Filter(GameEntity entity)
		=> entity.hasParentTransform && entity.hasTransform;

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var entity in entities)
		{
			entity.transform.value.parent = entity.parentTransform.value;
		}
	}
}