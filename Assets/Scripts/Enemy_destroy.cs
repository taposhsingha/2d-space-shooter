﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroy : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
       if(other.tag=="Boundary")
       {
           return;
       }
       Destroy(other.gameObject);
       Destroy(gameObject);
   }
}
