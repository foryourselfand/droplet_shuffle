using System;
using Entitas;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using Object = UnityEngine.Object;

public class CreateGangSystem : IInitializeSystem
{
	private readonly Contexts _contexts;
	private readonly Transform _viewParent;

	public CreateGangSystem(Contexts contexts)
	{
		_contexts = contexts;
		_viewParent = new GameObject("Views").transform;
	}

	public void Initialize()
	{
		var shadowGameObject = InstantiateFromAsset("shadow");
		var shadowEntity = _contexts.game.CreateEntity();
		shadowEntity.AddGameObject(shadowGameObject);
		shadowEntity.AddPosition(new Vector2(-20, -20));

		var glassEntity = _contexts.game.CreateEntity();
		glassEntity.AddGameObject(InstantiateFromAsset("glass"));
		glassEntity.AddPosition(new Vector2(0, 9));
		glassEntity.AddParentTransform(shadowGameObject.transform);
	}

	private GameObject InstantiateFromAsset(string path)
	{
		var prefab = Resources.Load<GameObject>(path);
		var go = Object.Instantiate(prefab, _viewParent);
		return go;
	}
}