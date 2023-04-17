using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour
{
    Vector3 iniPos;
    Quaternion iniRot;

    void Awake()
    {
        iniPos = transform.localPosition;
        iniRot = transform.localRotation;
    }

    public void reset()
    {
        transform.localPosition = iniPos;
        transform.localRotation = iniRot;
    }
}
