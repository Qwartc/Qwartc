<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use app\models\Bases;
$form = ActiveForm::begin(['layout' => 'horizontal']) ?>
    <?= $form->field($model, 'id') ?>
    <?= $form->field($model, 'number_field')->label('Номер поля ') ?>
    <?= $form->field($model, 'base')->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База'); ?>
    <?= $form->field($model, 'plane')->label('Количество гектар') ?>
    <?= $form->field($model, 'place')->label('Месность') ?>
    <?= $form->field($model, 'plant')->label('Культура') ?>
    

    <div class="form-group">
        <div class="col-lg-offset-5 col-lg-5">
            <?= Html::submitButton('Редактировать', ['class' => 'btn btn-primary']) ?>
        </div>
    </div>
    <?php ActiveForm::end() ?>