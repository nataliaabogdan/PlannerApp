using System;
using System.Collections.Generic;

namespace PlannerApp.Model
{
    public class Planner
    {
        private static Planner _instance;
        public List<Event>[] week=new List<Event>[7];
        private AddTaskCheckable _addTaskCheckable;
        private RemoveTaskCheckable _removeTaskCheckable;
        private AddPlan _addPlan;
        private RemovePlan _removePlan;
        private PreviousPlan _previousPlan;
        private ClearDay _clearDay;
        private ProductivityAnalysisDay _productivityAnalysisDay;
        private DisplayPlanner _displayPlanner;
        private Planner() {}
        public static Planner GetInstance()
        {
            if (_instance == null)
            {
                _instance=new Planner();
            }

            return _instance;
        }
        
        
    }
}