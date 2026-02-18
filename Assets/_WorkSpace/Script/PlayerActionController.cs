using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActionController : MonoBehaviour
{
    PlayerInput playerInput;
    bool _playerAttackGetKey;
    bool _playerAttackGetKeyDown;
    bool _playerAttackGetKeyUp;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        _playerAttackGetKey = playerInput.actions["Attack"].IsPressed();
        _playerAttackGetKeyDown = playerInput.actions["Attack"].WasPressedThisFrame();
        _playerAttackGetKeyUp = playerInput.actions["Attack"].WasReleasedThisFrame();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
