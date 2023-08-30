using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Management : MonoBehaviour
{
    public void Scene_01()
    {
        SceneManager.LoadScene("Scene_01");
    }
    public void Scene_02()
    {
        SceneManager.LoadScene("Scene_02");
    }
}
