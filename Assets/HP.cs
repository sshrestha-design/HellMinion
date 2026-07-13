using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public float health;
    public Text healthText;
public GameObject restartPanel;
 void Start()
{   health=10;
 restartPanel.SetActive(false);
}
void Update()
{
 healthText.text=health.ToString();

if(health<=0)
         {
             restartPanel.SetActive(true);
             Time.timeScale = 0;
         }
         else{
             restartPanel.SetActive(false);
                          Time.timeScale = 1;

         }

}
  void OnTriggerEnter2D(Collider2D other)
{
     if (other.gameObject.tag == "bullet")
     {
                      health-=1;
other.gameObject.SetActive (false);


     }
}
}
