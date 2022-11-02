<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\ActiveForm;
use yii\widgets\LinkPager;
use app\models\Fields;
use app\models\FieldsForm;
use app\models\Bases;
use yii\bootstrap\Modal;
use yii\grid\GridView;


$this->title = 'Поля';
$users = Fields::find()->orderBy('id')->all();
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
?>
    <?php
     $fields = ActiveForm::begin(['id' => 'contact-form']); ?>

    <?= $fields->field($model, 'number_field')->textInput(['autofocus' => true])->label('Номер поля'); ?>

    <?= $fields->field($model, 'base')->textInput()->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База');?>

    <?= $fields->field($model, 'plane')->textInput()->label('Количество гектар'); ?>

    <?= $fields->field($model, 'place')->textInput()->label('Месность '); ?>

    <?= $fields->field($model, 'plant')->textInput()->label('Культура'); ?>
 
    
 
    <div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>
<div class="site-index">
<h1>Поля</h1>
<?php
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute' => 'number_field','label' => 'Название'],
        ['attribute'=>'base', 'label' => 'База'],
        ['attribute'=>'plane', 'label' =>'Количество гектар'],
        ['attribute'=>'place', 'label' =>'Месность'],
        ['attribute'=>'plant', 'label' =>'Культура'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdatefields&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeletefields&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>
    

    

    
</div>
