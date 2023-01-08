using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw_stone_walls : MonoBehaviour
{

    public GameObject wall_prefab;
    public Vector3 start_point_1;
    public Vector3 start_point_2;
    public int wall_amount;
    public float wall_distance;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i<wall_amount;i++)
        {
            Instantiate(wall_prefab, new Vector3(start_point_1.x, start_point_1.y, start_point_1.z + (wall_distance * i)), wall_prefab.transform.rotation);
            Instantiate(wall_prefab, new Vector3(start_point_2.x, start_point_2.y, start_point_2.z + (wall_distance * i)), wall_prefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
