using System;
using System.Collections.Generic;

namespace Coding
{
    public class Workflow
    {
        public List<IActivity> Activities { get; }
        
        public Workflow(List<IActivity> activities)
        {
            Activities = activities;
        }
    }
}