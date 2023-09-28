namespace Grouping
{
    public class DataFormViewModel
    {
        public GroupingModel GroupingModel { get; set; }

        public DataFormViewModel()
        {
            this.GroupingModel = new GroupingModel();
            GroupingModel.FirstName = "Clara";
            GroupingModel.MiddleName = "Venus";
            GroupingModel.LastName = "David";
            GroupingModel.Address = "California";
            GroupingModel.MobileNumber = "(742) 121-3133";
            GroupingModel.LandlineNumber = "+1 731 220-9832";
            GroupingModel.Email = "clasravenus@gmail.com";

        }
    }
}
