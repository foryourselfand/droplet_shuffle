using DG.Tweening;
using Entitas;

public class TweenAnimationView : View, ITweenAnimationListener
{
	public override void Link(Entity entity)
	{
		var e = (GameEntity) entity;
		e.AddTweenAnimationListener(this);
		base.Link(entity);
	}

	public void OnTweenAnimation(GameEntity entity, string value)
	{
		GetComponent<DOTweenAnimation>().DOPlayById(value);
	}
}