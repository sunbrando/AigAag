using UnityEngine;
using System.Collections;

/// <summary>
/// 这里记录所有的常理
/// </summary>
public class Convention : MonoBehaviour {

	//视野的角度 45度
    public const float VIEW_ANGLE = Mathf.PI * 0.25f; 
    //球的大小
    public const float SPHERE_SIZE = 1; 

    //方块的标准长宽高
    public static readonly Vector3 CUBE_SIZE = new Vector3(3, 7, 3);
    //Sin视野角度的值
    public static readonly float VIEW_SINVALUE = Mathf.Sin(VIEW_ANGLE);

    public enum MOVE_STATE
    {
        FORWARD,
        RIGHT
    }
}
