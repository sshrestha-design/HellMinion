using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
public int thislevel;
    void Start()
    {

    }

public void load()
{
          
        SceneManager.LoadScene(thislevel);
}
}
