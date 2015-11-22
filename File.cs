using System;
using System.Collections.Generic;

public class File
{
    private string _unitCode;
    private string _question;
    private string _answer;
    private List<string> _keywords;

    public File()
	{
	}

    public string UnitCode
    {
        get { return _unitCode; }
        set { _unitCode = value; }
    }

    public string Question
    {
        get { return _question; }
        set { _question = value; }
    }

    public string Answer
    {
        get { return _answer; }
        set { _answer = value; }
    }

    public List<string> Keywords
    {
        get { return _keywords; }
        set { _keywords = value; }
    }

}
