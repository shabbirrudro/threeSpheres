using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// float RADIUS_SPHERE2 = 10.0;
// float RADIUS_SPHERE3 = 2.5;

public class Rotator : MonoBehaviour
{
    //public GameObject pivotObject;
    public float speed;
    float timerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        //radius = this.gameObject.name == "Sphere2" ? 5 : 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCount = Time.deltaTime*speed;
        string bodyToRoatateAround = "";
        //float x  = Mathf.Cos(timerCount)*radius;
        //float y  = Mathf.Sin(timerCount)*radius;
        //float z  = 0;

        if (this.gameObject.name == "Sphere2")
        {
            bodyToRoatateAround = "Sphere1";
        }
        else
        {
            bodyToRoatateAround = "Sphere2";
        }
        transform.RotateAround(GameObject.Find(bodyToRoatateAround).transform.position, new Vector3 (0, 0, 1), timerCount);

        //Debug.Log(Vector3.Distance(GameObject.Find("Sphere3").transform.position, GameObject.Find("Sphere2").transform.position));
    }
}
