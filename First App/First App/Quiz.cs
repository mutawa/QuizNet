using System;
using System.Collections.Generic;
using First_App.Extensions;

public class Quiz
{
    private List<Question> questions = new List<Question>();
    private List<Question> pool = new List<Question>();
    private Question activeQuestion;

    public Quiz(QuestionType type, int count, int poolSize)
    {
        for(int i=0; i<count; i++)
        {
            questions.Add(new Question(type));
        }

        for(int i=0; i<poolSize; i++)
        {

            pool.Add( questions[0] );
            questions.RemoveAt(index: 0);
        }
        int r = Int.random(0, poolSize);

        activeQuestion = pool[r];

	}

    public string[] choices()
    {
        string[] reply = new string[pool.Count];
        int cnt = 0;
        foreach(Question q in pool)
        {
            reply[cnt] = q.Answer;
            cnt += 1;
        }
        return reply;
    }

    public override string ToString()
    {
        return $"[{string.Join(",",choices())}]   {activeQuestion}";

    }

    public string getActiveQuestion()
    {
        return activeQuestion.Text;
    }

    public string submitAnswer(string answer)
    {
        if (answer==activeQuestion.Answer)
        {
            foreach(Question q in pool)
            {
                if(activeQuestion == q)
                {

                }
            }
            return "you bet";
        } else
        {
            return "no";
        }
    }
}


