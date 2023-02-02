namespace CollectionHierarchy.Models
{
    using CollectionHierarchy.Contracts;
    public class MyList : AddRemoveCollection, IMyList
    {
        public int Used => this.Data.Count;

        public override string Remove()
        {
            string removeItem = this.Data[0];
            this.Data.RemoveAt(0);

            return removeItem;
        }
    }
}
