using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Show_Object : MonoBehaviour
{
    public GameObject Hard_Hat;

    void Start() {

    }

    void Update() {
        
    }

    public void whenButtonClicked() {
        if (Hard_Hat.activeInHierarchy == true)
            Hard_Hat.SetActive(false);
        else
            Hard_Hat.SetActive(true);
    }
}
