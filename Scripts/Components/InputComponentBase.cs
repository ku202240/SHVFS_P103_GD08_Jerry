using UnityEngine;

public abstract class InputComponentBase : MonoBehaviour
{
    public abstract Vector2 GetInputDirection();
    public abstract Vector2 GetInputDirectionNormalized();
}