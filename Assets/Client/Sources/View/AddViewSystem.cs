using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
	private readonly Transform _parent;

	public AddViewSystem(Contexts contexts) : base(contexts.game)
	{
		_parent = new GameObject("Views").transform;
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.Asset.Added());

	protected override bool Filter(GameEntity entity)
		=> !entity.hasView;

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var entity in entities)
			entity.AddView(InstantiateView(entity));
	}

	private IView InstantiateView(GameEntity entity)
	{
		var prefab = Resources.Load<GameObject>(entity.asset.value);
		var view = Object.Instantiate(prefab, _parent).GetComponent<IView>();
		view.Link(entity);
		return view;
	}
}