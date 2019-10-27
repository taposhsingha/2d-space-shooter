using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

void Update()
  {
      this.transform.position = this.transform.position + new Vector3 (0f,15f,0f) * Time.deltaTime;
      
  }
}
