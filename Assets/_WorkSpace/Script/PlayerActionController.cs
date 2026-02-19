using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActionController : MonoBehaviour
{
    PlayerInput playerInput;
    bool _playerAttackGetKeyDown;
    bool _playerAttackGetKeyUp;
    bool _reloadGetKeyDown;
    bool _isClick;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        _playerAttackGetKeyDown = playerInput.actions["Attack"].WasPressedThisFrame();
        _playerAttackGetKeyUp = playerInput.actions["Attack"].WasReleasedThisFrame();
        _reloadGetKeyDown = playerInput.actions["Reload"].WasPressedThisFrame();
    }

    public void Tick()
    {
        if (_playerAttackGetKeyDown)
        {
            _isClick = true;
        }
        else if (_playerAttackGetKeyUp)
        {
            _isClick = false;
        }

        if (_isClick)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
}
