using System;
using System.Threading;
using PlannerApp.View;
using PlannerApp.Model;
namespace PlannerApp.Controller
{
    public class Planner
    {
        private static Planner _instance;
        public PlannerData _PlannerData;
        private RemoveTaskCheckable _removeTaskCheckable;
        private RemovePlan _removePlan;
        private ClearDay _clearDay;
        private DisplayPlanner _displayPlanner;
        private LengthOfLongestDay _lengthOfLongestDay;
        private InvalidTypeNotification _invalidTypeNotification;
        private Invoker _invoker;
        private MementoManager _mementoManager;
        private DisplayMenu _displayMenu;
        private Command1And2 _command1And2;
        private Command3And4 _command3And4;
        private Command7 _command7;
        private Command5 _command5;
        private ClearAll _clearAll;
        private Planner()
        {
            _PlannerData=new PlannerData();
            _removeTaskCheckable=new RemoveTaskCheckable(this._PlannerData);
            _removePlan=new RemovePlan(this._PlannerData);
            _clearDay=new ClearDay();
            _displayPlanner=new DisplayPlanner();
            _lengthOfLongestDay=new LengthOfLongestDay();
            _invalidTypeNotification=new InvalidTypeNotification();
            _invoker=new Invoker();
            _mementoManager=new MementoManager(_PlannerData);
            _displayMenu=new DisplayMenu();
            _command1And2=new Command1And2();
            _command3And4=new Command3And4();
            _command7=new Command7();
            _command5=new Command5();
            _clearAll=new ClearAll();
            
        }
        public static Planner GetInstance()
        {
            if (_instance == null)
            {
                _instance=new Planner();
            }

            return _instance;
        }
        public void DisplayPlanner()
        {
            _displayPlanner.Display1Planner(this);
        }

        public void DisplayMenu()
        {
            _displayMenu.Display();
        }
        public int getLengthOfLongestDay()
        {
            return _lengthOfLongestDay.getLengthOfLongestDay(this._PlannerData);
        }

        public void AdditionOperation(CreatorAdd creatorAdd, int day, string note)
        {
            creatorAdd.Addition(_PlannerData,day,note);
        }
        public void Add1TaskCheckable(int day, string note)
        {
            _mementoManager.Backup();
            AdditionOperation(new CreatorAddTaskCheckable(),day, note);
        }

        public void Add1Plan(int day, string note)
        {
            _mementoManager.Backup();
            AdditionOperation(new CreatorAddPlan(), day, note);
        }

        public void CheckOffATask(int day, int placement)
        {
            _mementoManager.Backup();
            if (_PlannerData.week[day][placement].GetType() == typeof(Plan))
            {
                _invalidTypeNotification.DisplayWarning();
                Thread.Sleep(3000);
            }
            else
            {
                var temp = (TaskCheckable) _PlannerData.week[day][placement];
                temp._stateOfTask.Check();
            }

        }

        public void ClearADay(int day)
        {
            _mementoManager.Backup();
            _clearDay.Clear(this._PlannerData,day);
        }

        public void ClearAllPlanner()
        {
            _mementoManager.Backup();
            _clearAll.ClearWholePlanner(this._PlannerData);
        }
        public void RemoveAPlan(int day, int placement)
        {
            _mementoManager.Backup();
            _invoker.SetRemove(_removePlan);
            _invoker.InvokeRemove(day,placement);
        }
        public void RemoveATask(int day, int placement)
        {
            _mementoManager.Backup();
            _invoker.SetRemove(_removeTaskCheckable);
            _invoker.InvokeRemove(day,placement);
        }

        public void PreviousPlan()
        {
            _mementoManager.Undo();
        }

        public bool IsPlacementValid(int day, int placement)
        {
            return _PlannerData.IsPlacementValid(day, placement);
        }

        public void Run()
        {
            string command = "";
            while (!command.Equals("9"))
            {
                DisplayPlanner();
                DisplayMenu();
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                    case "2":
                        Console.Clear();
                        DisplayPlanner();
                        DayAndNote dn=new DayAndNote();
                        dn = _command1And2.TemplateMethod();
                        if (dn.Day == 7) break;
                        if (command == "1") Add1TaskCheckable(dn.Day, dn.Note);
                        else Add1Plan(dn.Day, dn.Note);
                        break;
                    case "3":
                    case "4":
                        Console.Clear();
                        DisplayPlanner();
                        DayAndNote dn34=new DayAndNote();
                        dn34 = _command3And4.TemplateMethod();
                        if (dn34.Day == 7) break;
                        int placement = Convert.ToInt32(dn34.Note);
                        bool validation = IsPlacementValid(dn34.Day, placement);
                        if (!validation)
                        {
                            _invalidTypeNotification.DisplayInvalidPlacement();
                            Thread.Sleep(3000);
                            break;
                        }
                        if(command=="3") RemoveATask(dn34.Day,placement-1);
                        else RemoveAPlan(dn34.Day,placement-1);
                        break;
                    case "5":
                        Console.Clear();
                        DisplayPlanner();
                        DayAndNote dn5=new DayAndNote();
                        dn5 = _command5.TemplateMethod();
                        if (dn5.Day == 7) break;
                        int placement5 = Convert.ToInt32(dn5.Note);
                        bool validation5 = IsPlacementValid(dn5.Day, placement5);
                        if (!validation5)
                        {
                            _invalidTypeNotification.DisplayInvalidPlacement();
                            Thread.Sleep(3000);
                            break;
                        }
                        CheckOffATask(dn5.Day,placement5-1);
                        break;
                    case "6":
                        Console.Clear();
                        DisplayPlanner();
                        PreviousPlan();
                        break;
                    case "7":
                        Console.Clear();
                        DisplayPlanner();
                        DayAndNote dn7=new DayAndNote();
                        dn7 = _command7.TemplateMethod();
                        if (dn7.Day == 7) break;
                        ClearADay(dn7.Day);
                        break;
                    case "8":
                        Console.Clear();
                        DisplayPlanner();
                        ClearAllPlanner();
                        break;
                    case "9":
                        break;
                    default:
                        _invalidTypeNotification.DisplayInvalidCommand();
                        Thread.Sleep(3000);
                        break;
                }
                
            }
        }
    }
}