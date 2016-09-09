using UnityEngine;
using System.Collections;

/// <summary>
/// 玩家对象控制
/// </summary>
public class PlayerCtrl : MonoBehaviour {


	void Start () {
        InteractionCtrl.MouseDownEven += new InteractionCtrl.MouseDown(SwitchPlayerRotation);
	}
	
	void Update () {
        transform.position += transform.forward * Time.deltaTime * 5;
	}

    /// <summary>
    /// 切换玩家角度
    /// </summary>
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
