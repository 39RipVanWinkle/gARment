using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloControl : MonoBehaviour
{
    public Transform rightForearm;
    public Transform rightHand;
    public Transform rightHand_end;
    public Transform leftForearm;
    public Transform leftHand;
    public Transform leftHand_end;
    public Transform Bot_arm1_l;
    public Transform Bot_arm2_l;
    public Transform Bot_arm3_l;
    public Transform Bot_arm1_r;
    public Transform Bot_arm2_r;
    public Transform Bot_arm3_r;
    private float x = 90;
    private float y = 0;
    private float z = -90;

    void Start()
    {

    }

    void Update()
    {
        CloRotate(rightForearm , Bot_arm1_l ,-x, -1 , -z);
        CloRotate(rightHand , Bot_arm2_l ,-x, -1 , -z);
        CloRotate(rightHand_end , Bot_arm3_l ,-x, -1 , -z);
        CloRotate(leftForearm , Bot_arm1_r ,x, 1 , z);
        CloRotate(leftHand , Bot_arm2_r ,x, 1 , z);
        CloRotate(leftHand_end , Bot_arm3_r ,x, 1 , z);
    }

    private void CloRotate(Transform objectA , Transform objectB ,  float x , float y , float z)
    {
        objectA.rotation = objectB.rotation;
        objectA.rotation *= Quaternion.Euler(x, y , z); // 因为Blender和Unity坐标系不同，修正x轴的方向
    }




}
