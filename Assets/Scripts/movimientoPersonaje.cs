using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPersonaje: MonoBehaviour
{
	

	public float velocidad;

	public float movimientoHorizontal;
	public float movimientoVertical;
	[SerializeField]
	private bool powerUpvelocidad = false;
	

	void Start()
	{
		velocidad = 2.0f;
	}

	// Update is called once per frame
	void Update()
	{
		aumentarVelocidad();

		float Horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
		print(Horizontal);
		transform.Translate(Horizontal, 0, 0);
		
	}

	

	

	void aumentarVelocidad()
	{

		float horizontal = Input.GetAxis("Horizontal");

		if (powerUpvelocidad == true)
		{

			transform.Translate(Vector3.right * velocidad * 10.0f * horizontal * Time.deltaTime);
		}
		else
		{
			transform.Translate(Vector3.right * velocidad * horizontal * Time.deltaTime);


		}

	}

	public void Power()
	{
		powerUpvelocidad = true;
		StartCoroutine(powerDown());
	}



	IEnumerator powerDown()
	{
		yield return new WaitForSeconds(5.0f);
		powerUpvelocidad = false;
	}



}