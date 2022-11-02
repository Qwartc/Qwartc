<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use yii\widgets\ActiveForm;
use app\models\Fuel;
use app\models\Bases;
use app\models\Technics;
use yii\bootstrap\Modal;
use yii\grid\GridView;


$this->title = 'Топливо';
$users = Fuel::find()->orderBy('id')->all();
?>
<?php
    if(!Yii::$app->user->isGuest){

     Modal::begin([
        'header' => '<h2>Поля</h2>',
        'toggleButton' => [
            'label' => 'Добавить поле',
            'tag' => 'button',
            'class' => 'btn btn-success site-index',
        ]
    ]);

     $fuel = ActiveForm::begin(['id' => 'contact-form']) ?>
    <?= $fuel->field($model, 'id') ?>
    <?= $fuel->field($model, 'technic')->dropdownList(
    Technics::find()->select(['name', 'id'])->indexBy('name')->column())->label('Техника'); ?>
    <?= $fuel->field($model, 'amount')->label('Количество') ?>
    <?= $fuel->field($model, 'base')->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База'); ?>
    <?= $fuel->field($model, 'time')->label('Дата') ?>

<div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>

<div class="site-index">
<h1>Топливо</h1>
<?php
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute'=>'base', 'label' => 'База'],
        ['attribute'=>'amount', 'label' =>'Количество, л'],
        ['attribute'=>'technic', 'label' =>'Техника'],
        ['attribute'=>'time', 'label' =>'Дата'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdatefuel&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeletefuel&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>
    

    
</div>
