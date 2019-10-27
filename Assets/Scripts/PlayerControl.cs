using System.Collections;
using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float xMax,xMin;
    public GameObject shot;
    public Transform Spawnpoint;
    public float Bulletspeed;
    private float nextFire;



   
   void Update()
   {
      if(Input.GetButton("Fire1") && Time.time >nextFire)
      {
          nextFire = Time.time + Bulletspeed;
          Instantiate(shot,Spawnpoint.position,Spawnpoint.rotation);
      }
   
   }   void FixedUpdate()
   {
       float moveHorizontal = Input.GetAxis("Horizontal");
       Vector3 movement = new Vector3 (moveHorizontal,0.0f,0.0f);
       GetComponent<Rigidbody>().velocity = movement*speed;
       GetComponent<Rigidbody>().position = new Vector3
       (
           Mathf.Clamp(GetComponent<Rigidbody>().position.x,xMin,xMax),
           0.0f,
           0.0f
       );
   }
}
