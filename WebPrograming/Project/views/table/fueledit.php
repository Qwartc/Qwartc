<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use app\models\Bases;
use app\models\Technics;
$form = ActiveForm::begin(['layout' => 'horizontal']) ?>
    <?= $form->field($model, 'id') ?>
    <?= $form->field($model, 'technic')->dropdownList(
    Technics::find()->select(['name', 'id'])->indexBy('name')->column())->label('Техника'); ?>
    <?= $form->field($model, 'amount')->label('Количество') ?>
    <?= $form->field($model, 'base')->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База'); ?>
    <?= $form->field($model, 'time')->label('Дата') ?>
    

    <div class="form-group">
        <div class="col-lg-offset-5 col-lg-5">
            <?= Html::submitButton('Редактировать', ['class' => 'btn btn-primary']) ?>
        </div>
    </div>
    <?php ActiveForm::end() ?>