using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const int maxHit = 10;
    public GameObject target;
    public GameObject parentOfTargets;
    public GameObject objCounter;
    public GameObject wonObj;
    public GameObject shootSound;

    private Text textCounter;
    private bool won;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        textCounter = objCounter.GetComponent<Text>();
        won = false;
        InvokeRepeating("spawn", 1f,2f);
        wonObj.SetActive(false);
     }

    //spawn a Target at a random position within a specified x and y range.
    //Instantiate (make a concrete GameObject, i.e., a clone from the given prefab Target) the 
    //Target as a child of the ParentOfTargets. In this case transform. localPosition instead of 
    //transform.position is important!!
    private void spawn()
    {
        //Target spawnen
        float randomX = Random.Range(-414, 414);
        float randomY = Random.Range(-234, 234);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target,parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;

        Debug.Log(random2DPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if(won == true)
        {
            CancelInvoke("spawn");
            wonObj.SetActive(true);
        }
        else
        {
            Debug.Log(won);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Pressed");
            shootSound.GetComponent<AudioSource>().Play();
        }
    }
    public void IncrementScore()
    {
        score++;
        Debug.Log("Increment ..." + score);
        textCounter.text = score.ToString();

        if(score == maxHit)
        {
            won = true;
        }
    }
}
