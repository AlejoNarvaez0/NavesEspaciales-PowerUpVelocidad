﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    [SerializeField]
    private float velocidadDisparo = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velocidadDisparo * Time.deltaTime);

        if (transform.position.y >= 4.30f)
        {
            Destroy(this.gameObject);
        }

    }
}
