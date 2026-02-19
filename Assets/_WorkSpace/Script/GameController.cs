using UnityEngine;

public class GameController : MonoBehaviour
{
    private PlayerActionController playerActionController = new();

    void Start()
    {
        
    }

    void Update()
    {
        playerActionController.Tick();
    }
}
