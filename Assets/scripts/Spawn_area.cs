using UnityEngine;

public class Spawn_area : MonoBehaviour
{
    public Vector2 areaSize;
    // Start is called before the first frame update
    void Start()
    {
        areaSize = transform.localScale;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
