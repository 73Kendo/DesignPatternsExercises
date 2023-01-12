namespace DesignPatternsExercises.Composite
{
    public interface IScrumComponent
    {
        public string Type { get; }

        public Guid Id { get; }

        public int CalculateStoryPoints();

        public Status GetStatus();
    }

    public enum Status
    {
        New,
        InProgress,
        Closed
    }

    public class UserStory : IScrumComponent
    {
        public int StoryPoints { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }
        
        public Guid Id => Guid.NewGuid();

        public string Type => nameof(UserStory);

        public UserStory(int storyPoints, Status status)
        {
            StoryPoints = storyPoints;
            Status = status;
        }
        
        public int CalculateStoryPoints()
        {
            return StoryPoints;
        }

        public Status GetStatus()
        {
            return Status;
        }
    }


    public class Epic : IScrumComponent
    {
        private readonly List<IScrumComponent> _components;

        public Epic(List<IScrumComponent> components)
        {
            this._components = components;
        }

        public Guid Id => Guid.NewGuid();

        public string Type => nameof(Epic);

        public void Add(IScrumComponent scrumComponent)
        {
            _components.Add(scrumComponent);
        }

        public void Remove(Guid id)
        {
            _components.RemoveAll(c => c.Id == id);
        }

        public int CalculateStoryPoints()
        {
            return _components.Sum(c => c.CalculateStoryPoints());
        }

        public Status GetStatus()
        {
            if (_components.Any(c => c.GetStatus() == Status.InProgress)) return Status.InProgress;
            if (_components.All(c => c.GetStatus() == Status.Closed)) return Status.Closed;
            if (_components.All(c => c.GetStatus() == Status.New)) return Status.New;

            return Status.InProgress;
        }
    }
}
