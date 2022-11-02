<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use app\models\Type;
use yii\widgets\ActiveForm;
use yii\bootstrap\Modal;
use yii\grid\GridView;


$this->title = 'Тип работ(действий)';
$users = Type::find()->orderBy('id')->all();
?>
<?php
    if(!Yii::$app->user->isGuest){

     Modal::begin([
        'header' => '<h2>Тип</h2>',
        'toggleButton' => [
            'label' => 'Добавить тип',
            'tag' => 'button',
            'class' => 'btn btn-success site-index',
        ]
    ]);

     $fuel_on_base = ActiveForm::begin(['id' => 'contact-form']) ?>
    <?= $fuel_on_base->field($model, 'name')->label('Тип') ?>

<div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>
<div class="site-index">
<h1>Тип работ(действий)</h1>
<?php
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute'=>'id', 'label' => '#'],
        ['attribute'=>'name', 'label' =>'Тип'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdatetype&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeletetype&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>
    

    
</div>
