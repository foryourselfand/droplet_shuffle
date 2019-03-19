using Entitas;
using Entitas.Unity;
using UnityEngine;

public class View : MonoBehaviour, IView
{
	public void Link(Entity entity)
	{
		gameObject.Link(entity);
	}
}