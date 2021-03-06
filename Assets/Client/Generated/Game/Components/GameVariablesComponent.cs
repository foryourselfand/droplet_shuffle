//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity variablesEntity { get { return GetGroup(GameMatcher.Variables).GetSingleEntity(); } }
    public VariablesComponent variables { get { return variablesEntity.variables; } }
    public bool hasVariables { get { return variablesEntity != null; } }

    public GameEntity SetVariables(int newCurrentPlaceNumber, int newPositionDistance) {
        if (hasVariables) {
            throw new Entitas.EntitasException("Could not set Variables!\n" + this + " already has an entity with VariablesComponent!",
                "You should check if the context already has a variablesEntity before setting it or use context.ReplaceVariables().");
        }
        var entity = CreateEntity();
        entity.AddVariables(newCurrentPlaceNumber, newPositionDistance);
        return entity;
    }

    public void ReplaceVariables(int newCurrentPlaceNumber, int newPositionDistance) {
        var entity = variablesEntity;
        if (entity == null) {
            entity = SetVariables(newCurrentPlaceNumber, newPositionDistance);
        } else {
            entity.ReplaceVariables(newCurrentPlaceNumber, newPositionDistance);
        }
    }

    public void RemoveVariables() {
        variablesEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public VariablesComponent variables { get { return (VariablesComponent)GetComponent(GameComponentsLookup.Variables); } }
    public bool hasVariables { get { return HasComponent(GameComponentsLookup.Variables); } }

    public void AddVariables(int newCurrentPlaceNumber, int newPositionDistance) {
        var index = GameComponentsLookup.Variables;
        var component = (VariablesComponent)CreateComponent(index, typeof(VariablesComponent));
        component.currentPlaceNumber = newCurrentPlaceNumber;
        component.positionDistance = newPositionDistance;
        AddComponent(index, component);
    }

    public void ReplaceVariables(int newCurrentPlaceNumber, int newPositionDistance) {
        var index = GameComponentsLookup.Variables;
        var component = (VariablesComponent)CreateComponent(index, typeof(VariablesComponent));
        component.currentPlaceNumber = newCurrentPlaceNumber;
        component.positionDistance = newPositionDistance;
        ReplaceComponent(index, component);
    }

    public void RemoveVariables() {
        RemoveComponent(GameComponentsLookup.Variables);
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

    static Entitas.IMatcher<GameEntity> _matcherVariables;

    public static Entitas.IMatcher<GameEntity> Variables {
        get {
            if (_matcherVariables == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Variables);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherVariables = matcher;
            }

            return _matcherVariables;
        }
    }
}
