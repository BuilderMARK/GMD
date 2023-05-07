using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public float pickUpRange;
    private GameObject objectInHand;
    public GameObject pickupPrefab;
    public Transform handPosition;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * pickUpRange, Color.red, 1f);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E pressed");
            TryPickUp();
        }
    }

    private void TryPickUp()
    {
        Debug.Log("inside");
         if (objectInHand != null)
        {
            return;
        }

        RaycastHit hit;
        bool raycastHit = Physics.Raycast(transform.position, transform.forward, out hit, pickUpRange);
        if (!raycastHit || !hit.collider.CompareTag("Pickup"))
        {
            Debug.Log("Inside Inside");
            return;
        }

        PickUpObject(hit.collider);
    }

    private void PickUpObject(Collider pickupCollider)
    {
        Debug.Log("insidepickup");
        objectInHand = Instantiate(pickupPrefab, handPosition.position, handPosition.rotation, handPosition);
        objectInHand.GetComponent<Rigidbody>().isKinematic = true;
        Destroy(pickupCollider.gameObject);
    }
}