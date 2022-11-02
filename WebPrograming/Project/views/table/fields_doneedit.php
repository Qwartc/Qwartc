<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use app\models\Fields;
use app\models\Bases;
use app\models\Type;
use app\models\Workers;
use app\models\Technics;
$fields_done = ActiveForm::begin(['layout' => 'horizontal']) ?>
    

    <?= $fields_done->field($model1, 'base')->textInput()->dropdownList(Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База');?>
 

    <?= $fields_done->field($model1, 'field')->textInput()->dropdownList(
    Fields::find()->select(['place', 'id'])->indexBy('place')->column())->label('Поле');?>

    <?= $fields_done->field($model1, 'amount')->textInput()->label('Количество cделанных гектар'); ?>
    
    <?= $fields_done->field($model1, 'type')->textInput()->dropdownList(
    Type::find()->select(['name', 'id'])->indexBy('name')->column())->label('Тип работ');?>

    <?= $fields_done->field($model1, 'who')->textInput()->dropdownList(
    Workers::find()->select(['surname', 'id'])->indexBy('surname')->column())->label('Работник');?>

    <?= $fields_done->field($model1, 'technic')->textInput()->dropdownList(
    Technics::find()->select(['name', 'id'])->indexBy('name')->column())->label('Техника');?>

    <?= $fields_done->field($model1, 'date')->textInput()->label('Дата'); ?>

    <?= $fields_done->field($model1, 'field_number')->textInput()->label('Номер поля'); ?>

    <div class="form-group">
        <div class="col-lg-offset-5 col-lg-5">
            <?= Html::submitButton('Редактировать', ['class' => 'btn btn-primary']) ?>
        </div>
    </div>
    <?php ActiveForm::end() ?>