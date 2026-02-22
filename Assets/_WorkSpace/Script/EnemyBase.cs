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
    [SerializeField] int _currentHP;
    EnemyState _currentState;

    /// <summary>
    /// UŒ‚ˆ—(State‚ªUŒ‚‚Ì‚Ì‚İŒÄ‚Ño‚³‚ê‚é)
    /// </summary>
    /// <param name="motionTimer"></param>
    void Attack(int motionTimer)
    {
        if (_currentState == EnemyState.Attack)
        {

        }
    }

    /// <summary>
    /// €–Sˆ—
    /// </summary>
    /// <param name="motionTimer"></param>
    void Death(int motionTimer)
    {

    }

    bool IsAlive()
    {
        return _currentHP > 0;
    }
}
