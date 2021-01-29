using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeToScene1 : MonoBehaviour
{
    public Transform dist;
    private float distance;

    void Update()
    {
        distance = Vector3.Distance(transform.position, dist.position);
        Debug.Log(distance);
        if (distance < 1.5f)
        {
            LoadA("Scene1");
        }
    }
    public void LoadA(string scene_name)
    {
        Debug.Log("sceneName to load:" + scene_name);
        SceneManager.LoadScene(scene_name);
    }
}
