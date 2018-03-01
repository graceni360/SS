
using UnityEngine;
using UnityEngine.UI;

public class HealthBarColoring : MonoBehaviour {

    public Color AboveHalf;
    public Color HalfHealth;
    public Color QuarterHealth;
    public Color Excess;

    public Image ColorHolder;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        chooseColor();
	}

    private void chooseColor()
    {
        float health = transform.localScale.x;
        if (health > 1)
        {
            ColorHolder.color = Excess;
        }
        else if (health > 0.5 && health <= 1)
        {
            ColorHolder.color = AboveHalf;
        }
        else if (health <= 0.5  && health > 0.25)
        {
            ColorHolder.color = HalfHealth;
        }
        else// (health < 0.25)
        {
            ColorHolder.color = QuarterHealth;
        }

    }
}
