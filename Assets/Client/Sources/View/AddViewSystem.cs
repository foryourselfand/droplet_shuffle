using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
	private readonly Transform _viewParent;

	public AddViewSystem(Contexts contexts) : base(contexts.game)
	{
		_viewParent = new GameObject("Views").transform;
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.Asset);

	protected override bool Filter(GameEntity entity)
		=> entity.hasAsset && !entity.hasView;

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var entity in entities)
			entity.AddView(InstantiateView(entity));
	}

	private IView InstantiateView(GameEntity entity)
	{
		var prefab = Resources.Load<GameObject>(entity.asset.value);
		var parentTransform = entity.hasParentTransform ? entity.parentTransform.value : _viewParent;
		var go = Object.Instantiate(prefab, parentTransform);
		entity.AddTransform(go.transform);
		var view = go.GetComponent<IView>();
		view.Link(entity);
		return view;
	}
}