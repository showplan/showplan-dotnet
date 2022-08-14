using Showplan;

namespace ShowPlan.EntityFrameworkCore7.Interceptor;

public class ShowplanXmlAction : IShowplanInterceptorAction
{
    private readonly Action<ShowPlanXML> _action;
    private static readonly ShowplanDeserializer s_deserializer = new();

    public ShowplanXmlAction(Action<ShowPlanXML> action)
    {
        _action = action;
    }

    public void Intercepted(string showPlan)
    {
        _action.Invoke(s_deserializer.Deserialize(showPlan));
    }
}
