# Практическая работа №14 — Кинотеатр (WPF + Entity Framework)

WPF-приложение кинотеатра с базой данных, группа 3ИСИП-323.

## Возможности

- **FirstPage** — список фильмов с сортировкой по рейтингу и по названию;
- **RegistrationPage** — регистрация: имя пользователя, пароль, повтор пароля;
- **ProfilePage** — заготовка личного кабинета (страница пока пустая).

## База данных

Таблицы `Movies` (название, описание, рейтинг, возрастной рейтинг, постер по URL), `Genres`, `Halls`, `Sessions`, `Seats`, `SessionSeats`, `Tickets`, `Users`.

## Технологии

- C#, WPF, .NET Framework 4.7.2
- Entity Framework 6 (Database First, `Model1.edmx`)
- SQL Server, база `Kinoteathor`

## Запуск

1. Создайте в SQL Server базу `Kinoteathor` с таблицами из `Model1.edmx`.
2. При необходимости поправьте строку подключения в `WpfApp7/App.config`.
3. Откройте `WpfApp7.sln` в Visual Studio и нажмите F5.

> Развитие этой работы на Avalonia — репозиторий [Pr14](https://github.com/Sc0pPP/Pr14).
