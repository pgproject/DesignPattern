namespace ExerciseAdapter
{
    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Height * rc.Width;
        }
    }
}