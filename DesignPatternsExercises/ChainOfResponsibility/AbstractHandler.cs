namespace DesignPatternsExercises.ChainOfResponsibility
{
    public abstract class AbstractHandler : IPurchaseHandler
    {
        private IPurchaseHandler? _nextHandler;

        public IPurchaseHandler SetNext(IPurchaseHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual PurchaseItem Handle(Purchase purchase)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(purchase);
            }
            else
            {
                return PurchaseItem.Yes;
            }
        }
    }
}
