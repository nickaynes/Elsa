﻿using Elsa.Expressions;
using Elsa.Models;

namespace Elsa.Activities.Console.Activities 
{
    /// <summary>
    /// Writes a text string to the specified stream.
    /// </summary>
    public class WriteLine : Activity
    {
        public WriteLine() : this(null)
        {
        }

        public WriteLine(string text)
        {
            TextExpression = new WorkflowExpression<string>(PlainTextEvaluator.SyntaxName, text);
        }
        
        public WorkflowExpression<string> TextExpression { get; set; }
    }
}
