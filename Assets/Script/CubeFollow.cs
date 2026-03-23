using UnityEngine;
public class CubeFollow : MonoBehaviour
{
    public Transform player;
    public float speed = 3;
    public float distance = 0;
    void Start()
    {

    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > distance)
        {
            transform.LookAt(player);
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }
}
