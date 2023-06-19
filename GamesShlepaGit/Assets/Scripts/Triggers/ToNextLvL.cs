using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu ("My components/ToNextLvL")]

public class ToNextLvL : MonoBehaviour
{
    public int sceneIndex;

    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}