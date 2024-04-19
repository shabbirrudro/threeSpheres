using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;

    public void ShowUI()
    {
        fadeIn = true;
        //myUIGroup.alpha = 1;
    }


    public void HideUI()
    {
        //myUIGroup.alpha = 0;
        fadeOut = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeIn)
        {
            myUIGroup.alpha += Time.deltaTime;
            if(myUIGroup.alpha >= 1)
            {
                fadeIn = false;
            }
        }

        if (fadeOut)
        {
            myUIGroup.alpha -= Time.deltaTime;
            if (myUIGroup.alpha == 0)
            {
                fadeOut = false;
            }
        }
    }
}
