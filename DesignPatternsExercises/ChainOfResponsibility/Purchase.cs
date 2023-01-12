namespace DesignPatternsExercises.ChainOfResponsibility
{
    public class Purchase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        private List<ApprovalChain> Approvals { get; }
        public IEnumerable<ApprovalChain> ApprovalChain { get; }

        public void AddApproval(ApprovalChain chain)
        {
            Approvals.Add(chain);
        }

        public Purchase(string name, decimal price)
        {
            Name = name;
            Price = price;
            Approvals = new List<ApprovalChain>();
            ApprovalChain = Approvals;
        }

    }

    public class ApprovalChain
    {
        public string Person { get; }

        public string Comment { get; private set; } = "";

        public Status Status { get; set; }

        public ApprovalChain(string person) => Person = person;

        public void Approve()
        {
            Status = Status.Approved; 
        }

        public void Reject(string comment)
        {
            Status = Status.Rejected;
            Comment = comment;
        }
    }

    public enum Status
    {
        Approved,
        Rejected
    }
}
