using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


    public float HP = 100;
    public Slider HPslider;
    public Player_Controller playerController;

	// Use this for initialization
	void Awake ()
    {
       // HPslider = GetComponent<Slider>();
        //playerController = GetComponent<Player_Controller>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        HandleHP(HP);
	}

    private void HandleHP(float hp)
    {
        HPslider.value = (hp / 100);
    }
}
