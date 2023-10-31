/*
 * Написать программу для вывода «Hello <user>» на консоль. Пусть <user>
 * вводиться с консоли, программа должна потребовать ввод <user>.
 * Для чтения с консоли используйте Console.ReadLine().
 */
Console.WriteLine("Введите имя пользователя");
var userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");