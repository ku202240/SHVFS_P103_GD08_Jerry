using UnityEngine;

public class IngredientSpawnerComponent : InteractableComponentBase
{
    public override void Interact()
    {
        Debug.Log("Spawn the food!");
    }
}