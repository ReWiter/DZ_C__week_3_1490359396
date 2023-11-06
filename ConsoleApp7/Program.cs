namespace N1
{
    interface IWorker {
        bool Job { get; }
        List<IWorker> ListOfWorks { get; set; }
        string ToString();
    }
    interface IPart {
        List<IPart> listofpart { set; get; }
     string pt { get; }
     int value { get; }
        string ToString();
    }
    class Basement:IPart {
        public List<IPart> listofpart { set; get; }
        string ppt = "Basement";
        int ttl = 1;
        public string pt { 
            get 
            { 
            return ppt;
            } 
        }
        public int value
        {
            get
            {
                return ttl ;
            }
        }
        public override string ToString()
        {
            return $"{value} фундамент";
        }
    }
    class Wall : Basement {
        string ppt = "Wall";
        int ttl = 4;
        public new string pt
        {
            get
            {
                return ppt;
            }
        }
        public new int value
        {
            get
            {
                return ttl;
            }
        }
        public override string ToString()
        {
            return $"{value} стены";
        }
    }
    class Door : Wall {
        string ppt = "Door";
        int ttl = 1;
        public new string pt
        {
            get
            {
                return ppt;
            }
        }
        public new int value
        {
            get
            {
                return ttl;
            }
        }
        public override string ToString()
        {
            return $"{value} дверь";
        }
    }
    class Window : Door {
        string ppt = "Window";
        int ttl = 4;
        public new string pt
        {
            get
            {
                return ppt;
            }
        }
        public new int value
        {
            get
            {
                return ttl;
            }
        }
        public override string ToString()
        {
            return $"{value} окна";
        }
    }
    class Roof :Window {
        string ppt = "Roof";
        int ttl = 1;
        public new string pt
        {
            get
            {
                return ppt;
            }
        }
        public new int value
        {
            get
            {
                return ttl;
            }
        }
        public override string ToString()
        {
            return $"{value} крыша";
        }
    }
    class House:Roof {
        new List<IPart> listofpart { set; get; }
    }
    class Worker:IWorker {
        public List<IWorker> ListOfWorks { get; set; }
        public string Name { get; set; }
        public string Wor { get; set; }
        public bool job { set; get; }
        public bool Job
        {
            get { return job; }
        }
        public override string ToString()
        {
            return $"Имя работника {Name}, что делал {Wor}";
        }
    }
    class TeamLeader:Worker {
        bool job = true;
        public bool Job
        {
            get { return job; }
        }
        public override string ToString()
        {
            return"\n Работа выполнена"+
                "\n////\\\\\\\\" +
                "\n-------"+
                "\n|o   o|"+
                "\n|o H o|"+
                "\n-------";
        }
    }
    class Team: TeamLeader {
        public new List<IWorker> ListOfWorks { get; set; }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            TeamLeader team = new Team();
            TeamLeader leader= new TeamLeader();
            team.ListOfWorks=new List<IWorker> { 
                new Worker { Name = "Jhon", Wor = "Basement",job=true},
                new Worker { Name = "Smith", Wor = "Wall",job=true},
                new Worker { Name = "Sam", Wor = "Door",job=true},
                new Worker { Name = "Dooglas", Wor = "Window",job=true},
                new Worker { Name = "Tobias", Wor = "Roof",job=true},
            };
            foreach (IWorker worker in team.ListOfWorks)
            {
                Console.WriteLine(worker);
            }           
            House house = new House();
            house.listofpart = new List<IPart> {
                new Basement(),
                new Wall(),
                new Door(),
                new Window(),
                new Roof()
            };
            foreach (IPart item in house.listofpart)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(leader);
        }
            

    }
} 