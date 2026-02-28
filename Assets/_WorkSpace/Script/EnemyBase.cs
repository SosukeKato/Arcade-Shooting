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
    protected ObjectPool _objectPool;
    protected Animator _anim;

    protected int _currentHP;

    protected EnemyState _currentState;
    protected PoolType _poolType;

    [SerializeField]  int _maxHP;

    /// <summary>
    /// 生成タイミングで処理する
    /// </summary>
    void Awake()
    {
        _anim = GetComponent<Animator>();
        _objectPool = FindAnyObjectByType<ObjectPool>();
    }

    /// <summary>
    /// オブジェクトをtrueにしたときに呼び出される(初期化処理)
    /// </summary>
    void OnEnable()
    {
        _currentHP = _maxHP;
        _currentState = EnemyState.Idle;
    }

    public virtual void Update()
    {
        if (_currentState == EnemyState.Death)
        {
            if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Death") && _anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                _objectPool.ReturnObject((int)PoolType.Enemy, this.gameObject);
            }
        }
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
