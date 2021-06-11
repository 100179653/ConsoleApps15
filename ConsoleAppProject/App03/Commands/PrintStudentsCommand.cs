namespace ConsoleAppProject.App03.Commands
{
    using System;
    using ConsoleAppProject.Common;
    
    /// <summary>
    /// Print all students
    /// </summary>
    /// <author>Chris Edgley</author>
    [ClassName("4. Print students")]
    public class PrintStudentsCommand : Command
    {
        /// <summary>
        /// Create new command as assign receiver of the newly created command
        /// </summary>
        /// <param name="studentGrades">The receiver of this command</param>
        public PrintStudentsCommand(StudentGrades studentGrades)
            : base(studentGrades)
        { }

        /// <summary>
        /// Execute this command as print all students
        /// </summary>
        private void Command.Execute()
        {
            Console.WriteLine(PrintStudentsCommand);
        }
            
    }
}
