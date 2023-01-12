namespace DesignPatternsExercises.ChainOfResponsibility
{
    public static class Example
    {
        public static void Run()
        {
            var item = new Purchase("Laptop DELL XPS 9305 13.3 i5-1135G7 8GB RAM 256GB SSD Windows 11", 7500);

            var chMan = new ApprovalChain("Manager");
            chMan.Approve();
            item.AddApproval(chMan);

            var chDir = new ApprovalChain("Director");
            chDir.Approve();
            item.AddApproval(chDir);

            var chCeo = new ApprovalChain("CEO");
            chCeo.Reject("Too expensive, let's buy something cheaper");
            //chDir.Approve();
            item.AddApproval(chCeo);

            /*********************/

            var ceoApproval = new CeoApproval();
            var directorApproval = new DirectorApproval();
            var managerApproval = new ManagerApproval();

            managerApproval.SetNext(directorApproval).SetNext(ceoApproval);

            var canProceedWithPurchase = managerApproval.Handle(item);

            if(canProceedWithPurchase == PurchaseItem.Yes)
            {
                Console.WriteLine("Send e-mail to logistics department");
            } 
            else
            {
                Console.WriteLine("Send e-mail to purchase creator");
            }
        }
    }
}
