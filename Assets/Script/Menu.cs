using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
public GameObject tutorialPanel;
public GameObject creditsPanel;
    void Start()
    {
tutorialPanel.SetActive(false);
creditsPanel.SetActive(false);
    }
     private void Update()
    {
        Escape();
    }

public void StartGame()
{

        SceneManager.LoadScene(1);
}
public void OpenTutorial()
{
tutorialPanel.SetActive(true);
}
public void Quit()
{
    Application.Quit();
}
public void OpenCredits()
{
creditsPanel.SetActive(true);
}
public void Escape()
{
    if(Input.GetKeyDown(KeyCode.Escape))
    {
        tutorialPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }
}
public void ClosePanels()
{
    tutorialPanel.SetActive(false);
    creditsPanel.SetActive(false);
}
}