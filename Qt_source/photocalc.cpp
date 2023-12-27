#include "photocalc.h"
#include "./ui_photocalc.h"
#include "mathscompendium.h"
#include <QFileDialog>
#include <QFileSystemModel>
#include <QTreeWidget>
#include <QDir>
PhotoCalc::PhotoCalc(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::PhotoCalc)
{
    ui->setupUi(this);

}

PhotoCalc::~PhotoCalc()
{
    delete ui;
}

void PhotoCalc::on_pushButton_clicked()
{
    MathsCompendium maths;
    maths.cropFactor = ui->cropInput->text().toDouble();
    maths.aperture = ui->apertureInput->text().toDouble();
    maths.pixelPitch = ui->pixelPitchInput->text().toDouble();
    maths.expoFL = ui->FLinput->text().toDouble();
    maths.declination = ui->declinationInput->value();
    maths.rCustomValue = ui->customRinput->text().toDouble();
    maths.precisionLevel = ui->precisionInput->value();

    maths.Calc_ExpoL();

    ui->customResultOutput->setText(QString::number(maths.expoLresults[0]));
    ui->r500resultOutput->setText(QString::number(maths.expoLresults[1]));
    ui->simpleNPFresultOutput->setText(QString::number(maths.expoLresults[2]));
    ui->fullNPFresultOutput->setText(QString::number(maths.expoLresults[3]));
}

void PhotoCalc::on_pushButton_2_clicked()
{
    MathsCompendium maths;
    maths.sensorWidth = ui->sensorWInput->text().toDouble();
    maths.sensorHeight = ui->sensorHInput->text().toDouble();
    maths.fovFL = ui->FoVFLinput->text().toDouble();

    maths.Calc_FoV();

    ui->FoVWOutput->setText(QString::number(maths.FoVresults[0]));
    ui->FoVHOutput->setText(QString::number(maths.FoVresults[1]));
    ui->FoVDOutput->setText(QString::number(maths.FoVresults[2]));
}

void PhotoCalc::on_profileDirSelectButton_clicked()
{
    ui->cameraProfileDirBox->setText
    (
        QFileDialog::getExistingDirectory
        (
            this,
            tr("Choose Directory"),
            "./profiles/"
        )
    );
}

void PhotoCalc::on_newProfileButton_clicked()
{
    QString camName = ui->camNameInput->text();
    QString sensorCrop = ui->cropInput->text();
    QString sensorWidth = ui->sensorWInput->text();
    QString sensorHeight = ui->sensorHInput->text();
    QString sensorPitch = ui->pixelPitchInput->text();

    QString camFileName = camName;
    QFile cameraProfile("./profiles/" + camFileName.append(".camDB"));
    if (cameraProfile.open(QFile::WriteOnly | QFile::Truncate))
    {
        QTextStream out(&cameraProfile);
        out << camName << "\n";
        out << sensorCrop << "\n";
        out << sensorWidth << "\n";
        out << sensorHeight << "\n";
        out << sensorPitch;
    }
}

void PhotoCalc::on_overwriteProfileButton_clicked()
{

}

void PhotoCalc::on_loadProfileButton_clicked()
{

}


void PhotoCalc::on_removeProfile_clicked()
{

}


void PhotoCalc::on_tabWidget_currentChanged(int index)
{
    if (ui->tabWidget->currentIndex() == 2)
    {
        QFileSystemModel profileModel;
        QModelIndex profileIndex = profileModel.index(0);
        profileModel.setRootPath("/profiles");
        //ui->cameraList->setRootIndex(&profileModel);

    }
}

