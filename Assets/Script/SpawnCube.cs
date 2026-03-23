using Unity.VisualScripting;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject cube;
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cube Spawner"))
        {
            Instantiate(cube, gameObject.transform.position, Quaternion.identity);
            cube.GetComponent<CubeFollow>().player = player;
        }
    }
}
