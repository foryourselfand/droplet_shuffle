using System.Collections.Generic;
using Entitas;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
	public AddViewSystem(Contexts contexts) : base(contexts.game)
	{
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.GameObject);

	protected override bool Filter(GameEntity entity)
		=> entity.hasGameObject && !entity.hasView;

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var entity in entities)
		{
			entity.AddTransform(entity.gameObject.value.transform);
			var view = entity.gameObject.value.GetComponent<IView>();
			view.Link(entity);
			entity.AddView(view);
		}
	}
}