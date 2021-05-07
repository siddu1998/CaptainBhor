using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers>QnA;
    public GameObject[] options;
    public int currentQuestion;
    public Text QuestionTxt;

    public void Start(){
        generateQuestion();

    }

    public void correct(){
                QuestionTxt.text = "Congratulations! You got it correct!";
        removeQuestion();
        PlayerControl.HeroHealth+=5.0f;
        if(QnA.Count>0){
        generateQuestion();
        }
        else{
        QuestionTxt.text = "You Have solved the Quiz! Now Beat the Element";
        }
        
    }
    void SetAnswer(){
        for (int i = 0;i<options.Length;i++){
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            if(QnA[currentQuestion].CorrectAnswer==i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion(){
        
        currentQuestion = Random.Range(0,QnA.Count);
        QuestionTxt.text = QnA[currentQuestion].Question;
        SetAnswer();
    }

    void removeQuestion(){
        QnA.RemoveAt(currentQuestion);
    }


}
