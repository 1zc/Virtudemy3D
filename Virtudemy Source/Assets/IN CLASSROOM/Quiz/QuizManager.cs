using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private Text trueAnswerText;

    [SerializeField]
    private Text falseAnswerText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    void Start()
    {
        if(unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
        Debug.Log(currentQuestion.question + " is " + currentQuestion.isCorrect);
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        questionText.text = currentQuestion.question;

        if (currentQuestion.isCorrect)
        {
            trueAnswerText.text = "CORRECT!";
            falseAnswerText.text = "WRONG!";

        }

        else
        {
            trueAnswerText.text = "WRONG!";
            falseAnswerText.text = "CORRECT!";
        }
    }

    IEnumerator TransitionToNextQuestion ()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

    public void ExitQUIZ()
    {
        Application.LoadLevel("Class");
    }

    public void ExitToTPanel()
    {
        Application.LoadLevel("TMenu");
    }

    public void UserSelectTrue()
    {
        animator.SetTrigger("True");

        if (currentQuestion.isCorrect)
        {
            Debug.Log("CORRECT ANSWER!");
        }

        else
        {
            Debug.Log("WRONG ANSWER!");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectFalse()
    {
        animator.SetTrigger("False");

        if (!currentQuestion.isCorrect)
        {
            Debug.Log("CORRECT ANSWER!");
        }

        else
        {
            Debug.Log("WRONG ANSWER!");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

}
