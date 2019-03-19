using Entitas;
using Entitas.Unity;
using UnityEngine;

public class View : MonoBehaviour, IView, IPositionListener, IDestroyedListener
{
	private Transform _transform;

	public void Link(Entity entity)
	{
		gameObject.Link(entity);
		var e = (GameEntity) entity;
		e.AddPositionListener(this);
		e.AddDestroyedListener(this);
	}

	public Transform SpecialTransform
	{
		get => _transform;
		set => _transform.parent = value;
	}

	public void OnPosition(GameEntity entity, Vector2 value)
	{
		transform.localPosition = value;
	}

	public void OnDestroyed(GameEntity entity)
	{
		gameObject.Unlink();
		Destroy(gameObject);
	}
}