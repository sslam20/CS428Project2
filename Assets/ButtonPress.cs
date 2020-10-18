using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonPress : MonoBehaviour
{
    public GameObject btn;
    public Animator ani;
    public AudioSource crash;
    public AudioSource voiceLine;

    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("Button");
        ani.GetComponent<Animator>();
        btn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        btn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        ani.SetTrigger("startle");
        crash.Play();
        voiceLine.Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
