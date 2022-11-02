<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use yii\widgets\ActiveForm;
use app\models\Chemicals;
use app\models\ChemicalsForm;
use app\models\Bases;
use yii\bootstrap\Modal;
use yii\grid\GridView;

$this->title = 'Химия';
$users = Chemicals::find()->orderBy('id')->all();
?>
<?php
    if(!Yii::$app->user->isGuest){

     Modal::begin([
        'header' => '<h2>Химия</h2>',
        'toggleButton' => [
            'label' => 'Добавить химию',
            'tag' => 'button',
            'class' => 'btn btn-success site-index',
        ]
    ]);
?>
    <?php
     $chemicals = ActiveForm::begin(['id' => 'contact-form']); ?>

    <?= $chemicals->field($model, 'name')->textInput(['autofocus' => true])->label('Название'); ?>

    <?= $chemicals->field($model, 'amount')->textInput()->label('Количество '); ?>

    <?= $chemicals->field($model, 'base')->textInput()->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База');?>
 
    
 
    <div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>
<div class="site-index">
<h1>Химия</h1>
<?php     
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute' => 'name','label' => 'Название'],
        ['attribute'=>'amount', 'label' =>'Количество'],
        ['attribute'=>'base', 'label' => 'База'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdatechemicals&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeletechemicals&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>
    

    
</div>
