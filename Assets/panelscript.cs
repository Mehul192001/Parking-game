using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelscript : MonoBehaviour
{


	public GameObject Endscrn;

	 void OnTriggerEnter(Collider other)
	{


		if (other.gameObject.tag == "nwt")
		{
			Endscrn.gameObject.SetActive(true);
			Cursor.visible = true;

		}

	}
}
