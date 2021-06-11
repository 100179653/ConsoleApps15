using System.ComponentModel;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// First Class is Grade A   : 70 - 100
    /// Upper Second is Grade B  : 60 - 69
    /// Lower Second is Grade C  : 50 - 59
    /// Third Class is Grade D   : 40 - 49
    /// Grade F is a Fail        :  0 - 39
    /// </summary>
    public enum Grades
    {
        [Description("Fail")]
        F, 
        [Description("Third Class")]
        D, 
        [Description("Lower Second")]
        C, 
        [Description("Upper Second")]
        B, 
        [Description("First Class")]
        A
    }
}
