using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActionController
{
    InputAction _playerAttack;
    InputAction _reload;
    bool _isClick;
    float _timer;

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
        
    }

    /// <summary>
    /// 攻撃の処理
    /// </summary>
    /// <param name="_timer">どれくらいの時間攻撃ボタンを押したか</param>
    /// <param name="attackInterval">攻撃ボタンを押している時間が攻撃のCTを超えたか</param>
    public void Attack(float attackInterval)
    {
        if (_playerAttack.WasPressedThisFrame())
        {
            _isClick = true;
        }
        else if (_playerAttack.WasReleasedThisFrame())
        {
            _isClick = false;
            _timer = 0;
        }

        if (_isClick)
        {
            _timer += Time.deltaTime;

            if (_timer >= attackInterval)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                _timer = 0;
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
