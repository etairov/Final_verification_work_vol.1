# Final_verification_work_vol.1

Для выполнения проверочной работы необходимо:
1.	Создать репозиторий на GitHub
2.	Нарисовать блок- схему алгоритма
3.	Внести текстовое описание решения (файл README.md)
4.	Написать программу, решающую поставленную задачу
5.	Использовать контроль версий (не одним коммитом, а соблюдая этапы- по разным коммитам)

Задача.
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.
Примеры:
[“hello”, “2”, “world”, “😊”] -> [“2”, “😊”]
[“1234”, “1567”, “-2”, “computer science”] -> [“2”]
[“Russia”, “Denmark”, “Kazan”] -> []

------------------------------------------------------------

Описание программы.
Программа состоит из двух методов:

1. Метод string[] InitStringArray(string message)
В данном методе через ввод с клавиатуры задаем возможность выбора количества строк в массиве и вводим с клавиатуры сами строки, далее метод выводит нам весь первоначально заданный массив на печать. Метод создан при помощи двух циклов for и одного оператора ветвления if.

2. Метод void SelectStrings(string[] stringArray):
Данный метод при помощи цикла for и оператора ветвления if выбирает из начального массива строки, удовлетворяющие условию (кол-во символов в строке <=3). Далее отправляет на печать массив из отобранных элементов.
