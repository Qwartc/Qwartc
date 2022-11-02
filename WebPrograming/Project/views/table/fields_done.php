<?php

/* @var $this yii\web\View */
use yii\helpers\Html;
use yii\widgets\LinkPager;
use yii\widgets\ActiveForm;
use app\models\Fields_done;
use app\models\Fields;
use app\models\Bases;
use app\models\Type;
use app\models\Workers;
use app\models\Technics;
use app\models\Fields_doneForm;
use yii\bootstrap\Modal;
use yii\grid\GridView;

$this->title = 'Сделаные поля';
$users = Fields_done::find()->orderBy('id')->all();
?>
<?php
    if(!Yii::$app->user->isGuest){

     Modal::begin([
        'header' => '<h2>Сделаные поля</h2>',
        'toggleButton' => [
            'label' => 'Добавить поле',
            'tag' => 'button',
            'class' => 'btn btn-success site-index',
        ]
    ]);
?>
    <?php
     $fields_done = ActiveForm::begin(['id' => 'contact-form']); ?>
     <? ?>

    <?= $fields_done->field($model1, 'base')->textInput()->dropdownList(Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База');?>
 

    <?= $fields_done->field($model1, 'field')->textInput()->dropdownList(
    Fields::find()->select(['place', 'id'])->indexBy('place')->column())->label('Поле');?>

    <?= $fields_done->field($model1, 'amount')->textInput()->label('Количество cделанных гектар'); ?>
    
    <?= $fields_done->field($model1, 'type')->textInput()->dropdownList(
    Type::find()->select(['name', 'id'])->indexBy('name')->column())->label('Тип работ');?>

    <?= $fields_done->field($model1, 'who')->textInput()->dropdownList(
    Workers::find()->select(['surname', 'id'])->indexBy('surname')->column())->label('Работник');?>

    <?= $fields_done->field($model1, 'technic')->textInput()->dropdownList(
    Technics::find()->select(['name', 'id'])->indexBy('name')->column())->label('Техника');?>

    <?= $fields_done->field($model1, 'date')->textInput()->label('Дата'); ?>

    <?= $fields_done->field($model1, 'field_number')->textInput()->label('Номер поля'); ?>
 
    <div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>
<div class="site-index">
<h1>Сделаные поля</h1>
<?php
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute'=>'base', 'label' => 'База'],
        ['attribute'=>'field', 'label' =>'Поле'],
        ['attribute'=>'amount', 'label' =>'Количество гектар'],
        ['attribute'=>'type', 'label' =>'Тип работ'],
        ['attribute'=>'who', 'label' =>'Работник'],
        ['attribute'=>'technic', 'label' =>'Техника'],
        ['attribute'=>'date', 'label' =>'Дата'],
        ['attribute' => 'field_number','label' => 'Номер поля'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdatefields_done&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeletefields_done&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>

    
</div>
