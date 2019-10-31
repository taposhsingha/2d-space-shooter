﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroy : MonoBehaviour
{
   public GameObject explosion;

   void OnTriggerEnter(Collider other)
   {
       if(other.tag=="Boundary")
       {
           return;
       }
       Instantiate(explosion,transform.position,transform.rotation);
       Destroy(other.gameObject);
       Destroy(gameObject);
   }
}
