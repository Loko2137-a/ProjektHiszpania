using UnityEngine;

public class CubeFollow : MonoBehaviour
{
    public Transform player;
    public float speed = 3;
    public float distance = 2;

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);
        if (dist > distance)
        {
            transform.LookAt(player);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}