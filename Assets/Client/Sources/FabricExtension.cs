using DG.Tweening;
using UnityEngine;

public static class FabricExtension
{
	public static void CreateShadowAndGlass(this GameContext context, float x, int number)
	{
		var shadowGameObject = InstantiateFromAsset("shadow");
		var shadowEntity = context.CreateEntity();
		shadowEntity.AddGameObject(shadowGameObject);
		shadowEntity.AddPosition(new Vector2(x, -30));
		shadowEntity.AddPlaceNumber(context.variables.currentPlaceNumber++);
		shadowEntity.AddParentTransform(context.viewParent.value);

		var isDudeHolder = number == 1 || number == 2;

		var glassEntity = context.CreateEntity();
		glassEntity.AddGameObject(InstantiateFromAsset("glass"));
		glassEntity.AddPosition(new Vector2(0, 7.5F));
		glassEntity.AddParentTransform(shadowGameObject.transform);
		glassEntity.AddDudeHolder(isDudeHolder);

		if (!isDudeHolder) return;
		var dudeEntity = context.CreateEntity();
		dudeEntity.AddGameObject(InstantiateFromAsset("dude"));
		dudeEntity.AddPosition(new Vector2(0, 2));
		dudeEntity.AddParentTransform(shadowGameObject.transform);
		dudeEntity.AddColor(number == 1 ? Color.cyan : Color.yellow);
	}

	private static GameObject InstantiateFromAsset(string path)
	{
		var prefab = Resources.Load<GameObject>(path);
		var go = Object.Instantiate(prefab);
		return go;
	}
}