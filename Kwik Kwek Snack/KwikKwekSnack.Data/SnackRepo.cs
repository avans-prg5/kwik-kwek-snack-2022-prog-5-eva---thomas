using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class SnackRepo
    {
        SnackContext _context = new SnackContext();

        //Methods to get stuff out of database

        public List<Item> GetDrinks()
        {
            return _context.Items.Where(i => i.IsDrink).ToList();
        }

        public List<Item> GetSnacks()
        {
            return _context.Items.Where(i => !i.IsDrink).ToList();
        }

        public Item? GetItem(string name)
        {
            return _context.Items.Where(i => i.Name.Equals(name)).FirstOrDefault();
        }

        public List<SnackInOrder> GetSnacksInOrder(int orderID)
        {
            return _context.Snacks.Where(i => i.OrderID == orderID).ToList();
        }

        public List<DrinkInOrder> GetDrinksInOrder(int orderID)
        {
            return _context.Drinks.Where(i => i.OrderID == orderID).ToList();
        }

        public Order? GetOrder(int id)
        {
            Order temp = _context.Orders.Where(o => o.OrderID == id).FirstOrDefault();
            temp.Drinks = GetDrinksInOrder(temp.OrderID);
            temp.Snacks = GetSnacksInOrder(temp.OrderID);
            return temp;
        }

        public List<Extra> GetExtra(ExtraName name)
        {
            return _context.Extras.Where(e => e.Name.Equals(name.ToString())).ToList();
        }

        public void SaveNewOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public Order? GetLastCompleted()
        {
            return _context.Orders.OrderBy(o => o.OrderID).Where(o => o.Status.Equals(Status.Gereed)).LastOrDefault();
        }
        public List<Order> GetOrdersInQueue()
        {
            return _context.Orders.OrderBy(o => o.OrderID).Where(o => o.Status.Equals(Status.Wachtrij)).ToList();
        }

        public void UpdateOrder(Order order)
        {
            _context.Update(order);
            _context.SaveChanges();
        }

        public float GetOrderPrice(Order order)
        {
            float sum = 0;

            foreach (SnackInOrder snackInOrder in order.Snacks)
            {
                for (int i = 0; i < snackInOrder.Amount; i++)
                {
                    sum += snackInOrder.Snack.Price;
                    foreach (Extra extra in snackInOrder.Extra)
                    {
                        sum += extra.Price;
                    }
                }
            }
            foreach (DrinkInOrder drinkInOrder in order.Drinks)
            {
                for (int i = 0; i < drinkInOrder.Amount; i++)
                {
                    sum += drinkInOrder.Drink.Price;
                    if (drinkInOrder.Straw) { sum += 0.10f; }
                    if (drinkInOrder.Ice) { sum += 0.10f; }
                    switch (drinkInOrder.Size)
                    {
                        case Size.S:
                            break;
                        case Size.M:
                            sum += drinkInOrder.Drink.Price * 0.5f;
                            break;
                        case Size.L:
                            sum += drinkInOrder.Drink.Price * 1.0f;
                            break;
                        case Size.XL:
                            sum += drinkInOrder.Drink.Price * 1.5f;
                            break;
                        default:
                            break;
                    }
                }
            }

            if (order.TakeAway)
            {
                sum += 0.10f;
            }


            return sum;

        }

        public void AddSnackToOrder(SnackInOrder item)
        {
            var snacks = GetOrder(item.OrderID).Snacks;
            foreach (var snack in snacks)
            {
                if (snack.SnackName.Equals(item.SnackName) && snack.OrderID == item.OrderID)
                {
                    snacks.FirstOrDefault(item).Amount++;
                    _context.SaveChanges();
                    return;
                }
            };
            item.Amount++;
            _context.Snacks.Add(item);
            _context.SaveChanges();
        }

        public void AddDrinkToOrder(DrinkInOrder item)
        {
            var drinks = GetOrder(item.OrderID).Drinks;
            if (drinks.Contains(item))
                drinks.FirstOrDefault(item).Amount++;
            else
                _context.Drinks.Add(item);
            _context.SaveChanges();
        }
    }

}