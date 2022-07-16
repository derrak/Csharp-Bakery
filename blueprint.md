Prompt: 
Welcome to the bakery! Today we are selling:
Bread: $5 a loaf. If you buy two, you get the third one free!
Pastries: $2 each. Discounts start when you buy 3 or more!

bread tests
can create newBread object typeof(Bread)

can return price of 1 bread

can return price of 3 bread (with discouint)




public int BreadPrice {get; set;}
public int BreadNum {get; set}


      bread
            if (CustOrder > 2) 
      {
      return (CustOrder * 5) - (CustOrder/3*5);
      }
      else 
      {
      return CustOrder * Price;
      }

pastry
      if (CustOrder > 2) 
      {
      return (CustOrder * 2) - (CustOrder/3);
      }
      else 
      {
      return CustOrder * Price;
      }

