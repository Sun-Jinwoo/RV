using UnityEngine;
using UnityEngine.InputSystem;
public class MovePlayer : MonoBehaviour
{
    private Movimientos inputActions;

    private Vector2 movementInput;

    public float speed = 5f;

    private void Awake()
    {
        inputActions = new Movimientos();
    }
    private void OnEnable()
    {
        inputActions.Player.Enable();
    }


}
