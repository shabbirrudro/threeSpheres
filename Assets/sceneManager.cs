using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void SelectScene(string sceneName)
    {
        Task.Delay(1000);
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
    }

    public void LoadSingleScene(string sceneName)
    {
        Task.Delay(1000);
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }

    public void UnloadScene(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
}
