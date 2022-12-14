# 1st term paper
 Сравнение эффективности метрик (инвариантов) для определения изоморфных графов


1. Принцип работы:
  1.1. Генерируется матрица смежности графа;
  1.2. Вычисляются значения инвариантов и скорость работы алгоритмов;
  1.3. Каждый граф сохраняется в отдельный файл;
  1.4. При исследовании на изоморфизм сравниваются уже вычисленные значения инвариантов.

2. Итоговый список инвариантов:
  2.1. Индекс Винера;
  2.2. Индекс Рандича;
  2.3. Определитель матрицы смежности;
  2.4. Плотность графа;
  2.5. Число компонент смежности;
  2.6. Цикломатическое число;
  2.7. Упорядоченный вектор степеней первого порядка;
  2.8. Упорядоченный вектор степеней второго порядка.

3. Хранение графов:
  3.1. Каждый граф хранится в отдельном бинарном файле;
  3.2. Все файлы находятся в папке "Graphs";
  3.3. Папка "Graphs" должна лежать в корне диска С;
  3.4. Имя файла имеет шаблон "graph_№.bin";

4. Создание матрицы смежности:
  4.1. По умолчанию создается случайная матрица;
  4.2. Пользователь может установить либо число вершин графа, либо число вершин и число ребер одновременно;
  4.3. Если в полях ввода вершин и ребер указаны нули, создастся случайная матрица.

5. Статистика:
  Статистику исследования можно сохранить в текстовый файл. При закрытии формы исследования статистика обнуляется.
