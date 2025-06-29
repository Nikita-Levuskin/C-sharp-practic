# .NET MAUI Showcase: Cross-Platform Applications

Разработка и демонстрация кроссплатформенных приложений (Калькулятор ИМТ, Трекер задач) с использованием .NET MAUI. Этот репозиторий содержит примеры кода, отчеты по ключевым аспектам фреймворка и разработанные приложения.

## Обзор проекта

Этот проект демонстрирует возможности .NET MAUI для создания современных и функциональных кроссплатформенных приложений, способных работать на Windows, macOS, Android и iOS. Он включает как фундаментальные примеры, так и более комплексные приложения.

**Используемые технологии:**
*   .NET MAUI
*   C#
*   XAML
*   Visual Studio 2022
*   Git & GitHub

## Структура репозитория

Проект организован следующим образом:

*   **`/HelloMauiApp`**: Содержит исходный код демонстрационного приложения .NET MAUI, иллюстрирующего различные концепции и компоненты фреймворка.
*   **`/Reports`**: Содержит технические обзоры и отчеты по ключевым темам .NET MAUI, описывающие концепции, примеры кода и выводы.

## Базовая часть: Ключевые аспекты .NET MAUI

Этот раздел охватывает фундаментальные концепции и компоненты .NET MAUI. По каждой теме представлен технический обзор и примеры кода. Ссылки на материалы [metanit.com/sharp/maui/](https://metanit.com/sharp/maui/) использовались в качестве основы для изучения и демонстрации.

*   **Глава 1: Введение в .NET MAUI**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-1.docx`](./Reports/Report-Chapter-1.docx)
    *   Ключевые моменты: Настройка окружения, структура проекта, первое приложение.
*   **Глава 2: Основы XAML**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-2.docx`](./Reports/Report-Chapter-2.docx)
    *   Ключевые моменты: Синтаксис XAML, code-behind, создание UI программно, `LoadFromXaml`.
*   **Глава 3: Компоновки (Layouts)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-3.docx`](./Reports/Report-Chapter-3.docx)
    *   Ключевые моменты: StackLayout, Grid, FlexLayout. Демонстрация на отдельных страницах с навигацией через AppShell.
*   **Глава 4: Элементы управления (Controls)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-4.docx`](./Reports/Report-Chapter-4.docx)
    *   Ключевые моменты: Label, Entry, Editor, Button, ImageButton, CheckBox, RadioButton, BoxView, Frame, Border, Image, WebView, Picker, DatePicker, TimePicker, Switch, Slider, Stepper, ProgressBar, ActivityIndicator, SearchBar, CollectionView, RefreshView, SwipeView. Демонстрация на единой странице `Chapter4ControlsPage`.
*   **Глава 5: Привязка данных (Data Binding)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-5.docx`](./Reports/Report-Chapter-5.docx)
    *   Ключевые моменты: INotifyPropertyChanged, BindingContext, режимы привязки (OneWay, TwoWay, OneTime), ICommand, CommandParameter, StringFormat, продемонстрированы с SimpleViewModel на `DataBindingDemoPage`.
*   **Глава 6: Стили (Styles)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-6.docx`](./Reports/Report-Chapter-6.docx)
    *   Ключевые моменты: Явные и неявные стили, наследование (`BasedOn`), `StaticResource`, `DynamicResource` (упомянуто), классы стилей (`StyleClass`), платформо-зависимые стили (`OnPlatform`), продемонстрированы на `StylesDemoPage`.
*   **Глава 7: Ресурсы (Resources)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-7.docx`](./Reports/Report-Chapter-7.docx)
    *   Ключевые моменты: Определение и использование ресурсов на уровне приложения и страницы, `StaticResource`, `DynamicResource`, словари ресурсов, переопределение ресурсов, продемонстрированы на `ResourcesDemoPage`.
*   **Глава 8: Навигация (Navigation)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-8.docx`](./Reports/Report-Chapter-8.docx)
    *   Ключевые моменты: Стековая навигация (`PushAsync`, `PopAsync`), модальная навигация (`PushModalAsync`, `PopModalAsync`), Shell-навигация на основе URI (`GoToAsync`, `Routing.RegisterRoute`), передача данных между страницами (конструктор, `QueryProperty`, `MessagingCenter`), продемонстрированы на `NavigationHomePage`, `NavigationDetailPage`, `NavigationModalPage`.
*   **Глава 9: Работа с платформозависимым кодом (Platform-specifics & Essentials)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-9.docx`](./Reports/Report-Chapter-9.docx)
    *   Ключевые моменты: Условная компиляция (`#if`), частичные классы (partial classes), .NET MAUI Essentials (`DeviceInfo`, `AppInfo`, `Connectivity`, `HapticFeedback`, `Share`, `Browser`), продемонстрированы на `PlatformDemoPage`.
*   **Глава 10: Диалоги (Dialogs)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-10.docx`](./Reports/Report-Chapter-10.docx)
    *   Ключевые моменты: `DisplayAlert` (простой и с подтверждением), `DisplayActionSheet`, `DisplayPromptAsync`, продемонстрированы на `DialogsDemoPage`.
*   **Глава 11: Графика (Graphics)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-11.docx`](./Reports/Report-Chapter-11.docx)
    *   Ключевые моменты: `Microsoft.Maui.Graphics`, `GraphicsView`, `IDrawable`, `ICanvas`, рисование фигур (линии, прямоугольники, эллипсы, дуги, пути), работа с текстом и цветами, продемонстрированы на `GraphicsDemoPage`.
*   **Глава 12: Жесты (Gestures)**
    *   Статус: *Реализовано*
    *   Обзор: [`/Reports/Report-Chapter-12.docx`](./Reports/Report-Chapter-12.docx)
    *   Ключевые моменты: Распознаватели жестов, `TapGestureRecognizer`, `PinchGestureRecognizer`, `PanGestureRecognizer`, `SwipeGestureRecognizer`, `PointerGestureRecognizer`, продемонстрированы на `GesturesDemoPage`.
