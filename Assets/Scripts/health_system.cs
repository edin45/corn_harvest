using System.Collections;
using System.Collections.Generic;
using Tayx.Graphy.Utils.NumString;
using UnityEngine;
using UnityEngine.UI;

public class health_system : MonoBehaviour
{
    public string m_health_detrement_object_tag;
    public int m_total_health = 5;
    public Text m_health_display_text;
    public Image m_health_bar_fill;
    public bool m_destory_object_on_zero_health = false;
    public bool m_game_over_on_zero_energy = true;


    private int _current_health;

    // Start is called before the first frame update
    void Start()
    {

        _current_health = m_total_health;
        update_health_bar();
        m_health_display_text.text = _current_health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void update_health_bar()
    {
        m_health_bar_fill.fillAmount = _current_health.ToFloat() / m_total_health.ToFloat();
    }

    void check_and_realize_damage(string collider_tag)
    {        
        if (collider_tag == m_health_detrement_object_tag)
        {
            _current_health--;
            if (m_health_display_text != null)
            {
                m_health_display_text.text = _current_health.ToString();
            }

            if (m_health_bar_fill != null)
            {
                update_health_bar();
            }

            check_death();
        }
    }

    void check_death()
    {
        if (_current_health <= 0)
        {
            if (m_game_over_on_zero_energy)
            {
                FindObjectOfType<game_manager>().GameOver();
            }

            if (m_destory_object_on_zero_health)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        check_and_realize_damage(collision.collider.tag);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        check_and_realize_damage(other.tag);
    }
}
