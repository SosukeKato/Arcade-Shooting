using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    private PlayerActionController playerActionController;
    private AudioController audioController;
    private SceneController sceneController;

    PlayerInput playerInput;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        playerActionController = new(playerInput);
        audioController = new();
        sceneController = new();
    }

    void Start()
    {
        
    }

    void Update()
    {
        playerActionController.Tick();
    }
}
