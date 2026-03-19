@echo off

set /p num=Nhap so bai vua lam xong: 

echo ============================
echo Dang commit Bai %num%...
echo ============================

git add .
git commit -m "Bai %num%"
git push origin "bai%num%-20/03"

set /a next=%num%+1

echo ============================
echo Tao branch bai%next%-20/03...
echo ============================

git checkout -b "bai%next%-20/03"

echo DONE! Sang bai %next% code tiep nha.
pause