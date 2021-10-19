using System;

namespace Coding
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.Activities)
            {
                if (activity == null)
                    throw new ArgumentException("Activities cannot be null.");
                
                activity.Execute();
            }
        }
    }
}