using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Event(EventTarget.Self)]
public class TweenAnimationComponent : IComponent
{
	public string value;
}