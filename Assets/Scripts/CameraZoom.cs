using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 5f;
    private bool isSelected = false;
    private Camera mainCamera;
    private GameObject selectedSphere;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (isSelected)
        {
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, transform.position + transform.forward * -3, Time.deltaTime * zoomSpeed);
            //if (Vector3.Distance(mainCamera.transform.position, transform.position + transform.forward * -3) < 0.1f)
            //{

            StartCoroutine(ExecuteAfterTime(2));
            //}
        }
    }

    void OnMouseDown()
    {
        isSelected = true;
        selectedSphere = gameObject;
        foreach (GameObject sphere in GameObject.FindGameObjectsWithTag("Sphere"))
        {
            if (sphere != gameObject)
            {
                sphere.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 0);
            }
        }
    }

    void SceneLoader(GameObject sphere)
    {
        if(sphere.name == "Sphere1")
        {
            SceneManager.LoadScene("Scene3");
        }

        if (sphere.name == "Sphere2")
        {
            SceneManager.LoadScene("Scene3E");
        }

        if (sphere.name == "Sphere3")
        {
            SceneManager.LoadScene("Scene3M");
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        SceneLoader(selectedSphere);


    }
}
