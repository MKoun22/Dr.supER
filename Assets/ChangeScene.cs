using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour
{
    
    public Transform dist;
    private float distance;

    void Update()
    {
        distance = Vector3.Distance(transform.position, dist.position);
        Debug.Log(distance);
        if (distance < 1.5f)
        {
            LoadA("Scene2");
        }
    }
    public void LoadA(string scene_name)
    {
        Debug.Log("sceneName to load:" + scene_name);
        SceneManager.LoadScene(scene_name);
    }

    /*public float Example()
    {
        if(theDest)
        {
            float dist = Vector3.Distance(theDest.position, transform.position);
            print("Distance to other:" + dist);
            return dist;
        }



    }*/
    //public static float Distance(Vector3 a, Vector3 b)
   // {
        //if (distance < 0.7f)
        //{

       // }
  //  }
}
