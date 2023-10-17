using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day28
{
    public delegate void MyDel(string msg);

    public class Program
    {
        /*   public event MyDel Event;

           public void InvokeEvent(string e)
           {
               Event.Invoke(e);
           }
           public void Subscribe(Sub subs)
           {
               Event += subs.EventHandler;
           }
           public void UnSubscribe(Sub subs)
           {
               Event -= subs.EventHandler;
           }*/


        static void Main(string[] args)
        {
            //day 28th
            /* Program obj = new Program();
             Sub subs = new Sub();
             obj.Subscribe(subs);
             obj.InvokeEvent("An error has occured!");
             obj.UnSubscribe(subs);*/


            Console.ReadKey();
        }
    }
    public delegate void TaskDel(string msg);
    public class TaskClass
    {
        public string Description;
        public bool IsComplete;
    }
    public class TaskList
    {
        List<string> list;
        public event TaskDel TaskAdded;
        public event TaskDel TaskRemoved;
        public event TaskDel TaskCompleted;

        public TaskList()
        {
            TaskAdded += EventHandler;
            TaskRemoved += EventHandler;
            TaskCompleted += EventHandler;
        }
        public void EventHandler(string msg)
        {
            TaskDel(this, msg);
        }
        public void AddTask(string desc)
        {
            list.Add(desc);
        }
        public void RemoveTask(string desc)
        {
            list.Remove(desc);
        }
        public void CompleteTask(string desc)
        {
            //
        } 
    }














 /* public class Sub
    {
        public Program prog;
        public void EventHandler(string e)
        {
            Console.WriteLine(e);
        }
    } */
}
