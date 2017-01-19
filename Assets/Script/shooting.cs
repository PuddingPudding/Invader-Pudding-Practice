using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour
{
    public GameObject Bullet;//子彈物件

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z) && GameFunction.isGaming)
        {
            GameObject bulletClone;
            bulletClone = (GameObject)Instantiate(Bullet, transform.position, new Quaternion(0, 0 , 0, 0));
            //複製子彈物件在物件位置

            bulletClone.GetComponent<BulletMove>().team = GetComponent<MetaData>().team;
            //設定bullet的BulletMove中的Team值 為 此物件中MetaData的Team
        }
    }
}
