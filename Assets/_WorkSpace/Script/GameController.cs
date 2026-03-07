using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    private PlayerActionController _playerActionController;
    private AudioController _audioController;
    private SceneController _sceneController;
    private StateController _stateController;

    PlayerInput playerInput;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        _playerActionController = new(playerInput);
        _audioController = new();
        _sceneController = new();
        _stateController = new();
    }

    void Start()
    {
        
    }

    void Update()
    {
        _playerActionController.Tick();
    }
}
