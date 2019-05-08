using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS380ProjectManagment
{
    public abstract class Base
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Description { get; set; }
    }

    public class ActionItemData : Base
    {
        public Guid Resource { get; set; }

        public void SetResource(ResourceData resource)
        {
            if (resource == null)
            {
                Resource = Guid.Empty;
                return;
            }
            Resource = resource.Id;
        }

        public DateTime ExpectedCompletionDate { get; set; }

        public string Status { get; set; }
        public string StatusDescription { get; set; }
    }

    public class TaskData : Base
    {
        public bool IsMilestone { get; set; }
        public List<Guid> Resources { get; set; } = new List<Guid>();
        public void AddResource(string name)
        {
            var res = Database.Instance.Resources.Where(x => x.Name == name).FirstOrDefault();
            if (res != null)
            {
                Resources.Add(res.Id);
            }
        }
        public void RemoveResource(string name)
        {
            var res = Database.Instance.Resources.Where(x => x.Name == name).FirstOrDefault();
            if (res != null)
            {
                Resources.Remove(res.Id);
            }
        }

        public DateTime ExpectedStartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public int ExpectedDuration { get; set; }

        public List<Guid> PredecessorTasks { get; set; } = new List<Guid>();

        public List<Guid> StartToFinishTasks { get; set; } = new List<Guid>();
        public List<Guid> StartToStartTasks { get; set; } = new List<Guid>();
        public List<Guid> FinishToFinishTasks { get; set; } = new List<Guid>();
        public List<Guid> FinishToStartTasks { get; set; } = new List<Guid>();

        public void AddTask(string name, List<Guid> list)
        {
            var res = Database.Instance.Tasks.Where(x => x.Name == name).FirstOrDefault();
            if (res != null)
            {
                list.Add(res.Id);
            }
        }

        public void RemoveTask(string name, List<Guid> list)
        {
            var res = Database.Instance.Tasks.Where(x => x.Name == name).FirstOrDefault();
            if (res != null)
            {
                list.Remove(res.Id);
            }
        }

        public List<Guid> Issues { get; set; } = new List<Guid>();
        public void AddIssue(string name)
        {
            var res = Database.Instance.Issues.Where(x => x.Name == name).FirstOrDefault();
            if (res != null)
            {
                Issues.Add(res.Id);
            }
        }
    }

    public class ResourceData : Base
    {

    }

    public class DeliverableData : Base
    {

    }

    public class IssueData : Base
    {

    }

    public class DecisionData : Base {
    }

    public class Database
    {
        private static Lazy<Database> dbInstance = new Lazy<Database>(() =>
        {
            if (File.Exists("database.txt"))
            {
                return JsonConvert.DeserializeObject<Database>(File.ReadAllText("database.txt"));
            }
            return new Database();
        });

        public static Database Instance => dbInstance.Value;

        public List<ActionItemData> ActionItems { get; set; } = new List<ActionItemData>();
        public List<TaskData> Tasks { get; set; } = new List<TaskData>();
        public List<ResourceData> Resources { get; set; } = new List<ResourceData>();
        public List<DeliverableData> Deliverables { get; set; } = new List<DeliverableData>();
        public List<IssueData> Issues { get; set; } = new List<IssueData>();
        public List<DecisionData> Decisions { get; set; } = new List<DecisionData>();

        public static void Save()
        {
            File.WriteAllText("database.txt", JsonConvert.SerializeObject(Instance));
        }


        public static T NewItem<T>(string name, string description) where T : Base, new()
        {
            T retVal = new T();
            retVal.Name = name;
            retVal.Id = Guid.NewGuid();
            retVal.Description = description;
            var list = typeof(Database).GetProperties().Where(x => x.PropertyType == typeof(List<T>)).First().GetValue(Database.Instance) as List<T>;
            list.Add(retVal);
            return retVal;
        }


    }
}
