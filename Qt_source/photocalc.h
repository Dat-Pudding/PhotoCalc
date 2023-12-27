#ifndef PHOTOCALC_H
#define PHOTOCALC_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui {
class PhotoCalc;
}
QT_END_NAMESPACE

class PhotoCalc : public QMainWindow
{
    Q_OBJECT

public:
    PhotoCalc(QWidget *parent = nullptr);
    ~PhotoCalc();

private slots:
    void on_pushButton_clicked();

    void on_pushButton_2_clicked();

    void on_profileDirSelectButton_clicked();

    void on_newProfileButton_clicked();

    void on_overwriteProfileButton_clicked();

    void on_loadProfileButton_clicked();

    void on_removeProfile_clicked();

    void on_tabWidget_currentChanged(int index);

private:
    Ui::PhotoCalc *ui;
};
#endif // PHOTOCALC_H
