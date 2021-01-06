using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
public GameObject tutorials;
public GameObject Credits;
    void Start()
    {
tutorials.SetActive(false);
Credits.SetActive(false);
    }
     private void Update()
    {
        Escape();
    }

public void Newgame()
{
          
        SceneManager.LoadScene(1);
}
public void tutorial()
{
tutorials.SetActive(true);
}
public void Quit()
{

}
public void Credit()
{
Credits.SetActive(true);
}
public void Escape()
{
    if(Input.GetKeyDown(KeyCode.Escape))
    {
        tutorials.SetActive(false);
        Credits.SetActive(false);
    }
}
public void close()
{
    tutorials.SetActive(false);
    Credits.SetActive(false);
}
}