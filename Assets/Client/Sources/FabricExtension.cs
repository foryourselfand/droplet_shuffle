using UnityEngine;

public static class FabricExtension
{
	public static void CreateShadowAndGlass(this GameContext context, int x, bool isDudeHolder)
	{
		var shadowGameObject = InstantiateFromAsset("shadow");
		var shadowEntity = context.CreateEntity();
		shadowEntity.AddGameObject(shadowGameObject);
		shadowEntity.AddPosition(new Vector2(x, -30));
		shadowEntity.AddPlaceNumber(context.variables.currentPlaceNumber++);

		var glassEntity = context.CreateEntity();
		glassEntity.AddGameObject(InstantiateFromAsset("glass"));
		glassEntity.AddPosition(new Vector2(0, 9));
		glassEntity.AddParentTransform(shadowGameObject.transform);
		glassEntity.AddDudeHolder(isDudeHolder);

		if (!isDudeHolder) return;
		var dudeEntity = context.CreateEntity();
		dudeEntity.AddGameObject(InstantiateFromAsset("dude"));
		dudeEntity.AddPosition(new Vector2(0, 0));
		dudeEntity.AddParentTransform(shadowGameObject.transform);
		dudeEntity.AddColor(Color.blue);
	}

	private static GameObject InstantiateFromAsset(string path)
	{
		var prefab = Resources.Load<GameObject>(path);
		var go = Object.Instantiate(prefab);
		return go;
	}
}