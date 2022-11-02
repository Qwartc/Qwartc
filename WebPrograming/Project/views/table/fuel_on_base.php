<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use yii\widgets\ActiveForm;
use app\models\Fuel_on_base;
use app\models\Bases;
use yii\bootstrap\Modal;
use yii\grid\GridView;


$this->title = 'Топливо на базе';
$users = Fuel_on_base::find()->orderBy('id')->all();
?>
<?php
    if(!Yii::$app->user->isGuest){

     Modal::begin([
        'header' => '<h2>Топливо</h2>',
        'toggleButton' => [
            'label' => 'Пополнить топливо',
            'tag' => 'button',
            'class' => 'btn btn-success site-index',
        ]
    ]);

     $fuel_on_base = ActiveForm::begin(['id' => 'contact-form']) ?>
     <?= $fuel_on_base->field($model, 'id') ?>
    <?= $fuel_on_base->field($model, 'amount')->label('Количество') ?>
    <?= $fuel_on_base->field($model, 'base')->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База'); ?>

<div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>
<div class="site-index">
<h1>Топливо на базе</h1>
<?php
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute'=>'base', 'label' => 'База'],
        ['attribute'=>'amount', 'label' =>'Количество, л'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdatefuel_on_base&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeletefuel_on_base&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>
    

    
</div>
