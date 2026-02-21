using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    private PlayerActionController playerActionController;
    private AudioController audioController;
    private SceneController sceneController;
    private StateController stateController;

    PlayerInput playerInput;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        playerActionController = new(playerInput);
        audioController = new();
        sceneController = new();
        stateController = new();
    }

    void Start()
    {
        
    }

    void Update()
    {
        playerActionController.Tick();
    }
}
