using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartClone : MonoBehaviour
{
    public GameObject restartPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject RestartClone = Instantiate(restartPrefab);
    }

}
