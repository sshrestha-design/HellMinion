
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   Rigidbody2D body;
   private Vector3 targetposition;
   private bool isMoving;
 

public SpriteRenderer range;

public float runSpeed = 20.0f;
public GameObject ranger;
public Animator animator;
 AudioSource audioSource; 
 public AudioClip[] shoot;
 private AudioClip shootClip;

void Start ()
{
   body = GetComponent<Rigidbody2D>();
   ranger.SetActive(false);
      audioSource = gameObject.GetComponent<AudioSource>();
}

void Update()
{
 
   if(Input.GetKeyDown("space"))
   {
ranger.SetActive(true);
   }
    if(Input.GetKeyUp("space"))
   {
ranger.SetActive(false);
   }
   if(Input.GetMouseButton(0))
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
     int index = Random.Range(0, shoot.Length);
         shootClip = shoot[index];
         audioSource.clip = shootClip;
         audioSource.Play();
   }
}

void SetTargetPosition()
{
targetposition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
targetposition.z=transform.position.z;
isMoving=true;
animator.SetBool("IsJumping",true);
}
public void Move()
{
   
transform.position=Vector3.MoveTowards(transform.position,targetposition,runSpeed*Time.deltaTime);
if(transform.position==targetposition)
{
   isMoving=false;
   animator.SetBool("IsJumping",false);
}
}
void Moveback()
{
}
}