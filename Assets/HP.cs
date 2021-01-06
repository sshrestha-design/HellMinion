using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{  
    public float health;
    public Text healths;
public GameObject Restart;
 void Start()
{   health=10;
 Restart.SetActive(false);
}
void Update()
{                        
 healths.text=health.ToString();

if(health<=0)
         {
             Restart.SetActive(true);
             Time.timeScale = 0;
         }
         else{
             Restart.SetActive(false);
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
