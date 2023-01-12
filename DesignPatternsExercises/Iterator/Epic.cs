using System.Collections;

namespace DesignPatternsExercises.Iterator
{
    public interface IScrumComponent
    {
        public string Type { get; }

        public Guid Id { get; }

        public string Title { get; }

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

        public UserStory(int storyPoints, Status status, string title)
        {
            StoryPoints = storyPoints;
            Status = status;
            Title = title;
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

    public class Epic : IEnumerable<IScrumComponent> //IScrumComponent
    {
        private readonly List<IScrumComponent> _components;

        public Epic(List<IScrumComponent> components)
        {
            this._components = components;
        }

        public Guid Id => Guid.NewGuid();

        public string Type => nameof(Epic);

        public IEnumerator<IScrumComponent> GetEnumerator()
        {
            return _components.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _components.GetEnumerator();
        }
    }
}
