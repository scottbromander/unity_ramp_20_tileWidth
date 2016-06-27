using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public PlayerInventoryDisplay playerInventoryDisplay;
	private int totalStars = 0;

	void Start () {
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplay> ();
	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Star")){
			totalStars++;
			playerInventoryDisplay.OnChangeCarryingStar(totalStars);
			Destroy (hit.gameObject);
		}
	}
}
