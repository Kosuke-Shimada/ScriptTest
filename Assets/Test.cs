lusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;
    private int power = 25;

    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");

        this.hp -= damage;
    }
}

public class Test : MonoBehaviour {

    void Start () {

        Boss lastboss = new Boss();


        lastboss.Attack();

        lastboss.Defence(3);

        int mp = 53;                    

        public void Magic() {

            Debug.Log("魔法攻撃をした。残りMPは" );

            this.mp -= 5;

            for (int i = 0; i < 11; i++) {

                Debog.Log ("MPが足りないため魔法が使えない。")


            } 

        }




    }
}
	

	void Update () {
		
	}
}