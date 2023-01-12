namespace DesignPatternsExercises.ChainOfResponsibility
{
    public class CeoApproval : AbstractHandler
    {
        public override PurchaseItem Handle(Purchase purchase)
        {
            var ceoApproved = purchase.ApprovalChain.FirstOrDefault(ch => ch.Person == "CEO");

            return ceoApproved != null && ceoApproved.Status == Status.Approved ? base.Handle(purchase) : PurchaseItem.No;
        }
    }

    public class DirectorApproval : AbstractHandler
    {
        public override PurchaseItem Handle(Purchase purchase)
        {
            var ceoApproved = purchase.ApprovalChain.FirstOrDefault(ch => ch.Person == "Director");

            return ceoApproved != null && ceoApproved.Status == Status.Approved ? base.Handle(purchase) : PurchaseItem.No;
        }
    }

    public class ManagerApproval : AbstractHandler
    {
        public override PurchaseItem Handle(Purchase purchase)
        {
            var ceoApproved = purchase.ApprovalChain.FirstOrDefault(ch => ch.Person == "Manager");

            return ceoApproved != null && ceoApproved.Status == Status.Approved ? base.Handle(purchase) : PurchaseItem.No;
        }
    }
}
