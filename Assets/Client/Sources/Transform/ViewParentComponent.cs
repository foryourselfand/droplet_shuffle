using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Unique]
public class ViewParentComponent : IComponent
{
	public Transform value;
}