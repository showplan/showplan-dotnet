namespace ShowPlan.EntityFrameworkCore7.Interceptor;

public interface IShowplanInterceptorAction
{
    void Intercepted(string showPlan);
}
