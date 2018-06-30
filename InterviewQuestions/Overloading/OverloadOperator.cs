namespace IntervieweQuestions
{
    public class Box
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get { return Width * Height; } }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            return new Box()
            {
                Height = b.Height + c.Height,
                Width = b.Width + c.Width
            };
        }
    }
}
