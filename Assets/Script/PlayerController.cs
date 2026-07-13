
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   Rigidbody2D body;
   private Vector3 targetPosition;
   private bool isMoving;


public SpriteRenderer rangeIndicator;

public float runSpeed = 20.0f;
public GameObject rangerObject;
public Animator animator;
 AudioSource audioSource;
 public AudioClip[] shoot;
 private AudioClip shootClip;

void Start ()
{
   body = GetComponent<Rigidbody2D>();
   rangerObject.SetActive(false);
      audioSource = gameObject.GetComponent<AudioSource>();
}

void Update()
{

   if(Input.GetKeyDown("space"))
   {
rangerObject.SetActive(true);
   }
    if(Input.GetKeyUp("space"))
   {
rangerObject.SetActive(false);
   }
   if(Input.GetMouseButtonDown(0))
   {
      RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

if(hit.collider != null)
{
   if(hit.collider.tag=="Platform")
 {SetTargetPosition();}}


   }
   if(isMoving)
   {
     Move();
   }
}
//Movement and animation function are done in SetTarget and Move
void SetTargetPosition()
{
targetPosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
targetPosition.z=transform.position.z;
isMoving=true;
animator.SetBool("IsJumping",true);
if (shoot != null && shoot.Length > 0)
{
    int index = Random.Range(0, shoot.Length);
    shootClip = shoot[index];
    if (audioSource != null)
    {
        audioSource.clip = shootClip;
        audioSource.Play();
    }
}
}
public void Move()
{

transform.position=Vector3.MoveTowards(transform.position,targetPosition,runSpeed*Time.deltaTime);
if(transform.position==targetPosition)
{
   isMoving=false;
   animator.SetBool("IsJumping",false);
}
}
void MoveBack()
{
//Not in Range.Update Required
}
}
