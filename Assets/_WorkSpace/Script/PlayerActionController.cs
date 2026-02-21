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
    }

    /// <summary>
    /// UŒ‚‚Ìˆ—
    /// </summary>
    /// <param name="timer">‚Ç‚ê‚­‚ç‚¢‚ÌŠÔUŒ‚ƒ{ƒ^ƒ“‚ğ‰Ÿ‚µ‚½‚©</param>
    /// <param name="attackInterval">UŒ‚ƒ{ƒ^ƒ“‚ğ‰Ÿ‚µ‚Ä‚¢‚éŠÔ‚ªUŒ‚‚ÌCT‚ğ’´‚¦‚½‚©</param>
    public void Attack(float timer, float attackInterval)
    {
        if (_isClick)
        {
            timer += Time.deltaTime;

            if (timer >= attackInterval)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            }
        }
    }

    /// <summary>
    /// ƒŠƒ[ƒh‚Ìˆ—
    /// </summary>
    /// <param name="magazine">Œ»İ‚Ì‘•’e”</param>
    /// <param name="magazineMax">Å‘å‘•’e”</param>
    public void Reload(int magazine, int magazineMax)
    {
        if (_reloadGetKeyDown)
        {
            magazine = magazineMax;
        }
    }
}
