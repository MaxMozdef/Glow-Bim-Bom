using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonLogic : MonoBehaviour
{
    int indexGameplayScene = 1;

    public void PlayGame()
    {
        SceneManager.LoadScene(indexGameplayScene);
    }
}
