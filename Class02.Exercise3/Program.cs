int phoneCredit = 102;
int messageCredit = 5;

int smsCount = phoneCredit / messageCredit;
int remainingCredits = phoneCredit % messageCredit;

Console.WriteLine(" You can send " + smsCount + " SMS messages. ");
Console.WriteLine(" Credits left: " + remainingCredits);
