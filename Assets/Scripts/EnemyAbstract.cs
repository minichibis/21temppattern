using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAbstract : MonoBehaviour, EnemyTemplate
{
	public int hp;
    // Start is called before the first frame update
    protected void Awake()
    {
		Debug.Log(getHealth());
        hp = getHealth();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, 0.15f);
		if (hp == 0){
			Destroy(gameObject);
		}
    }
	
	public void takeDamage(){
		hp--;
	}
	
	public abstract int getHealth();
	
	
	
}
