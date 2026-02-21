using UnityEngine.SceneManagement;

public class SceneController
{
    /// <summary>
    /// SceneØ‚è‘Ö‚¦
    /// </summary>
    /// <param name="SceneName">Scene–¼</param>
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
