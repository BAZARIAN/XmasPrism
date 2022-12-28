using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

// объект при столкновении с объектом который имеет тэг Danger умирает
public class ObstacleItem : MonoBehaviour
{
    public float currentValue = 3;
    // [SerializeField]
    // private UnityEvent onDestroyObstacle;
    [SerializeField]
    [ContextMenu("Получить дамаг")]
    public void GetDamage(float damage)//float value
    {
        Debug.Log("damage");
        currentValue -= damage;
        GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.red, 1/currentValue);
        if(currentValue<=0)
        {
            // onDestroyObstacle.Invoke();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D (Collision2D collision) {
        Debug.Log("касание");
        if (collision.gameObject.tag == "Danger") {
            GetDamage(1);
        }
    }
}