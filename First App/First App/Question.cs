
using System;
using First_App.Extensions;

struct Question : IEquatable<Question>
{
    string text;
    string answer;
    public Question(QuestionType type)
    {
        switch (type)
        {
            case QuestionType.addition:
                int a = Int.random(0, 10);
                int b = Int.random(0, 10);

                text = $"{a}+{b}";
                answer = $"{a+b}";

                
                break;
            default:
                throw new Exception("Not implemented");

        }
    }

    public string Text { get => text; set => text = value; }
    public string Answer { get => answer; set => answer = value; }

    public override bool Equals(object obj)
    {
        return obj is Question question && Equals(question);
    }

    public bool Equals(Question other)
    {
        return Text == other.Text &&
               Answer == other.Answer;
    }

    public override string ToString()
    {
        return text + "=" + answer;
    }

    public static bool operator == (Question lhs, Question rhs)
    {
        return (lhs.text == rhs.text && lhs.answer == rhs.answer);
    }


    public static bool operator !=(Question lhs, Question rhs)
    {
        return (lhs.text != rhs.text || lhs.answer != rhs.answer);
    }
}

