using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Cleanup(CleanupMode.RemoveComponent)]
public class AnimationCompletedComponent : IComponent
{
}