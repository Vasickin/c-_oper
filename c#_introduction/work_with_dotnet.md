# Начало работы: c# #

## Создание проекта ##

1. В VSCode создать папку
2. Инициалезировать __git__:
```sh
git init
```
3. Подготоака папки для создания проекта:
```sh
dotnet new console
```
4. Добавить папку в репозиторий:
```sh
git add <имя_папки>
```
5. Сделать первый commit:
```sh
git commit -m "first commit"
```
6. Создание удаленного репозитория на GitHub
7. Следуя подсказкам на GitHub подключить локальный репозирорий к удаленному репозиторию:
```sh
git remote add origin https://github.com/Vasickin/имя_репозитория.git
git branch -M main
git push -u origin main
```

