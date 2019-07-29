using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCharacter : MonoBehaviour {	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space))
        {
            GetComponent<RectTransform>().Rotate(new Vector3(0, 3, 0));
        }
    }
}
