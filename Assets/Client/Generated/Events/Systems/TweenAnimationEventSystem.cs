//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class TweenAnimationEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<ITweenAnimationListener> _listenerBuffer;

    public TweenAnimationEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<ITweenAnimationListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.TweenAnimation)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasTweenAnimation && entity.hasTweenAnimationListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.tweenAnimation;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.tweenAnimationListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnTweenAnimation(e, component.value);
            }
        }
    }
}
