using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    public bool IsWireCube = false;
    public Color WireColor = Color.green;
    private void OnDrawGizmos()
    {
        if (IsWireCube)
        {
            Gizmos.color = WireColor;
            Gizmos.DrawWireCube(transform.position, transform.localRotation * transform.localScale);
        }
    }
}
