using Entitas;
using UnityEngine;

public class CreateViewParentSystem : IInitializeSystem
{
	private readonly Contexts _contexts;

	public CreateViewParentSystem(Contexts contexts)
	{
		_contexts = contexts;
	}

	public void Initialize()
	{
		var parentTransform = new GameObject("View").transform;
		parentTransform.localPosition += new Vector3(-45, 0);
		_contexts.game.SetViewParent(parentTransform);
	}
}