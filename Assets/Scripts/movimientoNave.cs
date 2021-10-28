using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoNave : MonoBehaviour
{



    public float movimientoVertical;
    public float movimientoHorizontal;
    public float velocidadHorizontal;
    public float velocidadVertical;
    public int vidasJugador;

    public GameObject disparoLaser;
    
    

    // Start is called before the first frame update
    void Start()
    {
        velocidadHorizontal = 5.0f;
        velocidadVertical = 5.0f;

    }

    // Update is called once per frame
    void Update()
    {
        movimientoPersonaje();
        disparoPersonaje();
        
    }


    void movimientoPersonaje()
    {
        //Desplazamiento del personaje en el eje x && y
        movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * velocidadHorizontal * movimientoHorizontal);

        movimientoVertical = Input.GetAxis("Vertical"); 
        transform.Translate(Vector3.up * Time.deltaTime * movimientoVertical * velocidadVertical);

        //Limitacion del eje x && y
        if (transform.position.y > 3.37f)
        {
            transform.position = new Vector3(transform.position.x, 3.37f, transform.position.z);
        }

        if (transform.position.y < -3.31f)
        {
            transform.position = new Vector3(transform.position.x, -3.31f, transform.position.z);
        }

        if (transform.position.x > 5.96f)
        {
            transform.position = new Vector3(5.96f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -5.97f)
        {
            transform.position = new Vector3(-5.97f, transform.position.y, transform.position.z);
        }



    }
    void disparoPersonaje()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(disparoLaser, transform.position + new Vector3(0, 0, 0f), Quaternion.identity);

            
           
        }
        else if(Input.GetKey(KeyCode.T))
            {
            Instantiate(disparoLaser, transform.position + new Vector3(0, 0, 0f), Quaternion.identity);
            Instantiate(disparoLaser, transform.position + new Vector3(0.40f, 0, 0f), Quaternion.identity);
            Instantiate(disparoLaser, transform.position + new Vector3(-0.40f, 0, 0f), Quaternion.identity);

        }
    }




}

    
        




