using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    public float speed = 2;

    public int team = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //20行的版本無法隨方向改變子彈前進的方向，無論旋轉與否，皆往上
        //21行的版本則可以
       // transform.position += new Vector3( 0 ,  speed * Time.deltaTime , 0);
        transform.Translate(Vector2.up * speed * Time.deltaTime );
        if(gameObject.transform.position.y > 8 || gameObject.transform.position.y < -8)
        {
            Destroy(gameObject);
        }
    }

}
