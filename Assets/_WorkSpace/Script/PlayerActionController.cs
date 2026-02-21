using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActionController
{
    InputAction _playerAttack;
    InputAction _reload;
    bool _isClick;

    /// <summary>
    /// コンストラクタ(なんかピュアクラスで使えるAwake的なものらしい)
    /// </summary>
    /// <param name="playerInput"></param>
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
    /// 攻撃の処理
    /// </summary>
    /// <param name="timer">どれくらいの時間攻撃ボタンを押したか</param>
    /// <param name="attackInterval">攻撃ボタンを押している時間が攻撃のCTを超えたか</param>
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
    /// リロードの処理
    /// </summary>
    /// <param name="magazine">現在の装弾数</param>
    /// <param name="magazineMax">最大装弾数</param>
    public void Reload(int magazine, int magazineMax)
    {
        if (_reload.WasPressedThisFrame())
        {
            magazine = magazineMax;
        }
    }
}
