using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InfoText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        if(activeScene == "Scene3E")
        {
            TextMeshProUGUI planetInfo = gameObject.GetComponent<TextMeshProUGUI>();
            planetInfo.text = "Earth\n" +
                "Mass: 5.98E24 kg";
        }
        if (activeScene == "Scene3M")
        {
            TextMeshProUGUI planetInfo = gameObject.GetComponent<TextMeshProUGUI>();
            planetInfo.text = "The Moon\n" +
                "Mass: 7.35E22 kg";
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
