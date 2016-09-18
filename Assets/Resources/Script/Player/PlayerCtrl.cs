using UnityEngine;
using System.Collections;

/// <summary>
/// 玩家对象控制
/// </summary>
public class PlayerCtrl : MonoBehaviour {

    public static Convention.MOVE_STATE moveState = Convention.MOVE_STATE.FORWARD; 


	void Start () {
        InteractionCtrl.MouseDownEven += new InteractionCtrl.MouseDown(SwitchPlayerRotation);
	}
	
	void Update () {
        PlayerMove();
	}

    public void PlayerMove()
    {
        Vector3 direction;

        if (moveState == Convention.MOVE_STATE.RIGHT)
        {
            direction = transform.forward;
        }
        else
        {
            direction = transform.right;
        }
        transform.position += direction * Time.deltaTime * Config.Speed;
    }

    /// <summary>
    /// 切换玩家角度
    /// </summary>
    public void SwitchPlayerRotation()
    {
        if (moveState == Convention.MOVE_STATE.RIGHT)
        {
            moveState = Convention.MOVE_STATE.FORWARD;
        }
        else
        {
            moveState = Convention.MOVE_STATE.RIGHT;
        }
    }
}
