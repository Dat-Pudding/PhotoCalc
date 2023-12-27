#include "photocalc.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    PhotoCalc w;
    w.show();
    return a.exec();
}
