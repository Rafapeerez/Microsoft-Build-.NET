namespace BlazingPizza.Services;

public class OrderState{
    public bool ShowingConfigureDialog { get; private set; }
    public Pizza ConfiguringPizza { get; private set; }
    public Order Order { get; private set; } = new Order();

    public void ShowConfigurePizzaDialog(PizzaSpecial special){
        ConfiguringPizza = new Pizza(){
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>(),
        };

        ShowingConfigureDialog = true;
    }

    //Function that cancel the dialog
    public void CancelConfigurePizzaDialog(){
        ConfiguringPizza = null;
        ShowingConfigureDialog = false;
    }

    //Function that pass the pizza ato the order
    public void ConfirmConfigurePizzaDialog(){
        Order.Pizzas.Add(ConfiguringPizza);
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
    }

    //Function to remove pizza from the order
    public void RemoveConfigurePizza(Pizza pizza){
        Order.Pizzas.Remove(pizza);
    }
}
