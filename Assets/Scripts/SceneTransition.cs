using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;  // Reference to the Animator component
    private string sceneToLoad;

    // Call this function to fade out and load a scene
    public void FadeToScene(string sceneName)
    {
        sceneToLoad = sceneName;
        animator.SetTrigger("FadeOut");  // Assumes there is a FadeOut trigger in the animator
    }

    // This function will be called at the end of the fade-out animation via an animation event
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
