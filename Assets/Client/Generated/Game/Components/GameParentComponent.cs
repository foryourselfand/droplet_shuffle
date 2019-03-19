//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ParentComponent parent { get { return (ParentComponent)GetComponent(GameComponentsLookup.Parent); } }
    public bool hasParent { get { return HasComponent(GameComponentsLookup.Parent); } }

    public void AddParent(IView newValue) {
        var index = GameComponentsLookup.Parent;
        var component = (ParentComponent)CreateComponent(index, typeof(ParentComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceParent(IView newValue) {
        var index = GameComponentsLookup.Parent;
        var component = (ParentComponent)CreateComponent(index, typeof(ParentComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveParent() {
        RemoveComponent(GameComponentsLookup.Parent);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherParent;

    public static Entitas.IMatcher<GameEntity> Parent {
        get {
            if (_matcherParent == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Parent);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherParent = matcher;
            }

            return _matcherParent;
        }
    }
}
