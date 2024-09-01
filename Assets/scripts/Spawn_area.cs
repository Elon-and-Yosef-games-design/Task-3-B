using UnityEngine;

public class Spawn_area : MonoBehaviour
{
    public Vector2 areaSize { get; set; }
    public Rect areaRect
    {
        get
        {
            Vector3 worldScale = transform.lossyScale;//the scale of the object in world space
            Vector2 size = new Vector2(worldScale.x, worldScale.y);

            return new Rect(transform.position.x - size.x / 2, transform.position.y - size.y / 2, size.x, size.y);
        }
    }
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
