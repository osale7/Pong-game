using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnCollisionEnter2D(Collision2D collision)

    {
        ball ball = collision.gameObject.GetComponent<ball>();

        if (ball != null)

        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }

    }
}

    

