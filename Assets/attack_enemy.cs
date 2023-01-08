using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_enemy : MonoBehaviour
{
    public GameObject m_attack_object;

    private Camera _cam;
    private List<GameObject> _attack_objects_to_destroy = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //for(int i = 0;i< _attack_objects_to_destroy.Count;i++)
        //{
        //    Destroy(_attack_objects_to_destroy[i]);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    Debug.Log("ObjectHit: " + raycastHit.transform.gameObject);
                    //_attack_objects_to_destroy.Add(
                    Instantiate(m_attack_object, raycastHit.transform);
                        //);
                    
                }
            }
        }
    }
}
