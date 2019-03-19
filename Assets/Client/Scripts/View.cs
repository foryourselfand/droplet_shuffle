using Entitas;
using Entitas.Unity;
using UnityEngine;

public class View : MonoBehaviour, IView, IPositionListener, IDestroyedListener
{
	public void Link(Entity entity)
	{
		gameObject.Link(entity);
		var e = (GameEntity) entity;
		e.AddPositionListener(this);
		e.AddDestroyedListener(this);
	}

	public void OnPosition(GameEntity entity, Vector2Int value)
	{
		transform.localPosition = new Vector2(value.x, value.y);
	}

	public void OnDestroyed(GameEntity entity)
	{
		gameObject.Unlink();
		Destroy(gameObject);
	}
}