using Microsoft.AspNetCore.Components;

namespace Calculator.Components
{
    public partial class MyCalc : ComponentBase
    {
        private string expression = "";

    
    private void AddToExpression(string value)
    {
        expression += value;
    }

   
    private void Clear()
    {
        expression = "";
    }

    
    private void CalculateResult()
    {
        try
        {
           
            var result = new System.Data.DataTable().Compute(expression, null);
            expression = result.ToString();
        }
        catch (Exception)
        {
            expression = "Error"; 
        }
    }
    }
}