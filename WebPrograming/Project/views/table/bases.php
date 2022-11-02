<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use yii\widgets\ActiveForm;
use app\models\Bases;
use app\models\BasesForm;
use yii\bootstrap\Modal;
use yii\grid\GridView;

$this->title = 'Базы';
$users = Bases::find()->orderBy('id')->all();
?>
<?php
    if(!Yii::$app->user->isGuest){

     Modal::begin([
        'header' => '<h2>Базы</h2>',
        'toggleButton' => [
            'label' => 'Добавить базу',
            'tag' => 'button',
            'class' => 'btn btn-success site-index',
        ]
    ]);
?>
    <?php
     $bases = ActiveForm::begin(['id' => 'contact-form']); ?>

    <?= $bases->field($model, 'name')->textInput(['autofocus' => true])->label('Название'); ?>

    <?= $bases->field($model, 'plane')->textInput()->label('Количество гектар'); ?>

    <?= $bases->field($model, 'place')->textInput()->label('Месность');?>
 
    
 
    <div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>
<div class="site-index">
<h1>Базы</h1>
<?php     
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute' => 'name','label' => 'Название'],
        ['attribute'=>'place', 'label' =>'Место'],
        ['attribute'=>'plane', 'label' => 'Количество гектар всего'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdatebases&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeletebases&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>
    

    
</div>
