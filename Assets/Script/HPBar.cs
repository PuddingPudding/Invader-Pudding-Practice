using UnityEngine;
using System.Collections;

public class HPBar : MonoBehaviour {

    public float maxHP = 100;
    public float HP = 100;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = new Vector2( (-0.55f + 0.55f * (HP / maxHP) )  ,  0 );
	}
}
