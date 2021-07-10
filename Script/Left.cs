using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject player;

    bool check;

    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        check = true;
        if (check)
        {
            if (player.transform.position.x <= -2.16f)
            {
                GameControl.m_instance.Move = 0;
            }
            else
            {
                GameControl.m_instance.Move = -1;
            }
        }

       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        GameControl.m_instance.Move = 0;
    }
}
