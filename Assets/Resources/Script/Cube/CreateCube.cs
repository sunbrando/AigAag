using UnityEngine;
using System.Collections;

public class CreateCube : MonoBehaviour {

    public GameObject CubeTem;

    //上一方块
    private GameObject mLastObj;

    void Start()
    {
        mLastObj = GameObject.Find("Platform");
        for (int index = 0; index < 50; index++)
        {
            Create();
        }
    }

    //创建标准方块条
    void Create()
    {
        GameObject newCube;

        Vector3 pos = GetCubePos(mLastObj.transform.position, mLastObj.transform.localScale, Convention.CUBE_SIZE);
        newCube = Instantiate(CubeTem) as GameObject;
        newCube.transform.position = pos;

        mLastObj = newCube;
    }

    /// <summary>
    /// 获取方块条的坐标
    /// </summary>
    /// <param name="lastPos">上一方块的位置</param>
    /// <param name="lastCubeSize">上一方块的大小</param>
    /// <param name="newCubeSize">正在创建的方块的大小</param>
    /// <returns></returns>
    Vector3 GetCubePos(Vector3 lastPos, Vector3 lastCubeSize, Vector3 newCubeSize)
    {
        int randonNumber = Random.Range(0, 2);
        float posX, posY, posZ;
        if (randonNumber == 0) //右边
        {
            posX = lastCubeSize.x / 2 + newCubeSize.x / 2;
            posZ = lastCubeSize.z / 2 - newCubeSize.z / 2;
        }
        else
        {
            posX = lastCubeSize.x / 2 - newCubeSize.x / 2;
            posZ = lastCubeSize.z / 2 + newCubeSize.z / 2;
        }

        posY = -(newCubeSize.y / 2 + Convention.SPHERE_SIZE / 2);

        return new Vector3(lastPos.x + posX, posY, lastPos.z + posZ);
    }
}
