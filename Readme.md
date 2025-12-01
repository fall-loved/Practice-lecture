Богович Юрий Фёдорович, курс 4

git init #инициализируем локальный репозиторий
git remote add origin <ссылка_на_удалённый_репозиторий> #добавляем удалённый репозиторий
git config push.autoSetupRemote true #включил для удобства
touch Readme.md #создаём заглушку
git add . #добавляем комитим и отправляем как исходный комит
git commit -m "initial commit"
git push
#далее добавляем ветки от исходного комита
git checkout -b db-architecture #ветка, добавить, комит, push...
git add db-architecture
git commit -m "finished db-architecture task"
git push 
git checkout main
git checkout -b sql
git add sql
git commit -m "finished sql task"
git push 
git checkout main
git checkout -b openAPI
git add openAPI
git commit -m "finished openAPI task"
git push 
git checkout main
git checkout -b testingAPI
git add testingAPI
git commit -m "finished testingAPI task"
git push 
git checkout main
git checkout -b dotnet-introduction
git add dotnet-introduction
git commit -m "finished dotnet-introduction task"
git push 
git checkout main
git checkout -b collections-linq
git add collections-linq
git commit -m "finished collections-linq task"
git push 
git checkout main
git checkout -b asp-dotnet
git add asp-dotnet
git commit -m "finished asp-dotnet task"
git push 
git checkout main
git checkout -b entity-framework
git add entity-framework
git commit -m "finished entity-framework task"
git push 
git checkout main #теперь добавляем файл с описанием
git add Readme.md 
git commit -m "added readme"
git push
