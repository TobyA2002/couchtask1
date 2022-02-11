using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(CharacterController), typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField, Tooltip(("Speed multiplier"))]
    private float playerSpeed = 2.0f;
    [SerializeField, Tooltip("How high the player will jump")]    
    private float jumpHeight = 1.0f;
    [SerializeField, Tooltip("How strong is gravity")]
    private float gravityValue = -9.81f;

    #region Private
        private CharacterController controller;
        private Vector3 playerVelocity;
        private bool groundedPlayer;

        private Vector2 movementInput = Vector2.zero;
        private bool jumped = false;
    #endregion Private
    
    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
    
  
    public void OnMove(InputAction.CallbackContext context) {
        movementInput = context.ReadValue<Vector2>();
    }

    
    public void OnJump(InputAction.CallbackContext context) {
        jumped = context.action.triggered;
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
   
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

     
        Vector3 move = new Vector3(movementInput.x, 0, movementInput.y);
        controller.Move(move * (Time.deltaTime * playerSpeed));

      
        if (jumped && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        
   
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
