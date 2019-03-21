using Entitas;
using UnityEngine;

public class ColorView : View, IColorListener
{
	public override void Link(Entity entity)
	{
		var e = (GameEntity) entity;
		e.AddColorListener(this);
		base.Link(entity);
	}

	public void OnColor(GameEntity entity, Color value)
	{
		GetComponent<SpriteRenderer>().color = value;
	}
}