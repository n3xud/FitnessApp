namespace FitnessApp.Pages
{
    public partial class ExerciseDone
    {
        public int ExerciseDone_Id { get; set; }

        public string Exercise_Name { get; set; }
        public List<ExerciseList> ExerciseLists { get; set; }   
    };
    public partial class ExerciseList
    {
        public int Reps { get; set; }
        public int Weight { get; set; }
    };
    public partial class Exercises
    {
        public string Exercise_Name { get; set; }

        public string MuscleGroup { get; set; }
    }
}
