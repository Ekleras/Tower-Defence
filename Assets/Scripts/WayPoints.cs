using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    public static Transform[] way;

    void Awake()
    {
        way = new Transform[transform.childCount];

        for(int i = 0; i < way.Length; i++)
        {
            way[i] = transform.GetChild(i);
        }
    }
}
