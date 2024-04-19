using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class callNextScene : MonoBehaviour
{

    //private Scene activeScene;


    private void NextScene()
    {
        //if (scene.name == "Scene1")
        
            SceneManager.LoadScene("Scenes/Scene2");
        
    }

    //void Start()
    //{
    //    activeScene = SceneManager.GetActiveScene();
    //    NextScene(activeScene);
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown("space"))
    //    {
    //        gameObject.GetComponent<sceneManager>().UnloadScene("Scenes/Scene1");
    //        gameObject.GetComponent<sceneManager>().SelectScene("Scenes/Scene2");
    //    }
    //}
}
