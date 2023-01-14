namespace DesignPatternsExercises.ChainOfResponsibility
{
    public interface IPurchaseHandler
    {
        IPurchaseHandler SetNext(IPurchaseHandler handler);
        PurchaseItem Handle(Purchase purchase);
    }

    public enum PurchaseItem
    {
        Yes,
        No
    }
}
