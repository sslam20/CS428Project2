﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float lifetime = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (lifetime > 0) {
          lifetime -= Time.deltaTime;
          if (lifetime <= 0) {
            Destroy(this.gameObject);
          }
        }
    }
}
