using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectLandingDistanceCalculator : MonoBehaviour
{
    private XRGrabInteractable interactable;
    private Vector3 initialPosition;

    private void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(OnSelectEnter);
        interactable.selectExited.AddListener(OnSelectExit);
    }

    private void OnSelectEnter(SelectEnterEventArgs args)
    {
        initialPosition = transform.position;
    }

    private void OnSelectExit(SelectExitEventArgs args)
    {
        float distance = Vector3.Distance(initialPosition, transform.position);
        Debug.Log("Distanta de la pozitia initiala: " + distance.ToString("F2") + " prajini");
    }

    private void Update()
    {

    }
}
