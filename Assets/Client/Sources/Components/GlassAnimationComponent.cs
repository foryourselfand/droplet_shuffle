using DG.Tweening;
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Event(EventTarget.Self)]
public class GlassAnimationComponent : IComponent
{
	public int y;
	public Ease ease;
}