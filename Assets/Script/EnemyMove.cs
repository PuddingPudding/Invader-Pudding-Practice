using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

    public float movingCounter = 0 , posX = 0;
    public float movingCounterMax = 3;
    public GameObject Bullet;
    public float shootingCounter = 0, shootingCounterMax = 0.7f;

	// Use this for initialization
	void Start () {
        posX = Random.Range(-3, 3);
    }
	
	// Update is called once per frame
	void Update () {
        movingCounter += Time.deltaTime;
        shootingCounter += Time.deltaTime;

        if(movingCounter >= movingCounterMax)
        {
            movingCounter = 0;
            posX = Random.Range(-3, 3);            
        }
        AIMove(posX);
        
        if(shootingCounter >= shootingCounterMax)
        {
            shootingCounter = 0;
            AIShoot();
        }
    }

    public void AIMove(float posX)
    {
        float speed = GetComponent<MetaData>().Speed;
        if(Mathf.Abs(posX - transform.position.x) > 0.1f)
        {
            if(posX < transform.position.x) //新出現的座標於現有座標左邊
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
    }

    public void AIShoot()
    {
        GameObject bulletClone;
        bulletClone = (GameObject)Instantiate(Bullet, transform.position, new Quaternion(0, 0, 0, 0) );
        //複製子彈物件在物件位置

        bulletClone.GetComponent<BulletMove>().team = this.GetComponent<MetaData>().team;
        //設定bullet的BulletMove中的Team值 為 此物件中MetaData的Team

        bulletClone.transform.Rotate(0 , 0 , 180);//旋轉180度
    }

}
