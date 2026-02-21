using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActionController
{
    InputAction _playerAttack;
    InputAction _reload;
    bool _isClick;

    public PlayerActionController(PlayerInput playerInput)
    {
        _playerAttack = playerInput.actions["Attack"];
        _reload = playerInput.actions["Reload"];
    }

    public void Tick()
    {
        if (_playerAttack.WasPressedThisFrame())
        {
            _isClick = true;
        }
        else if (_playerAttack.WasReleasedThisFrame())
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
        if (_reload.WasPressedThisFrame())
        {
            magazine = magazineMax;
        }
    }
}
