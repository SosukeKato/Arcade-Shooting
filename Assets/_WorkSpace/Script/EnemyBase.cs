using UnityEngine;

public enum EnemyState
{
    Idle,
    Move,
    Attack,
    Death,
}

public class EnemyBase : MonoBehaviour
{
    Animator _anim;

    [SerializeField] int _maxHP;
    [SerializeField] float _animationTime;

    int _currentHP;
    float _animationTimer;

    EnemyState _currentState;

    /// <summary>
    /// 生成タイミングで処理する
    /// </summary>
    void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    /// <summary>
    /// オブジェクトをtrueにしたときに呼び出される(初期化処理)
    /// </summary>
    void OnEnable()
    {
        _currentHP = _maxHP;
        _currentState = EnemyState.Idle;
    }

    /// <summary>
    /// 子クラスに委託するUpdate処理
    /// </summary>
    void Tick()
    {
        if (_currentState == EnemyState.Death)
        {
            if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Death") && _anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                Destroy(gameObject);//後からObjectPoolのReturnObject()に変更する
            }
        }
    }

    /// <summary>
    /// 攻撃処理(Stateが攻撃の時のみ呼び出される)
    /// </summary>
    void Attack()
    {
        if (_currentState == EnemyState.Attack) return;

        _anim.SetTrigger("Attack");
        _currentState = EnemyState.Attack;
    }

    /// <summary>
    /// 死亡処理
    /// </summary>
    void Death()
    {
        if (_currentState == EnemyState.Death) return;

        _anim.SetTrigger("Death");
        _currentState = EnemyState.Death;
    }

    /// <summary>
    /// HPの処理
    /// </summary>
    void Health()
    {
        if (_currentHP < 0)
        {
            Death();
        }
    }
}
