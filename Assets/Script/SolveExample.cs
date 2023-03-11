using UnityEngine.UI;
using UnityEngine;

public class SolveExample : MonoBehaviour
{
    [SerializeField] Slider slTime;
    [SerializeField] Image panel;

    [SerializeField] Text exampleText1, exampleText2;
    [SerializeField] Text answerText1, answerText2, answerText3, answerText4;

    bool isClick;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        string[] typeAct = { " - ", " + ", " / ", " * " };
        string act = typeAct[Random.Range(0, typeAct.Length)];

        int colNum1 = Random.Range(3, 6);
        int colNum2 = Random.Range(3, 6);

        answerText1.text = Random.Range(-100, 1000).ToString();
        answerText2.text = Random.Range(-100, 1000).ToString();
        answerText3.text = Random.Range(70, 1000).ToString();
        answerText4.text = Random.Range(70, 1000).ToString();

        exampleText1.text = Random.Range(Mathf.Pow(10, colNum1), Mathf.Pow(10, colNum1 + 1)).ToString() 
            + act + Random.Range(Mathf.Pow(10, colNum2), Mathf.Pow(10, colNum2 + 1)).ToString();
        exampleText2.text = Random.Range(Mathf.Pow(10, colNum1), Mathf.Pow(10, colNum1 + 1)).ToString()
            + act + Random.Range(Mathf.Pow(10, colNum2), Mathf.Pow(10, colNum2 + 1)).ToString();
    }

    public void ClickExample()
    {
        isClick = true;
    }

    private void Update()
    {
        if (slTime.value < slTime.maxValue && !isClick)
        {
            slTime.value += Time.deltaTime;
        }
        else
        {
            anim.SetTrigger("IsClick");
        }
    }
    public void ClosePanelAnim()
    {
        gameObject.SetActive(false);
    }
}