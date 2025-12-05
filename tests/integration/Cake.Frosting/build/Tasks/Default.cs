using Cake.Frosting;

[IsDependentOn(typeof(Hello))]
[IsDependentOn(typeof(ConfigurationFromArguments))]
public sealed class Default : FrostingTask<Context>
{
}