class Order
{
    private List<Item> itemList;
    public IReadOnlyList<Item> ItemList
    {
        get { return itemList; }
    }
    public void AddItem(Item item) {/*...*/ }
    public void DeleteItem(Item item) {/*...*/ }
}
class OrderProcessor
{
    private Order order;
    public OrderProcessor(Order order)
    {
        this.order = order;
    }

    public void CalculateTotalSum() {/*...*/}
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}

}

class OrderRepository
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}

}

