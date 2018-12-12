using _2048;
namespace CommandPattern
{
    public abstract class Command
    {
        public abstract void Execute(int x, int xx, Form1 form, LabelUtility labels);
    }
}

