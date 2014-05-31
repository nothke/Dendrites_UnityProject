using UnityEngine;
using System.Collections;

public class Utility_Restart : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab))
			Application.LoadLevel (Application.loadedLevel);
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
	}
}
