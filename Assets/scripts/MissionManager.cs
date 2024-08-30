using UnityEngine;

public class MissionManager : MonoBehaviour
{
    [SerializeField] private string item_name;
    [SerializeField] private int count;
    [SerializeField]
    Collectible[] collectibles;

    GameObject[] spawn_areas;

    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<Timer>();
        Debug.Log(timer);

        timer.StartCounting(60);
    }

    void Start_Mission()
    {
        Spawn_items(item_name, count);

    }

    void Spawn_items(string item_name, int count)
    {
        Debug.Log("Spawning items");
        for (int i = 0; i < count; i++)
        {
            //Vector3 pos = new Vector3(Random.Range(0, grid.width), 0, Random.Range(0, grid.height));
            //GameObject item = Instantiate(Resources.Load(item_name), pos, Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
