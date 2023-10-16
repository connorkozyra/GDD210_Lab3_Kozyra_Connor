using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent onStart;
    public UnityEvent onUpdate;
    public UnityEvent Enter;

    // Start is called before the first frame update
    void Start()
    {
        onStart.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        onUpdate.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        Enter.Invoke();
    }
}
