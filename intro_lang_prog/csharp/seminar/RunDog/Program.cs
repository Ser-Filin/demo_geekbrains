/*
Задача, блок схема которой была рассмотрена на одной из лекций.
Написать программу, подсчитывающую сколько раз пробежит собака
между друзьями, идущими навстречу друг другу.
*/

int distance = 10000, firstFriendSpeed = 1, secondFriendSpeed = 2,
    dogSpeed = 5, friend = 2, count = 0, time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance -= (firstFriendSpeed + secondFriendSpeed) * time;
    count ++;
}

Console.WriteLine($"Собака пробежит {count} раз.");