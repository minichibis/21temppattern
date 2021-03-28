using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
			
			GameObject g = new GameObject();
			int a = Random.Range(1, 4);
			if(a == 3){
				g.AddComponent<Skeleton>();
			} else{
				g.AddComponent<Slime>();
			}
			g.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), -1);
		} else if(Input.GetKeyDown(KeyCode.Space)){
			foreach(EnemyAbstract i in FindObjectsOfType<EnemyAbstract>()){
				i.transform.localScale = new Vector3(0.5f, 1.5f, 1f);
				i.takeDamage();
			}
		} else if (Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
}
