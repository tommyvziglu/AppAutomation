using TestTheApp.Context;
using TestTheApp.Tasks;

namespace TestTheApp.Steps
{
    public abstract class StepBaseContext
    {
        protected StepBaseContext(StepContext context)
        {
            Context = context;
        }

        protected StepContext Context { get; private set; }
        
        public FillIn FillIn => new FillIn(Context.AndroidDriver);
        
    }
}