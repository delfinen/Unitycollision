using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscript : MonoBehaviour {

    public Animator anim;

	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("ha", true);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetBool("ha", false);
        }



    }
}
