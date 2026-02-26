using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : EnemyBase
{
    void Start()
    {

    }

    public override void Update()
    {
        base.Update();
    }

    /// <summary>
    /// 攻撃モーション待機処理(Stateが攻撃の時のみ呼び出される)
    /// </summary>
    void Attack()
    {
        if (_currentState == EnemyState.Attack) return;

        _anim.SetTrigger("Attack");
        _currentState = EnemyState.Attack;
    }
}
