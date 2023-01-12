namespace DesignPatternsExercises.Iterator
{
    public class Example
    {
        public static void Run()
        {
            var userStories = new List<IScrumComponent> {
                new UserStory(1, Status.New, "As a user I would like to have login page"),
                new UserStory(2, Status.InProgress, "As I user I would like to be able to view the article"),
                new UserStory(5, Status.InProgress, "As I user I would like to be able to generate a report"),
                new UserStory(8, Status.New, "As I user I would like to be able to manage my account")
            };

            foreach (var items in new Epic(userStories))
            {
                Console.WriteLine($"{items.Type} -> Title: {items.Title}");
            }
        }
    }
}