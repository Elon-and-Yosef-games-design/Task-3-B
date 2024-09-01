using UnityEngine;

public class ItemFactory : MonoBehaviour
{
    [SerializeField] private string item_name;
    [SerializeField] private int count;
    [SerializeField] Collectible collectible_Prefab;

    [SerializeField]
    GameObject Spawn_areas_prefabs;

    Spawn_area[] spawn_areas;

    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        spawn_areas = Spawn_areas_prefabs.GetComponentsInChildren<Spawn_area>();
        Debug.Log(spawn_areas.Length);
        spawn_items(5, "collectible");
        /*
        timer = FindObjectOfType<Timer>();
        Debug.Log(timer);

        timer.StartCounting(60);*/
    }

    public void spawn_items(int amount, string item_name)
    {
        int area_index;
        float x, y;

        for (int i = 0; i < amount; i++)
        {
            
            area_index = Random.Range(0, spawn_areas.Length);
            Debug.Log("The chosen area index: " + area_index);
            Rect area =  spawn_areas[area_index].areaRect;
            Debug.Log("The chosen area: " + area);
            x = Random.Range(area.xMin, area.xMax);
            Debug.Log("x min area: " + area.xMin);
            Debug.Log("x max  area: " + area.xMax);
            Debug.Log(x);
            y = Random.Range(area.yMin, area.yMax);
            Debug.Log("y min area: " + area.yMin);
            Debug.Log("y max  area: " + area.yMax);
            Debug.Log(y);
            if (collectible_Prefab != null)
            {
                GameObject item = Instantiate(collectible_Prefab.gameObject, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                //item.collectible_name = item_name;
            }
        }
    }



}
