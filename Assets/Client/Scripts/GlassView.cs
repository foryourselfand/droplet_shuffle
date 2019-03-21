using DG.Tweening;
using Entitas;
using UnityEngine;
using UnityEngine.Events;

public class GlassView : View, IGlassAnimationListener
{
	public int distance;

	public override void Link(Entity entity)
	{
		var e = (GameEntity) entity;
		e.AddGlassAnimationListener(this);
		base.Link(entity);
	}

	public void OnGlassAnimation(GameEntity entity, int y, Ease ease)
	{
		transform.DOMove(new Vector3(0, y * distance), 1).SetRelative(true).SetEase(ease)
			.OnComplete(() => entity.isAnimationCompleted = true);
	}
}