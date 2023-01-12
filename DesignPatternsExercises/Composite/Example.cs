using DesignPatternsExercises.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExercises.Composite
{
    internal class Example
    {
        public static void Run()
        {
            var userStories = new List<IScrumComponent> {
                new UserStory(1, Status.New),
                new UserStory(2, Status.InProgress),
                new UserStory(5, Status.InProgress),
                new UserStory(8, Status.New)
            };

            foreach (var component in new List<IScrumComponent> { new Epic(userStories), new UserStory(13, Status.New) })
            {
                Console.WriteLine($"{component.Type} story points {component.CalculateStoryPoints()}");
                Console.WriteLine($"{component.Type} status {component.GetStatus()}");
            }
        }
    }
}
