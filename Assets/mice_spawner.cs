using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mice_spawner : MonoBehaviour
{

    public GameObject m_mice_prefab;
    public Transform m_player_transform;
    public float m_max_distance_z;
    public float m_max_distance_x;
    public int min_mice_amount = 3;


    private game_manager _game_manager;

    // Start is called before the first frame update
    void Start()
    {
        _game_manager = FindObjectOfType<game_manager>();
    }


    // Update is called once per frame
    void Update()
    {
        if(_game_manager.m_mice_in_existance_currently < min_mice_amount)
        {
            Transform mice_prefab_transform = m_mice_prefab.transform;
            
            GameObject mice_instance = Instantiate(m_mice_prefab, new Vector3(0f, 4.128871f, m_player_transform.position.z - 1 - (Random.value * m_max_distance_z)), mice_prefab_transform.rotation);
            _game_manager.m_mice_in_existance_currently++;
            //SpawnAndWait();
        }
    }

    IEnumerator SpawnAndWait()
    {
        Transform mice_prefab_transform = m_mice_prefab.transform;
        transform.position = new Vector3(0f, 4.128871f, m_player_transform.position.z - 1 - (Random.value * m_max_distance_z));
        Instantiate(m_mice_prefab, transform);
        _game_manager.m_mice_in_existance_currently++;

        yield return new WaitForSeconds(2);
    }
}
