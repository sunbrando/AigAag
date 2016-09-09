using UnityEngine;
using System.Collections;

/// <summary>
/// 玩家对象控制
/// </summary>
public class PlayerCtrl : MonoBehaviour {


	// Use this for initialization
	void Start () {
        InteractionCtrl.MouseDownEven += new InteractionCtrl.MouseDown(SwitchPlayerRotation);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime;
	}

    public void SwitchPlayerRotation()
    {
        Vector3 rot = new Vector3(0, 45, 0);

        if (transform.localEulerAngles == rot)
        {
            transform.localEulerAngles = Vector3.zero;
        }
        else
        {
            transform.localEulerAngles = rot;
        }
    }
}
