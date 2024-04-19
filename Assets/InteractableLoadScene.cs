using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableLoadScene : MonoBehaviour
{
    public string sceneNameToLoad;

    private void OnMouseDown()
    {
        LoadScene();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
