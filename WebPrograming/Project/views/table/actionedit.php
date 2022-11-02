<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use app\models\Type;
use app\models\Bases;
$form = ActiveForm::begin(['layout' => 'horizontal']) ?>
    <?= $form->field($model, 'id') ?>
    <?= $form->field($model, 'time')->label('Время') ?>
    <?= $form->field($model, 'type')->dropdownList(
    Type::find()->select(['name', 'id'])->indexBy('name')->column())->label('Тип работ'); ?>
    <?= $form->field($model, 'base')->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База'); ?>
    <?= $form->field($model, 'amount')->label('Количество') ?>
    <?= $form->field($model, 'comment')->label('Коментарий') ?>
    <?= $form->field($model, 'user')->label('Учасник') ?>

    <div class="form-group">
        <div class="col-lg-offset-5 col-lg-5">
            <?= Html::submitButton('Редактировать', ['class' => 'btn btn-primary']) ?>
        </div>
    </div>
    <?php ActiveForm::end() ?>