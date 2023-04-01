#! /bin/sh

CLANG_VERSION=$(echo $(clang --version) | cut -c 14- | cut -f2 -d" ")
CLANG_LIBC="/usr/lib/clang/$CLANG_VERSION/include"

echo "Clang version: $CLANG_VERSION"
echo "Using clang libc directory: $CLANG_LIBC"

SCRIPTPATH="$( cd -- "$(dirname "$0")" >/dev/null 2>&1 || exit ; pwd -P )"

cd "$SCRIPTPATH" || exit
cd "generation/" || exit

gen()
{
    cd "$1" || return
    ClangSharpPInvokeGenerator @generate.rsp -I"$CLANG_LIBC"
    cd ".." || exit
}

gen "xproto"
gen "xcb"
gen "shape"
gen "render"
gen "xfixes"
gen "xinput"
gen "randr"