using UnityEngine;

// Abstract classes cannot be used directly
// We inherit from them, and implement their members
public class PlayerInputComponent : InputComponentBase
{
    // private Vector2 inputDirection;
    private PlayerActions playerActions;

    private void Awake()
    {
        playerActions = new PlayerActions();
        playerActions.PlayerInput.Enable();
    }
    
    // // Make the player move forward, back, left, right
    // private void Update()
    // {
    //     inputDirection = Vector2.zero;
    //     
    //     if (Input.GetKey(KeyCode.W))
    //     {
    //         inputDirection.y += 1;
    //         // Debug.Log("W");
    //     }
    //     if (Input.GetKey(KeyCode.S))
    //     {
    //         inputDirection.y -= 1;
    //         // Debug.Log("S");
    //     }
    //     if (Input.GetKey(KeyCode.A))
    //     {
    //         inputDirection.x -= 1;
    //         // Debug.Log("A");
    //     }
    //     if (Input.GetKey(KeyCode.D))
    //     {
    //         inputDirection.x += 1;
    //         // Debug.Log("D");
    //     }
    // }

    public override Vector2 GetInputDirection()
    {
        return playerActions.PlayerInput.Movement.ReadValue<Vector2>();
    }

    public override Vector2 GetInputDirectionNormalized()
    {
        return GetInputDirection().normalized;
    }
}