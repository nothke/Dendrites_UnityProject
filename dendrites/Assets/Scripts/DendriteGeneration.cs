using UnityEngine;
using System.Collections;

public class DendriteGeneration : MonoBehaviour
{

	public float forceFactor; // Random force multiplier
	public float randomPercent; // This is the rate of spawning in percent per frame
	public int numberOfTwins; // A maximum number of instances spawned in a single birth
	public int maxBirths; // A maximum number of births an object can have
	public int fertilityLoss; // After how many generations do they become infertile. This is used to limit the infinite generation

	private int i;

	void Update ()
	{
		rigidbody.AddForce (Random.Range (-1f, 1f) * forceFactor, Random.Range (-1f, 1f) * forceFactor, Random.Range (-1f, 1f) * forceFactor);
	
		if (Random.value < (0.01 * randomPercent)) {
			if (i < maxBirths) {
				for (int j = 0; j < numberOfTwins; j++) { // I previously used: "Random.Range (0, numberOfTwins)", but it was hard to control fps
					GameObject newborn = Instantiate (gameObject, transform.position, Quaternion.identity) as GameObject;
					newborn.GetComponent<DendriteGeneration>().randomPercent -= randomPercent / fertilityLoss;
				}
				i++;
			}
		}
	}
}
