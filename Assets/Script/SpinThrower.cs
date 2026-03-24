using UnityEngine;

public class SpinThrower : MonoBehaviour
{
    public float spinSpeed = 180f;   
    public float throwForce = 10f; 

    private void FixedUpdate()
    {
        transform.Rotate(spinSpeed * Time.fixedDeltaTime, 0f, 0f, Space.Self);
    }

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        if (rb == null) return;
        if (!collision.gameObject.CompareTag("Player")) return;
        Vector3 contactPoint = collision.contacts[0].point;
        Vector3 radial = (contactPoint - transform.position).normalized;
        Vector3 tangential = Vector3.Cross(transform.right, radial);
        rb.AddForce(tangential * throwForce, ForceMode.VelocityChange);
    }
}