namespace WebApplication1.MyServices
{
    public class NewClass
    {
        public void someVoid()
        {
            //crashing on VS v17.13.3 and v17.13.5
            //in In program.cs  there is  registered variable var test = "test"; on line 7

            //uncoment below and click on "test" word to crash

            //var foo = test
        }
    }
}
