# Итоговая работа по первому блоку
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Репозиторий содержит следующие файлы:**
1. `diagram.md`- блок-схема алгоритма решения задачи
2. `Program.cs` - файл программы решения задачи

**Алгоритм решения задачи**
1. Первоначальный массив задается на старте выполнения алгоритма.
2. Определяется размер конечного массива путем подсчета количества элементов, соответствующих условию (длина меньше либо равна 3 символам).
3. Создается новый массив с размером равным результату из второго шага.
4. Из первоначального массива выбираются элементы, соответствующие условию и записываются в созданный на третьем шаге массив.
5. Полученный массив выводится на консоль.