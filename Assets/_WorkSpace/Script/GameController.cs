using UnityEngine;

public class GameController : MonoBehaviour
{
    private PlayerActionController playerActionController = new();
    private AudioController audioController = new();
    private SceneController sceneController = new();

    void Start()
    {
        
    }

    void Update()
    {
        playerActionController.Tick();
    }
}
