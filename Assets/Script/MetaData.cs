using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MetaData : MonoBehaviour {

    public string UnitName = "New Unit";//名稱預設為新單位
    public int HP = 10;//生命值預設為10
    public float Speed = 2;//速度預設為2
    public int team = 0;
    public GameObject HealthBar;
    public Text HealthNum;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter2D(Collider2D col)  //2D觸發事件
    {
        
        if (col.GetComponent<BulletMove>().team != team)//如果Team值不同則受到傷害
        {
            HP -= 10;
            Destroy(col.gameObject);
            if (HP <= 0)
            {
                Destroy(gameObject);
            }
            HealthBar.GetComponent<HPBar>().HP = HP;
            
        }
    }
}
