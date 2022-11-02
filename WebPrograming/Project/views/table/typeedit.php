<?php
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
$form = ActiveForm::begin(['layout' => 'horizontal']) ?>
    <?= $form->field($model, 'id') ?>
    <?= $form->field($model, 'name')->label('Тип') ?>
    

    <div class="form-group">
        <div class="col-lg-offset-5 col-lg-5">
            <?= Html::submitButton('Редактировать', ['class' => 'btn btn-primary']) ?>
        </div>
    </div>
    <?php ActiveForm::end() ?>