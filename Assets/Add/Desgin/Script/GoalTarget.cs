using UnityEngine;
using System.Collections;

public class GoalTarget : MonoBehaviour
{
    public  GameObject lookTarget;

   
    void Update()
    {


        {
            // 対象物へのベクトルを算出
            Vector3 toDirection = lookTarget.transform.position - transform.position;
            // 対象物へ回転する
            transform.rotation = Quaternion.LookRotation(toDirection, Vector3.forward);
        }
    }
}