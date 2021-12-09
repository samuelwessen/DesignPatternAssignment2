namespace Adapter
{
    public class AdapterMain
    {
        public void Run()
        {
            ReturningStrings returningStrings = new();
            PrintingInts printingInts = new();
            AdapterService service = new();
            printingInts.Print(service.ConvertToInt());
        }
    }
}