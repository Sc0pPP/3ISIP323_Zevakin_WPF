# Практическая работа №13 — Магазин (WPF + Entity Framework)

WPF-приложение интернет-магазина с базой данных, группа 3ИСИП-323.

## Страницы

1. **FirstPage** — каталог товаров (карточки с картинкой и описанием), кнопка «Купить»;
2. **SecondPage** — корзина и «Оформить заказ»;
3. **ThirdPage** — данные покупателя: ФИО, индекс, адрес, пароль.

## База данных

Таблицы `Tovary` (ID, Name, Price, URL), `Cart`, `Order`, `TovaryOrder`, `Users`.

## Технологии

- C#, WPF, .NET Framework 4.7.2
- Entity Framework 6 (Database First, `Model1.edmx`)
- SQL Server, база `shop`

## Запуск

1. Создайте в SQL Server базу `shop` с таблицами из `Model1.edmx`.
2. При необходимости поправьте строку подключения в `WpfApp7/App.config`.
3. Откройте `WpfApp7.sln` в Visual Studio и нажмите F5.
