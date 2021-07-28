using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    InputActionCollections InputCol;
    [SerializeField] float MoveSpeed;
    private Vector2 PlayerMovementInput;
    private void OnDisable()
    {
        InputCol.Disable();
    }

    private void Awake()
    {
       
    }

    void Start()
    {
        SetupInput();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void SetupInput()
    {
        InputCol = new InputActionCollections();
        InputCol.Enable();
        InputCol.Gameplay.Move.performed += ReadMovementValFromCtx;
        InputCol.Gameplay.Move.canceled += ReadMovementValFromCtx;
    }

    void ReadMovementValFromCtx(InputAction.CallbackContext ctx)
    {
        PlayerMovementInput = ctx.ReadValue<Vector2>();
    }

    private void MovePlayer()
    {
        Vector3 MoveDir = new Vector3(PlayerMovementInput.normalized.x, 0, PlayerMovementInput.normalized.y);
        transform.Translate(MoveDir * MoveSpeed * Time.deltaTime);
    }
}
