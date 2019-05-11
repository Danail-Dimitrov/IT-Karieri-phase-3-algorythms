using System;
using System.Text;

public class Writer
{
    public StringBuilder collectedText = new StringBuilder();
    public void WriteLine(string content)
    {
        this.collectedText.AppendLine(content);
        Console.WriteLine(content);
    }
}