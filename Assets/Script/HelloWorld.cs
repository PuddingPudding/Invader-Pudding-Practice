using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

    MetaData unit;
    
    // Use this for initialization
    void Start () {
        unit = GetComponent<MetaData>(); //獲取小飛兵的組件
        
    }
	
	// Update is called once per frame
	void Update ()
    {               
        float speed;

        if (unit != null)
        {
            speed = unit.Speed;
        }
        else
        {
            print("hello bitch!");
            speed = 2;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed); //往左
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed); //往右
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed); //往上
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed); //往下
        }
        
    }

    /*void OnCollisionEnter2D() //2D碰撞事件
    {
        transform.position = new Vector2(0 , 0);
    }*/
}
