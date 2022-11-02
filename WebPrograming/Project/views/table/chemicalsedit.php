<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use app\models\Bases;
$form = ActiveForm::begin(['layout' => 'horizontal']) ?>
    <?= $form->field($model, 'id') ?>
    <?= $form->field($model, 'name')->label('Название ') ?>
    <?= $form->field($model, 'amount')->label('Количество') ?>
    <?= $form->field($model, 'base')->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База'); ?>

    <div class="form-group">
        <div class="col-lg-offset-5 col-lg-5">
            <?= Html::submitButton('Редактировать', ['class' => 'btn btn-primary']) ?>
        </div>
    </div>
    <?php ActiveForm::end() ?>