using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");

        this.hp -= damage;
    }


    public void Magic() {

        if (mp >= 0) {

            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" this.mp);

        } else {

            for (int i = 0; i < 11;)

                Debug.Log("MPが足りないため魔法が使えない。");

        }



    }
}


public class Test : MonoBehaviour {

    void Start () {

        Boss lastboss = new Boss();

        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < array.Length; i++) {

            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i > 5  i--) {

            Debug.Log(array[i]);
        }
        lastboss.Attack();

        lastboss.Defence(3);

    }
}
	

	void Update () {
		
	}
}