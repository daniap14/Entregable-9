using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonScene : MonoBehaviour
{
    public posicion posicion;

    void Start()
    {
        posicion = FindObjectOfType<posicion>();



    }

    public void Scene_one()
    {
        posicion.counter = posicion.counter + 1;
        SceneManager.LoadScene("Black");
    }

    public void Scene_two()
    {
        posicion.counter = posicion.counter + 1;
        SceneManager.LoadScene("Red");
    }

}
