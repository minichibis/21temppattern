using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : EnemyAbstract
{
	Sprite spri;
    // Start is called before the first frame update
    void Awake()
    {
		base.Awake();
        spri = Resources.Load<Sprite>("skel");
		SpriteRenderer s = gameObject.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
		s.sprite = spri;
    }

    public override int getHealth(){
		return 10;
	}
}
