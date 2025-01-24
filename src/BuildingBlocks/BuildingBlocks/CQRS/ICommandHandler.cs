using MediatR;


namespace BuildingBlocks.CQRS
{
    /// <summary>
    /// I command handler which do not return any response
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public interface ICommandHandler<in TCommand> 
        : ICommandHandler<TCommand, Unit> where TCommand : ICommand<Unit>
    {

    }
    /// <summary>
    /// I command handler returns result which is not null
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public interface ICommandHandler<in TCommand, TResponse>
        : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
    {

    }
}
