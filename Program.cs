//Isaiah Keith Ferguson
//Nested Lists Lecuture
//We will declare Lists

List<string> AmericanFood = new List<string>();
List<string> AsianFood = new List<string>();
List<string> mexicanFood = new List<string>();


//This holds a list list of strings
List<List<string>> FoodList = new List<List<string>>();

AmericanFood.Add("Cheese burger");
AmericanFood.Add("Steak");
AmericanFood.Add("HotDog");
AmericanFood.Add("Pot Roast");

AsianFood.Add("Pho");
AsianFood.Add("Fried Rice");
AsianFood.Add("Sour Soup");
AsianFood.Add("Sushi");

mexicanFood.Add("Beans and Rice");
mexicanFood.Add("Burrito");
mexicanFood.Add("Tacos");
mexicanFood.Add("Biria");

FoodList.Add(AmericanFood);
FoodList.Add(AsianFood);
FoodList.Add(mexicanFood);

// Iteratting thru the nested list FOODLIST

for (int i = 0; i < FoodList.Count; i++)
{

    //The 4 in the J is equal to the index of the Lists in the Lists IE J = mexicanFood[j]
    for (int j = 0; j < 4; j++)
    {
        //Food List [i] = American List or our Asian List
        //Food List [i][j] = American List indexs or our AsianFood Indexs
        Console.WriteLine(FoodList[i][j]);
    }
    Console.WriteLine("--------------------------");
}