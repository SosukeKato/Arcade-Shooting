using UnityEngine.SceneManagement;

public enum GameState
{
    Title,
    InGame,
    GamaClear,
    GameOver
}

public enum PlayerState
{
    Move,
    Encount
}

public class StateController
{
    public StateController()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }
}
