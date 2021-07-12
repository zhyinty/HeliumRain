@echo off

if not exist SDL git clone https://github.com/libsdl-org/SDL.git

cd SDL
hg update
cd ..

echo "finish."
pause
